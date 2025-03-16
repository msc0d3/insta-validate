using CheckLiveIG.API;
using CheckLiveIG.Interfaces;
using CheckLiveIG.Models;
using CheckLiveIG.Request;
using CheckLiveIG.Singleton;
using CheckLiveIG.Utils;
using Leaf.xNet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckLiveIG.View
{
    public partial class FMain : Form
    {
        private ConcurrentQueue<string> _accountqueue = new ConcurrentQueue<string>();
        private CancellationTokenSource _cancellationTokenSource;
        private List<string> _proxyPool = new List<string>();
        private int _live;
        private int _die;
        private int _retries;
        private int _unknown;
        string SavePath = string.Empty;
        private Stopwatch StopwatchElapsed = new Stopwatch();
        public FMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            this.Text = $"Check Live Instagram v{ProductVersion}";
            cbbapiver.SelectedIndex = 0;
            if (File.Exists(PathSingleton.ProxyListFile))
            {
                LoadProxies(File.ReadAllLines(PathSingleton.ProxyListFile).ToList());
            }
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are your want to exit ?", "exit confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _cancellationTokenSource?.Cancel();
                tmupdatecount.Stop();
                tmupdatecount.Dispose();
                Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            ResetCounter();
            tmupdatecount.Start();
            StopwatchElapsed.Reset();
            StopwatchElapsed.Start();
            _cancellationTokenSource = new CancellationTokenSource();
            int Maxthreads = (int)numthreads.Value;
            Isruning(true);
            string datetimnow = DateTime.Now.ToString("dd-MM-yyyy HH.mm.ss");
            SavePath = Application.StartupPath + "\\result\\result_" + datetimnow;
            Directory.CreateDirectory(SavePath);
            new Thread(() =>
            {
                ThreadPool.SetMinThreads(Maxthreads, Maxthreads);
                Thread[] array = new Thread[Maxthreads];
                for (int i = 0; i < Maxthreads; i++)
                {
                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        break;
                    }
                    array[i] = new Thread((ThreadStart)delegate
                    {
                        while (!_cancellationTokenSource.IsCancellationRequested && !_accountqueue.IsEmpty)
                        {
                            StartCheck();
                        }
                    });
                    array[i].Start();
                    //Task.Delay(TimeSpan.FromSeconds(MainFormUISettings.DelayThread)).Wait();
                }
                for (int j = 0; j < Maxthreads; j++)
                {
                    if (array[j] != null)
                    {
                        array[j].Join();
                    }
                }
                Task.Delay(TimeSpan.FromSeconds(2)).Wait();
                tmupdatecount.Stop();
                StopwatchElapsed.Stop();
                SaveRemainData();
                Isruning(false);
                _cancellationTokenSource?.Cancel();
                GC.SuppressFinalize(this);
                GC.WaitForFullGCApproach();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }).Start();
        }
        private void SaveRemainData()
        {
            SaveFile(SavePath + "\\RemainData.txt", string.Join(Environment.NewLine, _accountqueue));
        }
        private void ResetCounter()
        {
            _live = 0;
            _die = 0;
            _retries = 0;
        }
        private void btnstop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

        private void btnimportproxy_Click(object sender, EventArgs e)
        {
            FrmImport import = new FrmImport($"Proxies");
            import.ShowDialog(this);
            if (import.ImportResult == DialogResult.OK && import.ImportedData.Count != 0)
            {
                LoadProxies(import.ImportedData);
            }
        }

        private void btnimportdata_Click(object sender, EventArgs e)
        {
            FrmImport import = new FrmImport($"Data IG");
            import.ShowDialog(this);
            if (import.ImportResult == DialogResult.OK && import.ImportedData.Count != 0)
            {
                LoadCookies(new ConcurrentQueue<string>(import.ImportedData));
            }
        }
        private void LoadCookies(ConcurrentQueue<string> cookies)
        {
            _accountqueue = new ConcurrentQueue<string>(cookies);
            lbaccC.Text = $"Accounts : {_accountqueue.Count}";
        }
        private void btnresultFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(SavePath))
                {
                    Process.Start(SavePath);
                }
                else
                {
                    Process.Start(Environment.CurrentDirectory);
                }
            }
            catch
            {
                //WriteErrorExceptionLog(ex, "btnresultFolder_Click");
            }
        }
        private void LoadProxies(List<string> proxies)
        {
            _proxyPool = new List<string>(proxies);
            lbprxC.Text = $"Proxies : {proxies.Count}";
            File.WriteAllText(PathSingleton.ProxyListFile, string.Join(Environment.NewLine, _proxyPool));
        }
        private void SaveFile(string path, string content)
        {
            try
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    File.AppendAllText(path, content + Environment.NewLine, Encoding.UTF8);
                }));
            }
            catch
            {
                //WriteErrorExceptionLog(ex, "SaveFile");
            }
        }
        private void Isruning(bool status)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                btnstart.Enabled = !status;
                btnstop.Enabled = status;
            });
        }
        private string RandomProxy()
        {
            return _proxyPool.RandomItemInList();
        }
        private string GetProxy()
        {
            string Proxy = string.Empty;
        WaitProxy:
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                return Proxy;
            }
            Proxy = RandomProxy();
            Proxy = ProxyInfoModel.RenderSessionIfIsProxyServer(Proxy);
            Task.Delay(TimeSpan.FromMilliseconds(500)).Wait();
            if (string.IsNullOrEmpty(Proxy))
            {
                Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                goto WaitProxy;
            }
            return Proxy;
        }
        private void StartCheck()
        {
            string data = string.Empty;
            string proxy = string.Empty;
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                try
                {
                    if (_accountqueue.IsEmpty)
                    {
                        break;
                    }
                    data = string.Empty;
                    _accountqueue.TryDequeue(out data);
                    if (string.IsNullOrEmpty(data))
                    {
                        continue;
                    }
                    string accountid = Regex.Match(data, "ds_user_id=(\\d+);").Groups[1].Value;
                    if (string.IsNullOrEmpty(accountid))
                    {
                        SaveFile(SavePath + "\\InvalidIGData.txt", data);
                        continue;
                    }
                    HttpConfig httpConfig = new HttpConfig
                    {
                        UseProxy = false,
                        CustomUserAgent = new CustomUserAgentConfig()
                    };
                    httpConfig.CustomUserAgent.IsUseCustomUG = false;
                    proxy = GetProxy();
                    if (!string.IsNullOrEmpty(proxy))
                    {
                        httpConfig.UseProxy = true;
                        httpConfig.Proxy = ProxyClient.Parse(ProxyType.HTTP, proxy);
                        httpConfig.ConnectTimeOut = 30000;
                    }
                    IIGAccountQueryAPI iGAccountQueryAPI = GetIGAccountQueryAPI(httpConfig);
                    IGApiQueryResult iGApiQueryResult = iGAccountQueryAPI.QueryInfoAccount(accountid);
                    if(iGApiQueryResult.IgStatusCode == Enums.IgApiCallStatusCode.Error)
                    {
                        _retries++;
                        _accountqueue.Enqueue(data);
                        continue;
                    }
                    else if(iGApiQueryResult.IgStatusCode == Enums.IgApiCallStatusCode.UnknownBlockType)
                    {
                        _unknown++;
                        SaveFile(SavePath + "\\Unknown_IGStatus.txt", data);
                    }
                    else if(iGApiQueryResult.IgStatusCode == Enums.IgApiCallStatusCode.Checkpoint)
                    {
                        _die++;
                        SaveFile(SavePath + "\\IGDie.txt", data);
                    }
                    else
                    {
                        _live++;
                        SaveFile(SavePath + "\\IGLive.txt", data);
                    }
                }
                catch
                {
                    SaveFile(SavePath + "\\ErrorRun.txt", data);
                }
            }
        }
        private IIGAccountQueryAPI GetIGAccountQueryAPI(HttpConfig httpConfig)
        {
            if(cbbapiver.SelectedIndex == 0)
            {
                return new IGWebApi(httpConfig);
            }
            return new IGAnroidApi(httpConfig);
        }

        private void tmupdatecount_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    lbliveC.Text = $"Live : {_live}";
                    lbdieC.Text = $"Die : {_die}";
                    lbtriesC.Text = $"Retries : {_retries}";
                    lbunkC.Text = $"Unknown : {_unknown}";
                    lbtimerun.Text = $"{StopwatchElapsed.Elapsed.Days}D {StopwatchElapsed.Elapsed.Hours}H {StopwatchElapsed.Elapsed.Minutes}M {StopwatchElapsed.Elapsed.Seconds}S";
                }));
            }
            catch
            {
                //WriteErrorExceptionLog(ex, "tmupdatecount_Tick");
            }
        }
    }
}
