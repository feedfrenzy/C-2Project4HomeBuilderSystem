using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class Home : System.Web.UI.Page
    {
        RealtorSvc.Realtor pxy = new RealtorSvc.Realtor();

        protected void Page_Load(object sender, EventArgs e)
        {
            gvHomes.DataSource =  pxy.GetHomes();
            gvHomes.DataBind();
        }

        protected void ddlAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ava = ddlAvailability.SelectedValue.ToString();
            pxy.GetUpdates(ava);
        }

        protected void ddlBathrooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlBedrooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlMinPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlMaxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}