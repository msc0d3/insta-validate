using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Singleton
{
    public class PathSingleton
    {
        public static string ConfigPath = Environment.CurrentDirectory + "\\config";
        //public static string ProxyServicesFolder = ConfigPath + "\\proxyservices";
        public static string ProxyListFile = ConfigPath + "\\proxylist.txt";
    }
}
