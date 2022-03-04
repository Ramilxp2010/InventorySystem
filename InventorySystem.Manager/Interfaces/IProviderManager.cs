using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IProviderManager
    {
        int CreateProvider(Provider item);
        IEnumerable<Provider> GetProviders(bool showIsDelete = false);
        void UpdateProvider(Provider item);
        void DeleteProvider(Provider item);

    }
}
