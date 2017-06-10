using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Catalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.SelectedIndexChanged += new EventHandler(GridView1_SelectedIndexChanged);
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        string d = row.Cells[1].Text;

        string url = "proddetails.aspx?";
        url += "product_id=" + d;

        Response.Redirect(url);
    }
}