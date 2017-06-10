using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class ProdDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        /*if (e.CommandName == "AddToCart")
        {

            string url = "cart.aspx?";

            DetailsViewRow row = DetailsView1.Rows[0];
            string product_id = row.Cells[1].Text;

            url += "product_id=" + product_id;
            url += "&qty=" + txt_qty.Text;

            Response.Redirect(url);
        }*/

        if (e.CommandName == "AddToCart")
        {

            DetailsViewRow row = DetailsView1.Rows[0];
            string product_id = row.Cells[1].Text;

            ArrayList prods = new ArrayList();
            ArrayList qtys = new ArrayList();

            //prods = (ArrayList)Session["cartprod"];
            //qtys = (ArrayList)Session["cartqty"];
            prods = Session["cartprod"] == null ? prods : (ArrayList)Session["cartprod"];
            qtys = Session["cartqty"] == null ? qtys : (ArrayList)Session["cartqty"];

            prods.Add(product_id);
            qtys.Add(txt_qty.Text);

            Session["cartprod"] = prods;
            Session["cartqty"] = qtys;

            Response.Redirect("cart.aspx");
        } //for the delete button to work

        else if (e.CommandName == "SubmitReview")

        {

            string url = "review.aspx?";

            DetailsViewRow row = DetailsView1.Rows[0];
            string product_id = row.Cells[1].Text;

            url += "product_id=" + product_id;
            Response.Redirect(url);
        }
    }
}