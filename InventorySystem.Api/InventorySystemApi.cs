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
using InventorySystem.Manager.Interfaces;

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

        public void UpdateProduct(Product item)
        {
            ApiManager.PostResponse("UpdateProduct", item).ToString();
        }

        public void DeleteProduct(Product item)
        {
            ApiManager.PostResponse("RemoveProduct", item).ToString();
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

        public void UpdateUnit(Unit item)
        {
            ApiManager.PostResponse("UpdateUnit", item).ToString();
        }

        public void DeleteUnit(Unit item)
        {
            ApiManager.PostResponse("RemoveUnit", item).ToString();
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

        public void UpdateProvider(Provider item)
        {
            ApiManager.PostResponse("UpdateProvider", item).ToString();
        }

        public void DeleteProvider(Provider item)
        {
            ApiManager.PostResponse("RemoveProvider", item).ToString();
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

        public void ProductWorkUpdate(ProductWork item)
        {
            ApiManager.PostResponse("ProductWorkUpdate", item).ToString();
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

        public void PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            ApiManager.PostResponse("PurchaseInvoiceUpdate", item).ToString();
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

        public void InvoiceUpdate(Invoice item)
        {
             ApiManager.PostResponse("InvoiceUpdate", item).ToString();
        }

        #endregion Invoice

        #region Inventory

        public IEnumerable<Inventory> GetInventories()
        {
            return ApiManager.GetResponseResult<Inventory>($"GetInventories");
        }

        public void InventoryUpdate(Inventory item)
        {
            ApiManager.PostResponse("InventoryUpdate", item).ToString();
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

        public IEnumerable<Inventory> GetInventoriesWithProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetInvoicesWithProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoicesWithProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductWork> GetProductByInventory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductWork> GetProductByInvoice(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<WarehouseProduct> IWarehouseProductManager.GetWarehouseProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WarehouseProduct> Search(string text)
        {
            throw new NotImplementedException();
        }
    }
}
