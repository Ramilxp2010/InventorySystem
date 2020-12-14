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
    public static class InventorySystemApi
    {
        public static bool CheckServer()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(ApiManager.APP_PATH + $"/api/values/GetServerStatus/status");
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
            return ApiManager.GetResponseResult<Product>($"GetProducts/{showIsDelete}");
        }

        public static int CreateProduct(Product item)
        {
            return ApiManager.PostResponseResult("CreateProduct", item);
        }

        public static string UpdateProduct(Product item)
        {
            return ApiManager.PostResponse("UpdateProduct", item).ToString();
        }

        public static string DeleteProduct(Product item)
        {
            return ApiManager.PostResponse("RemoveProduct", item).ToString();
        }

        #endregion Product

        #region Unit

        public static IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return ApiManager.GetResponseResult<Unit>($"GetUnits/{showIsDelete}");
        }

        public static int CreateUnit(Unit item)
        {
            return ApiManager.PostResponseResult("CreateUnit", item);
        }

        public static string UpdateUnit(Unit item)
        {
            return ApiManager.PostResponse("UpdateUnit", item).ToString();
        }

        public static string DeleteUnit(Unit item)
        {
            return ApiManager.PostResponse("RemoveUnit", item).ToString();
        }

        #endregion Unit

        #region Providers

        public static IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return ApiManager.GetResponseResult<Provider>($"GetProviders/{showIsDelete}");
        }

        public static int CreateProvider(Provider item)
        {
            return ApiManager.PostResponseResult("CreateProvider", item);
        }

        public static string UpdateProvider(Provider item)
        {
            return ApiManager.PostResponse("UpdateProvider", item).ToString();
        }

        public static string DeleteProvider(Provider item)
        {
            return ApiManager.PostResponse("RemoveProvider", item).ToString();
        }

        #endregion Providers

        #region ProductWork
        
        public static IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            return ApiManager.GetResponseResult<ProductWork>($"GetProductByPurchaseInvoice/byid/{item.Id}");
        }

        public static IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            return ApiManager.GetResponseResult<ProductWork>($"GetProductByInvoice/byid/{item.Id}");
        }

        public static IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            return ApiManager.GetResponseResult<ProductWork>($"GetProductByInventory/byid/{item.Id}");
        }

        public static int ProductWorkCreate(ProductWork item)
        {
            return ApiManager.PostResponseResult("ProductWorkCreate", item);
        }

        public static string ProductWorkUpdate(ProductWork item)
        {
            return ApiManager.PostResponse("ProductWorkUpdate", item).ToString();
        }

        #endregion ProductWork

        #region PurchaseInvoice

        public static IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return ApiManager.GetResponseResult<PurchaseInvoice>($"GetPurchaseInvoices");
        }

        /// <summary>
        /// Add new item and return item id
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            return ApiManager.PostResponseResult("PurchaseInvoiceCreate", item);
        }

        public static string PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            return ApiManager.PostResponse("PurchaseInvoiceUpdate", item).ToString();
        }

        #endregion PurchaseInvoice

        #region Invoice

        public static IEnumerable<Invoice> GetInvoices()
        {
            return ApiManager.GetResponseResult<Invoice>($"GetInvoices");
        }

        public static int InvoiceCreate(Invoice item)
        {
            return ApiManager.PostResponseResult("InvoiceCreate", item);
        }

        public static string InvoiceUpdate(Invoice item)
        {
            return ApiManager.PostResponse("InvoiceUpdate", item).ToString();
        }

        #endregion Invoice

        #region Inventory

        public static List<Inventory> GetInventories()
        {
            return ApiManager.GetResponseResult<Inventory>($"GetInventories").ToList();
        }

        public static string InventoryUpdate(Inventory item)
        {
            return ApiManager.PostResponse("InventoryUpdate", item).ToString();
        }

        public static int InventoryCreate(Inventory item)
        {
            return ApiManager.PostResponseResult("InventoryCreate", item);
        }

        #endregion Invoice

        public static List<WarehouseProduct> GetWarehouseProducts()
        {
            return ApiManager.GetResponseResult<WarehouseProduct>($"GetWarehouseProducts").ToList();
        }

    }
}
