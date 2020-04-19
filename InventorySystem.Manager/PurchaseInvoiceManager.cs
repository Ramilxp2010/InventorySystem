using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InventorySystem.Manager
{
    public class PurchaseInvoiceManager
    {
        private IGenericRepository<ProductWork> _productWorkRepository;
        private IGenericRepository<PurchaseInvoice> _purchaseRepository;
        private IGenericRepository<Invoice> _invoiceRepository;
        private IGenericRepository<Inventory> _inventoryRepository;

        public PurchaseInvoiceManager()
        {
            _productWorkRepository = RootContainer.Container.Resolve<IGenericRepository<ProductWork>>();
            _purchaseRepository = RootContainer.Container.Resolve<IGenericRepository<PurchaseInvoice>>();
            _invoiceRepository = RootContainer.Container.Resolve<IGenericRepository<Invoice>>();
            _inventoryRepository = RootContainer.Container.Resolve<IGenericRepository<Inventory>>();
        }

        public int ProductWorkCreate(ProductWork item)
        {
            return _productWorkRepository.Create(item).Id;
        }

        public void ProductWorkUpdate(ProductWork item)
        {
            _productWorkRepository.Update(item);
        }

        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(int id)
        {
            return _productWorkRepository.GetWithInclude(x => x.PurchaseInvoiceId == id,
                work => work.Product,
                work => work.Product.Unit,
                work => work.PurchaseInvoice.Provider);
        }

        public IEnumerable<ProductWork> GetProductByInvoice(int id)
        {
            return _productWorkRepository.GetWithInclude(x => x.InvoiceId == id,
                work => work.Product,
                work => work.Product.Unit);
        }

        public IEnumerable<ProductWork> GetProductByInventory(int id)
        {
            return _productWorkRepository.GetWithInclude(x => x.InventoryId == id,
                work => work.Product,
                work => work.Product.Unit);
        }

        public int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            return _purchaseRepository.Create(item).Id;
        }

        public void PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            _purchaseRepository.Update(item);
        }
        
        public int InvoiceCreate(Invoice item)
        {
            return _invoiceRepository.Create(item).Id;
        }

        public void InvoiceUpdate(Invoice item)
        {
            _invoiceRepository.Update(item);
        }

        public int InventoryCreate(Inventory item)
        {
            return _inventoryRepository.Create(item).Id;
        }

        public void InventoryUpdate(Inventory item)
        {
            _inventoryRepository.Update(item);
        }
    }
}
