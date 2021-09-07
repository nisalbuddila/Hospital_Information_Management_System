using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hospital_Information_Management_System
{
    public class connectionDB
    {
        public SqlConnection connectDB()
        {
            string server = "";
            string database = "HIMS";
            string uid = "";
            string password = "";
            string conString = "Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + uid + ";Password=" + password + "";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }
    }
}
