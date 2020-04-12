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
            _purchaseInvoices = _guideManager.GetPurchaseInvoices();
            ShowPurchaseInvoices(_purchaseInvoices);
            EnablePurchaseDate(false);

            _invoices = _guideManager.GetInvoices();
            ShowInvoices(_invoices);
            EnableInvoiceDate(false);

            _inventories = _guideManager.GetInventories();
            ShowInventories(_inventories);
            EnableInventoryDate(false);
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

        #region Purchase

        private void ShowPurchaseInvoices(IEnumerable<PurchaseInvoice> purchaseInvoices)
        {
            dgv_PurchaseInvoices.Rows.Clear();
            foreach (var invoice in purchaseInvoices)
            {
                dgv_PurchaseInvoices.Rows.Add();
                var index = dgv_PurchaseInvoices.Rows.Count - 1;
                dgv_PurchaseInvoices.Rows[index].Cells[0].Value = invoice.Date;
                dgv_PurchaseInvoices.Rows[index].Cells[1].Value = invoice.Provider.Name;
                dgv_PurchaseInvoices.Rows[index].Cells[2].Value = invoice.Number;
                dgv_PurchaseInvoices.Rows[index].Tag = invoice;
            }
        }

        private void rbPurchase_CheckedChanged(object sender, EventArgs e)
        {
            var purchaseInvoices = _purchaseInvoices;
            var rb = (RadioButton) sender;
            switch (rb.Name)
            {
                case "rb_dayPurchase":
                    purchaseInvoices = _purchaseInvoices.Where(x => x.Date.Date == DateTime.Now.Date);
                    ShowPurchaseInvoices(purchaseInvoices);
                    EnablePurchaseDate(false);
                    break;
                case "rb_WeekPurchase":
                    var date = DateTime.Now.AddDays(-7);
                    purchaseInvoices = _purchaseInvoices.Where(x => x.Date >= date && x.Date <= DateTime.Now);
                    ShowPurchaseInvoices(purchaseInvoices);
                    EnablePurchaseDate(false);
                    break;
                case "rb_AllPurchase":
                    ShowPurchaseInvoices(_purchaseInvoices);
                    EnablePurchaseDate(false);
                    break;
                case "rb_ChoosePurchase":
                    ShowPurchaseChooseDates();
                    EnablePurchaseDate(true);
                    break;
                default:
                    ShowPurchaseInvoices(_purchaseInvoices);
                    break;

            }
        }

        public void ShowPurchaseChooseDates()
        {
            var date1 = dtp_FromPurchase.Value;
            var date2 = dtp_ToPurchase.Value;
            var purchaseInvoices = _purchaseInvoices.Where(x => x.Date >= date1 && x.Date <= date2);
            ShowPurchaseInvoices(purchaseInvoices);
        }

        private void dtp_FromPurchase_ValueChanged(object sender, EventArgs e)
        {
            if (rb_ChoosePurchase.Checked)
            {
                ShowPurchaseChooseDates();
            }
        }

        private void EnablePurchaseDate(bool value)
        {
            dtp_FromPurchase.Enabled = value;
            dtp_ToPurchase.Enabled = value;
        }

        #endregion Purchase

        #region Invoice

        private void ShowInvoices(IEnumerable<Invoice> invoices)
        {
            dgv_Invoices.Rows.Clear();
            foreach (var invoice in invoices)
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

        private void rbInvoice_CheckedChanged(object sender, EventArgs e)
        {
            var invoices = _invoices;
            var rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "rb_DayInvoice":
                    invoices = _invoices.Where(x => x.Date.Date == DateTime.Now.Date);
                    ShowInvoices(invoices);
                    EnableInvoiceDate(false);
                    break;
                case "rb_WeekInvoice":
                    var date = DateTime.Now.AddDays(-7);
                    invoices = _invoices.Where(x => x.Date >= date && x.Date <= DateTime.Now);
                    ShowInvoices(invoices);
                    EnableInvoiceDate(false);
                    break;
                case "rb_AllInvoice":
                    ShowInvoices(_invoices);
                    EnableInvoiceDate(false);
                    break;
                case "rb_ChooseInvoice":
                    ShowInvoicesChooseDates();
                    EnableInvoiceDate(true);
                    break;
                default:
                    ShowInvoices(_invoices);
                    break;

            }
        }

        public void ShowInvoicesChooseDates()
        {
            var date1 = dtp_FromInvoice.Value;
            var date2 = dtp_ToInvoice.Value;
            var invoices = _invoices.Where(x => x.Date >= date1 && x.Date <= date2);
            ShowInvoices(invoices);
        }

        private void dtp_FromInvoice_ValueChanged(object sender, EventArgs e)
        {
            if (rb_ChooseInvoice.Checked)
            {
                ShowInvoicesChooseDates();
            }
        }

        private void EnableInvoiceDate(bool value)
        {
            dtp_FromInvoice.Enabled = value;
            dtp_ToInvoice.Enabled = value;
        }

        #endregion Invoice

        #region Invoice

        private void ShowInventories(IEnumerable<Inventory> inventories)
        {
            dgv_Inventories.Rows.Clear();
            foreach (var invoice in inventories)
            {
                dgv_Inventories.Rows.Add();
                var index = dgv_Inventories.Rows.Count - 1;
                dgv_Inventories.Rows[index].Cells[0].Value = invoice.Date;
                dgv_Inventories.Rows[index].Cells[1].Value = invoice.ResponsibleName;
                dgv_Inventories.Rows[index].Cells[2].Value = invoice.Number;
                dgv_Inventories.Rows[index].Tag = invoice;
            }
        }

        private void rbInventory_CheckedChanged(object sender, EventArgs e)
        {
            var inventories = _inventories;
            var rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "rb_DayInventory":
                    inventories = _inventories.Where(x => x.Date.Date == DateTime.Now.Date);
                    ShowInventories(inventories);
                    EnableInventoryDate(false);
                    break;
                case "rb_WeekInventory":
                    var date = DateTime.Now.AddDays(-7);
                    inventories = _inventories.Where(x => x.Date >= date && x.Date <= DateTime.Now);
                    ShowInventories(inventories);
                    EnableInventoryDate(false);
                    break;
                case "rb_AllInventory":
                    ShowInventories(_inventories);
                    EnableInventoryDate(false);
                    break;
                case "rb_ChooseInventory":
                    ShowInventoryChooseDates();
                    EnableInventoryDate(true);
                    break;
                default:
                    ShowInventories(_inventories);
                    break;

            }
        }

        public void ShowInventoryChooseDates()
        {
            var date1 = dtp_FromInventory.Value;
            var date2 = dtp_ToInventory.Value;
            var inventories = _inventories.Where(x => x.Date >= date1 && x.Date <= date2);
            ShowInventories(inventories);
        }

        private void dtp_FromInventory_ValueChanged(object sender, EventArgs e)
        {
            if (rb_ChooseInventory.Checked)
            {
                ShowInventoryChooseDates();
            }
        }

        private void EnableInventoryDate(bool value)
        {
            dtp_FromInventory.Enabled = value;
            dtp_ToInventory.Enabled = value;
        }

        #endregion Invoice
    }
}
