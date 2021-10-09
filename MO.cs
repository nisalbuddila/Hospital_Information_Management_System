using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Hospital_Information_Management_System
{
    public partial class MO : Form
    {
        public static string uName;

        public MO()
        {
            InitializeComponent();
          
        }
        private void lblSymptoms_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

//Medical Officers' Appointments Load to Grid view
        private void MO_Load(object sender, EventArgs e)
        {   //view user name
            txtUname.Text = Login.userName ;



            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter dr = new SqlDataAdapter("SELECT a.APP_NO, p.NAME, P.NIC, a.SYMPTOMS FROM APPOIMENT a" +
                        " INNER JOIN PATIENT p ON p.U_ID = a.U_ID WHERE a.STATUS = 'Approved' AND a.M_OFFICER = '" + txtUname.Text +"'", SC);

                    DataTable dt = new DataTable();
                    dr.Fill(dt);

                    dataGridViewAppointments.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Can not connect to database!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Can't connect to Database" + error, "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

//Viewing Box 
        private void dataGridViewAppointments_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void dataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null)
                {
                    txtAppNo .Text = row.Cells[0].Value.ToString();
                    txtPatient.Text = row.Cells[1].Value.ToString();
                    txtNic.Text = row.Cells[2].Value.ToString();
                    txtSymptoms.Text  = row.Cells[3].Value.ToString();
                }
            }
        }

//Button Completed
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE APPOIMENT SET STATUS = 'Completed' WHERE APP_NO = @AppNo", SC);
                    cmd.Parameters.AddWithValue("@AppNo", txtAppNo.Text);
                    cmd.ExecuteNonQuery(); 
                }
                else
                {
                    MessageBox.Show("Can not connect to database!");
        }
            }
            catch (Exception error)
            {
                MessageBox.Show("Can't connect to Database" + error, "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

// Botton Incompleted
        private void btnIncompleted_Click(object sender, EventArgs e)
        {

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE APPOIMENT SET STATUS = 'Incompleted' WHERE APP_NO = @AppNo", SC);
                    cmd.Parameters.AddWithValue("@AppNo", txtAppNo.Text);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Can not connect to database!");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Can't connect to Database" + error, "Please Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
         
//MOuserDetails Form Open
        private void button1_Click(object sender, EventArgs e)
        {   
            uName = txtUname.Text;
            MOuserDetails frm = new MOuserDetails();
            frm.Show();
            this.Hide();
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
