using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using NLog;

namespace InventorySystem.Manager
{
    public class PurchaseInvoiceManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private IGenericRepository<ProductWork> _productWorkRepository;
        private IGenericRepository<PurchaseInvoice> _purchaseRepository;
        private IGenericRepository<Invoice> _invoiceRepository;
        private IGenericRepository<Inventory> _inventoryRepository;

        public PurchaseInvoiceManager()
        {
            _productWorkRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<ProductWork>>();
            _purchaseRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<PurchaseInvoice>>();
            _invoiceRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Invoice>>();
            _inventoryRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Inventory>>();
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
            try
            {
                Logger.Info($"Try to get ProductWorks by Id {id}");
                return _productWorkRepository.GetWithInclude(x => x.PurchaseInvoiceId == id,
                    work => work.Product,
                    work => work.Product.Unit,
                    work => work.PurchaseInvoice.Provider);
            }
            catch (Exception ex) 
            {
                Logger.Error($"Try to get ProductWorks by Id {id}. Error = {ex.ToString()}");
                return null;
            }
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
