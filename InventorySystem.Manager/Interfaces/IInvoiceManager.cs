using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IInvoiceManager
    {
        int InvoiceCreate(Invoice item);
        IEnumerable<Invoice> GetInvoices();
        string InvoiceUpdate(Invoice item);
    }
}
