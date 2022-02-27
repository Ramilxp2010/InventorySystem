using InventorySystemClient.Models;
using InventorySystemClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class InvoiceViewModel : BaseViewModel
    {
        private Frame _mainFrame;
        public Frame MainFrame
        {
            get => _mainFrame;
            set
            {
                _mainFrame = value;
                OnPropertyChanged("MainFrame");
            }
        }

        private PurshaseItemModel _selectedItem;
        public PurshaseItemModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ObservableCollection<PurshaseItemModel> Items { get; set; }

        public InvoiceViewModel(Frame mainFrame)
        {
            _mainFrame = mainFrame;
            Items = new ObservableCollection<PurshaseItemModel>
            {
                 new PurshaseItemModel
                 {
                     ProductName = "Product 1",
                     ProductCount = 1,
                     ProductCode = "1010",
                     ProductMeasure = "kg"

                 },
                 new PurshaseItemModel
                 {
                     ProductName = "Product 10",
                     ProductCount = 10,
                     ProductCode = "1010",
                     ProductMeasure = "kg"
                 },
                 new PurshaseItemModel
                 {
                     ProductName = "Product 20",
                     ProductCount = 20,
                     ProductCode = "1010",
                     ProductMeasure = "kg"
                 },
                 new PurshaseItemModel
                 {
                     ProductName = "Product 100",
                     ProductCount = 100,
                     ProductCode = "1010",
                     ProductMeasure = "kg"
                 }
            };
        }
    }
}
