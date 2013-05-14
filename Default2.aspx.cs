using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["person"] != null)
        {
            int personKey = (int)Session["person"];
            DonorGet dg = new DonorGet(personKey);

            string donorName = null;
            DataSet ds = dg.GetDonation();
            foreach (DataRow row in ds.Tables["Donor"].Rows)
            {
                donorName = row["firstName"].ToString() + " " + row["lastName"].ToString();
            }
            lblDonorName.Text = donorName;
            DataSet ds2=dg.GetDonationAmount();

            GridView1.DataSource = ds2.Tables["Donations"];
            GridView1.DataBind();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
}