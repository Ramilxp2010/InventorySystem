using InventorySystemClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class WarehouseViewModel : BaseViewModel
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

        private WarehouseItemModel _selectedWarehouseItem;
        public WarehouseItemModel SelectedWarehouseItem
        {
            get => _selectedWarehouseItem;
            set
            {
                _selectedWarehouseItem = value;
                OnPropertyChanged("SelectedWarehouseItem");
            }
        }

        public ObservableCollection<WarehouseItemModel> WarehouseItems { get; set; }

        public WarehouseViewModel(Frame mainFrame) 
        {
            _mainFrame = mainFrame;
            WarehouseItems = new ObservableCollection<WarehouseItemModel>
            {
                 new WarehouseItemModel
                 {
                     ProductName = "Product 1",
                     ProductCount = 1
                 },
                 new WarehouseItemModel
                 {
                     ProductName = "Product 10",
                     ProductCount = 10
                 },
                 new WarehouseItemModel
                 {
                     ProductName = "Product 20",
                     ProductCount = 20
                 },
                 new WarehouseItemModel
                 {
                     ProductName = "Product 100",
                     ProductCount = 100
                 }
            };
        }
    }
}
