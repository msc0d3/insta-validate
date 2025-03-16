using CheckLiveIG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Models
{
    public class ProxyInfoModel
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullProxyFormat()
        {
            string fullinfo = string.Empty;
            List<string> _data = new List<string>();
            if (!string.IsNullOrEmpty(Host))
            {
                _data.Add(Host);
            }
            if (!string.IsNullOrEmpty(Port))
            {
                _data.Add(Port);
            }
            if (!string.IsNullOrEmpty(UserName))
            {
                _data.Add(UserName);
            }
            if (!string.IsNullOrEmpty(Password))
            {
                _data.Add(Password);
            }
            if (_data.Count > 0)
            {
                fullinfo = string.Join(":", _data);
            }
            return fullinfo;
        }
        public ProxyInfoModel(string host, string port)
        {
            Host = host;
            Port = port;
        }
        public ProxyInfoModel(string host, string port, string user, string password)
        {
            Host = host;
            Port = port;
            UserName = user ?? string.Empty;
            Password = password ?? string.Empty;
        }
        public ProxyInfoModel(string proxyaddress)
        {
            if (proxyaddress.Contains(":"))
            {
                string[] parts = proxyaddress.Split(':');
                Host = parts[0];
                Port = parts[1];
                if (parts.Length >= 3)
                {
                    UserName = parts[2];
                    Password = parts[3];
                }
            }
        }
        public static ProxyInfoModel Parse(string proxyaddress)
        {
            return new ProxyInfoModel(proxyaddress);
        }
        public static string RenderSessionIfIsProxyServer(string sourceproxy)
        {
            ProxyInfoModel proxyInfo = ProxyInfoModel.Parse(sourceproxy);
            if (string.IsNullOrEmpty(proxyInfo.UserName))
            {
                return sourceproxy;
            }
            string sessid = RandomUtils.RandomStringWithoutUppercase(10);
            int sesstime = 1;
            if (sourceproxy.Contains("lunaproxy.net")) // lunaproxy
            {
                proxyInfo.UserName += $"-sessid-{sessid}-sesstime-{sesstime}";
            }
            else if (sourceproxy.Contains("abcproxy.")) // abcproxy
            {
                proxyInfo.UserName += $"-session-{sessid}-sessTime-{sesstime}";
            }
            else if (sourceproxy.Contains("lightningproxies."))
            {
                proxyInfo.UserName += $"-session-{sessid}-sessTime-{sesstime}";
            }
            string fullproxyrendered = proxyInfo.FullProxyFormat();
            proxyInfo.Dispose();
            return fullproxyrendered;
        }
        public void Dispose()
        {
            Host = string.Empty;
            Port = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            GC.SuppressFinalize(this);
        }
    }
}
