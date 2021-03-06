
namespace Hospital_Information_Management_System
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewMO = new CustomControls.RJControls.RJButton();
            this.btnReceptionist = new CustomControls.RJControls.RJButton();
            this.btnPatientView = new CustomControls.RJControls.RJButton();
            this.btnNewUser = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUname = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.btnLogout = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnViewMO);
            this.panel1.Controls.Add(this.btnReceptionist);
            this.panel1.Controls.Add(this.btnPatientView);
            this.panel1.Controls.Add(this.btnNewUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 463);
            this.panel1.TabIndex = 0;
            // 
            // btnViewMO
            // 
            this.btnViewMO.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnViewMO.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.btnViewMO.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnViewMO.BorderRadius = 0;
            this.btnViewMO.BorderSize = 0;
            this.btnViewMO.FlatAppearance.BorderSize = 0;
            this.btnViewMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewMO.ForeColor = System.Drawing.Color.White;
            this.btnViewMO.Location = new System.Drawing.Point(1, 320);
            this.btnViewMO.Name = "btnViewMO";
            this.btnViewMO.Size = new System.Drawing.Size(199, 46);
            this.btnViewMO.TabIndex = 10;
            this.btnViewMO.Text = "View Medical Officers";
            this.btnViewMO.TextColor = System.Drawing.Color.White;
            this.btnViewMO.UseVisualStyleBackColor = false;
            this.btnViewMO.Click += new System.EventHandler(this.btnViewMO_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.BackColor = System.Drawing.Color.Violet;
            this.btnReceptionist.BackgroundColor = System.Drawing.Color.Violet;
            this.btnReceptionist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReceptionist.BorderRadius = 0;
            this.btnReceptionist.BorderSize = 0;
            this.btnReceptionist.FlatAppearance.BorderSize = 0;
            this.btnReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceptionist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReceptionist.ForeColor = System.Drawing.Color.White;
            this.btnReceptionist.Location = new System.Drawing.Point(0, 272);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(199, 46);
            this.btnReceptionist.TabIndex = 9;
            this.btnReceptionist.Text = "View Receptionists";
            this.btnReceptionist.TextColor = System.Drawing.Color.White;
            this.btnReceptionist.UseVisualStyleBackColor = false;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnPatientView
            // 
            this.btnPatientView.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnPatientView.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.btnPatientView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPatientView.BorderRadius = 0;
            this.btnPatientView.BorderSize = 0;
            this.btnPatientView.FlatAppearance.BorderSize = 0;
            this.btnPatientView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPatientView.ForeColor = System.Drawing.Color.White;
            this.btnPatientView.Location = new System.Drawing.Point(0, 224);
            this.btnPatientView.Name = "btnPatientView";
            this.btnPatientView.Size = new System.Drawing.Size(199, 46);
            this.btnPatientView.TabIndex = 8;
            this.btnPatientView.Text = "ViewPatients";
            this.btnPatientView.TextColor = System.Drawing.Color.White;
            this.btnPatientView.UseVisualStyleBackColor = false;
            this.btnPatientView.Click += new System.EventHandler(this.btnPatientView_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btnNewUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewUser.BorderRadius = 0;
            this.btnNewUser.BorderSize = 0;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(0, 176);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(199, 46);
            this.btnNewUser.TabIndex = 7;
            this.btnNewUser.Text = "Add New User";
            this.btnNewUser.TextColor = System.Drawing.Color.White;
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hospital_Information_Management_System.Properties.Resources.avatar_default_icon32;
            this.pictureBox1.ErrorImage = global::Hospital_Information_Management_System.Properties.Resources.avatar_default_icon32;
            this.pictureBox1.Location = new System.Drawing.Point(47, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(63, 146);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(65, 15);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "User Name";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(245, 62);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(182, 175);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Appoinments";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(444, 62);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(182, 175);
            this.rjButton2.TabIndex = 7;
            this.rjButton2.Text = "Mails";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(245, 255);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(182, 175);
            this.rjButton3.TabIndex = 8;
            this.rjButton3.Text = "Complaints";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.DarkCyan;
            this.rjButton4.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 20;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(444, 255);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(182, 175);
            this.rjButton4.TabIndex = 9;
            this.rjButton4.Text = "Loading....";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(534, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 34);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 463);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton btnReceptionist;
        private CustomControls.RJControls.RJButton btnPatientView;
        private CustomControls.RJControls.RJButton btnNewUser;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton btnLogout;
        private CustomControls.RJControls.RJButton btnViewMO;
    }
}