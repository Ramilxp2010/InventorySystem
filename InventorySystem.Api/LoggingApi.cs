using InventorySystem.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Api
{
    public static class LoggingApi
    {
        public static void Error(string callerName, Exception ex) 
        {
            PostResponse("Logging", new Log(callerName, LogType.Error, ex));
        }

        public static void Trace(string callerName)
        {
            PostResponse("Logging", new Log(callerName, LogType.Trace));
        }

        public static void Info(string callerName)
        {
            PostResponse("Logging", new Log(callerName, LogType.Info));
        }

        public static void Warning(string callerName)
        {
            PostResponse("Logging", new Log(callerName, LogType.Warning));
        }


        public static HttpStatusCode PostResponse<T>(string request, T item, [CallerMemberName] string callerName = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.PostAsJsonAsync(ApiManager.APP_PATH + $"/api/values/{request}", item).Result;
                    return response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                using (var client = new HttpClient())
                {
                    client.PostAsJsonAsync(ApiManager.APP_PATH + $"/api/values/Logging", new Log(callerName, LogType.Error, ex));
                }

                return HttpStatusCode.InternalServerError;
            }
        }

    }
}
