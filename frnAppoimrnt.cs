using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Information_Management_System
{
    public partial class frnAppoimrnt : Form

    {
        SqlCommand cmd;
        public frnAppoimrnt()
        {
            InitializeComponent();
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadCombo()
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();
            cmd = new SqlCommand("Select * From MEDICLE_OFFICER", SC);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            SC.Close();

            cbMediOfficer.DataSource = ds.Tables[0];
            cbMediOfficer.DisplayMember = "Name";
            cbMediOfficer.ValueMember = "U_ID";
        }

        private void frnAppoimrnt_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            //SqlConnection SC = new SqlConnection(@"Data Source=DESKTOP-Q5QGIVL;Initial Catalog=HMS;Integrated Security=True");
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            SC.Open();

            cmd = new SqlCommand("insert into [HMS].[dbo].[APPOIMENT](A_ID,P_NAME,A_DATE,M_OFFICER,SYMPTOMS) " +
                "values(@aid,@pname,@date,@mofficer,@symptoms)", SC);

            cmd.Parameters.AddWithValue("@aid", txtAID.Text);
            cmd.Parameters.AddWithValue("@pname", txtPname.Text);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dtpApp.Text.Trim()));
            cmd.Parameters.AddWithValue("@mofficer", cbMediOfficer.Text);
            cmd.Parameters.AddWithValue("@symptoms", txtSymptoms.Text);




            cmd.ExecuteNonQuery();
            SC.Close();
            SC.Dispose();
            MessageBox.Show("Record Inserted Successfully");
            Clear();
           



        }

        public void Clear()
        {
            txtAID.Text = "";
            dtpApp.Value = DateTime.Now;
            txtPname.Text = "";
            cbMediOfficer.Text = "";
            txtSymptoms.Text = "";

        }

        private void load_data()
        {
            try
            {
                connectionDB cDB = new connectionDB();
                SqlConnection SC = new SqlConnection();
                SC = cDB.connectDB();

                SC.Open();

                SqlCommand cmd = SC.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select A_ID,P_NAME,A_DATE,M_OFFICER,SYMPTOMS from APPOIMENT";
                cmd.ExecuteNonQuery();
                SC.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                int i = Convert.ToInt16(dt.Rows.Count.ToString());

                if (i != 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception l)
            {

                Console.WriteLine(l.Message);
                MessageBox.Show("Something Went Wrong!\nPlease Try Again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtAID.Text = dataGridView1.Rows[e.RowIndex].Cells["A_ID"].FormattedValue.ToString();
                txtPname.Text = dataGridView1.Rows[e.RowIndex].Cells["P_NAME"].FormattedValue.ToString();
                dtpApp.Text = dataGridView1.Rows[e.RowIndex].Cells["A_DATE"].FormattedValue.ToString();
                cbMediOfficer.Text = dataGridView1.Rows[e.RowIndex].Cells["M_OFFICER"].FormattedValue.ToString();
                txtSymptoms.Text = dataGridView1.Rows[e.RowIndex].Cells["SYMPTOMS"].FormattedValue.ToString();

            }
        }

        
    }   
        
    }


