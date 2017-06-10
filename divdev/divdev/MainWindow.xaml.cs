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

namespace divdev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.Show();
        }

        private void BtnNewProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addproduct = new AddProduct();
            addproduct.Show();
        }

        private void BtnNewOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrder addorder = new AddOrder();
            addorder.Show();
        }

        private void BtnNewCategory_Click(object sender, RoutedEventArgs e)
        {
            AddCategory addcategory = new AddCategory();
            addcategory.Show();
        }

        private void BtnNewSupplier_Click(object sender, RoutedEventArgs e)
        {
            AddSupplier addsupplier = new AddSupplier();
            addsupplier.Show();
        }

        private void BtnNewReview_Click(object sender, RoutedEventArgs e)
        {
            AddReview addreview = new AddReview();
            addreview.Show();
        }

        private void BtnNewFollow_Click(object sender, RoutedEventArgs e)
        {
            AddFollow addfollow = new AddFollow();
            addfollow.Show();
        }

        private void BtnListCategories_Click(object sender, RoutedEventArgs e)
        {
            ListCategories lstcat = new ListCategories();
            lstcat.Show();
        }

        private void BtnListCustomers_Click(object sender, RoutedEventArgs e)
        {
            ListCustomers lstcus = new ListCustomers();
            lstcus.Show();
        }

        private void BtnListFollows_Click(object sender, RoutedEventArgs e)
        {
            ListFollowing lstcus = new ListFollowing();
            lstcus.Show();
        }

        private void BtnListSuppliers_Click(object sender, RoutedEventArgs e)
        {
            ListSuppliers lstsup = new ListSuppliers();
            lstsup.Show();
        }

        private void BtnListProducts_Click(object sender, RoutedEventArgs e)
        {
            ListProducts lstpro = new ListProducts();
            lstpro.Show();
        }

        private void BtnListOrders_Click(object sender, RoutedEventArgs e)
        {
            ListOrders lstord = new ListOrders();
            lstord.Show();
        }

        private void BtnListReviews_Click(object sender, RoutedEventArgs e)
        {
            ListReviews lstrev = new ListReviews();
            lstrev.Show();
        }
    }
}
