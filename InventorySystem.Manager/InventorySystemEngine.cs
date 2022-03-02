using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InventorySystem.Manager
{
    public class InventorySystemEngine
    {
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductWork> _productWorkRepository;
        private IGenericRepository<PurchaseInvoice> _purchaseRepository;
        private IGenericRepository<Invoice> _invoiceRepository;
        private IGenericRepository<Inventory> _inventoryRepository;

        public InventorySystemEngine()
        {
            _productRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Product>>();
            _productWorkRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<ProductWork>>();
            _purchaseRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<PurchaseInvoice>>();
            _invoiceRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Invoice>>();
            _inventoryRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Inventory>>();
        }

        public List<WarehouseProduct> GetWarehouseProducts()
        {
            List<WarehouseProduct> goods = new List<WarehouseProduct>();
            foreach (var product in _productRepository.GetWithInclude(x => x.Unit))
            {
                var productWorks = _productWorkRepository.GetWithInclude(work => work.Product, work => work.PurchaseInvoice, work => work.Invoice, work => work.Inventory).Where(x=>x.Product.Id == product.Id).ToList();
                var addedProducts = productWorks.Where(x => x.PurchaseInvoice != null || x.Inventory != null).Sum(x => x.Count);
                var removedProducts = productWorks.Where(x => x.Invoice != null).Sum(x => x.Count);

                goods.Add(new WarehouseProduct
                {
                    Product = product,
                    Count = addedProducts - removedProducts
                });
            }

            return goods;
        }
    }
}
