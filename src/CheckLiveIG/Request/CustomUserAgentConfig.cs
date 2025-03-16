using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Request
{
    public class CustomUserAgentConfig
    {
        public bool IsUseCustomUG { get; set; }
        public string UserAgent { get; set; }
        public UserAgentPlatform Platform { get; set; }
        public enum UserAgentPlatform
        {
            Mobile,
            Desktop
        }
    }
}
