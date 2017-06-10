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
    /// Interaction logic for AddReview.xaml
    /// </summary>
    public partial class AddReview : Window
    {
        public AddReview()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[5];
            int nbrinput = 0;

            strinput[0] = txtUsername.Text;
            strinput[1] = txtProductID.Text;
            strinput[2] = txtReviewDate.Text;
            strinput[3] = txtComment.Text;
            strinput[4] = txtRating.Text;

            nbrinput = 5;

            retval = datamgmt.ShowData(strinput, nbrinput, "review");
        }
    }
}
