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

        private string _productCode;
        public string ProductCode
        {
            get => _productCode;
            set
            {
                _productCode = value;
                OnPropertyChanged("ProductCode");
            }
        }

        private string _productMeasure;
        public string ProductMeasure
        {
            get => _productMeasure;
            set
            {
                _productMeasure = value;
                OnPropertyChanged("ProductMeasure");
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
