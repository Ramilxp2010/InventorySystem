using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class ProductWork
    {
        public int Id { get; set; }
        
        public decimal Count { get; set; }

        public decimal Cost { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int? PurchaseInvoiceId { get; set; }

        public PurchaseInvoice PurchaseInvoice { get; set; }

        public int? InvoiceId { get; set; }

        public Invoice Invoice { get; set; }
        
        public int? InventoryId { get; set; }

        public Inventory Inventory { get; set; }
    }
}
