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

        #region Product

        public IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            return _guideManager.GetProducts(showIsDelete);
        }

        public void CreateProduct([FromBody]Product item)
        {
            _guideManager.CreateProduct(item);
        }

        public void UpdateProduct([FromBody]Product item)
        {
            _guideManager.UpdateProduct(item);
        }

        public void DeleteProduct([FromBody]Product item)
        {
            _guideManager.DeleteProduct(item);
        }

        #endregion Product

        #region Unit

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return _guideManager.GetUnits(showIsDelete);
        }

        public void CreateUnit([FromBody]Unit item)
        {
            _guideManager.CreateUnit(item);
        }

        public void UpdateUnit([FromBody]Unit item)
        {
            _guideManager.UpdateUnit(item);
        }

        public void DeleteUnit([FromBody]Unit item)
        {
            _guideManager.DeleteUnit(item);
        }

        #endregion Unit

        #region Provider

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return _guideManager.GetProviders(showIsDelete);
        }

        public void CreateProvider([FromBody]Provider item)
        {
            _guideManager.CreateProvider(item);
        }

        public void UpdateProvider([FromBody]Provider item)
        {
            _guideManager.UpdateProvider(item);
        }

        public void DeleteProvider([FromBody]Provider item)
        {
            _guideManager.DeleteProvider(item);
        }

        #endregion Provider

        #region ProductWork

        public void ProductWorkCreate([FromBody]ProductWork item)
        {
            _invoiceManager.ProductWorkCreate(item);
        }

        public void ProductWorkUpdate([FromBody]ProductWork item)
        {
            _invoiceManager.ProductWorkUpdate(item);
        }

        public IEnumerable<ProductWork> GetProductByPurchaseInvoice([FromBody]PurchaseInvoice item)
        {
            return _invoiceManager.GetProductByPurchaseInvoice(item);
        }

        public IEnumerable<ProductWork> GetProductByInvoice([FromBody]Invoice item)
        {
            return _invoiceManager.GetProductByInvoice(item);
        }

        public IEnumerable<ProductWork> GetProductByInventory([FromBody]Inventory item)
        {
            return _invoiceManager.GetProductByInventory(item);
        }
        
        #endregion ProductWork

        #region PurchaseInvoice

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return _guideManager.GetPurchaseInvoices();
        }

        public void PurchaseInvoiceCreate([FromBody]PurchaseInvoice item)
        {
            _invoiceManager.PurchaseInvoiceUpdate(item);
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

        public void InvoiceCreate([FromBody]Invoice item)
        {
            _invoiceManager.InvoiceCreate(item);
        }

        public void InvoiceUpdate([FromBody]Invoice item)
        {
            _invoiceManager.InvoiceUpdate(item);
        }

        #endregion Invoice

        #region Inventory

        public List<Inventory> GetInventories()
        {
            return _guideManager.GetInventories().ToList();
        }

        public void InventoryCreate([FromBody]Inventory item)
        {
            _invoiceManager.InventoryCreate(item);
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