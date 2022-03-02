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
using InventorySystem.Api;
using InventorySystem.Core;
using Unity;

namespace InventorySystem
{
    public partial class ProvidersForm : Form
    {
        private IEnumerable<Provider> _providers;

        public ProvidersForm()
        {
            InitializeComponent();
            ShowProviders();
        }

        private void ShowProviders()
        {
            dgv_Providers.Rows.Clear();
            _providers = RootContainer.Instance.Container.Resolve<IInventorySystemApi>().GetProviders();
            foreach (var provider in _providers)
            {
                AddNewProvider(provider);
            }
        }

        private void AddNewProvider(Provider provider)
        {
            dgv_Providers.Rows.Add();
            var index = dgv_Providers.Rows.Count - 1;
            dgv_Providers.Rows[index].Cells[0].Value = provider.Name;
            dgv_Providers.Rows[index].Tag = provider;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new AddProviderForm().ShowDialog();
            ShowProviders();
        }

        private void btn_Updater_Click(object sender, EventArgs e)
        {
            if (dgv_Providers.CurrentRow == null)
            {
                return;
            }

            var seletedItem = dgv_Providers.CurrentRow.Tag as Provider;
            if (seletedItem != null)
            {
                new AddProviderForm(seletedItem).ShowDialog();
                ShowProviders();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Providers.CurrentRow == null)
            {
                return;
            }

            var seletedItem = dgv_Providers.CurrentRow.Tag as Provider;
            if (seletedItem != null)
            {
                RootContainer.Instance.Container.Resolve<IInventorySystemApi>().DeleteProvider(seletedItem);
                ShowProviders();
                MessageBox.Show("Удалено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
