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
        MySqlConnection cnMySQL;

        public REST()
        {
            string connString = "SERVER=localhost" + ";" +
                "DATABASE=hotel_mgt;" +
                "UID=root;" +
                "PASSWORD=;";

           cnMySQL = new MySqlConnection(connString);
        }
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
        public DataTable getGuestList()
        {

            MySqlCommand cmdMySQL = cnMySQL.CreateCommand();

            MySqlDataReader reader;

            cmdMySQL.CommandText = "SELECT guest_id, fname, lname, title, gender, citizenship, status FROM `guest`";

            cnMySQL.Open();

            reader = cmdMySQL.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);


            cnMySQL.Close();

            return dt;
        }

        [WebMethod]
        public DataSet getDates(String room_num)
        {
            DataSet dates = new DataSet();

            MySqlCommand cmdMySQL = cnMySQL.CreateCommand();

            cmdMySQL.CommandText = "SELECT room.room_num, check_in.checkin_date, reservation.check_in as reservation FROM `room`"+ 
            "LEFT JOIN reservation ON reservation.room_num = room.room_num" +
            "LEFT JOIN check_in ON check_in.room_num=room.room_num"+
            "WHERE room.room_num = @room_num";
            cmdMySQL.Parameters.Add(new MySqlParameter("@room_num", room_num));
            cnMySQL.Open();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmdMySQL);

            try
            {
                sqlDataAdapter.Fill(dates);
            }
            catch { }

            cnMySQL.Close();

            return dates;
        }

        [WebMethod]
        public DataTable getDataFromSearch(String fname)
        {

            MySqlCommand cmdMySQL = cnMySQL.CreateCommand();

            MySqlDataReader reader;

            cmdMySQL.CommandText = "SELECT * FROM `guest` WHERE fname LIKE '%" + fname + "%'";

            cnMySQL.Open();

            reader = cmdMySQL.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);


            cnMySQL.Close();

            return dt;
        }
    }
}
