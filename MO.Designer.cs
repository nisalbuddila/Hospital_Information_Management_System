
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAppTime = new System.Windows.Forms.TextBox();
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
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTodayApp);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 582);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(141)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.userImage);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 87);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblUserName);
            this.panel4.Controls.Add(this.lblArea);
            this.panel4.Location = new System.Drawing.Point(608, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 76);
            this.panel4.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(89, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 21);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(61, 38);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(118, 21);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Speciality Area";
            // 
            // userImage
            // 
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(807, 7);
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
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtAppTime);
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
            this.btnIncompleted.BackColor = System.Drawing.Color.LightCoral;
            this.btnIncompleted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncompleted.Location = new System.Drawing.Point(300, 403);
            this.btnIncompleted.Name = "btnIncompleted";
            this.btnIncompleted.Size = new System.Drawing.Size(103, 39);
            this.btnIncompleted.TabIndex = 3;
            this.btnIncompleted.Text = "Incompleted";
            this.btnIncompleted.UseVisualStyleBackColor = false;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleted.ForeColor = System.Drawing.Color.Black;
            this.btnCompleted.Location = new System.Drawing.Point(194, 403);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(103, 39);
            this.btnCompleted.TabIndex = 3;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(93, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 201);
            this.textBox1.TabIndex = 2;
            // 
            // txtAppTime
            // 
            this.txtAppTime.BackColor = System.Drawing.Color.White;
            this.txtAppTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppTime.Location = new System.Drawing.Point(93, 145);
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.Size = new System.Drawing.Size(310, 16);
            this.txtAppTime.TabIndex = 2;
            // 
            // txtNic
            // 
            this.txtNic.BackColor = System.Drawing.Color.White;
            this.txtNic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNic.Location = new System.Drawing.Point(93, 116);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(310, 16);
            this.txtNic.TabIndex = 2;
            // 
            // txtPatient
            // 
            this.txtPatient.BackColor = System.Drawing.Color.White;
            this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatient.Location = new System.Drawing.Point(93, 87);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(310, 16);
            this.txtPatient.TabIndex = 2;
            // 
            // txtAppNo
            // 
            this.txtAppNo.BackColor = System.Drawing.Color.White;
            this.txtAppNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppNo.Location = new System.Drawing.Point(93, 58);
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
            this.lblSymptoms.Location = new System.Drawing.Point(11, 175);
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
            this.lblNic.Location = new System.Drawing.Point(11, 116);
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
            this.lblPname.Location = new System.Drawing.Point(11, 87);
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
            this.lblAppNo.Location = new System.Drawing.Point(11, 58);
            this.lblAppNo.Name = "lblAppNo";
            this.lblAppNo.Size = new System.Drawing.Size(58, 17);
            this.lblAppNo.TabIndex = 1;
            this.lblAppNo.Text = "App. No";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}