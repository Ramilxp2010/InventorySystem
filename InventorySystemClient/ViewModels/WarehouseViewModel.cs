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

        private string _text;
        public string Text 
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");

                if (_text.Length > 3)
                    WarehouseItems = new ObservableCollection<WarehouseItemModel>(WarehouseItems.Where(x => x.ProductName.Contains(_text)));
            }
        }

        private RelayCommand _mouseEnterItem;
        public RelayCommand MouseEnterCommand
        {
            get => _mouseEnterItem ??
                (
                    _mouseEnterItem = new RelayCommand(obj=> 
                    {
                        int a = 20;
                        int b = 2;
                        int c = a + b;
                    })
                );
        }

        public WarehouseViewModel(Frame mainFrame) 
        {
            _mainFrame = mainFrame;

            WarehouseItems = new ObservableCollection<WarehouseItemModel>();
            var items = RootContainer.Instance.Container.Resolve<IWarehouseProductManager>().GetWarehouseProducts().ToList();
            foreach (var item in items) 
            {
                WarehouseItems.Add(new WarehouseItemModel
                {
                    ProductName = item.Product.Name,
                    ProductCount = item.Count,
                    ProductCode = item.Product.Code,
                    ProductMeasure = item.Product.Unit.Name
                });
            }
        }
    }
}
