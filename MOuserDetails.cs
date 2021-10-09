using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Information_Management_System
{
    public partial class MOuserDetails : Form
    {
        
        public MOuserDetails()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPersonal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
//Get data from DB to textboxes
        private void MOuserDetails_Load(object sender, EventArgs e)
        {
            btnSubmit.Visible = false;

            // view user name on MOuserDetails Form
            txtUname.Text = MO.uName;

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand  cmd = new SqlCommand ("SELECT NAME, NIC, TELEPHONE, DOB, GENDER, MARITAL_STATUS, STAFF_ID, EMAIL,DOJ" +
                        " FROM MEDICLE_OFFICER WHERE U_ID = @UserName", SC);
                    cmd.Parameters.AddWithValue("@UserName", txtUname.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtName.Text = dr.GetValue(0).ToString();
                        txtNic.Text = dr.GetValue(1).ToString();
                        txtPhone.Text = dr.GetValue(2).ToString();
                        txtDob.Text = dr.GetValue(3).ToString ();
                        cmbGender.Text = dr.GetValue(4).ToString();
                        cmbMaritalState.Text = dr.GetValue(5).ToString();
                        txtStaffId.Text = dr.GetValue(6).ToString();
                        txtStaffEmail.Text = dr.GetValue(7).ToString();
                        txtDoj.Text = dr.GetValue(8).ToString();
                    }

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
// Edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtNic.ReadOnly = false;
            txtPhone.ReadOnly = false;
            cmbMaritalState.Enabled = true;            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    if (MessageBox.Show("You Want to Update This Record?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                    {

                        SqlCommand cmd = new SqlCommand("UPDATE MEDICLE_OFFICER SET NAME=@name, NIC=@nic, TELEPHONE=@phone" +
                            " MARITAL_STATUS=@ms WHERE U_ID=@uname", SC);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@ms", cmbMaritalState.Text);
                        cmd.Parameters.AddWithValue("@uname", txtUname.Text);
                        cmd.ExecuteNonQuery();
                    }
                    
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
// MOuserDetails Form Close
        private void btnBack_Click(object sender, EventArgs e)
        {
            MO frm = new MO();
            frm.Show();
            this.Close();
        }

        private void txtStaffId_TextChanged(object sender, EventArgs e)
        {

        }
//Enable Changing Passsword
        private void btnPassword_Click(object sender, EventArgs e)
        {
            textOldPassward.ReadOnly = false;
            txtNewPassward.ReadOnly = false;
            txtConfirm.ReadOnly = false;
            btnSubmit.Visible = true;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }
//Change Password
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();

            try
            {
                SC.Open();
                if (SC.State == System.Data.ConnectionState.Open)
                {
                    if (txtNewPassward.Text == txtConfirm.Text)
                    {
                        SqlCommand cmnd = new SqlCommand("UPDATE MEDICLE_OFFICER SET PASSWORD='" + txtConfirm.Text + "' WHERE U_ID=@uname AND PASSWORD= '" + textOldPassward + "'", SC);
                        cmnd.Parameters.AddWithValue("@uname", txtUname.Text);
                        cmnd.ExecuteNonQuery();

                        MessageBox.Show("Password Changed", "Successfullys", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Sorry", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
    }
}
