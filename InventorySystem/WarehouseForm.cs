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
using InventorySystem.Api;
using Unity;

namespace InventorySystem
{
    public partial class WarehouseForm : Form
    {
        ApiManager _apiManager = new ApiManager();
        private BindingSource bs_Products;
        private List<WarehouseProduct> _products;

        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void LoadComponents(List<WarehouseProduct> products)
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

        private void btn_Purshase_Click(object sender, EventArgs e)
        {
            new PurshaseForm().ShowDialog();
            _products = _apiManager.GetWarehouseProducts().ToList();
            LoadComponents(_products);
        }

        private void Warehouse_Enter(object sender, EventArgs e)
        {
            //LoadComponents();
        }

        private void brn_Invoice_Click(object sender, EventArgs e)
        {
            new InvoiceForm().ShowDialog();
            _products = _apiManager.GetWarehouseProducts().ToList();
            LoadComponents(_products);
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
            _products = _apiManager.GetWarehouseProducts().ToList();
            LoadComponents(_products);
        }

        private void btn_CheckPurshases_Click(object sender, EventArgs e)
        {
            new AllInvoicesForm().Show();
        }

        private void продуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
            _products = _apiManager.GetWarehouseProducts().ToList();
            LoadComponents(_products);
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProvidersForm().ShowDialog();
            _products = _apiManager.GetWarehouseProducts().ToList();
            LoadComponents(_products);
        }

        private void едизмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnitForm().ShowDialog();
            _products = _apiManager.GetWarehouseProducts().ToList();
            LoadComponents(_products);
        }

        private void tb_Searh_TextChanged(object sender, EventArgs e)
        {
            if (tb_Searh.Text.Length > 3)
            {
                var products = _products.Where(x => x.Product.Name.ToLowerInvariant().Contains(tb_Searh.Text.ToLowerInvariant())).ToList();
                LoadComponents(products);
            }

            if (tb_Searh.Text.Length == 0)
            {
                LoadComponents(_products);
            }
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            if (_apiManager.CheckServer())
            {
                bs_Products = new BindingSource();
                _products = _apiManager.GetWarehouseProducts().ToList();
                LoadComponents(_products);

                dgv_products.DataSource = bs_Products;
                dgv_products.Columns[0].HeaderText = "НАЗВАНИЕ";
                dgv_products.Columns[1].HeaderText = "КОД";
                dgv_products.Columns[2].HeaderText = "КОЛИЧЕСТВО НА СКЛАДЕ";
                dgv_products.Columns[3].HeaderText = "ЕД. ИЗМ";
                dgv_products.Columns[4].Visible = false;
            }
            else
            {
                var result = MessageBox.Show("Сервер не доступен, обратись к системному администратору",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
