using InventorySystem.Contract;
using InventorySystem.Core;
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
using Unity;

namespace InventorySystem
{
    public partial class InvoiceForm : Form
    {

        private WarehouseForm _warehouse;
        private BindingSource bs_Products;
        private List<WarehouseProduct> _products;

        public InvoiceForm()
        {
            InitializeComponent();
            _warehouse = RootContainer.Container.Resolve<WarehouseForm>();
            bs_Products = new BindingSource();

            _products = ApiManager.GetWarehouseProducts().ToList();
            SetWareHouse(_products);

            dgv_Warehouse.DataSource = bs_Products;
            dgv_Warehouse.Columns[0].HeaderText = "НАЗВАНИЕ";
            dgv_Warehouse.Columns[1].HeaderText = "КОД";
            dgv_Warehouse.Columns[2].HeaderText = "КОЛИЧЕСТВО НА СКЛАДЕ";
            dgv_Warehouse.Columns[3].HeaderText = "ЕД. ИЗМ";
            dgv_Warehouse.Columns[4].Visible = false;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Count.Text))
            {
                ErrorProvider.SetError(tb_Count, "Поле не может быть пустым");
                return;
            }

            var selectedProduct = dgv_Warehouse.CurrentRow.Cells[4].Value;
            if (selectedProduct is Product)
            {
                var product = selectedProduct as Product;
                var warehouseProduct = _products.FirstOrDefault(x => x.Product.Id == product.Id);
                var selectedCount = decimal.Parse(tb_Count.Text);
                if (warehouseProduct.Count >= selectedCount)
                {
                    AddProduct(product, selectedCount);
                    warehouseProduct.Count = warehouseProduct.Count - selectedCount;
                    tb_Searh_TextChanged(null, null);
                }
                else
                {
                    MessageBox.Show($"Необходимого количества нет на складе. На складе - {warehouseProduct.Count}, требуется - {selectedCount}", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void AddProduct(Product product, decimal count, Unit unit = null)
        {
            dgv_Products.Rows.Add();
            var index = dgv_Products.Rows.Count - 1;
            dgv_Products.Rows[index].Cells[0].Value = product.Name;

            dgv_Products.Rows[index].Cells[1].Value = count;
            if (unit != null)
            {
                dgv_Products.Rows[index].Cells[2].Value = unit.Name;
            }
            else
            {
                dgv_Products.Rows[index].Cells[2].Value = product.Unit.Name;
            }

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

                var invoiceId = ApiManager.InvoiceCreate(invoice);
                if (invoiceId == -1)
                {
                    MessageBox.Show("Ну удалось добавить запись, обратись к системному администратору",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                foreach (DataGridViewRow row in dgv_Products.Rows)
                {
                    var prod = row.Tag as Product;
                    var product = new ProductWork()
                    {
                        ProductId = prod.Id,
                        Count = decimal.Parse(row.Cells[1].Value.ToString()),
                        InvoiceId = invoiceId,
                        Cost = 0
                    };
                    ApiManager.ProductWorkCreate(product);
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
        
        private void SetWareHouse(List<WarehouseProduct> products)
        {
            List<ProductViewModel> productView = products.Select(x =>
                new ProductViewModel
                {
                    Name = x.Product.Name,
                    Code = x.Product.Code,
                    Count = x.Count,
                    Unit = x.Product.Unit.Name,
                    Product = x.Product
                }).ToList();

            bs_Products.DataSource = productView;
        }

        private void tb_Searh_TextChanged(object sender, EventArgs e)
        {
            if (tb_Searh.Text.Length > 3)
            {
                var products = _products.Where(x => x.Product.Name.ToLowerInvariant().Contains(tb_Searh.Text.ToLowerInvariant())).ToList();
                SetWareHouse(products);
            }

            if (tb_Searh.Text.Length == 0)
            {
                SetWareHouse(_products);
            }
        }

        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Int32 selectedRowCount = dgv_Products.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        var product = dgv_Products.SelectedRows[0].Tag as Product;
                        var warehouseProduct = _products.FirstOrDefault(x => x.Product.Id == product.Id);
                        var count = Decimal.Parse(dgv_Products.SelectedRows[0].Cells[1].Value.ToString());
                        warehouseProduct.Count = warehouseProduct.Count + count;
                        tb_Searh_TextChanged(null, null);
                        dgv_Products.Rows.RemoveAt(dgv_Products.SelectedRows[0].Index);
                    }
                }
            }
        }

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Count { get; set; }
        public string Unit { get; set; }
        public Product Product { get; set; }
    }
}
