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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[8];
            int nbrinput = 0;

            strinput[0] = txtCustomerID.Text;
            strinput[1] = txtFirstname.Text;
            strinput[2] = txtLastname.Text;
            strinput[3] = txtEmail.Text;
            strinput[4] = txtAddress.Text;
            strinput[5] = txtCity.Text;
            strinput[6] = txtState.Text;
            strinput[7] = txtZip.Text;

            nbrinput = 8;

            retval = datamgmt.ShowData(strinput, nbrinput, "customer");
        }
    }
}
