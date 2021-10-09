
namespace Hospital_Information_Management_System
{
    partial class frmPatientDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientDashboard));
            this.btnAppoinments = new CustomControls.RJControls.RJButton();
            this.btnComplaints = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAppoinments
            // 
            this.btnAppoinments.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAppoinments.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAppoinments.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAppoinments.BorderRadius = 20;
            this.btnAppoinments.BorderSize = 0;
            this.btnAppoinments.FlatAppearance.BorderSize = 0;
            this.btnAppoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppoinments.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnAppoinments.Location = new System.Drawing.Point(115, 225);
            this.btnAppoinments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppoinments.Name = "btnAppoinments";
            this.btnAppoinments.Size = new System.Drawing.Size(208, 233);
            this.btnAppoinments.TabIndex = 7;
            this.btnAppoinments.Text = "Appoinments";
            this.btnAppoinments.TextColor = System.Drawing.Color.White;
            this.btnAppoinments.UseVisualStyleBackColor = false;
            this.btnAppoinments.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnComplaints
            // 
            this.btnComplaints.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComplaints.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnComplaints.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComplaints.BorderRadius = 20;
            this.btnComplaints.BorderSize = 0;
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComplaints.ForeColor = System.Drawing.Color.White;
            this.btnComplaints.Location = new System.Drawing.Point(545, 225);
            this.btnComplaints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(208, 233);
            this.btnComplaints.TabIndex = 9;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.TextColor = System.Drawing.Color.White;
            this.btnComplaints.UseVisualStyleBackColor = false;
            this.btnComplaints.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "PATIENT DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComplaints);
            this.Controls.Add(this.btnAppoinments);
            this.Name = "frmPatientDashboard";
            this.Text = "frmPatientDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnAppoinments;
        private CustomControls.RJControls.RJButton btnComplaints;
        private System.Windows.Forms.Label label1;
    }
}