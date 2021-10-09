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
    public partial class frmViewMO : Form
    {
        SqlCommand cmd;
        String UID;
        CryptoLab_BLL _cryptoLab_Bll = new CryptoLab_BLL();

        public frmViewMO()
        {
            InitializeComponent();
            DisplayData();
            disableFields();
        }

        private void DisplayData()
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();


            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [HMS].[dbo].[ADMIN] where", SC);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            SC.Close();
           
            // btnSave.Enabled = false;
            // btnUpdate.Enabled = false;
        }

        private void disableFields()
        {
            txtAddress.Enabled = false;
            txtStaffid.Enabled = false;
            txtFName.Enabled = false;
            txtNIC.Enabled = false;
            txtPass.Enabled = false;
            txtTele.Enabled = false;
            txtUID.Enabled = false;
            txtEmail.Enabled = false;
            cmbGender.Enabled = false;
            cmbStatus.Enabled = false;
            cmbActive.Enabled = false;
            dtpBdate.Enabled = false;
            txtSpecial.Enabled = false;
        }

        private void enableFields()
        {
            txtSpecial.Enabled = true;
            txtAddress.Enabled = true;
            txtStaffid.Enabled = true;
            txtFName.Enabled = true;
            txtNIC.Enabled = true;
            txtPass.Enabled = true;
            txtTele.Enabled = true;
            // txtUID.Enabled = true;
            txtEmail.Enabled = true;
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
            txtEmail.Clear();
            txtConPass.Clear();
            txtFName.Clear();
            txtNIC.Clear();
            txtPass.Clear();
            txtTele.Clear();
            txtUID.Clear();
            txtSpecial.Clear();
            txtStaffid.Clear();
            txtActiveS.Text = "--Select an Option--";
            cmbGender.Text = "--Select an Option--";
            cmbStatus.Text = "--Select an Option--";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();
            if (txtFName.Text != "" && txtUID.Text != "" && txtPass.Text == txtConPass.Text)
            {

                cmd = new SqlCommand("update  [HMS].[dbo].[MEDICLE_OFFICER] set NIC=@NIC, NAME=@Full_Name,DOB=@dob,MARITAL_STATUS=@M_Status,PASSWORD=@Password, ADDRESS=@Address,Telephone=@Tele,Gender=@Gender,STATUS=@status,SPECIAL=@special , STAFF_ID=@staffid, EMAIL=@email where U_ID=@U_ID", SC);
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
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@staffid", txtStaffid.Text);
                cmd.Parameters.AddWithValue("@special", txtSpecial.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                SC.Close();
                DisplayData();
                clearData();
                disableFields();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNIC.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtTele.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtUID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbActive.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            dtpBdate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSpecial.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
        //10 special
        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UID != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to permanently delete this '" + UID + "' record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    connectionDB cDB = new connectionDB();
                    SqlConnection SC = new SqlConnection();
                    SC = cDB.connectDB();
                    SC.Open();
                    cmd = new SqlCommand("delete[HMS].[dbo].[MEDICLE_OFFICER] where U_ID=@id", SC);
                    cmd.Parameters.AddWithValue("@id", UID);
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
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
