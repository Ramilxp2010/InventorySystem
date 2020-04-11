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
using InventorySystem.Core;
using InventorySystem.Manager;
using Unity;

namespace InventorySystem
{
    public partial class WarehouseForm : Form
    {
        List<WarehouseProduct> _products = new List<WarehouseProduct>();
        InventorySystemEngine _engine = new InventorySystemEngine();
        
        public WarehouseForm()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            _products = _engine.GetWarehouseProducts();
            foreach (var product in _products)
            {
                dgv_products.Rows.Add();
                var index = dgv_products.Rows.Count - 1;
                dgv_products.Rows[index].Cells[0].Value = product.Product.Name;
                dgv_products.Rows[index].Cells[1].Value = product.Count;
                dgv_products.Rows[index].Cells[2].Value = product.Product.Unit.Name;
                dgv_products.Rows[index].Cells[3].Value = product.Product.Code;
                dgv_products.Rows[index].Tag = product;
            }
        }

        private void btn_Purshase_Click(object sender, EventArgs e)
        {
            new PurshaseForm().Show();
        }

        private void Warehouse_Enter(object sender, EventArgs e)
        {
            LoadComponents();
        }

        private void brn_Invoice_Click(object sender, EventArgs e)
        {
            new InvoiceForm().Show();
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            new InventoryForm().Show();
        }

        private void btn_CheckPurshases_Click(object sender, EventArgs e)
        {
            new AllInvoicesForm().Show();
        }
    }
}
