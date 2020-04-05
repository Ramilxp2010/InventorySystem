using System.Collections.Generic;
using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
using Unity;

namespace InventorySystem.Manager
{
    public class GuideManager
    {
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<Unit> _unitRepository;
        private IGenericRepository<Provider> _providerRepository;

        public GuideManager()
        {
            _productRepository = RootContainer.Container.Resolve<IGenericRepository<Product>>();
            _unitRepository = RootContainer.Container.Resolve<IGenericRepository<Unit>>();
            _unitRepository = RootContainer.Container.Resolve<IGenericRepository<Unit>>();
            _providerRepository = RootContainer.Container.Resolve<IGenericRepository<Provider>>();
        }

        public void CreateProduct(Product item)
        {
            _productRepository.Create(item);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetWithInclude(x=>x.Unit);
        }

        public void CreateUnit(Unit item)
        {
            _unitRepository.Create(item);
        }

        public IEnumerable<Unit> GetUnits()
        {
            return _unitRepository.Get();
        }

        public void CreateProvider(Provider item)
        {
            _providerRepository.Create(item);
        }

        public IEnumerable<Provider> GetProviders()
        {
            return _providerRepository.Get();
        }

        public void UpdateProduct(Product item)
        {
            _productRepository.Update(item);
        }

        public void UpdateUnit(Unit item)
        {
            _unitRepository.Update(item);
        }

        public void UpdateProvider(Provider item)
        {
            _providerRepository.Update(item);
        }
        
        public void DeleteProduct(Product item)
        {
            _productRepository.Remove(item);
        }

        public void DeleteUnit(Unit item)
        {
            _unitRepository.Remove(item);
        }

        public void DeleteProvider(Provider item)
        {
            _providerRepository.Remove(item);
        }
    }
}
