using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InventorySystem.Mobile.ViewModels
{
    public class PurshaseViewModel : BaseViewModel
    {
        public PurshaseViewModel()
        {
            Title = "Purshase";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
