﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public class Invoice
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }
        
        public List<ProductWork> Products { get; set; }
    }
}
