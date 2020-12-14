using InventorySystem.Contract;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;

namespace InventorySystem.Api
{
    public static class ApiManager
    {
        private static string APP_PATH = ConfigurationManager.AppSettings["serverUrl"];
        private static IEnumerable<T> GetResponseResult<T>(string request, [CallerMemberName] string callerName = "")
        {
            try
            {
                var requestUri = $"{APP_PATH}/api/values/{request}";

                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(requestUri).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<IEnumerable<T>>(result);
                }
            }
            catch (Exception ex)
            {
                PostResponse("Logging", new Log(callerName, LogType.Error, ex));
                return Enumerable.Empty<T>();
            }
        }
        
        private static int PostResponseResult<T>(string request, T item, [CallerMemberName] string callerName = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/{request}", item);
                    var result = response.Result;
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                        return content;
                    }

                    return -1;
                }
            }
            catch (Exception ex)
            {
                PostResponse("Logging", new Log(callerName, LogType.Error, ex));
                return -2;
            }
        }

        private static HttpStatusCode PostResponse<T>(string request, T item, [CallerMemberName] string callerName = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/{request}", item).Result;
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

        public static bool CheckServer()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetServerStatus/status");
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<bool>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return false;
            }
        }

        #region Product

        public static IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            return GetResponseResult<Product>($"GetProducts/{showIsDelete}");
        }

        public static int CreateProduct(Product item)
        {
            return PostResponseResult("CreateProduct", item);
        }

        public static string UpdateProduct(Product item)
        {
            return PostResponse("UpdateProduct", item).ToString();
        }

        public static string DeleteProduct(Product item)
        {
            return PostResponse("RemoveProduct", item).ToString();
        }

        #endregion Product

        #region Unit

        public static IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return GetResponseResult<Unit>($"GetUnits/{showIsDelete}");
        }

        public static int CreateUnit(Unit item)
        {
            return PostResponseResult("CreateUnit", item);
        }

        public static string UpdateUnit(Unit item)
        {
            return PostResponse("UpdateUnit", item).ToString();
        }

        public static string DeleteUnit(Unit item)
        {
            return PostResponse("RemoveUnit", item).ToString();
        }

        #endregion Unit

        #region Providers

        public static IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return GetResponseResult<Provider>($"GetProviders/{showIsDelete}");
        }

        public static int CreateProvider(Provider item)
        {
            return PostResponseResult("CreateProvider", item);
        }

        public static string UpdateProvider(Provider item)
        {
            return PostResponse("UpdateProvider", item).ToString();
        }

        public static string DeleteProvider(Provider item)
        {
            return PostResponse("RemoveProvider", item).ToString();
        }

        #endregion Providers

        #region ProductWork
        
        public static IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            return GetResponseResult<ProductWork>($"GetProductByPurchaseInvoice/byid/{item.Id}");
        }

        public static IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            return GetResponseResult<ProductWork>($"GetProductByInvoice/byid/{item.Id}");
        }

        public static IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            return GetResponseResult<ProductWork>($"GetProductByInventory/byid/{item.Id}");
        }

        public static int ProductWorkCreate(ProductWork item)
        {
            return PostResponseResult("ProductWorkCreate", item);
        }

        public static string ProductWorkUpdate(ProductWork item)
        {
            return PostResponse("ProductWorkUpdate", item).ToString();
        }

        #endregion ProductWork

        #region PurchaseInvoice

        public static IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return GetResponseResult<PurchaseInvoice>($"GetPurchaseInvoices");
        }

        /// <summary>
        /// Add new item and return item id
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            return PostResponseResult("PurchaseInvoiceCreate", item);
        }

        public static string PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            return PostResponse("PurchaseInvoiceUpdate", item).ToString();
        }

        #endregion PurchaseInvoice

        #region Invoice

        public static IEnumerable<Invoice> GetInvoices()
        {
            return GetResponseResult<Invoice>($"GetInvoices");
        }

        public static int InvoiceCreate(Invoice item)
        {
            return PostResponseResult("InvoiceCreate", item);
        }

        public static string InvoiceUpdate(Invoice item)
        {
            return PostResponse("InvoiceUpdate", item).ToString();
        }

        #endregion Invoice

        #region Inventory

        public static List<Inventory> GetInventories()
        {
            return GetResponseResult<Inventory>($"GetInventories").ToList();
        }

        public static string InventoryUpdate(Inventory item)
        {
            return PostResponse("InventoryUpdate", item).ToString();
        }

        public static int InventoryCreate(Inventory item)
        {
            return PostResponseResult("InventoryCreate", item);
        }

        #endregion Invoice

        public static List<WarehouseProduct> GetWarehouseProducts()
        {
            return GetResponseResult<WarehouseProduct>($"GetWarehouseProducts").ToList();
        }

    }
}
