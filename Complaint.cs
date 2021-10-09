using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;



namespace Hospital_Information_Management_System
{
    public partial class Complaint : Form
    {
        SqlCommand cmd;
        public Complaint()
        {
            InitializeComponent();
            load_Data();
        }

        public void Clear()
        {
            txtType.Text = "";
            dtpDate.Value = DateTime.Now;
            txtPhoneNo.Text = "";
            txtComplaintby.Text = "";
            txtAction.Text = "";
            txtDiscription.Text = "";
            txtNote.Text = "";
            txtNIC.Text = "";

        }
        private void Complaint_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void disp_data()
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();
            //cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("Select NIC,PHONE_NO,date,DISCRIPTION,ACTIONTAKEN,NOTE,COMPLAINT_BY From COMPLAINT", SC);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            //SqlConnection SC = new SqlConnection(@"Data Source=DESKTOP-Q5QGIVL;Initial Catalog=HMS;Integrated Security=True");
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
             
            SC.Open();

            cmd = new SqlCommand("insert into [HMS].[dbo].[COMPLAINT](NIC,Com_Type,PHONE_NO,date,DISCRIPTION,ACTIONTAKEN,NOTE,ATTACHMENT,COMPLAINT_BY) " +
                "values(@nic,@C_Type, @PHO_No , @Date,@Discription,@ActionTaken,@Note,@Attachment,@C_name)", SC);

            cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
            cmd.Parameters.AddWithValue("@C_Type", txtType.Text);
            cmd.Parameters.AddWithValue("@PHO_No", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpDate.Text.Trim()));
            cmd.Parameters.AddWithValue("@Discription", txtDiscription.Text);
            cmd.Parameters.AddWithValue("@ActionTaken", txtAction.Text);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);
          //  cmd.Parameters.AddWithValue("@Attachment",btnBrowse .);
            cmd.Parameters.AddWithValue("@C_name", txtComplaintby.Text);

            byte[] file;
            using (var stream = new FileStream(ofdComplaint.FileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }

            cmd.Parameters.AddWithValue("@Attachment", file);

            cmd.ExecuteNonQuery();
            SC.Close();
            SC.Dispose();
            MessageBox.Show("Record Inserted Successfully");
            disp_data();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            SC.Open();

            SqlCommand cmd = SC.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (txtType.Text != "" && txtPhoneNo.Text != "" && txtDiscription.Text != "" && txtAction.Text != "" && txtNote.Text != "" && txtComplaintby.Text != "")
            {
                cmd.CommandText = "UPDATE complaint SET " +
                "Com_Type=@C_Type,PHONE_NO=@PHO_No,date=@Date,DISCRIPTION=@Discription," +
                "ACTIONTAKEN=@ActionTaken,NOTE=@Note,COMPLAINT_BY=@C_name WHERE nic='" + txtNIC.Text + "'";

                cmd.Parameters.AddWithValue("@C_Type", txtType.Text);
                cmd.Parameters.AddWithValue("@PHO_No", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpDate.Text.Trim()));
                cmd.Parameters.AddWithValue("@Discription", txtDiscription.Text);
                cmd.Parameters.AddWithValue("@ActionTaken", txtAction.Text);
                cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                cmd.Parameters.AddWithValue("@C_name", txtComplaintby.Text);

                cmd.ExecuteNonQuery();
                SC.Close();
                SC.Dispose();

                Clear();
                disp_data();
                MessageBox.Show("Record Update Successfully");

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }




            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            SC.Open();

            SqlCommand cmd = SC.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from complaint where nic='" + txtNIC.Text+"'";
                      

            
            
            cmd.ExecuteNonQuery();
            SC.Close();
            SC.Dispose();
            
            Clear();
            disp_data();
            MessageBox.Show("Record Delete Successfully");





            




            Clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdComplaint.InitialDirectory = @"C:\";
            ofdComplaint.RestoreDirectory = true;
            ofdComplaint.Title = "Browse Files";
            if(ofdComplaint.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void txtComplaintby_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                connectionDB cDB = new connectionDB();
                SqlConnection SC = new SqlConnection();
                SC = cDB.connectDB();

                SC.Open();

                SqlCommand cmd = SC.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.CommandText = "select C_ID,COMPLAINT_BY,Com_Type,PHONE_No,date,Discription,NOTE,ACTIONTAKEN from complaint where NIC=@nic";
                cmd.ExecuteNonQuery();
                SC.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                int i = Convert.ToInt16(dt.Rows.Count.ToString());

                if (i != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtType.Text = dr["Com_Type"].ToString();
                        txtComplaintby.Text = dr["COMPLAINT_BY"].ToString();
                        txtPhoneNo.Text = dr["PHONE_No"].ToString();
                        txtAction.Text = dr["ACTIONTAKEN"].ToString();
                        txtNote.Text = dr["NOTE"].ToString();
                        txtDiscription.Text = dr["Discription"].ToString();
                        dtpDate.Text = dr["date"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception l)
            {

                Console.WriteLine(l.Message);
                MessageBox.Show(l.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void load_Data()
        {
            try
            {
                connectionDB cDB = new connectionDB();
                SqlConnection SC = new SqlConnection();
                SC = cDB.connectDB();

                SC.Open();
               
                SqlCommand cmd = SC.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select C_ID,NIC,COMPLAINT_BY,PHONE_No,date,Discription,NOTE,ACTIONTAKEN from complaint";
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

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtNIC.Text = dataGridView1.Rows[e.RowIndex].Cells["NIC"].FormattedValue.ToString();
                txtType.Text = dataGridView1.Rows[e.RowIndex].Cells["C_ID"].FormattedValue.ToString();
                //txtComplaintby.Text = dataGridView1.Rows[e.RowIndex].Cells["Com_Type"].FormattedValue.ToString();
                txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells["PHONE_NO"].FormattedValue.ToString();
                dtpDate.Text = dataGridView1.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
                txtDiscription.Text = dataGridView1.Rows[e.RowIndex].Cells["DISCRIPTION"].FormattedValue.ToString();
                txtAction.Text = dataGridView1.Rows[e.RowIndex].Cells["ACTIONTAKEN"].FormattedValue.ToString();
                txtNote.Text = dataGridView1.Rows[e.RowIndex].Cells["NOTE"].FormattedValue.ToString();

            }
        }
    }
}
