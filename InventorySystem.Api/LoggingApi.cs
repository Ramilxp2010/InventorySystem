using InventorySystem.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Api
{
    public static class LoggingApi
    {
        public static void Error(string callerName, Exception ex) 
        {
            ApiManager.PostResponse("Logging", new Log(callerName, LogType.Error, ex));
        }

        public static void Trace(string callerName)
        {
            ApiManager.PostResponse("Logging", new Log(callerName, LogType.Trace));
        }

        public static void Info(string callerName)
        {
            ApiManager.PostResponse("Logging", new Log(callerName, LogType.Info));
        }

        public static void Warning(string callerName)
        {
            ApiManager.PostResponse("Logging", new Log(callerName, LogType.Warning));
        }
    }
}
