
namespace Hospital_Information_Management_System
{
    partial class viewMyAdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMyAdminProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.txtActiveS = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.dtpBdate = new System.Windows.Forms.DateTimePicker();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnUpdate = new CustomControls.RJControls.RJButton();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtConPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbActive);
            this.panel1.Controls.Add(this.txtActiveS);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.dtpBdate);
            this.panel1.Controls.Add(this.txtTele);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.txtUID);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblTele);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblNIC);
            this.panel1.Controls.Add(this.lblUID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 587);
            this.panel1.TabIndex = 5;
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(158, 464);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(200, 23);
            this.txtConPass.TabIndex = 53;
            this.txtConPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Retype Password:";
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cmbActive.Location = new System.Drawing.Point(158, 510);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(121, 23);
            this.cmbActive.TabIndex = 47;
            // 
            // txtActiveS
            // 
            this.txtActiveS.AutoSize = true;
            this.txtActiveS.BackColor = System.Drawing.Color.Transparent;
            this.txtActiveS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtActiveS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtActiveS.Location = new System.Drawing.Point(31, 510);
            this.txtActiveS.Name = "txtActiveS";
            this.txtActiveS.Size = new System.Drawing.Size(90, 17);
            this.txtActiveS.TabIndex = 46;
            this.txtActiveS.Text = "Active Status:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(160, 418);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 45;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // dtpBdate
            // 
            this.dtpBdate.Location = new System.Drawing.Point(159, 187);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(200, 23);
            this.dtpBdate.TabIndex = 44;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(160, 375);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(200, 23);
            this.txtTele.TabIndex = 43;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.cmbStatus.Location = new System.Drawing.Point(157, 235);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbStatus.TabIndex = 41;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(160, 330);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 23);
            this.cmbGender.TabIndex = 40;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(159, 136);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 23);
            this.txtAddress.TabIndex = 38;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(159, 89);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 23);
            this.txtFName.TabIndex = 37;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(158, 285);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(200, 23);
            this.txtNIC.TabIndex = 36;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(161, 40);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(200, 23);
            this.txtUID.TabIndex = 35;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPass.Location = new System.Drawing.Point(31, 419);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 34;
            this.lblPass.Text = "Password:";
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.BackColor = System.Drawing.Color.Transparent;
            this.lblTele.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTele.Location = new System.Drawing.Point(28, 381);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(73, 17);
            this.lblTele.TabIndex = 33;
            this.lblTele.Text = "Telephone:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(28, 331);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 32;
            this.lblGender.Text = "Gender:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(30, 236);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 17);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Marital Status:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDOB.Location = new System.Drawing.Point(30, 190);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 17);
            this.lblDOB.TabIndex = 28;
            this.lblDOB.Text = "BirthDate:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(30, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(30, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 17);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Full Name:";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.BackColor = System.Drawing.Color.Transparent;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNIC.Location = new System.Drawing.Point(29, 288);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(33, 17);
            this.lblNIC.TabIndex = 25;
            this.lblNIC.Text = "NIC:";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.BackColor = System.Drawing.Color.Transparent;
            this.lblUID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUID.Location = new System.Drawing.Point(32, 46);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(55, 17);
            this.lblUID.TabIndex = 24;
            this.lblUID.Text = "User ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Red;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(412, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(257, 51);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete My Account";
            this.btnDelete.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(412, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(257, 54);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(412, 234);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(257, 54);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hospital_Information_Management_System.Properties.Resources.avatar_default_icon32;
            this.pictureBox1.ErrorImage = global::Hospital_Information_Management_System.Properties.Resources.avatar_default_icon32;
            this.pictureBox1.Location = new System.Drawing.Point(488, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // viewMyAdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Name = "viewMyAdminProfile";
            this.Text = "viewMyAdminProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label txtActiveS;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DateTimePicker dtpBdate;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblUID;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnUpdate;
        private CustomControls.RJControls.RJButton btnEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}