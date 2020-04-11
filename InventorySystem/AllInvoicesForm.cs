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
    public partial class AllInvoicesForm : Form
    {
        GuideManager _guideManager = new GuideManager();
        
        private IEnumerable<PurchaseInvoice> _purchaseInvoices;
        private IEnumerable<Invoice> _invoices;
        private IEnumerable<Inventory> _inventories;

        public AllInvoicesForm()
        {
            InitializeComponent();
            ShowPurchaseInvoices();
            ShowInvoices();
            ShowInventories();
        }

        private void ShowPurchaseInvoices()
        {
            _purchaseInvoices = _guideManager.GetPurchaseInvoices();
            foreach (var invoice in _purchaseInvoices)
            {
                dgv_PurchaseInvoices.Rows.Add();
                var index = dgv_PurchaseInvoices.Rows.Count - 1;
                dgv_PurchaseInvoices.Rows[index].Cells[0].Value = invoice.Date;
                dgv_PurchaseInvoices.Rows[index].Cells[1].Value = invoice.Provider.Name;
                dgv_PurchaseInvoices.Rows[index].Cells[2].Value = invoice.Number;
                dgv_PurchaseInvoices.Rows[index].Tag = invoice;
            }
        }
        
        private void ShowInvoices()
        {
            _invoices = _guideManager.GetInvoices();
            foreach (var invoice in _invoices)
            {
                dgv_Invoices.Rows.Add();
                var index = dgv_Invoices.Rows.Count - 1;
                dgv_Invoices.Rows[index].Cells[0].Value = invoice.Date;
                dgv_Invoices.Rows[index].Cells[1].Value = invoice.ResponsibleName;
                dgv_Invoices.Rows[index].Cells[2].Value = invoice.Goal;
                dgv_Invoices.Rows[index].Cells[3].Value = invoice.Number;
                dgv_Invoices.Rows[index].Tag = invoice;
            }
        }
        
        private void ShowInventories()
        {
            _inventories = _guideManager.GetInventories();
            foreach (var invoice in _inventories)
            {
                dgv_Inventories.Rows.Add();
                var index = dgv_Inventories.Rows.Count - 1;
                dgv_Inventories.Rows[index].Cells[0].Value = invoice.Date;
                dgv_Inventories.Rows[index].Cells[1].Value = invoice.ResponsibleName;
                dgv_Inventories.Rows[index].Cells[2].Value = invoice.Number;
                dgv_Inventories.Rows[index].Tag = invoice;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView) sender;
            if (dataGrid == null)
            {
                return;
            }

            var selectedItem = dataGrid.CurrentRow.Tag;
            if (selectedItem != null)
            {
                new TransactionDetailForm(selectedItem).Show();
            }
        }
    }
}
