using InventorySystemClient.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class BasePage : BaseViewModel
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

        public BasePage(Frame mainFrame)
        {
            _mainFrame = mainFrame;
        }

        private RelayCommand _goBackCommand;
        public RelayCommand GoBackCommand
        {
            get
            {
                return _goBackCommand ?? (_goBackCommand = new RelayCommand(obj =>
                {
                    MainFrame.SetValue(Grid.ColumnProperty, 1);
                    MainFrame.GoBack();
                }));
            }
        }
    }
}
