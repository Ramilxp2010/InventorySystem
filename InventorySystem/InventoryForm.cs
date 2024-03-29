﻿using InventorySystem.Contract;
using InventorySystem.Core;
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
using Unity;
using InventorySystem.Manager.Interfaces;

namespace InventorySystem
{
    public partial class InventoryForm : Form, IInvoice
    {
        private WarehouseForm _warehouse;
        private BindingSource bs_Products;
        private IEnumerable<Product> _products;

        public InventoryForm()
        {
            InitializeComponent();
            _warehouse = RootContainer.Instance.Container.Resolve<WarehouseForm>();

            bs_Products = new BindingSource();
            _products = RootContainer.Instance.Container.Resolve<IProductManager>().GetProducts();

            bs_Products.DataSource = _products;

            if (_products.Any())
            {
                cmb_Products.DataSource = bs_Products;
                cmb_Products.DisplayMember = "Name";
                cmb_Products.ValueMember = "Id";
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Count.Text))
            {
                ErrorProvider.SetError(tb_Count, "Поле не может быть пустым");
                return;
            }

            if (cmb_Products.SelectedItem is Product)
            {
                AddProduct(cmb_Products.SelectedItem as Product, decimal.Parse(tb_Count.Text));
            }
        }

        public void AddProduct(Product product, decimal count, Unit unit = null)
        {
            dgv_Products.Rows.Add();
            var index = dgv_Products.Rows.Count - 1;
            dgv_Products.Rows[index].Cells[0].Value = product.Name;

            if (unit != null)
            {
                dgv_Products.Rows[index].Cells[1].Value = unit.Name;
            }
            else
            {
                dgv_Products.Rows[index].Cells[1].Value = product.Unit.Name;
            }

            dgv_Products.Rows[index].Cells[2].Value = count;
            dgv_Products.Rows[index].Tag = product;

            tb_Count.Clear();
            cmb_Products.SelectedItem = null;
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var inventory = new Inventory()
                {
                    ResponsibleName = tb_ResponsibleName.Text,
                    Date = dateTimePicker1.Value,
                    Number = tb_InvoiceNumber.Text
                };

                var inventoryId = RootContainer.Instance.Container.Resolve<IInventoryManager>().InventoryCreate(inventory);
                if (inventoryId == -1)
                {
                    MessageBox.Show("Ну удалось добавить запись, обратись к системному администратору",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                foreach (DataGridViewRow row in dgv_Products.Rows)
                {
                    var prod = row.Tag as Product;
                    var product = new ProductWork()
                    {
                        ProductId = prod.Id,
                        Count = decimal.Parse(row.Cells[2].Value.ToString()),
                        InventoryId = inventoryId,
                        Cost = 0
                    };
                    RootContainer.Instance.Container.Resolve<IProductWorkManager>().ProductWorkCreate(product);
                }

                var result = MessageBox.Show("Накладная добавлена! Добавить новую накладную?",
                    "Успех!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.No)
                {
                    _warehouse.Visible = true;

                    this.Close();
                }
                else
                {
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
            tb_Count.Clear();
            tb_InvoiceNumber.Clear();
            dgv_Products.Rows.Clear();
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_InvoiceNumber.Text))
            {
                ErrorProvider.SetError(tb_InvoiceNumber, "Поле не может быть пустым");
                result = false;
            }

            if (string.IsNullOrEmpty(tb_ResponsibleName.Text))
            {
                ErrorProvider.SetError(tb_ResponsibleName, "Поле не может быть пустым");
                result = false;
            }
            
            if (dgv_Products.Rows.Count == 0)
            {
                ErrorProvider.SetError(panel3, "Добавьте хотя бы один товар");
                result = false;
            }

            return result;
        }

        private void btn_AddNewProduct_Click(object sender, EventArgs e)
        {
            RootContainer.Instance.Container.RegisterInstance<IInvoice>(this);
            new AddProductForm().Show();
        }
    }
}
