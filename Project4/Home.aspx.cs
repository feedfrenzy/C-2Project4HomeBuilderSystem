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
    public partial class Home : System.Web.UI.Page
    {
        RealtorSvc.Realtor pxy = new RealtorSvc.Realtor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvHomes.DataSource = pxy.GetHomes();
                gvHomes.DataBind();
            }
        }

        protected void ddlAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bathrooms = int.Parse(ddlBathrooms.SelectedValue);
            int bedrooms = int.Parse(ddlBedrooms.SelectedValue);
            int maxPrice = int.Parse(ddlMaxPrice.SelectedValue);
            int square = int.Parse(ddlSquare.SelectedValue);
            DataSet newGv = pxy.doUpdates(maxPrice, square, bedrooms, bathrooms);

            gvHomes.DataSource = newGv;
            gvHomes.DataBind();

            lblShow.Text = "If you didnt see any grid view, that means no categories match in database.";
        }

        protected void ddlBathrooms_SelectedIndexChanged(object sender, EventArgs e)
        {

            int bathrooms = int.Parse(ddlBathrooms.SelectedValue);
            int bedrooms = int.Parse(ddlBedrooms.SelectedValue);
            int maxPrice = int.Parse(ddlMaxPrice.SelectedValue);
            int square = int.Parse(ddlSquare.SelectedValue);
            DataSet newGv = pxy.doUpdates(maxPrice, square, bedrooms, bathrooms);

            gvHomes.DataSource = newGv;
            gvHomes.DataBind();

            lblShow.Text = "If you didnt see any grid view, that means no categories match in database.";
        }

        protected void ddlBedrooms_SelectedIndexChanged(object sender, EventArgs e)
        {

            int bathrooms = int.Parse(ddlBathrooms.SelectedValue);
            int bedrooms = int.Parse(ddlBedrooms.SelectedValue);
            int maxPrice = int.Parse(ddlMaxPrice.SelectedValue);
            int square = int.Parse(ddlSquare.SelectedValue);
            DataSet newGv = pxy.doUpdates(maxPrice, square, bedrooms, bathrooms);

            gvHomes.DataSource = newGv;
            gvHomes.DataBind();

            lblShow.Text = "If you didnt see any grid view, that means no categories match in database.";
        }


        protected void ddlMaxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

            int bathrooms = int.Parse(ddlBathrooms.SelectedValue);
            int bedrooms = int.Parse(ddlBedrooms.SelectedValue);
            int maxPrice = int.Parse(ddlMaxPrice.SelectedValue);
            int square = int.Parse(ddlSquare.SelectedValue);
            DataSet newGv = pxy.doUpdates(maxPrice, square, bedrooms, bathrooms);

            gvHomes.DataSource = newGv;
            gvHomes.DataBind();

            lblShow.Text = "If you didnt see any grid view, that means no categories match in database.";
        }

        protected void ddlSquare_SelectedIndexChanged(object sender, EventArgs e)
        {

            int bathrooms = int.Parse(ddlBathrooms.SelectedValue);
            int bedrooms = int.Parse(ddlBedrooms.SelectedValue);
            int maxPrice = int.Parse(ddlMaxPrice.SelectedValue);
            int square = int.Parse(ddlSquare.SelectedValue);
            DataSet newGv = pxy.doUpdates(maxPrice, square, bedrooms, bathrooms);

            gvHomes.DataSource = newGv;
            gvHomes.DataBind();

            lblShow.Text = "If you didnt see any grid view, that means no categories match in database.";
        }
    }
}