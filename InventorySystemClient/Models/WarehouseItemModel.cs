using InventorySystemClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemClient.Models
{
    public class WarehouseItemModel : BaseViewModel
    {
        private string _productName;
        public string ProductName 
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        private decimal _productCount;
        public decimal ProductCount
        {
            get => _productCount;
            set
            {
                _productCount = value;
                OnPropertyChanged("ProductCount");
            }
        }

        public override string ToString()
        {
            return $"{_productName} - {_productCount}";
        }
    }
}
