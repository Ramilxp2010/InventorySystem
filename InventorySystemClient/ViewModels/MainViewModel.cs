using InventorySystemClient.Commands;
using InventorySystemClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class MainViewModel : BaseViewModel
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

        public MainViewModel(Frame frame) 
        {
            _mainFrame = frame;
            MainFrame.Navigate(new WarehouseView(_mainFrame));
        }

        private RelayCommand _goToWarehouseCommand;
        public RelayCommand GoToWarehouseCommand 
        {
            get 
            {
                return _goToWarehouseCommand ??
                    (_goToWarehouseCommand = new RelayCommand(obj =>
                    {
                        MainFrame.Navigate(new WarehouseView(_mainFrame));
                    }));
            }
        }

        private RelayCommand _goToPurshaseCommand;
        public RelayCommand GoToPurshaseCommand
        {
            get
            {
                return _goToPurshaseCommand ??
                    (_goToPurshaseCommand = new RelayCommand(obj =>
                    {
                        MainFrame.SetValue(Grid.ColumnProperty, 0);
                        MainFrame.SetValue(Grid.ColumnSpanProperty, 2);
                        MainFrame.Navigate(new PurshaseView(_mainFrame));
                    }));
            }
        }

        private RelayCommand _goToInvoiceAddItemCommand;
        public RelayCommand GoToInvoiceAddItemCommand
        {
            get
            {
                return _goToInvoiceAddItemCommand ??
                    (_goToInvoiceAddItemCommand = new RelayCommand(obj =>
                    {
                        MainFrame.SetValue(Grid.ColumnProperty, 0);
                        MainFrame.SetValue(Grid.ColumnSpanProperty, 2);
                        MainFrame.Navigate(new InvoiceAddItemView(_mainFrame));
                    }));
            }
        }
    }
}
