using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using NLog;
using InventorySystem.Manager.Interfaces;

namespace InventorySystem.Manager
{
    public class InvoiceManager : IInvoiceManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private IGenericRepository<Invoice> _invoiceRepository;

        public InvoiceManager()
        {
            _invoiceRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Invoice>>();
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return _invoiceRepository.Get();
        }

        public IEnumerable<Invoice> GetInvoicesWithProducts()
        {
            return _invoiceRepository.GetWithInclude(x => x.Products);
        }

        public int InvoiceCreate(Invoice item)
        {
            return _invoiceRepository.Create(item).Id;
        }

        public void InvoiceUpdate(Invoice item)
        {
            _invoiceRepository.Update(item);
        }

    }
}
