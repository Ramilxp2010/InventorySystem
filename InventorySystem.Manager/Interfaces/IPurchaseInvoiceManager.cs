using InventorySystem.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Manager.Interfaces
{
    public interface IPurchaseInvoiceManager
    {
        int PurchaseInvoiceCreate(PurchaseInvoice item);
        string PurchaseInvoiceUpdate(PurchaseInvoice item);
        IEnumerable<PurchaseInvoice> GetPurchaseInvoices();
    }
}
