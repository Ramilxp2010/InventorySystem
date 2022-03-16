using System;
using System.Collections;
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

namespace InventorySystemClient.UserControls
{
    /// <summary>
    /// Interaction logic for ProductListView.xaml
    /// </summary>
    public partial class ProductListView : UserControl
    {
        public ProductListView()
        {
            InitializeComponent();
        }

        public IEnumerable ListItems
        {
            get { return (IEnumerable)GetValue(ListItemsProperty); }
            set { SetValue(ListItemsProperty, value); }
        }

        public static readonly DependencyProperty ListItemsProperty =
            DependencyProperty.Register("ListItems", typeof(IEnumerable),
              typeof(ProductListView), new FrameworkPropertyMetadata((IEnumerable)null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public object CustomSelectedItem
        {
            get { return (IEnumerable)GetValue(CustomSelectedItemProperty); }
            set { SetValue(CustomSelectedItemProperty, value); }
        }

        public static readonly DependencyProperty CustomSelectedItemProperty =
            DependencyProperty.Register("CustomSelectedItem", typeof(object),
              typeof(ProductListView), new FrameworkPropertyMetadata((object)null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    }
}
