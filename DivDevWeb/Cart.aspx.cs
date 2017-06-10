using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList prods = new ArrayList();
        ArrayList qtys = new ArrayList();

        //prods = (ArrayList)Session["cartprod"];
        //qtys = (ArrayList)Session["cartqty"];
        prods = Session["cartprod"] == null ? prods : (ArrayList)Session["cartprod"];
        qtys = Session["cartqty"] == null ? qtys : (ArrayList)Session["cartqty"];

        /*if (!this.IsPostBack)
        {
            prods.Add(Request.QueryString["product_id"]);
            qtys.Add(Request.QueryString["qty"]);
        }

        Session["cartprod"] = prods;
        Session["cartqty"] = qtys;*/

        if (prods.Count > 0)
        {
            // ==================== 

            SqlDataSource ds = new SqlDataSource();

            string sqlstatement = "SELECT ROW_NUMBER() over(order by product_id) as ROWNUM, product_id, productname, saleprice, 0 as QTY_ORDER, 0 as LineTotal  FROM [Product] ";

            if (prods.Count > 1)
            {
                sqlstatement = sqlstatement + " WHERE product_id = " + prods[0].ToString();
                for (int i = 1; i < prods.Count; i++)
                {
                    sqlstatement = sqlstatement + " OR product_id = " + prods[i].ToString();
                }
            }
            else
            {
                sqlstatement = sqlstatement + "WHERE product_id = " + prods[0].ToString();
            }
            ds.SelectCommand = sqlstatement;

            ds.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["divdevConnectionString"].ConnectionString;

            ds.DataBind();

            GridView1.DataSource = ds;
            GridView1.DataBind();


            // Populate Quantities
            for (int i = 0; i < qtys.Count; i++)
            {
                GridView1.Rows[i].Cells[5].Text = qtys[i].ToString();
            }

            decimal prodprice;
            int qtypur;
            decimal linetotresult = 0;
            decimal basket_total = 0;
            int qty_total = 0;

            // Populate Line Totals and Accumulate Basket Total
            for (int i = 1; i <= prods.Count; i++)
            {
                prodprice = Decimal.Parse(GridView1.Rows[i - 1].Cells[4].Text);
                qtypur = Int16.Parse(GridView1.Rows[i - 1].Cells[5].Text);
                linetotresult = prodprice * qtypur;
                qty_total = (int)qty_total + qtypur;
                basket_total = basket_total + linetotresult;
                GridView1.Rows[i - 1].Cells[6].Text = linetotresult.ToString("C", CultureInfo.CurrentCulture);
            }

            // Provide Summary
            GridView1.FooterRow.Cells[4].Text = "Totals";
            GridView1.FooterRow.Cells[4].HorizontalAlign = HorizontalAlign.Right;
            GridView1.FooterRow.Cells[5].Text = qty_total.ToString();
            GridView1.FooterRow.Cells[6].Text = basket_total.ToString("C", CultureInfo.CurrentCulture);
        }
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ArrayList prods = new ArrayList();
        ArrayList qty = new ArrayList();

        prods = (ArrayList)Session["cartprod"];
        qty = (ArrayList)Session["cartqty"];

        prods.RemoveAt(e.RowIndex);
        qty.RemoveAt(e.RowIndex);

        Session["cartprod"] = (ArrayList)prods;
        Session["cartqty"] = (ArrayList)qty;

        Response.Redirect("cart.aspx?");
    }

    protected void Btn_checkout_Click(object sender, EventArgs e)
    {
        ArrayList prods = new ArrayList();
        ArrayList qty = new ArrayList();
        prods = (ArrayList)Session["cartprod"];
        qty = (ArrayList)Session["cartqty"];

        string custid = Context.User.Identity.Name;

        if (custid != "")
        {
            DateTime currdatetime = DateTime.Now;
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["divdevConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string insert_cmd = "insert into [order](customer_id, product_id, saledate, productqty, saleprice) values(@customer_id, @product_id, @saledate, @productqty, @saleprice)";
            try
            {
                conn.Open();
                for (int i = 0; i <= prods.Count; i++)
                {
                    SqlCommand icmd = new SqlCommand(insert_cmd, conn);
                    icmd.Parameters.AddWithValue("@customer_id", custid);
                    icmd.Parameters.AddWithValue("@product_id", prods[i]);
                    icmd.Parameters.AddWithValue("@saledate", currdatetime);
                    icmd.Parameters.AddWithValue("@productqty", qty[i]);
                    icmd.Parameters.AddWithValue("@saleprice", Decimal.Parse(GridView1.Rows[i].Cells[4].Text));
                    icmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('DB Save Problem');", true);
            }
            finally
            { conn.Close(); }

            Session["cartprod"] = new ArrayList();
            Session["cartqty"] = new ArrayList();

            Response.Redirect("confirm.aspx");
        }
        else
        {
            Response.Redirect("Account/Login");
        }
    }
}