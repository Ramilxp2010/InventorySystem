﻿using InventorySystem.Api;
using InventorySystem.Contract;
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
    public partial class AddUnitForm : Form
    {
        private Unit _unit;
        ApiManager _apiManager = new ApiManager();

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
                    _apiManager.CreateUnit(unit);
                    MessageBox.Show("Ед.изм добавлена!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _apiManager.UpdateUnit(unit);
                    MessageBox.Show("Ед.изм обновлена!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Save_Click_1(object sender, EventArgs e)
        {

        }
    }
}
