using InventorySystemClient.Commands;
using InventorySystemClient.Models;
using InventorySystemClient.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

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

        private ObservableCollection<WarehouseItemModel> _addedItems;
        public ObservableCollection<WarehouseItemModel> AddedItems
        {
            get { return _addedItems; }
            set
            {
                _addedItems = value;
                OnPropertyChanged("AddedItems");
            }
        }

        public InvoiceViewModel(Frame mainFrame, IEnumerable addedItems)
        {
            _mainFrame = mainFrame;
            _addedItems = (ObservableCollection<WarehouseItemModel>)addedItems;
        }

        private RelayCommand _goBackCommand;
        public RelayCommand GoBackCommand
        {
            get
            {
                return _goBackCommand ?? (_goBackCommand = new RelayCommand(obj =>
                {
                    MainFrame.GoBack();
                }));
            }
        }
    }
}
