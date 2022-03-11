using InventorySystem.Core;
using InventorySystem.Manager.Interfaces;
using InventorySystemClient.Commands;
using InventorySystemClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Unity;

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

        protected IWarehouseProductManager _warehouseProductManager;
        private IEnumerable<WarehouseItemModel> _itemsCached;

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

        public WarehouseViewModel(Frame mainFrame) 
        {
            _mainFrame = mainFrame;
            _warehouseProductManager = RootContainer.Instance.Container.Resolve<IWarehouseProductManager>();
            _itemsCached = LoadProducts();
            _warehouseItems = new ObservableCollection<WarehouseItemModel>(_itemsCached);
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
    }
}
