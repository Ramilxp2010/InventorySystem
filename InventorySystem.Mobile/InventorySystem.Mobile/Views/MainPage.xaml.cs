using InventorySystem.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InventorySystem.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Warehouse, new NavigationPage(new WarehousePage()));
            MenuPages.Add((int)MenuItemType.About, new NavigationPage(new AboutPage()));
        }

        public async Task NavigateFromMenu(int id)
        {
            //if (!MenuPages.ContainsKey(id))
            //{
            //    switch (id)
            //    {
            //        case (int)MenuItemType.Warehouse:
            //            MenuPages.Add(id, new NavigationPage(new WarehousePage()));
            //            break;
            //        case (int)MenuItemType.Invoice:
            //            MenuPages.Add(id, new NavigationPage(new ItemsPage()));
            //            break;
            //        case (int)MenuItemType.Purchase:
            //            MenuPages.Add(id, new NavigationPage(new PurshasePage()));
            //            break;
            //        case (int)MenuItemType.About:
            //            MenuPages.Add(id, new NavigationPage(new AboutPage()));
            //            break;
            //    }
            //}

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}