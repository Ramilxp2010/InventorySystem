using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IProductManager
    {
        int CreateProduct(Product item);
        void UpdateProduct(Product item);
        void DeleteProduct(Product item);
        IEnumerable<Product> GetProducts(bool showIsDelete = false);
    }
}
