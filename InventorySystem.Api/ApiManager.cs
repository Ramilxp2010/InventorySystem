using InventorySystem.Contract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Api
{
    public static class ApiManager
    {
        public static string APP_PATH = ConfigurationManager.AppSettings["serverUrl"];

        public static IEnumerable<T> GetResponseResult<T>(string request, [CallerMemberName] string callerName = "")
        {
            try
            {
                LoggingApi.Trace($"[CallerName]:{callerName};[Request]:{request};[Type]:{typeof(T)}");

                var requestUri = $"{APP_PATH}/api/values/{request}";

                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(requestUri).Result;
                    var result = response.Content.ReadAsStringAsync().Result;

                    LoggingApi.Info($"[CallerName]:{callerName};[Request]:{request};[Result]:{result}");

                    return JsonConvert.DeserializeObject<IEnumerable<T>>(result);
                }
            }
            catch (Exception ex)
            {
                LoggingApi.Error(callerName, ex);
                return Enumerable.Empty<T>();
            }
        }

        public static int PostResponseResult<T>(string request, T item, [CallerMemberName] string callerName = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    LoggingApi.Trace($"[CallerName]:{callerName};[Request]:{request};[Type]:{typeof(T)}");

                    var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/{request}", item);
                    var result = response.Result;

                    LoggingApi.Info($"[CallerName]:{callerName};[Request]:{request};[StatusCode]:{result.StatusCode}");

                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result);

                        LoggingApi.Info($"[CallerName]:{callerName};[Request]:{request};[Result]:{result}");

                        return content;
                    }

                    return -1;
                }
            }
            catch (Exception ex)
            {
                LoggingApi.Error(callerName, ex);
                return -2;
            }
        }

        public static HttpStatusCode PostResponse<T>(string request, T item, [CallerMemberName] string callerName = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    LoggingApi.Trace($"[CallerName]:{callerName};[Request]:{request};[Type]:{typeof(T)}");

                    var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/{request}", item).Result;

                    LoggingApi.Info($"[CallerName]:{callerName};[Request]:{request};[StatusCode]:{response.StatusCode}");

                    return response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                using (var client = new HttpClient())
                {
                    client.PostAsJsonAsync(APP_PATH + $"/api/values/Logging", new Log(callerName, LogType.Error, ex));
                }

                return HttpStatusCode.InternalServerError;
            }
        }

    }
}
