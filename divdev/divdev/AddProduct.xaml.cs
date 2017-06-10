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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[8];
            int nbrinput = 0;

            strinput[0] = txtProductid.Text;
            strinput[1] = txtProductName.Text;
            strinput[2] = txtProductImg.Text;
            strinput[3] = txtProductDesc.Text;
            strinput[4] = txtCategoryID.Text;
            strinput[5] = txtSupplierID.Text;
            strinput[6] = txtPurchasePrice.Text;
            strinput[7] = txtSalePrice.Text;

            nbrinput = 8;

            retval = datamgmt.ShowData(strinput, nbrinput, "product");
        }
    }
}
