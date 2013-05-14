using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DonorLoginClass dlc = new DonorLoginClass();
        int pk = dlc.Login(txtuser.Text, txtPassword.Text);
        if (pk != 0)
        {
            Session["person"] = pk;
            Response.Redirect("Default2.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login";
        }
    }
}