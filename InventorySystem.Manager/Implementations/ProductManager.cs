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
    public class ProductManager : IProductManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductWork> _productWorkRepository;

        public ProductManager()
        {
            _productRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Product>>();
            _productWorkRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<ProductWork>>();
        }

        public IEnumerable<Product> GetProducts(bool showIsDelete = false)
        {
            if (showIsDelete)
            {
                return _productRepository.GetWithInclude(x => x.Unit);
            }
            else
            {
                return _productRepository.GetWithInclude(x => x.Unit)
                    .Where(x => x.IsDelete == null || x.IsDelete == false);
            }
        }

        public int CreateProduct(Product item)
        {
            return _productRepository.Create(item).Id;
        }

        public void UpdateProduct(Product item)
        {
            _productRepository.Update(item);
        }

        public void DeleteProduct(Product item)
        {
            var relatives = _productWorkRepository.Get(x => x.ProductId == item.Id);
            if (relatives.Any())
            {
                item.IsDelete = true;
                item.Unit = null;
                UpdateProduct(item);
            }
            else
            {
                _productRepository.Remove(item);
            }
        }

    }
}
