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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InventorySystemClient.Views
{
    /// <summary>
    /// Interaction logic for InvoiceAddItem.xaml
    /// </summary>
    public partial class InvoiceAddItemView : Page
    {
        public InvoiceAddItemView(Frame frame)
        {
            InitializeComponent();
            DataContext = new InvoiceAddItemViewModel(frame);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var inputChar = e.Text.ToCharArray()[0];
            if (!char.IsDigit(inputChar) && (inputChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SelectAddress(object sender, RoutedEventArgs e)
        {
            var textBox = e.OriginalSource as TextBox;
            if (textBox != null)
                textBox.SelectAll();
        }

        private void SelectivelyIgnoreMouseButton(object sender,  MouseButtonEventArgs e)
        {
           // Find the TextBox
            DependencyObject parent = e.OriginalSource as UIElement;
            while (parent != null && !(parent is TextBox))
                parent = VisualTreeHelper.GetParent(parent);

            if (parent != null)
            {
                var textBox = (TextBox)parent;
                if (!textBox.IsKeyboardFocusWithin)
                {
                    // If the text box is not yet focussed, give it the focus and
                    // stop further processing of this click event.
                    textBox.Focus();
                    e.Handled = true;
                }
            }
        }
    }
}
