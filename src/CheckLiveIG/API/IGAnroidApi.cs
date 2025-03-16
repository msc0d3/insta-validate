using CheckLiveIG.Enums;
using CheckLiveIG.Interfaces;
using CheckLiveIG.Models;
using CheckLiveIG.Request;
using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.API
{
    public class IGAnroidApi : IIGAccountQueryAPI
    {
        private readonly string _samsung_ug = "Instagram 361.0.0.0.84 Android (28/9; 480dpi; 1080x1920; samsung; SM-G930F; herolte; samsungexynos8890; en_US; 673256705)";
        private HttpConfig _httpConfig;
        public IGAnroidApi(HttpConfig httpConfig)
        {
            _httpConfig = httpConfig;
        }
        public IGApiQueryResult QueryInfoAccount(string accountId)
        {
            var result = new IGApiQueryResult();
            HttpRequest httpRequest = HttpFactory.NewClient(_httpConfig);
            HttpResponse httpResponse = null;
            httpRequest.AddHeader("User-Agent", _samsung_ug);
            string payload = string.Empty;
            string resultapi = string.Empty;
            try
            {
                httpResponse = httpRequest.Get($"https://i.instagram.com/api/v1/users/{accountId}/info/");
                resultapi = httpResponse.ToString();
                if (resultapi.Contains("username\":") || resultapi.Contains("profile_pic_url\":"))
                {
                    result.IgStatusCode = IgApiCallStatusCode.Success;
                }
                else if (resultapi.Contains("user_not_found\""))
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
    }
}
