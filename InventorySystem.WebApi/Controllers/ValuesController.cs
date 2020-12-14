using InventorySystem.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InventorySystem.Contract;

namespace InventorySystem.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        GuideManager _guideManager = new GuideManager();
        PurchaseInvoiceManager _invoiceManager = new PurchaseInvoiceManager();
        InventorySystemEngine _engine = new InventorySystemEngine();

        [HttpGet]
        public bool GetServerStatus([FromBody]string status)
        {
            return true;
        }

        /// <summary>
        /// Logging
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Logging([FromBody]Log item)
        {
            _guideManager.MessageFromUI(item);
            return Ok();
        }

        #region Product

        public IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            return _guideManager.GetProducts(showIsDelete);
        }

        public int CreateProduct([FromBody]Product item)
        {
            return _guideManager.CreateProduct(item);
        }

        public void UpdateProduct([FromBody]Product item)
        {
            _guideManager.UpdateProduct(item);
        }

        public void RemoveProduct([FromBody]Product item)
        {
            _guideManager.DeleteProduct(item);
        }

        #endregion Product

        #region Unit

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return _guideManager.GetUnits(showIsDelete);
        }

        public int CreateUnit([FromBody]Unit item)
        {
            return _guideManager.CreateUnit(item);
        }

        public void UpdateUnit([FromBody]Unit item)
        {
            _guideManager.UpdateUnit(item);
        }

        public void RemoveUnit([FromBody]Unit item)
        {
            _guideManager.DeleteUnit(item);
        }

        #endregion Unit

        #region Provider

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return _guideManager.GetProviders(showIsDelete);
        }

        public int CreateProvider([FromBody]Provider item)
        {
            return _guideManager.CreateProvider(item);
        }

        public void UpdateProvider([FromBody]Provider item)
        {
            _guideManager.UpdateProvider(item);
        }

        public void RemoveProvider([FromBody]Provider item)
        {
            _guideManager.DeleteProvider(item);
        }

        #endregion Provider

        #region ProductWork

        public int ProductWorkCreate([FromBody]ProductWork item)
        {
            return _invoiceManager.ProductWorkCreate(item);
        }

        public void ProductWorkUpdate([FromBody]ProductWork item)
        {
            _invoiceManager.ProductWorkUpdate(item);
        }
        
        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(int id)
        {
            return _invoiceManager.GetProductByPurchaseInvoice(id);
        }

        public IEnumerable<ProductWork> GetProductByInvoice(int id)
        {
            return _invoiceManager.GetProductByInvoice(id);
        }

        public IEnumerable<ProductWork> GetProductByInventory(int id)
        {
            return _invoiceManager.GetProductByInventory(id);
        }
        
        #endregion ProductWork

        #region PurchaseInvoice

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return _guideManager.GetPurchaseInvoices();
        }

        public int PurchaseInvoiceCreate([FromBody]PurchaseInvoice item)
        {
            return _invoiceManager.PurchaseInvoiceCreate(item);
        }

        public void PurchaseInvoiceUpdate([FromBody]PurchaseInvoice item)
        {
            _invoiceManager.PurchaseInvoiceUpdate(item);
        }

        #endregion PurchaseInvoice

        #region Invoice

        public IEnumerable<Invoice> GetInvoices()
        {
            return _guideManager.GetInvoices();
        }

        public int InvoiceCreate([FromBody]Invoice item)
        {
            return _invoiceManager.InvoiceCreate(item);
        }

        public void InvoiceUpdate([FromBody]Invoice item)
        {
            _invoiceManager.InvoiceUpdate(item);
        }

        #endregion Invoice

        #region Inventory

        public IEnumerable<Inventory> GetInventories()
        {
            return _guideManager.GetInventories();
        }

        public int InventoryCreate([FromBody]Inventory item)
        {
            return _invoiceManager.InventoryCreate(item);
        }

        public void InventoryUpdate([FromBody]Inventory item)
        {
            _invoiceManager.InventoryUpdate(item);
        }

        #endregion Inventory
        
        public List<WarehouseProduct> GetWarehouseProducts()
        {
            return _engine.GetWarehouseProducts();
        }
    }
}