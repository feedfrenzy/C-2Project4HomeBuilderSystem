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
                gvHomes.Columns[0].Visible = false;
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

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";


            gvHomes.DataSource = pxy.GetHomes();
            gvHomes.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text.ToString();
            string city = txtCity.Text.ToString();
            string state = txtState.Text.ToString();
            string status = "Sale";
            int price = int.Parse(txtPrice.Text);
            int footage = int.Parse(txtFootage.Text);
            int bedroom = int.Parse(txtBedrooms.Text);
            int bathroom = int.Parse(txtBathrooms.Text);

            pxy.addHouse(address, city, state, status, price, footage, bedroom, bathroom);

            gvHomes.DataSource = pxy.GetHomes();
            gvHomes.DataBind();

            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtPrice.Text = "";
            txtFootage.Text = "";
            txtBedrooms.Text = "";
            txtBathrooms.Text = "";  
        }

        protected void gvHomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "updateHouse")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                pxy.showSelectedHouse(int.Parse(gvHomes.Rows[index].Cells[0].Text));

                Response.Redirect("UpdateHomes.aspx");
            }
            else if (e.CommandName == "deleteHouse")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int houseID = int.Parse(gvHomes.Rows[index].Cells[0].Text);

                pxy.deleteHouse(houseID);

                gvHomes.DataSource = pxy.GetHomes();
                gvHomes.DataBind();
            }
        }

        protected void gvHomes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvHomes.EditIndex = e.NewEditIndex;
        }
    }
}