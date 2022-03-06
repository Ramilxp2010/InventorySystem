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
using InventorySystem.Manager.Interfaces;

namespace InventorySystem.Manager.Implementations
{
    public class ProductWorkManager : IProductWorkManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private IGenericRepository<ProductWork> _productWorkRepository;

        public ProductWorkManager()
        {
            _productWorkRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<ProductWork>>();
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

        public IEnumerable<ProductWork> GetProductByInventory(Inventory item)
        {
            return _productWorkRepository.GetWithInclude(x => x.InventoryId == item.Id,
                work => work.Product,
                work => work.Product.Unit);
        }

        public IEnumerable<ProductWork> GetProductByInvoice(Invoice item)
        {
            return _productWorkRepository.GetWithInclude(x => x.InvoiceId == item.Id,
                work => work.Product,
                work => work.Product.Unit);
        }

        public IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item)
        {
            return _productWorkRepository.GetWithInclude(x => x.PurchaseInvoiceId == item.Id,
                work => work.Product,
                work => work.Product.Unit);
        }
    }
}
