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
    public partial class frmAppointment : Form
    {
        connectionDB con = new connectionDB();

       


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmAppoinment rp = new frmAppoinment();
           // rp.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectDB().Open();
                SqlCommand cmd = con.connectDB().CreateCommand();
                cmd.CommandType = CommandType.Text;

                String sql = "Update APPOIMENT Set CREATED_BY=@pName, Date=@date,M_ID=@mOff,REASON=@sym Where U_ID=@pID";
                cmd.CommandText = sql;
                //cmd.Parameters.AddWithValue("@pName", txtPName.Text);
                //cmd.Parameters.AddWithValue("@pID", txtPID.Text);
                cmd.Parameters.AddWithValue("@date", dtpAppointmentDate.Text);
                //cmd.Parameters.AddWithValue("@mOff", txtMediOfficer.Text);
                //cmd.Parameters.AddWithValue("@sym", txtSymplomes.Text);
                //cmd.Parameters.AddWithValue("@time", txtATime.Text);

                cmd.ExecuteNonQuery();

                con.connectDB().Close();

            }
            catch (Exception c)
            {

                Console.WriteLine(c.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectDB().Open();
                SqlCommand cmd = con.connectDB().CreateCommand();
                cmd.CommandType = CommandType.Text;

                String sql = "Delete from APPOIMENT Where CREATED_BY=@pID";
                cmd.CommandText = sql;
                //cmd.Parameters.AddWithValue("@pID", txtPName.Text);

                cmd.ExecuteNonQuery();

                con.connectDB().Close();

            }
            catch (Exception r)
            {

                Console.WriteLine(r.Message);
            }
        }

        public void clear()
        {
            //txtPName.Text = null;
            //txtMediOfficer.Text = null;
            //txtATime.Text = null;
            //txtSymplomes.Text = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Load(object sender, EventArgs e)
        {

        }
    }
}

