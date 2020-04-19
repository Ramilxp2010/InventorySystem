using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class Provider
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool? IsDelete { get; set; }
    }
}
