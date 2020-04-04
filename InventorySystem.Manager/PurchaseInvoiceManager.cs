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

        public void InventoryCreate(Invoice item)
        {
            _invoiceRepository.Create(item);
        }

        public void InventoryUpdate(Invoice item)
        {
            _invoiceRepository.Update(item);
        }
    }
}
