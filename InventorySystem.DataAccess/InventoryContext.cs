using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InventorySystem.Contract;

namespace InventorySystem.DataAccess
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductWork> ProductWorks { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
