using InventorySystem.Contract;
using InventorySystem.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Core;
using Unity;

namespace InventorySystem
{
    public partial class ProductsForm : Form
    {
        private IEnumerable<Product> _products;

        public ProductsForm()
        {
            InitializeComponent();
            ShowProducts();
        }
        
        private void ShowProducts()
        {
            dgv_Products.Rows.Clear();
            _products = RootContainer.Container.Resolve<IInventorySystemApi>().GetProducts();
            foreach (var product in _products)
            {
                AddNewProduct(product);
            }
        }
        
        private void AddNewProduct(Product product)
        {
            dgv_Products.Rows.Add();
            var index = dgv_Products.Rows.Count - 1;
            dgv_Products.Rows[index].Cells[0].Value = product.Name;
            dgv_Products.Rows[index].Cells[1].Value = product.Unit.Name;
            dgv_Products.Rows[index].Cells[1].Tag = product.Unit;
            dgv_Products.Rows[index].Cells[2].Value = product.Code;
            dgv_Products.Rows[index].Tag = product;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new AddNewProductForm().ShowDialog();
            ShowProducts();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Products.CurrentRow == null)
            {
                return;
            }

            var seletedItem = dgv_Products.CurrentRow.Tag as Product;
            if (seletedItem != null)
            {
                new AddNewProductForm(seletedItem).ShowDialog();
                ShowProducts();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Products.CurrentRow == null)
            {
                return;
            }

            var seletedItem = dgv_Products.CurrentRow.Tag as Product;
            if (seletedItem != null)
            {
                RootContainer.Container.Resolve<IInventorySystemApi>().DeleteProduct(seletedItem);
                ShowProducts();
                MessageBox.Show("Удалено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
