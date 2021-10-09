
namespace Hospital_Information_Management_System
{
    partial class frmViewAddAppoinments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAddAppoinments));
            this.txtAppoDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatiName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsymptoms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediOfficer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAppoDate
            // 
            this.txtAppoDate.Location = new System.Drawing.Point(187, 180);
            this.txtAppoDate.Name = "txtAppoDate";
            this.txtAppoDate.Size = new System.Drawing.Size(125, 27);
            this.txtAppoDate.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "APPOINMENT DATE";
            // 
            // txtPatiName
            // 
            this.txtPatiName.Location = new System.Drawing.Point(187, 114);
            this.txtPatiName.Name = "txtPatiName";
            this.txtPatiName.Size = new System.Drawing.Size(125, 27);
            this.txtPatiName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "PATIANT NAME";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(187, 43);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(125, 27);
            this.txtUid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "User ID";
            // 
            // btnAadd
            // 
            this.btnAadd.Location = new System.Drawing.Point(154, 452);
            this.btnAadd.Name = "btnAadd";
            this.btnAadd.Size = new System.Drawing.Size(113, 51);
            this.btnAadd.TabIndex = 32;
            this.btnAadd.Text = "Add";
            this.btnAadd.UseVisualStyleBackColor = true;
            this.btnAadd.Click += new System.EventHandler(this.btnAadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 488);
            this.dataGridView1.TabIndex = 33;
            // 
            // txtsymptoms
            // 
            this.txtsymptoms.Location = new System.Drawing.Point(187, 318);
            this.txtsymptoms.Name = "txtsymptoms";
            this.txtsymptoms.Size = new System.Drawing.Size(125, 27);
            this.txtsymptoms.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "SYMPTOMS";
            // 
            // txtMediOfficer
            // 
            this.txtMediOfficer.Location = new System.Drawing.Point(187, 237);
            this.txtMediOfficer.Name = "txtMediOfficer";
            this.txtMediOfficer.Size = new System.Drawing.Size(125, 27);
            this.txtMediOfficer.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Medical Officer";
            // 
            // frmViewAddAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1022, 581);
            this.Controls.Add(this.txtsymptoms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediOfficer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAadd);
            this.Controls.Add(this.txtAppoDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatiName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.Name = "frmViewAddAppoinments";
            this.Text = "frmViewAddAppoinments";
            this.Load += new System.EventHandler(this.frmViewAddAppoinments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatiName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAppoDate;
        private System.Windows.Forms.TextBox txtsymptoms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMediOfficer;
        private System.Windows.Forms.Label label5;
    }
}