using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IInvoiceManager
    {
        int InvoiceCreate(Invoice item);
        void InvoiceUpdate(Invoice item);
        IEnumerable<Invoice> GetInvoices();
        IEnumerable<Invoice> GetInvoicesWithProducts();
    }
}
