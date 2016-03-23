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
        SqlCommand objCommand = new SqlCommand();

        [WebMethod]
        public DataSet GetHomes()
        {
            string strHomes = "SELECT * FROM HOMES";
            DataSet Homes = objDB.GetDataSet(strHomes);
            return Homes;
        }


        [WebMethod]
        public DataSet GetUpdates(string values)
        {

            string strHomes = "SELECT * FROM HOMES";
            DataSet Homes = objDB.GetDataSet(strHomes);
            return Homes;
            //DataSet Updates;

            //return Updates;
        }





    }
}
