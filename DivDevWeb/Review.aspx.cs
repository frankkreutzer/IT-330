using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Review : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string product_id = Request.QueryString["product_id"];

        TextBox auto = (TextBox)FormView1.FindControl("product_idTextBox");

        auto.Text = product_id;

        TextBox username = (TextBox)FormView1.FindControl("usernameTextBox");
        username.Text = Context.User.Identity.Name;
    }

    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        Response.Redirect("prodDetails.aspx?product_id=" + Request.QueryString["product_id"]);
    }
}