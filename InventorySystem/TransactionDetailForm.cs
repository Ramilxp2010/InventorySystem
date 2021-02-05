using InventorySystem.Contract;
using InventorySystem.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Core;
using Unity;

namespace InventorySystem
{
    public partial class TransactionDetailForm : Form
    {
        
        private IEnumerable<ProductWork> _products;
        private Invoice _invoice;

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
                _invoice = invoice;
                btn_Print.Visible = true;
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
            _products = RootContainer.Container.Resolve<IInventorySystemApi>().GetProductByPurchaseInvoice(invoice);
            SetFields(invoice.Number, invoice.Provider.Name, invoice.Date);
            label7.Text = "Поставщик ";
            this.Text = $"Приходная накладная, №{invoice.Number}";
        }

        private void HandleInvoice(Invoice invoice)
        {
            _products = RootContainer.Container.Resolve<IInventorySystemApi>().GetProductByInvoice(invoice);
            SetFields(invoice.Number, invoice.ResponsibleName, invoice.Date, invoice.Goal);
            this.Text = $"Накладная, №{invoice.Number}";
        }

        private void HandleInventory(Inventory inventory)
        {
            _products = RootContainer.Container.Resolve<IInventorySystemApi>().GetProductByInventory(inventory);
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            string fileName = "printTemplate.html";
            string fileProductPart = "productPart.txt";
            var path = Path.GetDirectoryName(Application.ExecutablePath);

            var dictonary = new Dictionary<string, string>();
            dictonary.Add("InvoiceNumber", _invoice.Number);
            dictonary.Add("ResponsibleName", _invoice.ResponsibleName);
            dictonary.Add("InvoiceGoal", _invoice.Goal);
            dictonary.Add("InvoiceDate", _invoice.Date.ToShortDateString());
            
            //string productPart = File.ReadAllText($@"{path}\{fileProductPart}");
            string productPart = Resource.productPart;

            var productTable = new StringBuilder();
            foreach (var product in _products)
            {
                var clone = productPart.Replace("ProductName", product.Product.Name);
                clone = clone.Replace("UnitValue", product.Product.Unit.Name);
                clone = clone.Replace("ProductCount", product.Count.ToString());
                productTable.Append(clone);
            }

            dictonary.Add("AllInvoiceProducts", productTable.ToString());

            //string contents = File.ReadAllText($@"{path}\{fileName}");
            string contents = Resource.printTemplate;
            foreach (var pair in dictonary)
            {
                contents = contents.Replace(pair.Key, pair.Value);
            }

            var newFile = $@"{path}/Накладная_{_invoice.Number}.html";
            var newFilePdf = $@"{path}/Накладная_{_invoice.Number}.pdf";
            var tool = $@"{path}/wkhtmltopdf.exe";
            File.WriteAllText(newFile, contents);
            if (File.Exists(newFile))
            {
                System.Diagnostics.Process.Start(newFile);
                //System.Diagnostics.Process.Start($"{tool} {newFile} {newFilePdf}");
            }
            if (File.Exists(newFilePdf))
            {
                //System.Diagnostics.Process.Start(newFilePdf);
            }
        }
        

    }
}
