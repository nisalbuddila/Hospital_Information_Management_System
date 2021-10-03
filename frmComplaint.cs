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
    public partial class frmComplaint : Form
    {
        connectionDB con = new connectionDB();

        public frmComplaint()
        {
            InitializeComponent();
        }

            

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectDB().Open();
                SqlCommand cmd = con.connectDB().CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "Insert INTO Complain(TYPE,DESCRIPTION,DATE,Approoved_By,Status)VALUE(@CType,@Dscriptionb,@date,@name,@status)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@name", txtComplaintby.Text);
                cmd.Parameters.AddWithValue("@CType", txtType.Text);
                cmd.Parameters.AddWithValue("@DESCRIPTION", txtDiscription.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@status", txtDiscription.Text);

            }
            catch (Exception B)
            {

                Console.WriteLine(B.Message);
                MessageBox.Show("Error!/nSomething Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }




    }
}
