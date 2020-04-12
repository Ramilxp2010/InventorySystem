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
    public partial class AddNewProductForm : Form
    {
        private Product _product;

        GuideManager _guideManager = new GuideManager();
        
        private BindingSource bs_Units;
        private IEnumerable<Unit> _units;

        public AddNewProductForm(Product product)
        {
            _product = product;
            InitializeComponent();
            LoadComponents();
            SetFields(_product);
        }

        public AddNewProductForm()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            bs_Units = new BindingSource();
            _units = _guideManager.GetUnits();

            bs_Units.DataSource = _units;
            cmb_Unit.DataSource = bs_Units;
            cmb_Unit.DisplayMember = "Name";
            cmb_Unit.ValueMember = "Id";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var product = _product ?? new Product();
                if (product != null)
                {
                    product.UnitId = (cmb_Unit.SelectedItem as Unit).Id;
                    product.Unit = null;
                    product.Name = tb_ProductName.Text;
                    product.Article = tb_Articul.Text;
                    product.Code = tb_Code.Text;
                    product.Description = tb_Description.Text;
                }

                if (_product == null)
                {
                    _guideManager.CreateProduct(product);
                    MessageBox.Show("Продукт добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _guideManager.UpdateProduct(product);
                    MessageBox.Show("Продукт обновлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                this.Close();
            }
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_ProductName.Text))
            {
                ErrorProvider.SetError(tb_ProductName, "Поле не может быть пустым");
                result = false;
            }

            if (cmb_Unit.SelectedItem == null)
            {
                ErrorProvider.SetError(cmb_Unit, "Поле не может быть пустым");
                result = false;
            }

            return result;
        }

        private void Clear()
        {
            tb_ProductName.Clear();
            tb_Articul.Clear();
            tb_Code.Clear();
            tb_Description.Clear();
        }

        public void SetFields(Product prod)
        {
            tb_ProductName.Text = prod.Name;
            tb_Articul.Text = prod.Article;
            tb_Code.Text = prod.Code;
            tb_Description.Text = prod.Description;
            cmb_Unit.SelectedItem = prod.Unit;
        }
    }
}
