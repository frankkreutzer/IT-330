using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Data.SqlClient;


namespace divdev
{
    class Datamgmt
    {
        public int ShowData(string[] strargs, int intargs, string datatype)
        {

            string msgtxt = "";

            for (int i = 0; i <= strargs.GetUpperBound(0); i++)
            { msgtxt = msgtxt + " " + strargs[i].ToString() + "\n"; };

            MessageBox.Show(msgtxt);

            if (datatype == "supplier")
            {
                int retval = 0;
                retval = AddSupplier(strargs, intargs);
            }

            else if (datatype == "category")
            {
                int retval = 0;
                retval = AddCategory(strargs, intargs);
            }
            else if (datatype == "product")
            {
                int retval = 0;
                retval = AddProduct(strargs, intargs);
            }
            else if (datatype == "follow")
            {
                int retval = 0;
                retval = AddFollow(strargs, intargs);
            }
            else if (datatype == "review")
            {
                int retval = 0;
                retval = AddReview(strargs, intargs);
            }
            else if (datatype == "order")
            {
                int retval = 0;
                retval = AddOrder(strargs, intargs);
            }
            else if (datatype == "customer")
            {
                int retval = 0;
                retval = AddCustomer(strargs, intargs);
            }

            return 0;
        }

        private int AddSupplier(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.SupplierTableAdapter auto = new divdevDataSetTableAdapters.SupplierTableAdapter();
            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2], strargs[3]);

            return 1;
        }

        private int AddCategory(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.CategoryTableAdapter auto = new divdevDataSetTableAdapters.CategoryTableAdapter();
            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2]);

            return 1;
        }

        private int AddProduct(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.ProductTableAdapter auto = new divdevDataSetTableAdapters.ProductTableAdapter();
            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2], strargs[3], Int16.Parse(strargs[4]), Int16.Parse(strargs[5]), float.Parse(strargs[6]), float.Parse(strargs[7]));

            return 1;
        }

        private int AddFollow(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.FollowingTableAdapter auto = new divdevDataSetTableAdapters.FollowingTableAdapter();
            auto.Insert(Int16.Parse(strargs[0]), Int16.Parse(strargs[1]), Int16.Parse(strargs[2]), Int16.Parse(strargs[3]));

            return 1;
        }

        private int AddReview(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.ReviewTableAdapter auto = new divdevDataSetTableAdapters.ReviewTableAdapter();
            auto.Insert(strargs[0], Int16.Parse(strargs[1]), Convert.ToDateTime(strargs[2]), strargs[3], Int16.Parse(strargs[4]));

            return 1;
        }


        private int AddOrder(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.OrderTableAdapter auto = new divdevDataSetTableAdapters.OrderTableAdapter();
            auto.Insert(strargs[0], Int16.Parse(strargs[1]), Convert.ToDateTime(strargs[2]), Int16.Parse(strargs[3]), float.Parse(strargs[4]));

            return 1;
        }

        private int AddCustomer(string[] strargs, int intargs)
        {
            divdevDataSetTableAdapters.CustomerTableAdapter auto = new divdevDataSetTableAdapters.CustomerTableAdapter();
            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2], strargs[3], strargs[4], strargs[5], strargs[6], strargs[7]);

            return 1;           
        }
    }
}
