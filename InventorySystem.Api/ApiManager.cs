﻿using InventorySystem.Contract;
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
    public class ApiManager
    {
        private string APP_PATH = ConfigurationManager.AppSettings["serverUrl"];
        private IEnumerable<T> GetResponseResult<T>(string request, [CallerMemberName] string callerName = "")
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
        
        private int PostResponseResult(string request, object item, [CallerMemberName] string callerName = "")
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

        private HttpStatusCode PostResponse(string request, object item, [CallerMemberName] string callerName = "")
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
            return GetResponseResult<Product>($"GetProducts/{showIsDelete}");
        }

        public int CreateProduct(Product item)
        {
            return PostResponseResult("CreateProduct", item);
        }

        public string UpdateProduct(Product item)
        {
            return PostResponse("UpdateProduct", item).ToString();
        }

        public string DeleteProduct(Product item)
        {
            return PostResponse("RemoveProduct", item).ToString();
        }

        #endregion Product

        #region Unit

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return GetResponseResult<Unit>($"GetUnits/{showIsDelete}");
        }

        public int CreateUnit(Unit item)
        {
            return PostResponseResult("CreateUnit", item);
        }

        public string UpdateUnit(Unit item)
        {
            return PostResponse("UpdateUnit", item).ToString();
        }

        public string DeleteUnit(Unit item)
        {
            return PostResponse("RemoveUnit", item).ToString();
        }

        #endregion Unit

        #region Providers

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return GetResponseResult<Provider>($"GetProviders/{showIsDelete}");
        }

        public int CreateProvider(Provider item)
        {
            return PostResponseResult("CreateProvider", item);
        }

        public string UpdateProvider(Provider item)
        {
            return PostResponse("UpdateProvider", item).ToString();
        }

        public string DeleteProvider(Provider item)
        {
            return PostResponse("RemoveProvider", item).ToString();
        }

        #endregion Providers

        #region ProductWork
        
        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            return GetResponseResult<ProductWork>($"GetProductByPurchaseInvoice/byid/{item.Id}");
        }

        public IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            return GetResponseResult<ProductWork>($"GetProductByInvoice/byid/{item.Id}");
        }

        public IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            return GetResponseResult<ProductWork>($"GetProductByInventory/byid/{item.Id}");
        }

        public int ProductWorkCreate(ProductWork item)
        {
            return PostResponseResult("ProductWorkCreate", item);
        }

        public string ProductWorkUpdate(ProductWork item)
        {
            return PostResponse("ProductWorkUpdate", item).ToString();
        }

        #endregion ProductWork

        #region PurchaseInvoice

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return GetResponseResult<PurchaseInvoice>($"GetPurchaseInvoices");
        }

        /// <summary>
        /// Add new item and return item id
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            return PostResponseResult("PurchaseInvoiceCreate", item);
        }

        public string PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            return PostResponse("PurchaseInvoiceUpdate", item).ToString();
        }

        #endregion PurchaseInvoice

        #region Invoice

        public IEnumerable<Invoice> GetInvoices()
        {
            return GetResponseResult<Invoice>($"GetInvoices");
        }

        public int InvoiceCreate(Invoice item)
        {
            return PostResponseResult("InvoiceCreate", item);
        }

        public string InvoiceUpdate(Invoice item)
        {
            return PostResponse("InvoiceUpdate", item).ToString();
        }

        #endregion Invoice

        #region Inventory

        public List<Inventory> GetInventories()
        {
            return GetResponseResult<Inventory>($"GetInventories").ToList();
        }

        public string InventoryUpdate(Inventory item)
        {
            return PostResponse("InventoryUpdate", item).ToString();
        }

        public int InventoryCreate(Inventory item)
        {
            return PostResponseResult("InventoryCreate", item);
        }

        #endregion Invoice

        public List<WarehouseProduct> GetWarehouseProducts()
        {
            return GetResponseResult<WarehouseProduct>($"GetWarehouseProducts").ToList();
        }

    }
}
