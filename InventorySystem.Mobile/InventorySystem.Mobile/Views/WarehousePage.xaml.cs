using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InventorySystem.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WarehousePage : ContentPage
    {
        private WarehouseViewModel viewModel;
        public WarehousePage ()
        {
            BindingContext = viewModel = new WarehouseViewModel();
            InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.WarehouseItems.Count == 0)
                viewModel.LoadWarehouseItemsCommand.Execute(null);
        }
    }
}