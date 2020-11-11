using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using InventorySystem.Api;
using InventorySystem.Contract;
using InventorySystem.Mobile.Models;
using InventorySystem.Mobile.Services;
using Xamarin.Forms;

namespace InventorySystem.Mobile.ViewModels
{
    public class WarehouseViewModel : BaseViewModel
    {
        public WarehouseItemDataSource WarehouseItemStore => new WarehouseItemDataSource(new ApiManager());

        public ObservableCollection<WarehouseItemModel> WarehouseItems;
        public Command LoadWarehouseItemsCommand { get; set; }

        public WarehouseViewModel()
        {
            Title = "Warehouse";
            WarehouseItems = new ObservableCollection<WarehouseItemModel>();
            WarehouseItems.Add(new WarehouseItemModel()
            {
                ProductName = "Tresfdas",
                Count = "123"
            });
            LoadWarehouseItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        
        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                //WarehouseItems.Clear();
                var items = await WarehouseItemStore.GetWarehouseProductsAsync(true);
                foreach (var item in items)
                {
                    WarehouseItems.Add(new WarehouseItemModel
                    {
                        ProductName = item.Product.Name,
                        Count = item.Count.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
