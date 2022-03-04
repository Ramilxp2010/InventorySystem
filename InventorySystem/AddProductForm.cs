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
using InventorySystem.Api;
using InventorySystem.Manager.Interfaces;

namespace InventorySystem
{
    public partial class AddProductForm : Form
    {

        private IEnumerable<Unit> _units;
        private BindingSource bs_Units;

        public AddProductForm()
        {
            InitializeComponent();
            bs_Units = new BindingSource();
            _units = RootContainer.Instance.Container.Resolve<IUnitManager>().GetUnits();
            bs_Units.DataSource = _units;

            cmb_Unit.DataSource = bs_Units;
            cmb_Unit.DisplayMember = "Name";
            cmb_Unit.ValueMember = "Id";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var unit = cmb_Unit.SelectedItem as Unit;
                var count = decimal.Parse(tb_Count.Text);
                var product = new Product()
                {
                    Name = tb_ProductName.Text,
                    Article = tb_Articul.Text,
                    Code = tb_Count.Text,
                    Description = tb_Description.Text,
                    UnitId = unit.Id
                };
                RootContainer.Instance.Container.Resolve<IProductManager>().CreateProduct(product);
                
                var purshase = RootContainer.Instance.Container.Resolve<IInvoice>();
                purshase.AddProduct(product, count, unit);

                ClearAll();
            }
        }

        private void ClearAll()
        {
            tb_ProductName.Clear();
            tb_Count.Clear();
            tb_Articul.Clear();
            tb_Code.Clear();
            tb_Description.Clear();
            cmb_Unit.SelectedItem = null;
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_ProductName.Text))
            {
                ErrorProvider.SetError(tb_ProductName, "Поле не может быть пустым");
                result = false;
            }

            if (string.IsNullOrEmpty(tb_Count.Text))
            {
                ErrorProvider.SetError(tb_Count, "Поле не может быть пустым");
                result = false;
            }

            if (cmb_Unit.SelectedItem == null)
            {
                ErrorProvider.SetError(cmb_Unit, "Поле не может быть пустым");
                result = false;
            }
            
            return result;
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

    }
}
