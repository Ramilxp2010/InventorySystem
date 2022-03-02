using InventorySystem.Contract;
using InventorySystem.Manager.Interfaces;
using System.Collections.Generic;

namespace InventorySystem.Api
{
    public interface IInventorySystemApi : IProductManager, IProviderManager, IInventoryManager, IUnitManager, IProductWorkManager, IInvoiceManager, IPurchaseInvoiceManager, IWarehouseProductManager
    {
        bool CheckServer();
    }
}