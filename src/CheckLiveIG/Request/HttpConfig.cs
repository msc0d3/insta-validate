using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Request
{
    public class HttpConfig
    {
        public ProxyClient Proxy { get; set; }
        public bool UseProxy { get; set; }
        public CustomUserAgentConfig CustomUserAgent { get; set; }
        public int ConnectTimeOut { get; set; }
        public static HttpConfig Default
        {
            get
            {
                return new HttpConfig
                {
                    UseProxy = false,
                    CustomUserAgent = new CustomUserAgentConfig
                    {
                        IsUseCustomUG = false
                    }
                };
            }
        }
    }
}
