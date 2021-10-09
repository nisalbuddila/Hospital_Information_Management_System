
namespace Hospital_Information_Management_System
{
    partial class MOuserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOuserDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userImage2 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMaritalState = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.lblDoj = new System.Windows.Forms.Label();
            this.txtDoj = new System.Windows.Forms.TextBox();
            this.lblOfficialDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOldPassward = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.textOldPassward = new System.Windows.Forms.TextBox();
            this.txtNewPassward = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbMaritalState = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 606);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.userImage2);
            this.panel2.Controls.Add(this.lblPersonal);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 610);
            this.panel2.TabIndex = 0;
            // 
            // userImage2
            // 
            this.userImage2.Image = ((System.Drawing.Image)(resources.GetObject("userImage2.Image")));
            this.userImage2.Location = new System.Drawing.Point(3, 81);
            this.userImage2.Name = "userImage2";
            this.userImage2.Size = new System.Drawing.Size(183, 178);
            this.userImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage2.TabIndex = 2;
            this.userImage2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(47, 556);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.dateDob);
            this.panel3.Controls.Add(this.cmbMaritalState);
            this.panel3.Controls.Add(this.cmbGender);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDoj);
            this.panel3.Controls.Add(this.txtStaffEmail);
            this.panel3.Controls.Add(this.txtConfirm);
            this.panel3.Controls.Add(this.txtNewPassward);
            this.panel3.Controls.Add(this.textOldPassward);
            this.panel3.Controls.Add(this.txtStaffId);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.txtNic);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.lblDob);
            this.panel3.Controls.Add(this.lblConfirm);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblOldPassward);
            this.panel3.Controls.Add(this.lblDoj);
            this.panel3.Controls.Add(this.lblStaffEmail);
            this.panel3.Controls.Add(this.lblMaritalState);
            this.panel3.Controls.Add(this.lblStaffId);
            this.panel3.Controls.Add(this.lblPhone);
            this.panel3.Controls.Add(this.lblGender);
            this.panel3.Controls.Add(this.lblNic);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblOfficialDetails);
            this.panel3.Location = new System.Drawing.Point(211, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 609);
            this.panel3.TabIndex = 1;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPersonal.ForeColor = System.Drawing.Color.White;
            this.lblPersonal.Location = new System.Drawing.Point(47, 29);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(86, 25);
            this.lblPersonal.TabIndex = 0;
            this.lblPersonal.Text = "Persanal";
            this.lblPersonal.Click += new System.EventHandler(this.lblPersonal_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(10, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNic.Location = new System.Drawing.Point(10, 60);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(30, 17);
            this.lblNic.TabIndex = 0;
            this.lblNic.Text = "NIC";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(13, 148);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 17);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(10, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 17);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblMaritalState
            // 
            this.lblMaritalState.AutoSize = true;
            this.lblMaritalState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaritalState.Location = new System.Drawing.Point(12, 185);
            this.lblMaritalState.Name = "lblMaritalState";
            this.lblMaritalState.Size = new System.Drawing.Size(85, 17);
            this.lblMaritalState.TabIndex = 0;
            this.lblMaritalState.Text = "Marital State";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDob.Location = new System.Drawing.Point(12, 119);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(35, 17);
            this.lblDob.TabIndex = 0;
            this.lblDob.Text = "DOB";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(111, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 16);
            this.txtName.TabIndex = 1;
            // 
            // txtNic
            // 
            this.txtNic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNic.Location = new System.Drawing.Point(111, 60);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(289, 16);
            this.txtNic.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(111, 91);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(289, 16);
            this.txtPhone.TabIndex = 1;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaffId.Location = new System.Drawing.Point(10, 279);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(47, 17);
            this.lblStaffId.TabIndex = 0;
            this.lblStaffId.Text = "StaffId";
            // 
            // txtStaffId
            // 
            this.txtStaffId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffId.Location = new System.Drawing.Point(111, 279);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(289, 16);
            this.txtStaffId.TabIndex = 1;
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaffEmail.Location = new System.Drawing.Point(10, 312);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(71, 17);
            this.lblStaffEmail.TabIndex = 0;
            this.lblStaffEmail.Text = "Staff Email";
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffEmail.Location = new System.Drawing.Point(111, 312);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(289, 16);
            this.txtStaffEmail.TabIndex = 1;
            // 
            // lblDoj
            // 
            this.lblDoj.AutoSize = true;
            this.lblDoj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoj.Location = new System.Drawing.Point(10, 351);
            this.lblDoj.Name = "lblDoj";
            this.lblDoj.Size = new System.Drawing.Size(80, 17);
            this.lblDoj.TabIndex = 0;
            this.lblDoj.Text = "Date of Join";
            // 
            // txtDoj
            // 
            this.txtDoj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoj.Location = new System.Drawing.Point(111, 351);
            this.txtDoj.Name = "txtDoj";
            this.txtDoj.Size = new System.Drawing.Size(289, 16);
            this.txtDoj.TabIndex = 1;
            // 
            // lblOfficialDetails
            // 
            this.lblOfficialDetails.AutoSize = true;
            this.lblOfficialDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblOfficialDetails.Location = new System.Drawing.Point(10, 246);
            this.lblOfficialDetails.Name = "lblOfficialDetails";
            this.lblOfficialDetails.Size = new System.Drawing.Size(107, 20);
            this.lblOfficialDetails.TabIndex = 0;
            this.lblOfficialDetails.Text = "Official Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Your Passward";
            // 
            // lblOldPassward
            // 
            this.lblOldPassward.AutoSize = true;
            this.lblOldPassward.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOldPassward.Location = new System.Drawing.Point(12, 434);
            this.lblOldPassward.Name = "lblOldPassward";
            this.lblOldPassward.Size = new System.Drawing.Size(91, 17);
            this.lblOldPassward.TabIndex = 0;
            this.lblOldPassward.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.Location = new System.Drawing.Point(12, 493);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(118, 17);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // textOldPassward
            // 
            this.textOldPassward.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOldPassward.Location = new System.Drawing.Point(140, 434);
            this.textOldPassward.Name = "textOldPassward";
            this.textOldPassward.Size = new System.Drawing.Size(132, 16);
            this.textOldPassward.TabIndex = 1;
            // 
            // txtNewPassward
            // 
            this.txtNewPassward.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassward.Location = new System.Drawing.Point(140, 463);
            this.txtNewPassward.Name = "txtNewPassward";
            this.txtNewPassward.Size = new System.Drawing.Size(132, 16);
            this.txtNewPassward.TabIndex = 1;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Location = new System.Drawing.Point(140, 493);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(132, 16);
            this.txtConfirm.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(293, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // cmbGender
            // 
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(110, 148);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(128, 23);
            this.cmbGender.TabIndex = 4;
            // 
            // cmbMaritalState
            // 
            this.cmbMaritalState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMaritalState.FormattingEnabled = true;
            this.cmbMaritalState.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbMaritalState.Location = new System.Drawing.Point(111, 185);
            this.cmbMaritalState.Name = "cmbMaritalState";
            this.cmbMaritalState.Size = new System.Drawing.Size(128, 23);
            this.cmbMaritalState.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(24, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Upload Your Photo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateDob
            // 
            this.dateDob.CustomFormat = "22/09/2021";
            this.dateDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDob.Location = new System.Drawing.Point(110, 119);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(128, 23);
            this.dateDob.TabIndex = 5;
            // 
            // MOuserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 605);
            this.Controls.Add(this.panel1);
            this.Name = "MOuserDetails";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox userImage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoj;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtNewPassward;
        private System.Windows.Forms.TextBox textOldPassward;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOldPassward;
        private System.Windows.Forms.Label lblDoj;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.Label lblMaritalState;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOfficialDetails;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.ComboBox cmbMaritalState;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateDob;
    }
}