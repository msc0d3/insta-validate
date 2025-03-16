using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Request
{
    public class HttpGlobal
    {
        public enum HttpCallStatus
        {
            Ok,
            Error
        }
        public class ContentTypes
        {
            public const string JsonContentType = "application/json";
            public const string JsonContentTypeUtf8 = "application/json charset=UTF-8";
            public const string FormUrlEncoded = "application/x-www-form-urlencoded";
            public const string FormUrlEncodedUtf8 = "application/x-www-form-urlencoded; charset=UTF-8";
        }
    }
}
