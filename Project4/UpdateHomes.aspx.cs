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
        DBConnect objDB = new DBConnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            gvSelectedHomes.DataSource = Session["updateDataSet"];
            gvSelectedHomes.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string id = Session["updateID"].ToString();

            int num;

            if (!String.IsNullOrEmpty(txtAddress.Text))
            {
                if (!String.IsNullOrEmpty(txtCity.Text))
                {
                    if (!String.IsNullOrEmpty(txtState.Text))
                    {
                        if (int.TryParse(txtPrice.Text, out num) && txtPrice.Text != "")
                        {
                            int thePrice = int.Parse(txtPrice.Text);

                            if (int.TryParse(ddlSquare.Text, out num) && ddlSquare.Text != "")
                            {
                                int theFootage = int.Parse(ddlSquare.Text);

                                if (int.TryParse(ddlBedrooms.Text, out num) && ddlBedrooms.Text != "")
                                {
                                    int theBedroom = int.Parse(ddlBedrooms.Text);

                                    if (int.TryParse(ddlBathrooms.Text, out num) && ddlBathrooms.Text != "")
                                    {
                                        int theBathroom = int.Parse(ddlBathrooms.Text);

                                        pxy.updateSelectedHouse(id, ddlStatus.SelectedValue.ToString(), txtAddress.Text, txtCity.Text, txtState.Text, thePrice, theFootage, theBedroom, theBathroom);

                                        string rebind = "SELECT * FROM Homes WHERE Id =" + id + "";

                                        gvSelectedHomes.DataSource = objDB.GetDataSet(rebind);
                                        gvSelectedHomes.DataBind();

                                        lblShow.Text = "Selected house updated!";
                                        lblWarning.Text = "";
                                    }
                                    else
                                    {
                                        lblWarning.Text = "Bathroom count can't be empty or must be an integer!";
                                    }
                                }
                                else
                                {
                                    lblWarning.Text = "Bedroom count can't be empty or must be an integer!";
                                }
                            }
                            else
                            {
                                lblWarning.Text = "Square Footage can't be empty or must be an integer!";
                            }
                        }
                        else
                        {
                            lblWarning.Text = "Price can't be empty or must be an integer!";
                        }
                    }
                    else
                    {
                        lblWarning.Text = "State can't be empty!";
                    }
                }
                else
                {
                    lblWarning.Text = "City can't be empty!";
                }

            }
            else
            {
                lblWarning.Text = "Address can't be empty!";
            }
        }
    }
}