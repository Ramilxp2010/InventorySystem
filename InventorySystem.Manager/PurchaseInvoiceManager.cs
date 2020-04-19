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

        public void ProductWorkCreate(ProductWork item)
        {
            _productWorkRepository.Create(item);
        }

        public void ProductWorkUpdate(ProductWork item)
        {
            _productWorkRepository.Update(item);
        }

        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            return _productWorkRepository.GetWithInclude(x => x.PurchaseInvoiceId == item.Id,
                work => work.PurchaseInvoice,
                work => work.Product,
                work => work.Product.Unit,
                work => work.PurchaseInvoice.Provider);
        }

        public IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            return _productWorkRepository.GetWithInclude(x => x.InvoiceId == item.Id,
                work => work.Invoice,
                work => work.Product,
                work => work.Product.Unit);
        }

        public IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            return _productWorkRepository.GetWithInclude(x => x.InventoryId == item.Id,
                work => work.Inventory,
                work => work.Product,
                work => work.Product.Unit);
        }

        public void PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            _purchaseRepository.Create(item);
        }

        public void PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            _purchaseRepository.Update(item);
        }
        
        public void InvoiceCreate(Invoice item)
        {
            _invoiceRepository.Create(item);
        }

        public void InvoiceUpdate(Invoice item)
        {
            _invoiceRepository.Update(item);
        }

        public void InventoryCreate(Inventory item)
        {
            _inventoryRepository.Create(item);
        }

        public void InventoryUpdate(Inventory item)
        {
            _inventoryRepository.Update(item);
        }
    }
}
