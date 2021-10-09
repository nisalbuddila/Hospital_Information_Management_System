using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Information_Management_System
{
    public partial class frmDashboard : Form
    {
        string username;
        public frmDashboard(String sessionUser)
        {
            InitializeComponent();
            username = sessionUser;
            lblUname.Text = username;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Close! record?", "Any Unsaved Changes will be lost!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            frmRegister registerfrm = new frmRegister(username);
            registerfrm.Show();
        }

        private void btnPatientView_Click(object sender, EventArgs e)
        {
            frmViewPatients newView = new frmViewPatients();
            newView.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing Application", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            frmViewReception newReception = new frmViewReception();
            newReception.Show();
        }

        private void btnViewMO_Click(object sender, EventArgs e)
        {
            frmViewMO frmview = new frmViewMO();
            frmview.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            viewMyAdminProfile frmview = new viewMyAdminProfile(username);
            frmview.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frnAppoimrnt myForm = new frnAppoimrnt();
            myForm.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Complaint myFormComplaint = new Complaint();
            myFormComplaint.Show();
        }
    }
}
