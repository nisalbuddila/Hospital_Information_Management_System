
namespace Hospital_Information_Management_System
{
    partial class frmViewPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPatients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.dtpBdate = new System.Windows.Forms.DateTimePicker();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAlergy = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblalergy = new System.Windows.Forms.Label();
            this.lblBlood = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.txtActiveS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.cmbActive);
            this.panel1.Controls.Add(this.txtActiveS);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.dtpBdate);
            this.panel1.Controls.Add(this.txtTele);
            this.panel1.Controls.Add(this.cmbBlood);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.txtAlergy);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.txtUID);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblTele);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblalergy);
            this.panel1.Controls.Add(this.lblBlood);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblNIC);
            this.panel1.Controls.Add(this.lblUID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 654);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(161, 567);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 45;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // dtpBdate
            // 
            this.dtpBdate.Location = new System.Drawing.Point(159, 230);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(200, 23);
            this.dtpBdate.TabIndex = 44;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(161, 520);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(200, 23);
            this.txtTele.TabIndex = 43;
            // 
            // cmbBlood
            // 
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "Ab-"});
            this.cmbBlood.Location = new System.Drawing.Point(159, 319);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(121, 23);
            this.cmbBlood.TabIndex = 42;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.cmbStatus.Location = new System.Drawing.Point(159, 275);
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
            this.cmbGender.Location = new System.Drawing.Point(161, 470);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 23);
            this.cmbGender.TabIndex = 40;
            // 
            // txtAlergy
            // 
            this.txtAlergy.Location = new System.Drawing.Point(161, 420);
            this.txtAlergy.Name = "txtAlergy";
            this.txtAlergy.Size = new System.Drawing.Size(200, 23);
            this.txtAlergy.TabIndex = 39;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(159, 179);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 23);
            this.txtAddress.TabIndex = 38;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(159, 132);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 23);
            this.txtFName.TabIndex = 37;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(161, 376);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(200, 23);
            this.txtNIC.TabIndex = 36;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(161, 83);
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
            this.lblPass.Location = new System.Drawing.Point(34, 567);
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
            this.lblTele.Location = new System.Drawing.Point(32, 523);
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
            this.lblGender.Location = new System.Drawing.Point(34, 470);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 32;
            this.lblGender.Text = "Gender:";
            // 
            // lblalergy
            // 
            this.lblalergy.AutoSize = true;
            this.lblalergy.BackColor = System.Drawing.Color.Transparent;
            this.lblalergy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblalergy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblalergy.Location = new System.Drawing.Point(32, 423);
            this.lblalergy.Name = "lblalergy";
            this.lblalergy.Size = new System.Drawing.Size(104, 17);
            this.lblalergy.TabIndex = 31;
            this.lblalergy.Text = "Alergies [if any]:";
            // 
            // lblBlood
            // 
            this.lblBlood.AutoSize = true;
            this.lblBlood.BackColor = System.Drawing.Color.Transparent;
            this.lblBlood.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBlood.Location = new System.Drawing.Point(32, 330);
            this.lblBlood.Name = "lblBlood";
            this.lblBlood.Size = new System.Drawing.Size(88, 17);
            this.lblBlood.TabIndex = 30;
            this.lblBlood.Text = "Blood Group:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(32, 286);
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
            this.lblDOB.Location = new System.Drawing.Point(30, 233);
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
            this.lblAddress.Location = new System.Drawing.Point(30, 182);
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
            this.lblName.Location = new System.Drawing.Point(30, 138);
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
            this.lblNIC.Location = new System.Drawing.Point(32, 379);
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
            this.lblUID.Location = new System.Drawing.Point(32, 89);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(55, 17);
            this.lblUID.TabIndex = 24;
            this.lblUID.Text = "User ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(370, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(637, 654);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cmbActive.Location = new System.Drawing.Point(161, 617);
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
            this.txtActiveS.Location = new System.Drawing.Point(34, 617);
            this.txtActiveS.Name = "txtActiveS";
            this.txtActiveS.Size = new System.Drawing.Size(90, 17);
            this.txtActiveS.TabIndex = 46;
            this.txtActiveS.Text = "Active Status:";
            // 
            // frmViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewPatients";
            this.Text = "frmViewPatients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DateTimePicker dtpBdate;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAlergy;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblalergy;
        private System.Windows.Forms.Label lblBlood;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label txtActiveS;
    }
}