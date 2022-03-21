using InventorySystemClient.Commands;
using InventorySystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class PopupWindowViewModel : BaseViewModel
    {
        private InvoiceAddItemViewModel _invoiceViewModel;

        public PopupWindowViewModel(InvoiceAddItemViewModel viewModel, object itemModel, RelayCommand command)
        {
            _invoiceViewModel = viewModel;
            var item = (WarehouseItemModel)itemModel;
            PopupCommand = command;
            _invoiceViewModel.SelectedWarehouseItem = item;
            _count = item.ProductCount;
        }

        private decimal _count;
        public string Count
        {
            get { return _count.ToString(); }
            set
            {
                _count = decimal.Parse(value);
                OnPropertyChanged("Count");
            }
        }

        public RelayCommand PopupCommand { get; }
    }


}
