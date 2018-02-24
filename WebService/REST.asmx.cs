using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for REST
    /// </summary>
    [WebService(Namespace = "http://kidscape.com/webservices/", Description="This is a web service for Kidscape", Name="RestService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class REST : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetCustomerName(int id)
        {
            //get customer name from the database.
            return "Microsoft Corporation";
        }

        [WebMethod]
        public bool InsertCustomer(int id, string customerName)
        {

            return true;
        }
        [WebMethod]
        public DataTable connectoToMySql()
        {
            string connString = "SERVER=localhost" + ";" +
                "DATABASE=hotel_mgt;" +
                "UID=root;" +
                "PASSWORD=;";

            MySqlConnection cnMySQL = new MySqlConnection(connString);

            MySqlCommand cmdMySQL = cnMySQL.CreateCommand();

            MySqlDataReader reader;

            cmdMySQL.CommandText = "select * from guest";

            cnMySQL.Open();

            reader = cmdMySQL.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);


            cnMySQL.Close();

            return dt;
        } 
    }
}
