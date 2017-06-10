﻿using System;
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
    /// Interaction logic for ListReviews.xaml
    /// </summary>
    public partial class ListReviews : Window
    {
        public ListReviews()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            divdevDataSet dataset = new divdevDataSet();

            // use a table adapter to populate the Supplier table
            divdevDataSetTableAdapters.ReviewTableAdapter adapter = new divdevDataSetTableAdapters.ReviewTableAdapter();

            adapter.Fill(dataset.Review);

            // use the Customer table as the DataContext for this Window
            dataGrid.ItemsSource = dataset.Review.DefaultView;
        }
    }
}
