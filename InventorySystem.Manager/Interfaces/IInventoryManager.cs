using InventorySystem.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Manager.Interfaces
{
    public interface IInventoryManager
    {
        int InventoryCreate(Inventory item);
        void InventoryUpdate(Inventory item);
        List<Inventory> GetInventories();
        List<Inventory> GetInventoriesWithProducts();
    }
}
