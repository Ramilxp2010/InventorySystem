using InventorySystem.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public interface IInvoice
    {
        void AddProduct(Product product, decimal count, Unit unit = null);
    }
}
