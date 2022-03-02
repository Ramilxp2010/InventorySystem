using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IWarehouseProductManager
    {
        List<WarehouseProduct> GetWarehouseProducts();
    }
}
