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

namespace InventorySystem.Manager
{
    public class InventoryManager : IInventoryManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private IGenericRepository<Inventory> _inventoryRepository;

        public InventoryManager()
        {
            _inventoryRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Inventory>>();
        }

        public int InventoryCreate(Inventory item)
        {
            return _inventoryRepository.Create(item).Id;
        }

        public void InventoryUpdate(Inventory item)
        {
            _inventoryRepository.Update(item);
        }

        public IEnumerable<Inventory> GetInventories()
        {
            return _inventoryRepository.Get();
        }

        public IEnumerable<Inventory> GetInventoriesWithProducts()
        {
            return _inventoryRepository.GetWithInclude(x => x.Products);
        }
    }
}
