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

namespace divdev
{
    /// <summary>
    /// Interaction logic for ListSuppliers.xaml
    /// </summary>
    public partial class ListSuppliers : Window
    {
        public ListSuppliers()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            divdevDataSet dataset = new divdevDataSet();

            // use a table adapter to populate the Supplier table
            divdevDataSetTableAdapters.SupplierTableAdapter adapter = new divdevDataSetTableAdapters.SupplierTableAdapter();

            adapter.Fill(dataset.Supplier);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Supplier.DefaultView;
        }
    }
}
