using InventorySystemClient.Commands;
using InventorySystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InventorySystemClient.ViewModels
{
    public class PopupWindowViewModel : BaseViewModel
    {
        public PopupWindowViewModel(RelayCommand command, string labelText, string textBoxDefaultValue)
        {
            PopupCommand = command;
            LabelText = labelText;
            TextBox = textBoxDefaultValue;
        }

        private decimal _textBoxValue;
        public string TextBox
        {
            get { return _textBoxValue.ToString(); }
            set
            {
                _textBoxValue = decimal.Parse(value);
                OnPropertyChanged("TextBox");
            }
        }
        
        private string _labelText;
        public string LabelText
        {
            get { return _labelText.ToString(); }
            set
            {
                _labelText = value;
                OnPropertyChanged("LabelText");
            }
        }

        public RelayCommand PopupCommand { get; }
    }


}
