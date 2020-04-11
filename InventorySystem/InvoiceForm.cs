using InventorySystem.Contract;
using InventorySystem.Core;
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
using Unity;

namespace InventorySystem
{
    public partial class InvoiceForm : Form
    {
        GuideManager _guideManager = new GuideManager();
        PurchaseInvoiceManager _purchaseManager = new PurchaseInvoiceManager();
        InventorySystemEngine _engine = new InventorySystemEngine();

        private WarehouseForm _warehouse;
        private BindingSource bs_Products;
        private List<WarehouseProduct> _products;

        public InvoiceForm()
        {
            InitializeComponent();
            _warehouse = RootContainer.Container.Resolve<WarehouseForm>();

            bs_Products = new BindingSource();
            _products = _engine.GetWarehouseProducts();
            bs_Products.DataSource = _products.Select(x =>
                new
                {
                    PN = x.Product.Name,
                    Cd = x.Product.Code,
                    Ct = x.Count,
                    Un = x.Product.Unit.Name
                });

            dgv_Products.DataSource = bs_Products;

            //SetWareHouse();
        }
        
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Count.Text))
            {
                ErrorProvider.SetError(tb_Count, "Поле не может быть пустым");
                return;
            }

            if (dgv_Warehouse.CurrentRow.Tag is ProductWork)
            {
                AddProduct(dgv_Warehouse.CurrentRow.Tag as ProductWork, decimal.Parse(tb_Count.Text));
            }
        }

        public void AddProduct(ProductWork product, decimal count, Unit unit = null)
        {
            dgv_Products.Rows.Add();
            var index = dgv_Products.Rows.Count - 1;
            dgv_Products.Rows[index].Cells[0].Value = product.Product.Name;

            if (unit != null)
            {
                dgv_Products.Rows[index].Cells[1].Value = unit.Name;
            }
            else
            {
                dgv_Products.Rows[index].Cells[1].Value = product.Product.Unit.Name;
            }

            dgv_Products.Rows[index].Cells[2].Value = count;
            dgv_Products.Rows[index].Tag = product;

            tb_Count.Clear();
        }
    
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var invoice = new Invoice()
                {
                    ResponsibleName = tb_ResponsibleName.Text,
                    Goal = tb_Goal.Text,
                    OrganizationName = tb_OrgName.Text,
                    Date = dateTimePicker1.Value,
                    Number = tb_InvoiceNumber.Text
                };

                foreach (DataGridViewRow row in dgv_Products.Rows)
                {
                    var prod = row.Tag as Product;
                    var product = new ProductWork()
                    {
                        ProductId = prod.Id,
                        Count = decimal.Parse(row.Cells[2].Value.ToString()),
                        Invoice = invoice,
                        Cost = 0
                    };
                    _purchaseManager.ProductWorkCreate(product);
                }

                var result = MessageBox.Show("Накладная добавлена! Добавить новую накладную?",
                    "Успех!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.No)
                {
                    _warehouse.Visible = true;

                    this.Close();
                }
                else
                {
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
            tb_Count.Clear();
            tb_Goal.Clear();
            tb_InvoiceNumber.Clear();
            dgv_Products.Rows.Clear();
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_InvoiceNumber.Text))
            {
                ErrorProvider.SetError(tb_InvoiceNumber, "Поле не может быть пустым");
                result = false;
            }

            if (string.IsNullOrEmpty(tb_ResponsibleName.Text))
            {
                ErrorProvider.SetError(tb_ResponsibleName, "Поле не может быть пустым");
                result = false;
            }

            if (string.IsNullOrEmpty(tb_Goal.Text))
            {
                ErrorProvider.SetError(tb_Goal, "Поле не может быть пустым");
                result = false;
            }

            if (dgv_Products.Rows.Count == 0)
            {
                ErrorProvider.SetError(panel3, "Добавьте хотя бы один товар");
                result = false;
            }

            return result;
        }
        
        private void SetWareHouse()
        {
            foreach (var product in _products)
            {
                dgv_Warehouse.Rows.Add();
                var index = dgv_Warehouse.Rows.Count - 1;
                dgv_Warehouse.Rows[index].Cells[0].Value = product.Product.Name;
                dgv_Warehouse.Rows[index].Cells[1].Value = product.Product.Code;
                dgv_Warehouse.Rows[index].Cells[2].Value = product.Count; 
                dgv_Warehouse.Rows[index].Cells[3].Value = product.Product.Unit.Name;
                dgv_Warehouse.Rows[index].Tag = product;
            }
        }

        private void tb_Searh_TextChanged(object sender, EventArgs e)
        {
            if (tb_Searh.Text.Length > 4)
            {
                _products = _products.Where(x => x.Product.Name.Contains(tb_Searh.Text)).ToList();
                SetWareHouse();
                dgv_Warehouse.Update();
            }

        }
    }
}
