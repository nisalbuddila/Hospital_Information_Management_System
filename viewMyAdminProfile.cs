using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using encryptDecrypt.BLL;
using encryptDecrypt.Model;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hospital_Information_Management_System
{
    public partial class viewMyAdminProfile : Form
    {
        SqlCommand cmd;
        String UID;
        String username;
        CryptoLab_BLL _cryptoLab_Bll = new CryptoLab_BLL();

        public viewMyAdminProfile(String sessionUser)
        {
            InitializeComponent();
            username = sessionUser;
            DisplayData();
            disableFields();
        }

        private void DisplayData() {

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();
            if (SC.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from [HMS].[dbo].[ADMIN] WHERE U_ID='" + username + "';", SC);
                SqlDataReader sddr;
                sddr = cmd.ExecuteReader();
                if (sddr.Read())
                {
                    txtUID.Text = sddr.GetValue(0).ToString();
                    txtNIC.Text = sddr.GetValue(1).ToString();
                    txtFName.Text = sddr.GetValue(2).ToString();
                    txtAddress.Text = sddr.GetValue(3).ToString();
                    dtpBdate.Text = sddr.GetValue(4).ToString();
                    cmbStatus.Text = sddr.GetValue(6).ToString();
                    txtPass.Text = sddr.GetValue(7).ToString();
                    txtTele.Text = sddr.GetValue(8).ToString();
                    cmbGender.Text = sddr.GetValue(9).ToString();


                }
                else
                {
                    MessageBox.Show("Error Loading Data", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Can't connect to Database", "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void disableFields()
        {
            txtAddress.Enabled = false;
            txtFName.Enabled = false;
            txtNIC.Enabled = false;
            txtPass.Enabled = false;
            txtTele.Enabled = false;
            txtUID.Enabled = false;
            cmbGender.Enabled = false;
            cmbStatus.Enabled = false;
            cmbActive.Enabled = false;
            dtpBdate.Enabled = false;
        }

        private void enableFields()
        {
            txtAddress.Enabled = true;
            txtFName.Enabled = true;
            txtNIC.Enabled = true;
            txtPass.Enabled = true;
            txtTele.Enabled = true;
            //txtUID.Enabled = true;
            cmbGender.Enabled = true;
            cmbStatus.Enabled = true;
            cmbActive.Enabled = true;
            dtpBdate.Enabled = true;
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

        public void clearData()
        {
            txtAddress.Clear();
            txtConPass.Clear();
            txtFName.Clear();
            txtNIC.Clear();
            txtPass.Clear();
            txtTele.Clear();
            txtUID.Clear();
            txtActiveS.Text = "--Select an Option--";
            cmbGender.Text = "--Select an Option--";
            cmbStatus.Text = "--Select an Option--";


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();
            if (txtFName.Text != "" && txtUID.Text != "" && txtPass.Text == txtConPass.Text)
            {

                cmd = new SqlCommand("update  [HMS].[dbo].[ADMIN] set NIC=@NIC, NAME=@Full_Name,DOB=@dob,MARITAL_STATUS=@M_Status,PASSWORD=@Password, ADDRESS=@Address,Telephone=@Tele,Gender=@Gender where U_ID=@U_ID", SC);
                cmd.Parameters.AddWithValue("@Full_Name", txtFName.Text);
                cmd.Parameters.AddWithValue("@U_ID", txtUID.Text);
                cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                cmd.Parameters.AddWithValue("@Password", txtConPass.Text = TextEncrypt());
                cmd.Parameters.AddWithValue("@M_Status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Tele", txtTele.Text);
                cmd.Parameters.AddWithValue("@dob", dtpBdate.Text);
                cmd.Parameters.AddWithValue("@status", cmbActive.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                SC.Close();
                DisplayData();
                disableFields();
            }
            else
            {
                MessageBox.Show("Couldn't Update the database!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { 
                DialogResult dr = MessageBox.Show("Are you sure you want to permanently delete this '" + username + "' record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    connectionDB cDB = new connectionDB();
                    SqlConnection SC = new SqlConnection();
                    SC = cDB.connectDB();
                    SC.Open();
                    cmd = new SqlCommand("delete[HMS].[dbo].[ADMIN] where U_ID=@id", SC);
                    cmd.Parameters.AddWithValue("@id", username);
                    cmd.ExecuteNonQuery();
                    SC.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    clearData();
                    UID = "";
                }
                else if (dr == DialogResult.No)
                {
                    //Nothing to do
                }
            }
            catch(Exception error1)
            {
                MessageBox.Show("Could'nt Delete the account !"+error1);
            }
        }
    }
}
