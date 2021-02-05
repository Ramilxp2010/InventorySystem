using InventorySystem.Api;
using InventorySystem.Contract;
using InventorySystem.Core;
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
    public partial class AddUnitForm : Form
    {
        private Unit _unit;
        public AddUnitForm(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            SetFields(unit);
        }
        public AddUnitForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var unit = _unit ?? new Unit();
                if (unit != null)
                {
                    unit.Name = tb_UnitName.Text;
                }

                if (_unit == null)
                {
                    RootContainer.Container.Resolve<IInventorySystemApi>().CreateUnit(unit);
                    MessageBox.Show("Ед.изм добавлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RootContainer.Container.Resolve<IInventorySystemApi>().UpdateUnit(unit);
                    MessageBox.Show("Ед.изм обновлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_UnitName.Text))
            {
                ErrorProvider.SetError(tb_UnitName, "Поле не может быть пустым");
                result = false;
            }

            return result;
        }

        private void Clear()
        {
            tb_UnitName.Clear();
        }

        public void SetFields(Unit unit)
        {
            tb_UnitName.Text = unit.Name;
        }
    }
}
