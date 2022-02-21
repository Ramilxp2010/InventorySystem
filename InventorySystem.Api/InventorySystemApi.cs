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
    public class InventorySystemApi : IInventorySystemApi 
    {
        public bool CheckServer()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(ApiManager.APP_PATH + $"/api/values/GetServerStatus/status");

                    var result = response.Result;
                    if (result?.StatusCode == HttpStatusCode.OK)
                    {
                        var content = JsonConvert.DeserializeObject<bool>(result.Content.ReadAsStringAsync().Result); ;
                        return content;
                    }

                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        #region Product

        public IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            return ApiManager.GetResponseResult<Product>($"GetProducts/{showIsDelete}");
        }

        public int CreateProduct(Product item)
        {
            return ApiManager.PostResponseResult("CreateProduct", item);
        }

        public string UpdateProduct(Product item)
        {
            return ApiManager.PostResponse("UpdateProduct", item).ToString();
        }

        public string DeleteProduct(Product item)
        {
            return ApiManager.PostResponse("RemoveProduct", item).ToString();
        }

        #endregion Product

        #region Unit

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return ApiManager.GetResponseResult<Unit>($"GetUnits/{showIsDelete}");
        }

        public int CreateUnit(Unit item)
        {
            return ApiManager.PostResponseResult("CreateUnit", item);
        }

        public string UpdateUnit(Unit item)
        {
            return ApiManager.PostResponse("UpdateUnit", item).ToString();
        }

        public string DeleteUnit(Unit item)
        {
            return ApiManager.PostResponse("RemoveUnit", item).ToString();
        }

        #endregion Unit

        #region Providers

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return ApiManager.GetResponseResult<Provider>($"GetProviders/{showIsDelete}");
        }

        public int CreateProvider(Provider item)
        {
            return ApiManager.PostResponseResult("CreateProvider", item);
        }

        public string UpdateProvider(Provider item)
        {
            return ApiManager.PostResponse("UpdateProvider", item).ToString();
        }

        public string DeleteProvider(Provider item)
        {
            return ApiManager.PostResponse("RemoveProvider", item).ToString();
        }

        #endregion Providers

        #region ProductWork

        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            return ApiManager.GetResponseResult<ProductWork>($"GetProductByPurchaseInvoice/byid/{item.Id}");
        }

        public IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            return ApiManager.GetResponseResult<ProductWork>($"GetProductByInvoice/byid/{item.Id}");
        }

        public IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            return ApiManager.GetResponseResult<ProductWork>($"GetProductByInventory/byid/{item.Id}");
        }

        public int ProductWorkCreate(ProductWork item)
        {
            return ApiManager.PostResponseResult("ProductWorkCreate", item);
        }

        public string ProductWorkUpdate(ProductWork item)
        {
            return ApiManager.PostResponse("ProductWorkUpdate", item).ToString();
        }

        #endregion ProductWork

        #region PurchaseInvoice

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return ApiManager.GetResponseResult<PurchaseInvoice>($"GetPurchaseInvoices");
        }

        /// <summary>
        /// Add new item and return item id
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            return ApiManager.PostResponseResult("PurchaseInvoiceCreate", item);
        }

        public string PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            return ApiManager.PostResponse("PurchaseInvoiceUpdate", item).ToString();
        }

        #endregion PurchaseInvoice

        #region Invoice

        public IEnumerable<Invoice> GetInvoices()
        {
            return ApiManager.GetResponseResult<Invoice>($"GetInvoices");
        }

        public int InvoiceCreate(Invoice item)
        {
            return ApiManager.PostResponseResult("InvoiceCreate", item);
        }

        public string InvoiceUpdate(Invoice item)
        {
            return ApiManager.PostResponse("InvoiceUpdate", item).ToString();
        }

        #endregion Invoice

        #region Inventory

        public List<Inventory> GetInventories()
        {
            return ApiManager.GetResponseResult<Inventory>($"GetInventories").ToList();
        }

        public string InventoryUpdate(Inventory item)
        {
            return ApiManager.PostResponse("InventoryUpdate", item).ToString();
        }

        public int InventoryCreate(Inventory item)
        {
            return ApiManager.PostResponseResult("InventoryCreate", item);
        }

        #endregion Invoice

        public List<WarehouseProduct> GetWarehouseProducts()
        {
            return ApiManager.GetResponseResult<WarehouseProduct>($"GetWarehouseProducts").ToList();
        }

    }
}
