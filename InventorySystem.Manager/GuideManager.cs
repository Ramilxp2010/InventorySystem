using System.Collections.Generic;
using System.Linq;
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
        private IGenericRepository<ProductWork> _productWorkRepository;
        private IGenericRepository<Unit> _unitRepository;
        private IGenericRepository<Provider> _providerRepository;
        private IGenericRepository<PurchaseInvoice> _purchaseInvoiceRepository;
        private IGenericRepository<Invoice> _invoiceRepository;
        private IGenericRepository<Inventory> _inventoryRepository;

        public GuideManager()
        {
            _productRepository = RootContainer.Container.Resolve<IGenericRepository<Product>>();
            _unitRepository = RootContainer.Container.Resolve<IGenericRepository<Unit>>();
            _providerRepository = RootContainer.Container.Resolve<IGenericRepository<Provider>>();
            _purchaseInvoiceRepository = RootContainer.Container.Resolve<IGenericRepository<PurchaseInvoice>>();
            _invoiceRepository = RootContainer.Container.Resolve<IGenericRepository<Invoice>>();
            _inventoryRepository = RootContainer.Container.Resolve<IGenericRepository<Inventory>>();
            _productWorkRepository = RootContainer.Container.Resolve<IGenericRepository<ProductWork>>();
        }

        public void CreateProduct(Product item)
        {
            _productRepository.Create(item);
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

        public void CreateUnit(Unit item)
        {
            _unitRepository.Create(item);
        }

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            if (showIsDelete)
            {
                return _unitRepository.Get();
            }
            else
            {
                return _unitRepository.Get().Where(x => x.IsDelete == null || x.IsDelete == false);
            }
        }

        public void CreateProvider(Provider item)
        {
            _providerRepository.Create(item);
        }

        public IEnumerable<Provider> GetProviders(bool showIsDelete = false)
        {
            if (showIsDelete)
            {
                return _providerRepository.Get();
            }
            else
            {
                return _providerRepository.Get().Where(x => x.IsDelete == null || x.IsDelete == false);
            }
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

        public void DeleteUnit(Unit item)
        {
            var relatives = _productRepository.Get(x => x.UnitId == item.Id);
            if (relatives.Any())
            {
                item.IsDelete = true;
                UpdateUnit(item);
            }
            else
            {
                _unitRepository.Remove(item);
            }
        }

        public void DeleteProvider(Provider item)
        {
            var relatives = _purchaseInvoiceRepository.Get(x => x.ProviderId == item.Id);
            if (relatives.Any())
            {
                item.IsDelete = true;
                UpdateProvider(item);
            }
            else
            {
                _providerRepository.Remove(item);
            }
        }

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return _purchaseInvoiceRepository.GetWithInclude(x => x.Products, invoice => invoice.Provider);
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return _invoiceRepository.GetWithInclude(x => x.Products);
        }

        public IEnumerable<Inventory> GetInventories()
        {
            return _inventoryRepository.GetWithInclude(x => x.Products);
        }
    }
}
