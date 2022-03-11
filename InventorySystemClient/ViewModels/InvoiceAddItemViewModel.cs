using InventorySystem.Core;
using InventorySystem.Manager.Interfaces;
using InventorySystemClient.Commands;
using InventorySystemClient.Models;
using InventorySystemClient.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Unity;

namespace InventorySystemClient.ViewModels
{
    public class InvoiceAddItemViewModel : BaseViewModel
    {
        private Frame _mainFrame;
        public Frame MainFrame 
        {
            get { return _mainFrame; }
            set 
            { 
                value = _mainFrame;
                OnPropertyChanged("MainFrame");
            }
        }

        protected IWarehouseProductManager _warehouseProductManager;
        private IEnumerable<WarehouseItemModel> _itemsCached;

        private ObservableCollection<WarehouseItemModel> _itemsAdded; 
        public ObservableCollection<WarehouseItemModel> ItemsAdded
        {
            get { return _itemsAdded; }
            set
            {
                _warehouseItems = value;
                OnPropertyChanged("ItemsAdded");
            }
        }
        private ObservableCollection<WarehouseItemModel> _warehouseItems;
        public ObservableCollection<WarehouseItemModel> WarehouseItems
        {
            get { return _warehouseItems; }
            set
            {
                _warehouseItems = value;
                OnPropertyChanged("WarehouseItems");
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

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
                WarehouseItems = new ObservableCollection<WarehouseItemModel>(Search(_text));
            }
        }

        private int _count;
        public string Count
        {
            get { return _count.ToString(); }
            set
            {
                _count = int.Parse(value);
                OnPropertyChanged("Count");
            }
        }

        public InvoiceAddItemViewModel(Frame mainFrame)
        {
            _mainFrame = mainFrame;
            _itemsAdded = new ObservableCollection<WarehouseItemModel>();
            _warehouseProductManager = RootContainer.Instance.Container.Resolve<IWarehouseProductManager>();
            _itemsCached = LoadProducts();
            _warehouseItems = new ObservableCollection<WarehouseItemModel>(_itemsCached);
        }

        private RelayCommand _goToInvoiceCommand;
        public RelayCommand GoToInvoiceCommand
        {
            get 
            {
                return _goToInvoiceCommand ??
                    (_goToInvoiceCommand = new RelayCommand(obj => 
                    {
                        MainFrame.Navigate(new InvoiceView(MainFrame));
                    }));
            }
        }

        private IEnumerable<WarehouseItemModel> LoadProducts()
        {
            foreach (var item in _warehouseProductManager.GetWarehouseProducts())
            {
                yield return new WarehouseItemModel
                {
                    ProductName = item.Product.Name,
                    ProductCount = item.Count,
                    ProductCode = item.Product.Code,
                    ProductMeasure = item.Product.Unit.Name
                };
            }
        }

        private IEnumerable<WarehouseItemModel> Search(string text)
        {
            foreach (var item in _warehouseProductManager.Search(text))
            {
                yield return new WarehouseItemModel
                {
                    ProductName = item.Product.Name,
                    ProductCount = item.Count,
                    ProductCode = item.Product.Code,
                    ProductMeasure = item.Product.Unit.Name
                };
            }
        }

        private RelayCommand _addProductCommand;
        public RelayCommand AddProductCommand
        {
            get
            {
                return _addProductCommand ??
                    (_addProductCommand = new RelayCommand(obj =>
                    {
                        if (SelectedWarehouseItem == null)
                            return;

                        var item = SelectedWarehouseItem;
                        item.ProductCount = _count;

                        _itemsAdded.Add(item);
                    }));
            }
        }

    }
}
