﻿using System;
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
using InventorySystem.Manager;
using Unity;

namespace InventorySystem
{
    public partial class Warehouse : Form
    {
        List<WarehouseProduct> _products = new List<WarehouseProduct>();
        InventorySystemEngine _engine = new InventorySystemEngine();
        
        public Warehouse()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            BindingSource bs = new BindingSource();

            _products = _engine.GetWarehouseProducts();
            bs.DataSource = _products.Select(x =>
                new
                {
                    ProductName = x.Product.Name,
                    Article = x.Product.Article,
                    Count = x.Count,
                    Unit = x.Product.Unit.Name
                });

            dgv_products.DataSource = bs;
        }

        private void btn_Purshase_Click(object sender, EventArgs e)
        {
            var purchaseFrom = RootContainer.Container.Resolve<Purshase>();
            purchaseFrom.Show();

           // this.Visible = false;
        }

        private void Warehouse_Enter(object sender, EventArgs e)
        {
            LoadComponents();
        }
        
    }
}
