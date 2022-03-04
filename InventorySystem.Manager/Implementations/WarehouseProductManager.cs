using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using InventorySystem.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InventorySystem.Manager.Implementations
{
    public class WarehouseProductManager : IWarehouseProductManager
    {
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductWork> _productWorkRepository;

        public WarehouseProductManager()
        {
            _productRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Product>>();
            _productWorkRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<ProductWork>>();
        }

        public List<WarehouseProduct> GetWarehouseProducts()
        {
            List<WarehouseProduct> goods = new List<WarehouseProduct>();
            foreach (var product in _productRepository.GetWithInclude(x => x.Unit))
            {
                var productWorks = _productWorkRepository.GetWithInclude(work => work.Product, work => work.PurchaseInvoice, work => work.Invoice, work => work.Inventory).Where(x => x.Product.Id == product.Id).ToList();
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
