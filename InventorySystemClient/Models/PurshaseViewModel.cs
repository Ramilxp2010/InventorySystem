using InventorySystemClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.Models
{
    public class PurshaseViewModel : BaseViewModel
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

        public PurshaseViewModel(Frame mainFrame)
        {
            _mainFrame = mainFrame;
        }
    }
}
