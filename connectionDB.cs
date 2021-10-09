using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hospital_Information_Management_System
{
    public class connectionDB
    {
        internal static string conString;

        public SqlConnection connectDB()
        {
            string server = "DESKTOP-S754J1J";
            string database = "HMS";
            string uid = "";
            string password = "";
            //User ID=" + uid + ";Password=" + password + ""
            string conString = "Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security = True;";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }
    }
}
