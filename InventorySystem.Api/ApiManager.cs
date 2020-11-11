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

namespace InventorySystem.Api
{
    public class ApiManager
    {
        //private string APP_PATH = "http://localhost:61510/";
        private string APP_PATH = ConfigurationManager.AppSettings["serverUrl"];

        public bool CheckServer()
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

        public IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetProducts/{showIsDelete}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<Product>>(result);
            }
        }

        public int CreateProduct(Product item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/CreateProduct", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return -1;
            }
        }

        public string UpdateProduct(Product item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/UpdateProduct", item).Result;
                return response.StatusCode.ToString();
            }
        }

        public string DeleteProduct(Product item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/RemoveProduct", item).Result;
                return response.StatusCode.ToString();
            }
        }

        #endregion Product

        #region Unit

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetUnits/{showIsDelete}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<Unit>>(result);
            }
        }

        public int CreateUnit(Unit item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/CreateUnit", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return -1;
            }
        }

        public string UpdateUnit(Unit item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/UpdateUnit", item).Result;
                return response.StatusCode.ToString();
            }
        }

        public string DeleteUnit(Unit item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/RemoveUnit", item).Result;
                return response.StatusCode.ToString();
            }
        }

        #endregion Unit

        #region Providers

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetProviders/{showIsDelete}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<Provider>>(result);
            }
        }

        public int CreateProvider(Provider item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/CreateProvider", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result);
                    return content;
                }

                return -1;
            }
        }

        public string UpdateProvider(Provider item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/UpdateProvider", item).Result;
                return response.StatusCode.ToString();
            }
        }

        public string DeleteProvider(Provider item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/RemoveProvider", item).Result;
                return response.StatusCode.ToString();
            }
        }

        #endregion Providers

        #region ProductWork
        
        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetProductByPurchaseInvoice/byid/{item.Id}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<ProductWork>>(result);
            }
        }

        public IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetProductByInvoice/byid/{item.Id}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<ProductWork>>(result);
            }
        }

        public IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetProductByInventory/byid/{item.Id}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<ProductWork>>(result);
            }
        }

        public int ProductWorkCreate(ProductWork item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/ProductWorkCreate", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return -1;
            }
        }

        public string ProductWorkUpdate(ProductWork item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/ProductWorkUpdate", item).Result;
                return response.StatusCode.ToString();
            }
        }

        #endregion ProductWork

        #region PurchaseInvoice

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetPurchaseInvoices").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<PurchaseInvoice>>(result);
            }
        }

        /// <summary>
        /// Add new item and return item id
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/PurchaseInvoiceCreate", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return -1;
            }
        }

        public string PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/PurchaseInvoiceUpdate", item).Result;
                return response.StatusCode.ToString();
            }
        }

        #endregion PurchaseInvoice

        #region Invoice

        public IEnumerable<Invoice> GetInvoices()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetInvoices").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<Invoice>>(result);
            }
        }

        public int InvoiceCreate(Invoice item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/InvoiceCreate", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return -1;
            }
        }

        public string InvoiceUpdate(Invoice item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/InvoiceUpdate", item).Result;
                return response.StatusCode.ToString();
            }
        }

        #endregion Invoice

        #region Inventory

        public List<Inventory> GetInventories()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetInventories").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Inventory>>(result);
            }
        }

        public string InventoryUpdate(Inventory item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/InventoryUpdate", item).Result;
                return response.StatusCode.ToString();
            }
        }

        public int InventoryCreate(Inventory item)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + $"/api/values/InventoryCreate", item);
                var result = response.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = JsonConvert.DeserializeObject<int>(result.Content.ReadAsStringAsync().Result); ;
                    return content;
                }

                return -1;
            }
        }

        #endregion Invoice

        public List<WarehouseProduct> GetWarehouseProducts()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(APP_PATH + $"/api/values/GetWarehouseProducts").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<WarehouseProduct>>(result);
            }
        }

    }
}
