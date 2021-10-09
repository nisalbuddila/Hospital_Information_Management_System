
namespace Hospital_Information_Management_System
{
    partial class frmViewAddComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAddComplaints));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtComTy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhnNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(203, 35);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(125, 27);
            this.txtUid.TabIndex = 1;
            // 
            // txtComTy
            // 
            this.txtComTy.Location = new System.Drawing.Point(203, 87);
            this.txtComTy.Name = "txtComTy";
            this.txtComTy.Size = new System.Drawing.Size(125, 27);
            this.txtComTy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "COMPLAINT TYPE";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(203, 242);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(125, 27);
            this.txtDe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DESCRIPTION";
            // 
            // btnCadd
            // 
            this.btnCadd.Location = new System.Drawing.Point(150, 505);
            this.btnCadd.Name = "btnCadd";
            this.btnCadd.Size = new System.Drawing.Size(94, 29);
            this.btnCadd.TabIndex = 16;
            this.btnCadd.Text = "ADD";
            this.btnCadd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(528, 494);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(203, 304);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(125, 27);
            this.txtNote.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "NOTE";
            // 
            // txtPhnNo
            // 
            this.txtPhnNo.Location = new System.Drawing.Point(203, 140);
            this.txtPhnNo.Name = "txtPhnNo";
            this.txtPhnNo.Size = new System.Drawing.Size(125, 27);
            this.txtPhnNo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "DATE";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(203, 189);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(125, 27);
            this.txtDate.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "PHONE NUMBER";
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(203, 404);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(125, 27);
            this.txtNic.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "NIC";
            // 
            // txtComBy
            // 
            this.txtComBy.Location = new System.Drawing.Point(203, 352);
            this.txtComBy.Name = "txtComBy";
            this.txtComBy.Size = new System.Drawing.Size(125, 27);
            this.txtComBy.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "COMPLAINT BY";
            // 
            // frmViewAddComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 577);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhnNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadd);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComTy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.Name = "frmViewAddComplaints";
            this.Text = "frmViewAddComplaints";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtComTy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhnNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComBy;
        private System.Windows.Forms.Label label8;
    }
}