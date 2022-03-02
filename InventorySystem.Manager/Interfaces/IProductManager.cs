using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IProductManager
    {
        int CreateProduct(Product item);
        IEnumerable<Product> GetProducts(bool showIsDelete = false);
        string UpdateProduct(Product item);
        string DeleteProduct(Product item);
    }
}
