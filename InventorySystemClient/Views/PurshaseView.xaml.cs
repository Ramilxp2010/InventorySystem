using InventorySystemClient.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InventorySystemClient.Views
{
    /// <summary>
    /// Interaction logic for PurshaseView.xaml
    /// </summary>
    public partial class PurshaseView : Page
    {
        public PurshaseView(Frame mainFrame)
        {
            InitializeComponent();
            DataContext = new PurshaseViewModel(mainFrame);
        }
    }
}
