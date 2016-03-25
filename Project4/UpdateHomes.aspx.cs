using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace Project4
{
    public partial class UpdateHomes : System.Web.UI.Page
    {
        RealtorSvc.Realtor pxy = new RealtorSvc.Realtor();



        protected void Page_Load(object sender, EventArgs e)
        {
            gvSelectedHomes.DataSource = pxy.showSelectedHouse();
            gvSelectedHomes.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}