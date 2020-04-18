using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Article { get; set; }

        public string Description { get; set; }

        public int UnitId { get; set; }

        public Unit Unit { get; set; }

        public bool? IsDelete { get; set; }
    }
}
