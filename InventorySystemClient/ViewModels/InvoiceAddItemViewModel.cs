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
                OnPropertyChanged("SelectedWarehouseItem");
            }
        }

        private WarehouseItemModel _selectedWarehouseItemToDelete;
        public WarehouseItemModel SelectedWarehouseItemToDelete
        {
            get => _selectedWarehouseItemToDelete;
            set
            {
                _selectedWarehouseItemToDelete = value;
                OnPropertyChanged("SelectedWarehouseItemToDelete");
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

        private RelayCommand _addtemPopup;
        public RelayCommand AddItemPopup
        {
            get
            {
                return _addtemPopup ??
                    (_addtemPopup = new RelayCommand(itemObj =>
                    {
                        var item = (WarehouseItemModel)itemObj;
                        SelectedWarehouseItem = item;
                        var lableText = $"На складе {item.ProductName} - {item.ProductCount}. Добавить: ";
                        var popup = new PopupWindow(AddProductCommand, lableText, item.ProductCount.ToString());
                        popup.ShowDialog();
                    }));
            }
        }

        private RelayCommand _deleteItemPopup;
        public RelayCommand DeleteItemPopup
        {
            get
            {
                return _deleteItemPopup ??
                    (_deleteItemPopup = new RelayCommand(itemObj =>
                    {
                        var item = (WarehouseItemModel)itemObj;
                        SelectedWarehouseItemToDelete = item;
                        var lableText = $"{item.ProductName} - {item.ProductCount}. Убрать: ";
                        var popup = new PopupWindow(DeleteProductCommand, lableText, item.ProductCount.ToString());
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
                    Action = AddItemPopup,
                    ActionDisplayName = "Add"
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
                    Action = AddItemPopup,
                    ActionDisplayName = "Add"
                };
            }
        }

        private RelayCommand _addProductCommand;
        public RelayCommand AddProductCommand
        {
            get
            {
                return _addProductCommand ??
                    (_addProductCommand = new RelayCommand(countObj => 
                    {
                        var count = Convert.ToDecimal(countObj);
                        AddProductToBasket(count);
                    }));
            }
        }

        private RelayCommand _deleteProductCommand;
        public RelayCommand DeleteProductCommand
        {
            get
            {
                return _deleteProductCommand ??
                    (_deleteProductCommand = new RelayCommand(countObj =>
                    {
                        var count = Convert.ToDecimal(countObj);
                        DeleteProductFromBasket(count);
                    }));
            }
        }

        private void AddProductToBasket(decimal count)
        {
            if (count <= 0)
                return;

            if (SelectedWarehouseItem == null)
                return;

            if (SelectedWarehouseItem.ProductCount - count < 0)
                return;

            SelectedWarehouseItem.ProductCount -= count;

            var addedItem = _itemsAdded.FirstOrDefault(x => x.ProductCode == SelectedWarehouseItem.ProductCode);
            if (addedItem != null)
            {
                addedItem.ProductCount += count;
                return;
            }

            _itemsAdded.Add(new WarehouseItemModel() 
            {
                ProductName = SelectedWarehouseItem.ProductName,
                ProductCode = SelectedWarehouseItem.ProductCode,
                ProductMeasure = SelectedWarehouseItem.ProductMeasure, 
                ProductCount = count,
                Action = DeleteItemPopup,
                ActionDisplayName = "Delete"
            });
        }

        private void DeleteProductFromBasket(decimal count)
        {
            if (count <= 0)
                return;

            if (SelectedWarehouseItemToDelete == null)
                return;

            if (SelectedWarehouseItemToDelete.ProductCount - count < 0)
                return;

            SelectedWarehouseItemToDelete.ProductCount -= count;
            var item = _warehouseItems.FirstOrDefault(x => x.ProductCode == SelectedWarehouseItemToDelete.ProductCode);
            item.ProductCount += count;

            if (SelectedWarehouseItemToDelete.ProductCount == 0)
            {
                _itemsAdded.Remove(SelectedWarehouseItemToDelete);
            }
        }
    }
}
