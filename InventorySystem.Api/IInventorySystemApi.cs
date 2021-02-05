using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Api
{
    public interface IInventorySystemApi
    {
        bool CheckServer();
        int CreateProduct(Product item);
        int CreateProvider(Provider item);
        int CreateUnit(Unit item);
        string DeleteProduct(Product item);
        string DeleteProvider(Provider item);
        string DeleteUnit(Unit item);
        List<Inventory> GetInventories();
        IEnumerable<Invoice> GetInvoices();
        IEnumerable<ProductWork> GetProductByInventory(Inventory item);
        IEnumerable<ProductWork> GetProductByInvoice(Invoice item);
        IEnumerable<ProductWork> GetProductByPurchaseInvoice(PurchaseInvoice item);
        IEnumerable<Product> GetProducts(bool showIsDelete = false);
        IEnumerable<Provider> GetProviders(bool showIsDelete = false);
        IEnumerable<PurchaseInvoice> GetPurchaseInvoices();
        IEnumerable<Unit> GetUnits(bool showIsDelete = false);
        List<WarehouseProduct> GetWarehouseProducts();
        int InventoryCreate(Inventory item);
        string InventoryUpdate(Inventory item);
        int InvoiceCreate(Invoice item);
        string InvoiceUpdate(Invoice item);
        int ProductWorkCreate(ProductWork item);
        string ProductWorkUpdate(ProductWork item);
        int PurchaseInvoiceCreate(PurchaseInvoice item);
        string PurchaseInvoiceUpdate(PurchaseInvoice item);
        string UpdateProduct(Product item);
        string UpdateProvider(Provider item);
        string UpdateUnit(Unit item);
    }
}