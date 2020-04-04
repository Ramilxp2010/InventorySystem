using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Contract;
using InventorySystem.Manager;

namespace InventorySystem
{
    public partial class Warehouse : Form
    {
        List<WarehouseProduct> _products = new List<WarehouseProduct>();
        InventorySystemEngine _engine = new InventorySystemEngine();
        
        public Warehouse()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();

            _products = _engine.GetWarehouseProducts();
            bs.DataSource = _products.Select(x => 
                new
                {
                    ProductName = x.Product.Name,
                    Article = x.Product.Article,
                    Count = x.Count,
                    Unit = x.Product.Unit.Name 
                });

            dgv_products.DataSource = bs;
        }
    }
}
