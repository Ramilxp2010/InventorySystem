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
using InventorySystem.Contract;

namespace InventorySystem
{
    public partial class UnitForm : Form
    {
        GuideManager _guideManager = new GuideManager();
        private IEnumerable<Unit> _units;

        public UnitForm()
        {
            InitializeComponent();
            ShowProviders();
        }

        private void ShowProviders()
        {
            dgv_Units.Rows.Clear();
            _units = _guideManager.GetUnits();
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
            ShowProviders();
        }

        private void btn_Updater_Click(object sender, EventArgs e)
        {
            var seletedItem = dgv_Units.CurrentRow.Tag as Unit;
            if (seletedItem != null)
            {
                new AddUnitForm(seletedItem).ShowDialog();
                ShowProviders();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var seletedItem = dgv_Units.CurrentRow.Tag as Provider;
            if (seletedItem != null)
            {
                //_guideManager.DeleteProduct(seletedItem);
                //ShowProducts();
                MessageBox.Show("Эта функциональность не реализована!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
