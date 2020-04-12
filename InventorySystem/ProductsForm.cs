using InventorySystem.Contract;
using InventorySystem.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class ProductsForm : Form
    {
        GuideManager _guideManager = new GuideManager();
        private IEnumerable<Product> _products;

        public ProductsForm()
        {
            InitializeComponent();
            ShowProducts();
        }
        
        private void ShowProducts()
        {
            dgv_Products.Rows.Clear();
            _products = _guideManager.GetProducts();
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
            var seletedItem = dgv_Products.CurrentRow.Tag as Product;
            if (seletedItem != null)
            {
                new AddNewProductForm(seletedItem).ShowDialog();
                ShowProducts();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var seletedItem = dgv_Products.CurrentRow.Tag as Product;
            if (seletedItem != null)
            {
                //_guideManager.DeleteProduct(seletedItem);
                //ShowProducts();
                MessageBox.Show("Эта функциональность не реализована!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
