using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Api;
using InventorySystem.Contract;
using InventorySystem.Core;
using Unity;

namespace InventorySystem
{
    public partial class AddProviderForm : Form
    {
        private Provider _provider;

        public AddProviderForm(Provider provider)
        {
            _provider = provider;
            InitializeComponent();
            SetFields(provider);
        }
        public AddProviderForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var provider = _provider ?? new Provider();
                if (provider != null)
                {
                    provider.Name = tb_ProviderName.Text;
                }

                if (_provider == null)
                {
                    RootContainer.Instance.Container.Resolve<IInventorySystemApi>().CreateProvider(provider);
                    MessageBox.Show("Поставщик добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RootContainer.Instance.Container.Resolve<IInventorySystemApi>().UpdateProvider(provider);
                    MessageBox.Show("Поставщик обновлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }

        private bool IsValid()
        {
            var result = true;

            if (string.IsNullOrEmpty(tb_ProviderName.Text))
            {
                ErrorProvider.SetError(tb_ProviderName, "Поле не может быть пустым");
                result = false;
            }
            
            return result;
        }

        private void Clear()
        {
            tb_ProviderName.Clear();
        }

        public void SetFields(Provider prod)
        {
            tb_ProviderName.Text = prod.Name;
        }
        
    }
}
