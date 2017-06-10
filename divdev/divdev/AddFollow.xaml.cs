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
    /// Interaction logic for AddFollow.xaml
    /// </summary>
    public partial class AddFollow : Window
    {
        public AddFollow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtCustomerID.Text;
            strinput[1] = txtCateID.Text;
            strinput[2] = txtSuppID.Text;
            strinput[3] = txtProdID.Text;

            nbrinput = 4;

            retval = datamgmt.ShowData(strinput, nbrinput, "follow");
        }
    }
}
