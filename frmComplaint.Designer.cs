
namespace Hospital_Information_Management_System
{
    partial class frmComplaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblComplaintby = new System.Windows.Forms.Label();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.lblPhno = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblActiontaken = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtComplaintby = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.txtPhnno = new System.Windows.Forms.TextBox();
            this.txtActiontaken = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 151);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txtAttachment);
            this.panel2.Controls.Add(this.txtDiscription);
            this.panel2.Controls.Add(this.txtComplaintby);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.lblAttachment);
            this.panel2.Controls.Add(this.lblDiscription);
            this.panel2.Controls.Add(this.lblComplaintby);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Location = new System.Drawing.Point(-2, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 344);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.txtActiontaken);
            this.panel3.Controls.Add(this.txtPhnno);
            this.panel3.Controls.Add(this.lblActiontaken);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblPhno);
            this.panel3.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(396, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 344);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Location = new System.Drawing.Point(1, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 82);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Information_Management_System.Properties.Resources.Complaint100x100;
            this.pictureBox1.Location = new System.Drawing.Point(336, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(339, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complaints Box";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblType.Location = new System.Drawing.Point(30, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 28);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // lblComplaintby
            // 
            this.lblComplaintby.AutoSize = true;
            this.lblComplaintby.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintby.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComplaintby.Location = new System.Drawing.Point(30, 110);
            this.lblComplaintby.Name = "lblComplaintby";
            this.lblComplaintby.Size = new System.Drawing.Size(119, 28);
            this.lblComplaintby.TabIndex = 1;
            this.lblComplaintby.Text = "Complaint By";
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDiscription.Location = new System.Drawing.Point(30, 190);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(96, 28);
            this.lblDiscription.TabIndex = 2;
            this.lblDiscription.Text = "Discription";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAttachment.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAttachment.Location = new System.Drawing.Point(30, 270);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(164, 28);
            this.lblAttachment.TabIndex = 3;
            this.lblAttachment.Text = "Attachment(if any)";
            // 
            // lblPhno
            // 
            this.lblPhno.AutoSize = true;
            this.lblPhno.Location = new System.Drawing.Point(38, 30);
            this.lblPhno.Name = "lblPhno";
            this.lblPhno.Size = new System.Drawing.Size(129, 28);
            this.lblPhno.TabIndex = 2;
            this.lblPhno.Text = "Phone Number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(38, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 28);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblActiontaken
            // 
            this.lblActiontaken.AutoSize = true;
            this.lblActiontaken.Location = new System.Drawing.Point(38, 190);
            this.lblActiontaken.Name = "lblActiontaken";
            this.lblActiontaken.Size = new System.Drawing.Size(109, 28);
            this.lblActiontaken.TabIndex = 4;
            this.lblActiontaken.Text = "ActionTaken";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtType.Location = new System.Drawing.Point(30, 61);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(344, 23);
            this.txtType.TabIndex = 4;
            // 
            // txtComplaintby
            // 
            this.txtComplaintby.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtComplaintby.Location = new System.Drawing.Point(30, 141);
            this.txtComplaintby.Name = "txtComplaintby";
            this.txtComplaintby.Size = new System.Drawing.Size(344, 23);
            this.txtComplaintby.TabIndex = 5;
            // 
            // txtDiscription
            // 
            this.txtDiscription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDiscription.Location = new System.Drawing.Point(30, 221);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(344, 23);
            this.txtDiscription.TabIndex = 6;
            // 
            // txtAttachment
            // 
            this.txtAttachment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAttachment.Location = new System.Drawing.Point(30, 301);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(344, 23);
            this.txtAttachment.TabIndex = 7;
            // 
            // txtPhnno
            // 
            this.txtPhnno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPhnno.Location = new System.Drawing.Point(38, 61);
            this.txtPhnno.Name = "txtPhnno";
            this.txtPhnno.Size = new System.Drawing.Size(344, 31);
            this.txtPhnno.TabIndex = 5;
            // 
            // txtActiontaken
            // 
            this.txtActiontaken.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtActiontaken.Location = new System.Drawing.Point(38, 221);
            this.txtActiontaken.Name = "txtActiontaken";
            this.txtActiontaken.Size = new System.Drawing.Size(344, 31);
            this.txtActiontaken.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnadd.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnadd.Location = new System.Drawing.Point(27, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 40);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(250, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmit.Location = new System.Drawing.Point(466, 24);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(681, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // frmComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmComplaint";
            this.Text = "frmComplaint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Label lblComplaintby;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblActiontaken;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPhno;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtComplaintby;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtActiontaken;
        private System.Windows.Forms.TextBox txtPhnno;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}