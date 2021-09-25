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
using encryptDecrypt.BLL;
using encryptDecrypt.Model;

namespace Hospital_Information_Management_System
{
    public partial class Login : Form
    {
        //global variable for keep session variable for login
        String UName;
        string Password;
        CryptoLab_BLL _cryptoLab_Bll = new CryptoLab_BLL();

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
                    SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC] FROM [HMS].[dbo].[ADMIN] WHERE U_ID ='" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "';", SC);
                    SqlDataReader sddr;
                    sddr = cmd.ExecuteReader();
                    if (sddr.Read())
                    {
                        //add selected user name into session variable
                        UName = sddr.GetValue(0).ToString();
                        frmDashboard newDashBoard = new frmDashboard(UName);
                        newDashBoard.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or password", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else{
                    MessageBox.Show("Cant connect to database!");
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Can't connect to Database"+ error, "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Encrypting the password
        public string TextEncrypt()
        {
            try
            {
                CryptoLab _cryptoLab = new CryptoLab();

                if (string.IsNullOrEmpty(txtPassword.Text))

                {
                    _cryptoLab.encryptText = "N/A";
                }
                else
                {
                    _cryptoLab.encryptText = txtPassword.Text.Trim();
                }

                _cryptoLab.method = "TripleDES";

                return _cryptoLab_Bll.EncryptText(_cryptoLab);
            }
            catch (Exception)
            {
                throw;
            }
        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Creating object from the database connection class

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            Password = TextEncrypt();
            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC],[PASSWORD] FROM [HMS].[dbo].[ADMIN] WHERE U_ID ='" + txtUserName.Text + "' AND Password = '" + Password + "';", SC);
                    SqlDataReader sddr;
                    sddr = cmd.ExecuteReader();
                    if (sddr.Read())
                    {
                        //add selected user name into session variable
                        UName = sddr.GetValue(0).ToString();
                        //Password = sddr.GetValue(2).ToString();
                        //String DecryptedPassword = ;
                        frmDashboard newDashBoard = new frmDashboard(UName);
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
