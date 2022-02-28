using InventorySystemClient.Commands;
using InventorySystemClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

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

        public InvoiceAddItemViewModel(Frame mainFrame)
        {
            _mainFrame = mainFrame;
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
    }
}
