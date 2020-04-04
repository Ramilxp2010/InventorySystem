using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class Warehouse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public Unit Unit { get; set; }

        public decimal Count { get; set; }

        public PurchaseInvoice PurchaseInvoice { get; set; }
    }
}
