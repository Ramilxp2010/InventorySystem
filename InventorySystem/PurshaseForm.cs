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
using InventorySystem.Contract;
using InventorySystem.Core;
using Unity;
using InventorySystem.Manager.Interfaces;

namespace InventorySystem
{
    public partial class PurshaseForm : Form, IInvoice
    {

        private WarehouseForm _warehouse;
        private BindingSource bs_Products;
        private BindingSource bs_Providers;
        private IEnumerable<Product> _products;
        private IEnumerable<Provider> _providers;

        public PurshaseForm()
        {
            InitializeComponent();

            _warehouse = RootContainer.Instance.Container.Resolve<WarehouseForm>();

            bs_Products = new BindingSource();
            bs_Providers = new BindingSource();
            _products = RootContainer.Instance.Container.Resolve<IProductManager>().GetProducts();
            _providers = RootContainer.Instance.Container.Resolve<IProviderManager>().GetProviders();

            bs_Products.DataSource = _products;
            bs_Providers.DataSource = _providers;
            
            cmb_Products.DataSource = bs_Products;
            cmb_Products.DisplayMember = "Name";
            cmb_Products.ValueMember = "Id";

            cmb_Providers.DataSource = bs_Providers;
            cmb_Providers.DisplayMember = "Name";
            cmb_Providers.ValueMember = "Id";
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Count.Text))
            {
                ErrorProvider.SetError(tb_Count, "Поле не может быть пустым");
                return;
            }

            if (cmb_Products.SelectedItem is Product)
            {
                AddProduct(cmb_Products.SelectedItem as Product, decimal.Parse(tb_Count.Text));
            }
        }

        public void AddProduct(Product product, decimal count, Unit unit = null)
        {
            dgv_Products.Rows.Add();
            var index = dgv_Products.Rows.Count - 1;
            dgv_Products.Rows[index].Cells[0].Value = product.Name;

            if (unit != null)
            {
                dgv_Products.Rows[index].Cells[1].Value = unit.Name;
            }
            else
            {
                dgv_Products.Rows[index].Cells[1].Value = product.Unit.Name;
            }

            dgv_Products.Rows[index].Cells[2].Value = count;
            dgv_Products.Rows[index].Tag = product;
            
            tb_Count.Clear();
            cmb_Products.SelectedItem = null;
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

        private bool _canUpdate = true;
        private bool _needUpdate = false;

        //If text has been changed then start timer
        //If the user doesn't change text while the timer runs then start search
        private void cmb_Products_TextChanged(object sender, EventArgs e)
        {
            if (_needUpdate)
            {
                if (_canUpdate)
                {
                    _canUpdate = false;
                    UpdateData();
                }
                else
                {
                    RestartTimer();
                }
            }
        }

        private void UpdateData()
        {
            if (cmb_Products.Text.Length > 4)
            {
                var products = _products.Where(x => x.Name.Contains(cmb_Products.Text));
                HandleTextChanged(products.ToList());
            }
            else if (cmb_Products.Text.Length == 0)
            {
                HandleTextChanged(_products.ToList());
            }
        }

        //If an item was selected don't start new search
        private void cmb_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needUpdate = false;
        }

        //Update data only when the user (not program) change something
        private void cmb_Products_TextUpdate(object sender, EventArgs e)
        {
            _needUpdate = true;
        }

        //While timer is running don't start search
        //timer1.Interval = 1500;
        private void RestartTimer()
        {
            timer1.Stop();
            _canUpdate = false;
            timer1.Start();
        }

        //Update data when timer stops
        private void timer1_Tick(object sender, EventArgs e)
        {
            _canUpdate = true;
            timer1.Stop();
            UpdateData();
        }

        //Update combobox with new data
        private void HandleTextChanged(List<Product> dataSource)
        {
            var text = cmb_Products.Text;

            if (dataSource.Count() > 0)
            {
                bs_Products.DataSource = dataSource;
                cmb_Products.DataSource = bs_Products;

                var sText = cmb_Products.Items[0].ToString();
                cmb_Products.SelectionStart = text.Length;
                cmb_Products.SelectionLength = sText.Length - text.Length;
                cmb_Products.DroppedDown = true;
                Cursor.Current = Cursors.Default;

                return;
            }
            else
            {
                cmb_Products.DroppedDown = false;
                cmb_Products.SelectionStart = text.Length;
            }
        }

        private void cmb_Products_DataSourceChanged(object sender, EventArgs e)
        {
            var text = cmb_Products.Text;
            var sText = cmb_Products.Text;
            cmb_Products.SelectionStart = text.Length;
            cmb_Products.SelectionLength = sText.Length - text.Length;
            cmb_Products.DroppedDown = false;
            Cursor.Current = Cursors.Default;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var purchaseInvoice = new PurchaseInvoice()
                {
                    ProviderId = (cmb_Providers.SelectedItem as Provider).Id,
                    Date = dateTimePicker1.Value,
                    Number =  tb_PurchaseNumber.Text
                };

                var purchaseInvoiceId = RootContainer.Instance.Container.Resolve<IPurchaseInvoiceManager>().PurchaseInvoiceCreate(purchaseInvoice);
                if (purchaseInvoiceId == -1)
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
                        Count = decimal.Parse(row.Cells[2].Value.ToString()),
                        PurchaseInvoiceId = purchaseInvoiceId,
                        Cost = 0
                    };
                    RootContainer.Instance.Container.Resolve<IProductWorkManager>().ProductWorkCreate(product);
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
                    cmb_Providers.SelectedItem = null;
                    tb_Goal.Clear();
                    tb_PurchaseNumber.Clear();
                    dgv_Products.Rows.Clear();
                }
            }
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_PurchaseNumber.Text))
            {
                ErrorProvider.SetError(tb_PurchaseNumber, "Поле не может быть пустым");
                result = false;
            }

            if (string.IsNullOrEmpty(tb_PurchaseNumber.Text))
            {
                ErrorProvider.SetError(tb_Goal, "Поле не может быть пустым");
                result = false;
            }

            if (string.IsNullOrEmpty(cmb_Providers.Text))
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

        private void Purshase_FormClosed(object sender, FormClosedEventArgs e)
        {
            _warehouse.Visible = true;
        }

        private void btn_AddNewProduct_Click(object sender, EventArgs e)
        {
            RootContainer.Instance.Container.RegisterInstance<IInvoice>(this);
            new AddProductForm().Show();
        }
    }
}
