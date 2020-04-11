using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class Inventory
    {
        public Inventory()
        {
            Products = new List<ProductWork>();
        }

        public int Id { get; set; }

        public string Number { get; set; }

        public string ResponsibleName { get; set; }

        public DateTime Date { get; set; }

        public ICollection<ProductWork> Products { get; set; }
    }
}
