using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IProductWorkManager
    {
        int ProductWorkCreate(ProductWork item);
        void ProductWorkUpdate(ProductWork item);
        IEnumerable<ProductWork> GetProductByInventory(Inventory item);
        IEnumerable<ProductWork> GetProductByInvoice(Invoice item);
        IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item);
        IEnumerable<ProductWork> GetProductByInventory(int id);
        IEnumerable<ProductWork> GetProductByInvoice(int id);
        IEnumerable<ProductWork> GetProductByPurchaseInvoice(int id);
    }
}
