using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Information_Management_System
{
    public partial class frmPatientDashboard : Form
    {
        public frmPatientDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frmViewAddAppoinments faa = new frmViewAddAppoinments();
            faa.Show();
            //this.Hide();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            frmViewAddComplaints fac = new frmViewAddComplaints();
            fac.Show();
            //this.Hide();
        }
    }
}
