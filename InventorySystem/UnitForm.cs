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

namespace InventorySystem
{
    public partial class UnitForm : Form
    {
        private IEnumerable<Unit> _units;

        public UnitForm()
        {
            InitializeComponent();
            ShowUnits();
        }

        private void ShowUnits()
        {
            dgv_Units.Rows.Clear();
            _units = InventorySystemApi.GetUnits();
            foreach (var unit in _units)
            {
                AddNewUnit(unit);
            }
        }

        private void AddNewUnit(Unit unit)
        {
            dgv_Units.Rows.Add();
            var index = dgv_Units.Rows.Count - 1;
            dgv_Units.Rows[index].Cells[0].Value = unit.Name;
            dgv_Units.Rows[index].Tag = unit;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new AddUnitForm().ShowDialog();
            ShowUnits();
        }

        private void btn_Updater_Click(object sender, EventArgs e)
        {
            if (dgv_Units.CurrentRow == null)
            {
                return;
            }

            var seletedItem = dgv_Units.CurrentRow.Tag as Unit;
            if (seletedItem != null)
            {
                new AddUnitForm(seletedItem).ShowDialog();
                ShowUnits();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Units.CurrentRow == null)
            {
                return;
            }

            var seletedItem = dgv_Units.CurrentRow.Tag as Unit;
            if (seletedItem != null)
            {
                InventorySystemApi.DeleteUnit(seletedItem);
                ShowUnits();
                MessageBox.Show("Удалено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
