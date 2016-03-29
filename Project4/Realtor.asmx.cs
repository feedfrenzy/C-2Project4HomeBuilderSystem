using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace Project4
{
    /// <summary>
    /// Summary description for Realtor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class Realtor : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();
        
        [WebMethod]
        public DataSet GetHomes()
        {
            string strHomes = "SELECT * FROM HOMES";
            DataSet Homes = objDB.GetDataSet(strHomes);
            return Homes;
        }


        [WebMethod]
        public DataSet doUpdates(int maxprice, int footage, int bedroom, int bathroom)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "updateHomes";


            objCommand.Parameters.AddWithValue("@theMaxPrice", maxprice);
            objCommand.Parameters.AddWithValue("@theSquare", footage);
            objCommand.Parameters.AddWithValue("@theBedrooms", bedroom);
            objCommand.Parameters.AddWithValue("@theBathrooms", bathroom);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }


        [WebMethod]
        public void deleteHouse(int houseID)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "deleteHouse";

            SqlParameter input = new SqlParameter("@houseID", houseID);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(input);

            objDB.GetDataSetUsingCmdObj(objCommand);
        }


        [WebMethod]
        public void addHouse(string address, string city, string state, string status, int price, int footage, int bedrooms, int bathrooms)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddHomes";

            objCommand.Parameters.AddWithValue("@theAddress", address);
            objCommand.Parameters.AddWithValue("@theCity", city);
            objCommand.Parameters.AddWithValue("@theState", state);
            objCommand.Parameters.AddWithValue("@theStatus", status);
            objCommand.Parameters.AddWithValue("@thePrice", price);
            objCommand.Parameters.AddWithValue("@theFootage", footage);
            objCommand.Parameters.AddWithValue("@theBedroom", bedrooms);
            objCommand.Parameters.AddWithValue("@theBathroom", bathrooms);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }


        [WebMethod]
        public DataSet showSelectedHouse(int id)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "ShowSelectedHomes";

            objCommand.Parameters.AddWithValue("@theId", id);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }


        [WebMethod]
        public void updateSelectedHouse(string id,string status, string address, string city, string state, int price, int footage, int bedroom, int bathroom)
        {

            int theID = int.Parse(id);


            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateSelectedHomes";

            objCommand.Parameters.AddWithValue("@theID", theID);
            objCommand.Parameters.AddWithValue("@theStatus", status);
            objCommand.Parameters.AddWithValue("@theAddress", address);

            objCommand.Parameters.AddWithValue("@theCity", city);
            objCommand.Parameters.AddWithValue("@theState", state);
            objCommand.Parameters.AddWithValue("@thePrice", price);
            objCommand.Parameters.AddWithValue("@theFootage", footage);
            objCommand.Parameters.AddWithValue("@theBedrooms", bedroom);
            objCommand.Parameters.AddWithValue("@theBathrooms", bathroom);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

    }
}
