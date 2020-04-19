using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class PurchaseInvoice
    {
        public PurchaseInvoice()
        {
            Products = new List<ProductWork>();
        }

        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public int ProviderId { get; set; }

        public Provider Provider { get; set; }

        public ICollection<ProductWork> Products { get; set; }
    }
}
