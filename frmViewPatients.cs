using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hospital_Information_Management_System
{
    public partial class frmViewPatients : Form
    {
        SqlCommand cmd;
        public frmViewPatients()
        {
            InitializeComponent();
            DisplayData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayData()
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();


            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [HMS].[dbo].[PATIENT]", SC);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            SC.Close();
           // btnSave.Enabled = false;
           // btnUpdate.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAlergy.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNIC.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTele.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtUID.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            cmbBlood.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbActive.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
        }
    }
}
