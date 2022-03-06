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

namespace InventorySystem.Manager.Implementations
{
    public class PurchaseInvoiceManager : IPurchaseInvoiceManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private IGenericRepository<PurchaseInvoice> _purchaseRepository;

        public PurchaseInvoiceManager()
        {
            _purchaseRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<PurchaseInvoice>>();
        }

        public int PurchaseInvoiceCreate(PurchaseInvoice item)
        {
            return _purchaseRepository.Create(item).Id;
        }

        public void PurchaseInvoiceUpdate(PurchaseInvoice item)
        {
            _purchaseRepository.Update(item);
        }

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoices()
        {
            return _purchaseRepository.GetWithInclude(invoice => invoice.Provider);
        }

        public IEnumerable<PurchaseInvoice> GetPurchaseInvoicesWithProducts()
        {
            return _purchaseRepository.GetWithInclude(x => x.Products, invoice => invoice.Provider);
        }

    }
}
