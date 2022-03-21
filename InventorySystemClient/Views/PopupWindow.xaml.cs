using InventorySystemClient.Commands;
using InventorySystemClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InventorySystemClient.Views
{
    /// <summary>
    /// Interaction logic for PopupWindow.xaml
    /// </summary>
    public partial class PopupWindow : Window
    {
        public PopupWindow(InvoiceAddItemViewModel invoiceViewModel, object obj, RelayCommand command)
        {
            InitializeComponent();
            DataContext = new PopupWindowViewModel(invoiceViewModel, obj, command);
        }
    }
}
