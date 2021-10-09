using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hospital_Information_Management_System
{
    public partial class Login : Form
    {
        //global variable for keep session variable for login
        String UName;
        public static String userName;
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Creating object from the database connection class

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC] FROM [HMS].[dbo].[MEDICLE_OFFICER] WHERE U_ID ='" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "';", SC);
                    SqlDataReader sddr;
                    sddr = cmd.ExecuteReader();
                    if (sddr.Read())
                    {
                        //add selected user name into session variable
                        UName = sddr.GetValue(0).ToString();
                        userName = UName;
                        MO newDashBoard = new MO();
                        newDashBoard.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or password", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cant connect to database!");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Can't connect to Database" + error, "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Creating object from the database connection class

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC] FROM [HMS].[dbo].[MEDICLE_OFFICER] WHERE U_ID ='" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "';", SC);
                    SqlDataReader sddr;
                    sddr = cmd.ExecuteReader();
                    if (sddr.Read())
                    {
                        //add selected user name into session variable
                        UName = sddr.GetValue(0).ToString();
                        userName = UName;
                        MO newDashBoard = new MO ();
                        newDashBoard.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or password", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cant connect to database!");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Can't connect to Database" + error, "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
