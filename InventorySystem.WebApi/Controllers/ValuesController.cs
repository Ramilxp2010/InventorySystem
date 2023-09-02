using System.Collections.Generic;
using System.Web.Http;
using InventorySystem.Contract;
using InventorySystem.Core;
using Unity;
using InventorySystem.Manager.Interfaces;
using System.Linq;

namespace InventorySystem.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private IInvoiceManager _invoiceManager;
        private IUnitManager _unitManager;
        private IProductManager _productManager;
        private IInventoryManager _inventoryManager;
        private IPurchaseInvoiceManager _purchaseInvoiceManager;
        private IProductWorkManager _productWorkManager;
        private IProviderManager _providerManager;
        private IWarehouseProductManager _warehouseProductManager;

        public ValuesController()
        {
            _invoiceManager = RootContainer.Instance.Container.Resolve<IInvoiceManager>();
            _unitManager = RootContainer.Instance.Container.Resolve<IUnitManager>();
            _productManager = RootContainer.Instance.Container.Resolve<IProductManager>();
            _inventoryManager = RootContainer.Instance.Container.Resolve<IInventoryManager>();
            _purchaseInvoiceManager = RootContainer.Instance.Container.Resolve<IPurchaseInvoiceManager>();
            _productWorkManager = RootContainer.Instance.Container.Resolve<IProductWorkManager>();
            _providerManager = RootContainer.Instance.Container.Resolve<IProviderManager>();
            _warehouseProductManager = RootContainer.Instance.Container.Resolve<IWarehouseProductManager>();
        }

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
            //RootContainer.Instance.Container.MessageFromUI(item);
            return Ok();
        }

        #region Product

        public IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            return _productManager.GetProducts(showIsDelete);
        }

        public int CreateProduct([FromBody]Product item)
        {
            return _productManager.CreateProduct(item);
        }

        public void UpdateProduct([FromBody]Product item)
        {
            _productManager.UpdateProduct(item);
        }

        public void RemoveProduct([FromBody]Product item)
        {
            _productManager.DeleteProduct(item);
        }

        #endregion Product

        #region Unit

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            return _unitManager.GetUnits(showIsDelete);
        }

        public int CreateUnit([FromBody]Unit item)
        {
            return _unitManager.CreateUnit(item);
        }

        public void UpdateUnit([FromBody]Unit item)
        {
            _unitManager.UpdateUnit(item);
        }

        public void RemoveUnit([FromBody]Unit item)
        {
            _unitManager.DeleteUnit(item);
        }

        #endregion Unit

        #region Provider

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            return _providerManager.GetProviders(showIsDelete);
        }

        public int CreateProvider([FromBody]Provider item)
        {
            return _providerManager.CreateProvider(item);
        }

        public void UpdateProvider([FromBody]Provider item)
        {
            _providerManager.UpdateProvider(item);
        }

        public void RemoveProvider([FromBody]Provider item)
        {
            _providerManager.DeleteProvider(item);
        }

        #endregion Provider

        #region ProductWork

        public int ProductWorkCreate([FromBody]ProductWork item)
        {
            return _productWorkManager.ProductWorkCreate(item);
        }

        public void ProductWorkUpdate([FromBody]ProductWork item)
        {
            _productWorkManager.ProductWorkUpdate(item);
        }
        
        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(int id)
        {
            return _productWorkManager.GetProductByPurchaseInvoice(id);
        }

        public IEnumerable<ProductWork> GetProductByInvoice(int id)
        {
            return _productWorkManager.GetProductByInvoice(id);
        }

        public IEnumerable<ProductWork> GetProductByInventory(int id)
        {
            return _productWorkManager.GetProductByInventory(id);
        }
        
        #endregion ProductWork

        #region PurchaseInvoice

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return _purchaseInvoiceManager.GetPurchaseInvoices();
        }

        public int PurchaseInvoiceCreate([FromBody]PurchaseInvoice item)
        {
            return _purchaseInvoiceManager.PurchaseInvoiceCreate(item);
        }

        public void PurchaseInvoiceUpdate([FromBody]PurchaseInvoice item)
        {
            _purchaseInvoiceManager.PurchaseInvoiceUpdate(item);
        }

        #endregion PurchaseInvoice

        #region Invoice

        public IEnumerable<Invoice> GetInvoices()
        {
            return _invoiceManager.GetInvoices();
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
            return _inventoryManager.GetInventories();
        }

        public int InventoryCreate([FromBody]Inventory item)
        {
            return _inventoryManager.InventoryCreate(item);
        }

        public void InventoryUpdate([FromBody]Inventory item)
        {
            _inventoryManager.InventoryUpdate(item);
        }

        #endregion Inventory
        
        public List<WarehouseProduct> GetWarehouseProducts()
        {
            return _warehouseProductManager.GetWarehouseProducts().ToList();
        }
    }
}