using CheckLiveIG.Enums;
using CheckLiveIG.Interfaces;
using CheckLiveIG.Models;
using CheckLiveIG.Request;
using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckLiveIG.API
{
    public class IGWebApi : IIGAccountQueryAPI
    {
        //private HttpRequest _httpRequest;
        private HttpConfig _httpConfig;
        public IGWebApi(HttpConfig httpConfig)
        {
            _httpConfig = httpConfig;
        }
        public IGApiQueryResult QueryInfoAccount(string accountId)
        {
            var result = new IGApiQueryResult();
            HttpRequest httpRequest = HttpFactory.NewClient(_httpConfig);
            HttpResponse httpResponse = null;
            PostHeaderBuilder(string.Empty, string.Empty).ToList().ForEach(header =>
            {
                httpRequest.AddHeader(header.Key, header.Value);
            });
            httpRequest.AddHeader("x-fb-friendly-name", "PolarisProfilePageContentQuery");
            httpRequest.AddHeader("x-ig-app-id", "936619743392459");
            string payload = string.Empty;
            string resultapi = string.Empty;
            try
            {
                payload = CheckLiveDieUidFormData(accountId);
                httpResponse = httpRequest.Post("https://www.instagram.com/graphql/query", payload, HttpGlobal.ContentTypes.FormUrlEncoded);
                resultapi = httpResponse.ToString();
                if (resultapi.Contains("profile_pic_url\":") || resultapi.Contains("full_name\":"))
                {
                    result.IgStatusCode = IgApiCallStatusCode.Success;
                }
                else if (resultapi.Contains("message\":\"execution error") && resultapi.Contains("status\":\"ok"))
                {
                    result.IgStatusCode = IgApiCallStatusCode.Checkpoint;
                }
                else
                {
                    result.IgStatusCode = IgApiCallStatusCode.UnknownBlockType;
                }
            }
            catch
            {
                result.IgStatusCode = IgApiCallStatusCode.Error;
            }
            finally
            {
                httpResponse = null;
                httpRequest?.Dispose();
                payload = string.Empty;
                resultapi = string.Empty;
            }
            return result;
        }
        private readonly string Chrome129WindowsUGStr = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/129.0.0.0 Safari/537.36";
        private string CheckLiveDieUidFormData(string uid)
        {
            Dictionary<string, string> formdata = new Dictionary<string, string>();
            formdata.Add("av", "0");
            formdata.Add("__user", "0");
            formdata.Add("fb_api_caller_class", "RelayModern");
            formdata.Add("fb_api_req_friendly_name", "PolarisProfilePageContentQuery");
            formdata.Add("variables", "{\"id\":\"" + uid + "\",\"render_surface\":\"PROFILE\"}");
            formdata.Add("server_timestamps", "true");
            formdata.Add("doc_id", "9539110062771438");
            return string.Join("&", formdata.Select(fdt => $"{fdt.Key}={fdt.Value}"));
        }
        private Dictionary<string, string> PostHeaderBuilder(string customorigin, string customreferer)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("accept", "*/*");
            headers.Add("accept-language", "en-US,en;q=0.9");
            if (!string.IsNullOrEmpty(customorigin))
            {
                headers.Add("origin", customorigin);
            }
            if (!string.IsNullOrEmpty(customreferer))
            {
                headers.Add("referer", customreferer);
            }
            headers.Add("priority", "u=1, i");
            headers.Add("sec-fetch-dest", "empty");
            headers.Add("sec-fetch-mode", "cors");
            headers.Add("sec-fetch-site", "same-origin");
            DesktopBrowserUGHeader().ToList().ForEach(header =>
            {
                headers.Add(header.Key, header.Value);
            });
            return headers;
        }
        private Dictionary<string, string> DesktopBrowserUGHeader()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"129\", \"Not=A?Brand\";v=\"8\", \"Chromium\";v=\"129\"");
            headers.Add("sec-ch-ua-mobile", "?0");
            headers.Add("sec-ch-ua-platform", "\"Windows\"");
            headers.Add("sec-ch-ua-model", "\"\"");
            headers.Add("sec-ch-ua-platform-version", "\"15.0.0\"");
            headers.Add("user-agent", Chrome129WindowsUGStr);
            return headers;
        }
    }
}
