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
        private IEnumerable<WarehouseProduct> _cache;

        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductWork> _productWorkRepository;

        public WarehouseProductManager()
        {
            _productRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Product>>();
            _productWorkRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<ProductWork>>();
        }

        public IEnumerable<WarehouseProduct> GetWarehouseProducts()
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

            _cache = goods;
            return goods;
        }

        public IEnumerable<WarehouseProduct> Search(string searchText)
        {
            var text = searchText.ToLowerInvariant();
            if (text.Length > 0 && text.Length <= 3)
                return _cache.Where(x => x.Product.Name.ToLowerInvariant().StartsWith(text));

            if (text.Length > 3)
                return _cache.Where(x => x.Product.Name.ToLowerInvariant().Contains(text));

            if (text.Length == 0)
                return _cache;

            return _cache;
        }
    }
}
