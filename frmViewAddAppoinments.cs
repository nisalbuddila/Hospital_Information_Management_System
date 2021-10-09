using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Information_Management_System
{
    public partial class frmViewAddAppoinments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - VLEFAE5; Initial Catalog = HMS; Integrated Security = True");

        public frmViewAddAppoinments()
        {
            InitializeComponent();
        }

        private void frmViewAddAppoinments_Load(object sender, EventArgs e)
        {

        }

        private void btnAadd_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into appoinments('"+txtUid.Text+"','"+txtPatiName.Text+"','"+txtAppoDate+"','"+txtMediOfficer.Text+"','"+txtsymptoms+"') ";
            cmd.ExecuteNonQuery();
                con.Close();

            MessageBox.Show("Sucussfull insert");

        }
        } 
}
