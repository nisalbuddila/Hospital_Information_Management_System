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
    public partial class frmViewReception : Form
    {
        SqlCommand cmd;
        String UID;
        CryptoLab_BLL _cryptoLab_Bll = new CryptoLab_BLL();
        public frmViewReception()
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
            adapt = new SqlDataAdapter("select * from [HMS].[dbo].[RECEPTION]", SC);
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
        }

        private void enableFields()
        {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNIC.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtTele.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtUID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStaffid.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbActive.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            dtpBdate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //7email
            //9staffid
            //14type

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableFields();
        }
    }
}
