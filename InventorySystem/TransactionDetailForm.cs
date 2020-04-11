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
    public partial class TransactionDetailForm : Form
    {
        PurchaseInvoiceManager _purchaseManager = new PurchaseInvoiceManager();
        
        private IEnumerable<ProductWork> _products;

        public TransactionDetailForm(object transaction)
        {
            InitializeComponent();
            HandleTransaction(transaction);
        }

        private void TransactionDetailForm_Load(object sender, EventArgs e)
        {

        }

        public void HandleTransaction(object selectedItem)
        {
            if (selectedItem is PurchaseInvoice)
            {
                var purchaseInvoice = selectedItem as PurchaseInvoice;
                HandlePurchaseInvoice(purchaseInvoice);
            }
            else if (selectedItem is Invoice)
            {
                var invoice = selectedItem as Invoice;
                HandleInvoice(invoice);
            }
            else if (selectedItem is Inventory)
            {
                var inventory = selectedItem as Inventory;
                HandleInventory(inventory);
            }
        }

        private void HandlePurchaseInvoice(PurchaseInvoice invoice)
        {
            _products = _purchaseManager.GetProductByPurchaseInvoice(invoice);
            SetFields(invoice.Number, invoice.Provider.Name, invoice.Date);
            label7.Text = "Поставщик ";
            this.Text = $"Приходная накладная, №{invoice.Number}";
        }

        private void HandleInvoice(Invoice invoice)
        {
            _products = _purchaseManager.GetProductByInvoice(invoice);
            SetFields(invoice.Number, invoice.ResponsibleName, invoice.Date, invoice.Goal);
            this.Text = $"Накладная, №{invoice.Number}";
        }

        private void HandleInventory(Inventory inventory)
        {
            _products = _purchaseManager.GetProductByInventory(inventory);
            SetFields(inventory.Number, inventory.ResponsibleName, inventory.Date);
            label7.Text = "Ответственный ";
            this.Text = $"Инвентаризация, №{inventory.Number}";
        }

        private void SetFields(string number, string responsibleName, DateTime date, string goal = null)
        {
            tb_InvoiceNumber.Text = number;
            tb_ResponsibleName.Text = responsibleName;
            dateTimePicker1.Value = date;
            tb_Goal.Text = goal;
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            foreach (var product in _products)
            {
                dgv_products.Rows.Add();
                var index = dgv_products.Rows.Count - 1;
                dgv_products.Rows[index].Cells[0].Value = product.Product.Name;
                dgv_products.Rows[index].Cells[1].Value = product.Count;
                dgv_products.Rows[index].Cells[2].Value = product.Product.Unit.Name;
                dgv_products.Rows[index].Cells[3].Value = product.Product.Code;
                dgv_products.Rows[index].Tag = product;
            }
        }
    }
}
