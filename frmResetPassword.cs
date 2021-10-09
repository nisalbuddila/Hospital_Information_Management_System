using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using encryptDecrypt.BLL;
using encryptDecrypt.Model;

namespace Hospital_Information_Management_System
{
    public partial class frmResetPassword : Form
    {
        String UName;
        CryptoLab_BLL _cryptoLab_Bll = new CryptoLab_BLL();

        public frmResetPassword()
        {
            InitializeComponent();
        }


        //Encrypting the password
        public string TextEncrypt()
        {
            try
            {
                CryptoLab _cryptoLab = new CryptoLab();

                if (string.IsNullOrEmpty(txtConPass.Text))

                {
                    _cryptoLab.encryptText = "N/A";
                }
                else
                {
                    _cryptoLab.encryptText = txtConPass.Text.Trim();
                }

                _cryptoLab.method = "TripleDES";

                return _cryptoLab_Bll.EncryptText(_cryptoLab);
            }
            catch (Exception)
            {
                throw;
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConPass.Text && txtUserName.Text!="" && txtPassword.Text!="" && txtNIC.Text!="" && txtFullName.Text != "" && txtConPass.Text !="")
            {
                //Creating object from the database connection class
                String UserID = txtUserName.Text.Substring(0, 1);

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
           
                try
                {
                    SC.Open();
                  
                    if (SC.State == System.Data.ConnectionState.Open)
                    {
                        
                        if (UserID == "A" || UserID == "a")
                        {
                            SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC],[PASSWORD] FROM [HMS].[dbo].[ADMIN] WHERE U_ID ='" + txtUserName.Text + "' AND NIC = '" + txtNIC.Text + "' AND NAME = '" + txtFullName.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmd.ExecuteReader();
                            
                            if (sddr.Read())
                            {
                                sddr.Close();
                                SqlCommand cmd2 = new SqlCommand("update  [HMS].[dbo].[ADMIN] set PASSWORD=@Password where U_ID=@U_ID",SC);
                                MessageBox.Show("Here11111");
                                cmd2.Parameters.AddWithValue("@Password", txtConPass.Text = TextEncrypt());
                                cmd2.Parameters.AddWithValue("@U_ID", txtUserName.Text);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Password Reset Successful!");
                                SC.Close();
                                
                                
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Details", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (UserID == "M" || UserID == "m")
                        {
                            SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC],[PASSWORD] FROM [HMS].[dbo].[MEDICLE_OFFICER] WHERE U_ID ='" + txtUserName.Text + "' AND NIC = '" + txtNIC + "' AND NAME = '" + txtFullName.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmd.ExecuteReader();
                            if (sddr.Read())
                            {
                                sddr.Close();
                                SqlCommand cmd2 = new SqlCommand("update  [HMS].[dbo].[MEDICLE_OFFICER] set PASSWORD=@Password where U_ID=@U_ID", SC);

                                cmd2.Parameters.AddWithValue("@Password", txtConPass.Text = TextEncrypt());
                                cmd2.Parameters.AddWithValue("@U_ID", txtUserName.Text);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Password Reset Successful!");
                                SC.Close();
                                

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Details", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (UserID == "R" || UserID == "r")
                        {
                            SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC],[PASSWORD] FROM [HMS].[dbo].[RECEPTION] WHERE U_ID ='" + txtUserName.Text + "' AND NIC = '" + txtNIC + "' AND NAME = '" + txtFullName.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmd.ExecuteReader();
                            if (sddr.Read())
                            {
                                sddr.Close();
                                SqlCommand cmd2 = new SqlCommand("update  [HMS].[dbo].[RECEPTION] set PASSWORD=@Password where U_ID=@U_ID", SC);

                                cmd2.Parameters.AddWithValue("@Password", txtConPass.Text = TextEncrypt());
                                cmd2.Parameters.AddWithValue("@U_ID", txtUserName.Text);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Password Reset Successful!");
                                SC.Close();
                               

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Details", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (UserID == "P" || UserID == "p")
                        {
                            SqlCommand cmd = new SqlCommand("SELECT [U_ID],[NIC],[PASSWORD] FROM [HMS].[dbo].[PATIENT] WHERE U_ID ='" + txtUserName.Text + "' AND NIC = '" + txtNIC + "' AND NAME = '" + txtFullName.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmd.ExecuteReader();
                            if (sddr.Read())
                            {
                                sddr.Close();
                                SqlCommand cmd2 = new SqlCommand("update  [HMS].[dbo].[PATIENT] set PASSWORD=@Password where U_ID=@U_ID", SC);

                                cmd2.Parameters.AddWithValue("@Password", txtConPass.Text = TextEncrypt());
                                cmd2.Parameters.AddWithValue("@U_ID", txtUserName.Text);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Password Reset Successful!");
                                SC.Close();
                               

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Details", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
            else
            {
                MessageBox.Show("Please fill all the fields", "Try Again!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
