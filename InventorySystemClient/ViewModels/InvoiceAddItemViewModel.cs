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
                _itemsAdded = value;
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
                Count = _selectedWarehouseItem.ProductCount.ToString();
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
                        MainFrame.Navigate(new InvoiceView(MainFrame, ItemsAdded));
                    }));
            }
        }

        private RelayCommand _goToPopupCommand;
        public RelayCommand GoToPopupCommand
        {
            get
            {
                return _goToPopupCommand ??
                    (_goToPopupCommand = new RelayCommand(obj =>
                    {
                        var popup = new PopupWindow(this, obj);
                        popup.ShowDialog();
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
                    ProductMeasure = item.Product.Unit.Name,
                    GoToPopupCommand = GoToPopupCommand
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
                    ProductMeasure = item.Product.Unit.Name,
                    GoToPopupCommand = GoToPopupCommand
                };
            }
        }

        private RelayCommand _addProductCommand;
        public RelayCommand AddProductCommand
        {
            get
            {
                return _addProductCommand ??
                    (_addProductCommand = new RelayCommand(obj => AddProductToBasket()));
            }
        }

        private void AddProductToBasket()
        {
            if (_count <= 0)
                return;

            if (SelectedWarehouseItem == null)
                return;

            if (SelectedWarehouseItem.ProductCount - _count < 0)
                return;

            SelectedWarehouseItem.ProductCount -= _count;

            var addedItem = _itemsAdded.FirstOrDefault(x => x.ProductCode == SelectedWarehouseItem.ProductCode);
            if (addedItem != null)
            {
                addedItem.ProductCount += _count;
                return;
            }

            _itemsAdded.Add(new WarehouseItemModel() 
            {
                ProductName = SelectedWarehouseItem.ProductName,
                ProductCode = SelectedWarehouseItem.ProductCode,
                ProductMeasure = SelectedWarehouseItem.ProductMeasure, 
                ProductCount = _count,
                GoToPopupCommand = GoToPopupCommand
            });
            
        }
    }
}
