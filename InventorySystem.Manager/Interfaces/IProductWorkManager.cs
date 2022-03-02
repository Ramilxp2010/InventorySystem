using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IProductWorkManager
    {
        int ProductWorkCreate(ProductWork item);
        string ProductWorkUpdate(ProductWork item);
        IEnumerable<ProductWork> GetProductByInventory(Inventory item);
        IEnumerable<ProductWork> GetProductByInvoice(Invoice item);
        IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item);
    }
}
