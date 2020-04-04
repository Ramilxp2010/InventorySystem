using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class ProductWork
    {
        public string Id { get; set; }

        public Product Product { get; set; }

        public decimal Count { get; set; }

        public decimal Cost { get; set; }

        public PurchaseInvoice PurchaseInvoice { get; set; }

        public Invoice Invoice { get; set; }
    }
}
