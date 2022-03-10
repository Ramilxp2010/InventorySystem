using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IWarehouseProductManager
    {
        IEnumerable<WarehouseProduct> GetWarehouseProducts();
        IEnumerable<WarehouseProduct> Search(string text);
    }
}
