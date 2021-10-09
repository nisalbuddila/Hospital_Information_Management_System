
namespace Hospital_Information_Management_System
{
    partial class MO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTodayApp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIncompleted = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtAppNo = new System.Windows.Forms.TextBox();
            this.lblAppTime = new System.Windows.Forms.Label();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblAppNo = new System.Windows.Forms.Label();
            this.lblVbox = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewAppointments);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTodayApp);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 582);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(5, 166);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowTemplate.Height = 25;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(454, 402);
            this.dataGridViewAppointments.TabIndex = 4;
            this.dataGridViewAppointments.SelectionChanged += new System.EventHandler(this.dataGridViewAppointments_SelectionChanged);
            this.dataGridViewAppointments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAppointments_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(141)))));
            this.panel3.Controls.Add(this.btnProfile);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.userImage);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 87);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Location = new System.Drawing.Point(869, 72);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(20, 18);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUname);
            this.panel4.Location = new System.Drawing.Point(605, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 76);
            this.panel4.TabIndex = 3;
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(141)))));
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUname.ForeColor = System.Drawing.Color.White;
            this.txtUname.Location = new System.Drawing.Point(43, 22);
            this.txtUname.Name = "txtUname";
            this.txtUname.ReadOnly = true;
            this.txtUname.Size = new System.Drawing.Size(144, 26);
            this.txtUname.TabIndex = 5;
            this.txtUname.Text = "User Name";
            this.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // userImage
            // 
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(804, 7);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(74, 77);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 1;
            this.userImage.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(141)))));
            this.btnHome.Location = new System.Drawing.Point(12, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(37, 39);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTodayApp
            // 
            this.lblTodayApp.AutoSize = true;
            this.lblTodayApp.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTodayApp.Location = new System.Drawing.Point(113, 107);
            this.lblTodayApp.Name = "lblTodayApp";
            this.lblTodayApp.Size = new System.Drawing.Size(227, 25);
            this.lblTodayApp.TabIndex = 2;
            this.lblTodayApp.Text = "TODAY APPOINTMENTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(463, 433);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "App No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Patient Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Patient NIC";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Symptoms";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "App Time";
            this.Column5.Name = "Column5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.btnIncompleted);
            this.panel2.Controls.Add(this.btnCompleted);
            this.panel2.Controls.Add(this.txtSymptoms);
            this.panel2.Controls.Add(this.txtNic);
            this.panel2.Controls.Add(this.txtPatient);
            this.panel2.Controls.Add(this.txtAppNo);
            this.panel2.Controls.Add(this.lblAppTime);
            this.panel2.Controls.Add(this.lblSymptoms);
            this.panel2.Controls.Add(this.lblNic);
            this.panel2.Controls.Add(this.lblPname);
            this.panel2.Controls.Add(this.lblAppNo);
            this.panel2.Controls.Add(this.lblVbox);
            this.panel2.Location = new System.Drawing.Point(469, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 485);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnIncompleted
            // 
            this.btnIncompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIncompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncompleted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncompleted.Location = new System.Drawing.Point(300, 421);
            this.btnIncompleted.Name = "btnIncompleted";
            this.btnIncompleted.Size = new System.Drawing.Size(103, 39);
            this.btnIncompleted.TabIndex = 3;
            this.btnIncompleted.Text = "Incompleted";
            this.btnIncompleted.UseVisualStyleBackColor = false;
            this.btnIncompleted.Click += new System.EventHandler(this.btnIncompleted_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Lime;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleted.ForeColor = System.Drawing.Color.Black;
            this.btnCompleted.Location = new System.Drawing.Point(194, 421);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(103, 39);
            this.btnCompleted.TabIndex = 3;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.BackColor = System.Drawing.Color.White;
            this.txtSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymptoms.Location = new System.Drawing.Point(99, 168);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(310, 201);
            this.txtSymptoms.TabIndex = 2;
            // 
            // txtNic
            // 
            this.txtNic.BackColor = System.Drawing.Color.White;
            this.txtNic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNic.Location = new System.Drawing.Point(99, 127);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(310, 16);
            this.txtNic.TabIndex = 2;
            // 
            // txtPatient
            // 
            this.txtPatient.BackColor = System.Drawing.Color.White;
            this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatient.Location = new System.Drawing.Point(99, 93);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(310, 16);
            this.txtPatient.TabIndex = 2;
            // 
            // txtAppNo
            // 
            this.txtAppNo.BackColor = System.Drawing.Color.White;
            this.txtAppNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppNo.Location = new System.Drawing.Point(99, 59);
            this.txtAppNo.Name = "txtAppNo";
            this.txtAppNo.Size = new System.Drawing.Size(310, 16);
            this.txtAppNo.TabIndex = 2;
            // 
            // lblAppTime
            // 
            this.lblAppTime.AutoSize = true;
            this.lblAppTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAppTime.Location = new System.Drawing.Point(11, 145);
            this.lblAppTime.Name = "lblAppTime";
            this.lblAppTime.Size = new System.Drawing.Size(69, 17);
            this.lblAppTime.TabIndex = 1;
            this.lblAppTime.Text = "App. Time";
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSymptoms.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSymptoms.Location = new System.Drawing.Point(3, 168);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(73, 17);
            this.lblSymptoms.TabIndex = 1;
            this.lblSymptoms.Text = "Symptoms";
            this.lblSymptoms.Click += new System.EventHandler(this.lblSymptoms_Click);
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNic.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNic.Location = new System.Drawing.Point(3, 127);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(30, 17);
            this.lblNic.TabIndex = 1;
            this.lblNic.Text = "NIC";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPname.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPname.Location = new System.Drawing.Point(3, 93);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(51, 17);
            this.lblPname.TabIndex = 1;
            this.lblPname.Text = "Patient";
            // 
            // lblAppNo
            // 
            this.lblAppNo.AutoSize = true;
            this.lblAppNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAppNo.Location = new System.Drawing.Point(3, 52);
            this.lblAppNo.Name = "lblAppNo";
            this.lblAppNo.Size = new System.Drawing.Size(93, 34);
            this.lblAppNo.TabIndex = 1;
            this.lblAppNo.Text = "Appointment \r\nNo";
            // 
            // lblVbox
            // 
            this.lblVbox.AutoSize = true;
            this.lblVbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblVbox.Location = new System.Drawing.Point(194, 12);
            this.lblVbox.Name = "lblVbox";
            this.lblVbox.Size = new System.Drawing.Size(124, 25);
            this.lblVbox.TabIndex = 0;
            this.lblVbox.Text = "Viewing Box";
            // 
            // MO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 581);
            this.Controls.Add(this.panel1);
            this.Name = "MO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAppTime;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblAppNo;
        private System.Windows.Forms.Label lblVbox;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtAppNo;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Button btnIncompleted;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTodayApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.TextBox txtUname;
    }
}