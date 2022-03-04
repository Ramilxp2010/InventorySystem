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
    public class ProviderManager : IProviderManager
    {
        private IGenericRepository<Provider> _providerRepository;

        public ProviderManager()
        {
            _providerRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Provider>>();
        }

        public int CreateProvider(Provider item)
        {
            return _providerRepository.Create(item).Id;
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

        public void UpdateProvider(Provider item)
        {
            _providerRepository.Update(item);
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

    }
}
