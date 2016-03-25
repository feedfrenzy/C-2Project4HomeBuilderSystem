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

            //SqlParameter inputParameter = new SqlParameter("@theAva", ava);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.VarChar;
            //objCommand.Parameters.Add(inputParameter);

            //inputParameter = new SqlParameter("@theMinPrice", minprice);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.Int;
            //objCommand.Parameters.Add(inputParameter);

            //inputParameter = new SqlParameter("@theMaxPrice", maxprice);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.Int;
            //objCommand.Parameters.Add(inputParameter);

            //inputParameter = new SqlParameter("@theSquare", footage);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.Int;
            //objCommand.Parameters.Add(inputParameter);

            //inputParameter = new SqlParameter("@theBedrooms", bedroom);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.Int;
            //objCommand.Parameters.Add(inputParameter);

            //inputParameter = new SqlParameter("@theBathrooms", bathroom);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.Int;
            //objCommand.Parameters.Add(inputParameter);
        }





    }
}
