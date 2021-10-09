
namespace Hospital_Information_Management_System
{
    partial class frmViewReception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewReception));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.btnUpdate = new CustomControls.RJControls.RJButton();
            this.btnEdit = new CustomControls.RJControls.RJButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStaffid = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(423, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(602, 932);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(182, 749);
            this.txtConPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(228, 27);
            this.txtConPass.TabIndex = 53;
            this.txtConPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 751);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Retype Password:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Snow;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.Location = new System.Drawing.Point(311, 892);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.DimGray;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Snow;
            this.btnClear.BackgroundColor = System.Drawing.Color.Snow;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(213, 892);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 33);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.DimGray;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(114, 892);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
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
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(16, 892);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 33);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cmbActive.Location = new System.Drawing.Point(182, 811);
            this.cmbActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(138, 28);
            this.cmbActive.TabIndex = 47;
            // 
            // txtActiveS
            // 
            this.txtActiveS.AutoSize = true;
            this.txtActiveS.BackColor = System.Drawing.Color.Transparent;
            this.txtActiveS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtActiveS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtActiveS.Location = new System.Drawing.Point(37, 811);
            this.txtActiveS.Name = "txtActiveS";
            this.txtActiveS.Size = new System.Drawing.Size(113, 23);
            this.txtActiveS.TabIndex = 46;
            this.txtActiveS.Text = "Active Status:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(184, 688);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(228, 27);
            this.txtPass.TabIndex = 45;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // dtpBdate
            // 
            this.dtpBdate.Location = new System.Drawing.Point(182, 272);
            this.dtpBdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(228, 27);
            this.dtpBdate.TabIndex = 44;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(184, 631);
            this.txtTele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(228, 27);
            this.txtTele.TabIndex = 43;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.cmbStatus.Location = new System.Drawing.Point(179, 336);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(138, 28);
            this.cmbStatus.TabIndex = 41;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(184, 571);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(228, 28);
            this.cmbGender.TabIndex = 40;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(182, 204);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 27);
            this.txtAddress.TabIndex = 38;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(182, 141);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(228, 27);
            this.txtFName.TabIndex = 37;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(182, 511);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(228, 27);
            this.txtNIC.TabIndex = 36;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(184, 76);
            this.txtUID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(228, 27);
            this.txtUID.TabIndex = 35;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPass.Location = new System.Drawing.Point(37, 689);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 23);
            this.lblPass.TabIndex = 34;
            this.lblPass.Text = "Password:";
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.BackColor = System.Drawing.Color.Transparent;
            this.lblTele.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTele.Location = new System.Drawing.Point(33, 639);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(92, 23);
            this.lblTele.TabIndex = 33;
            this.lblTele.Text = "Telephone:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(33, 572);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 23);
            this.lblGender.TabIndex = 32;
            this.lblGender.Text = "Gender:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(34, 337);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 23);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Marital Status:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDOB.Location = new System.Drawing.Point(34, 276);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(86, 23);
            this.lblDOB.TabIndex = 28;
            this.lblDOB.Text = "BirthDate:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(34, 208);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 23);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(34, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 23);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Full Name:";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.BackColor = System.Drawing.Color.Transparent;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNIC.Location = new System.Drawing.Point(34, 515);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(43, 23);
            this.lblNIC.TabIndex = 25;
            this.lblNIC.Text = "NIC:";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.BackColor = System.Drawing.Color.Transparent;
            this.lblUID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUID.Location = new System.Drawing.Point(37, 84);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(70, 23);
            this.lblUID.TabIndex = 24;
            this.lblUID.Text = "User ID:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtStaffid);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblStaffID);
            this.panel1.Controls.Add(this.txtConPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnEdit);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 932);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 449);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 57;
            // 
            // txtStaffid
            // 
            this.txtStaffid.Location = new System.Drawing.Point(182, 393);
            this.txtStaffid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStaffid.Name = "txtStaffid";
            this.txtStaffid.Size = new System.Drawing.Size(228, 27);
            this.txtStaffid.TabIndex = 56;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(37, 451);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStaffID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaffID.Location = new System.Drawing.Point(37, 393);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(69, 23);
            this.lblStaffID.TabIndex = 54;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // frmViewReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 932);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmViewReception";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewReception";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnClear;
        private CustomControls.RJControls.RJButton btnUpdate;
        private CustomControls.RJControls.RJButton btnEdit;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStaffid;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStaffID;
    }
}