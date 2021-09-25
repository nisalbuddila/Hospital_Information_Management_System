using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using encryptDecrypt.BLL;
using encryptDecrypt.Model;


namespace Hospital_Information_Management_System
{
    public partial class frmRegister : Form
    {
        SqlCommand cmd;
        CryptoLab_BLL _cryptoLab_Bll = new CryptoLab_BLL();

        public frmRegister()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbType.SelectedItem.ToString() == "Admin" || cmbType.SelectedItem.ToString() == "Medical Officer" || cmbType.SelectedItem.ToString() == "Receptionist")
            {
                panel1.Show();
                txtAlergy.Hide();
                cmbBlood.Hide();
            }
            else
            {
                panel1.Hide();
                txtAlergy.Show();
                cmbBlood.Show();
            }
        }

        public void clearData()
        {
            txtAddress.Clear();
            txtAlergy.Clear();
            txtConPass.Clear();
            txtFName.Clear();
            txtNIC.Clear();
            txtPass.Clear();
            txtTele.Clear();
            txtUID.Clear();
            cmbBlood.Text = "--Select an Option--";
            cmbGender.Text = "--Select an Option--";
            cmbStatus.Text = "--Select an Option--";
            cmbType.Text = "--Select an Option--";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            clearData();

        }

        //Encrypting the password
        public string TextEncrypt()
        {
            try
            {
                CryptoLab _cryptoLab = new CryptoLab();

                if (string.IsNullOrEmpty(txtConPass.Text))

                {
                    _cryptoLab.encryptText = "N/A";
                }
                else
                {
                    _cryptoLab.encryptText = txtConPass.Text.Trim();
                }

                _cryptoLab.method = "TripleDES";

                return _cryptoLab_Bll.EncryptText(_cryptoLab);
            }
            catch (Exception)
            {
                throw;
            }
        }
        


        private void btnSave_Click(object sender, EventArgs e)
        {
            connectionDB cDB = new connectionDB();
            SqlConnection SC = new SqlConnection();
            SC = cDB.connectDB();
            SC.Open();

            //cmbType.SelectedItem.ToString() == "Receptionist"
            if (cmbType.SelectedItem.ToString() == "Admin")
            {
                try
                {
                    if (txtUID.Text != "" && txtNIC.Text != "" && cmbType.Text != "--Select an Option--" && cmbStatus.Text != "--Select an Option--"  && txtConPass.Text != "")
                    {
                        if (txtPass.Text == txtConPass.Text)
                        {

                            SqlCommand cmdd = new SqlCommand("SELECT [U_ID],[NIC] FROM [HMS].[dbo].[ADMIN] WHERE NIC ='" + txtNIC.Text + "' OR U_ID ='" + txtUID.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmdd.ExecuteReader();
                            if (sddr.Read())
                            {
                                MessageBox.Show("This user is already existing!");
                                SC.Close();
                                SC.Open();
                            }
                            else
                            {
                                SC.Close();
                                SC.Open();
                                cmd = new SqlCommand("insert into [HMS].[dbo].[ADMIN](U_ID,NIC,NAME,ADDRESS,DOB,DO_REG,MARITAL_STATUS,PASSWORD,Telephone,Gender) values(@U_ID, @NIC , @Full_Name,@Address,@dob,@do_reg,@M_Status,@Password,@Tele,@Gender)", SC);
                                cmd.Parameters.AddWithValue("@Full_Name", txtFName.Text);
                                cmd.Parameters.AddWithValue("@U_ID", txtUID.Text);
                                cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                                cmd.Parameters.AddWithValue("@U_Type", cmbType.Text);
                                cmd.Parameters.AddWithValue("@Password", txtConPass.Text = TextEncrypt());
                                cmd.Parameters.AddWithValue("@M_Status", cmbStatus.Text);
                                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@Tele", txtTele.Text);
                                cmd.Parameters.AddWithValue("@dob", dtpBdate.Text);
                                cmd.Parameters.AddWithValue("@doj", dtpDOJ.Text);

                              
                                //selecting today date
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@do_reg", today.ToString());
                                cmd.ExecuteNonQuery();
                                SC.Close();
                                MessageBox.Show("Record Inserted Successfully");
                                clearData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords Doesn't match", "Please try again!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }
                }
                catch (System.Data.SqlClient.SqlException error1)
                {
                    MessageBox.Show("one or more field exceed the length!");
                }
            }
            else if(cmbType.SelectedItem.ToString() == "Medical Officer")
            {
                try
                {
                    if (txtUID.Text != "" && txtNIC.Text != "" && cmbType.Text != "--Select an Option--" && cmbStatus.Text != "--Select an Option--" && txtConPass.Text != "")
                    {
                        if (txtPass.Text == txtConPass.Text)
                        {

                            SqlCommand cmdd = new SqlCommand("SELECT [U_ID],[NIC] FROM [HMS].[dbo].[MEDICLE_OFFICER] WHERE NIC ='" + txtNIC.Text + "' OR U_ID ='" + txtUID.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmdd.ExecuteReader();
                            if (sddr.Read())
                            {
                                MessageBox.Show("This user is already existing!");
                                SC.Close();
                                SC.Open();
                            }
                            else
                            {
                                SC.Close();
                                SC.Open();
                                cmd = new SqlCommand("insert into [HMS].[dbo].[MEDICLE_OFFICER](U_ID,NIC,STAFF_ID,NAME,ADDRESS,DOB,DO_REG,MARITAL_STATUS,PASSWORD,SPECIAL,EMAIL,DOJ,Telephone,Gender,TYPE,STATUS) values(@U_ID, @NIC ,@staffID, @Full_Name,@Address,@dob,@do_reg,@M_Status,@Password,'GENARAL',@email,@doj,@Tele,@Gender,'Medical Officer','Active')", SC);
                                cmd.Parameters.AddWithValue("@Full_Name", txtFName.Text);
                                cmd.Parameters.AddWithValue("@U_ID", txtUID.Text);
                                cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                                cmd.Parameters.AddWithValue("@U_Type", cmbType.Text);
                                cmd.Parameters.AddWithValue("@Password", txtConPass.Text);
                                cmd.Parameters.AddWithValue("@M_Status", cmbStatus.Text);
                                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@Tele", txtTele.Text);
                                cmd.Parameters.AddWithValue("@dob", dtpBdate.Text);
                                cmd.Parameters.AddWithValue("@doj", dtpDOJ.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@staffID", txtStaffid.Text);

                                //selecting today date
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@do_reg", today.ToString());
                                cmd.ExecuteNonQuery();
                                SC.Close();
                                MessageBox.Show("Record Inserted Successfully");
                                clearData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords Doesn't match", "Please try again!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }
                }
                catch (System.Data.SqlClient.SqlException error1)
                {
                    MessageBox.Show("one or more field exceed the length!"+ error1);
                }
            }
            else if (cmbType.SelectedItem.ToString() == "Receptionist")
            {
                try
                {
                    if (txtUID.Text != "" && txtNIC.Text != "" && cmbType.Text != "--Select an Option--" && cmbStatus.Text != "--Select an Option--" && txtConPass.Text != "")
                    {
                        if (txtPass.Text == txtConPass.Text)
                        {

                            SqlCommand cmdd = new SqlCommand("SELECT [U_ID],[NIC] FROM [HMS].[dbo].[RECEPTION] WHERE NIC ='" + txtNIC.Text + "' OR U_ID ='" + txtUID.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmdd.ExecuteReader();
                            if (sddr.Read())
                            {
                                MessageBox.Show("This user is already existing!");
                                SC.Close();
                                SC.Open();
                            }
                            else
                            {
                                SC.Close();
                                SC.Open();
                                cmd = new SqlCommand("insert into [HMS].[dbo].[RECEPTION](U_ID,NIC,STAFF_ID,NAME,ADDRESS,DOB,DO_REG,MARITAL_STATUS,PASSWORD,EMAIL,DOJ,Telephone,Gender,TYPE,STATUS) values(@U_ID, @NIC ,@staffID, @Full_Name,@Address,@dob,@do_reg,@M_Status,@Password,@email,@doj,@Tele,@Gender,'Receptionist','Active')", SC);
                                cmd.Parameters.AddWithValue("@Full_Name", txtFName.Text);
                                cmd.Parameters.AddWithValue("@U_ID", txtUID.Text);
                                cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                                cmd.Parameters.AddWithValue("@U_Type", cmbType.Text);
                                cmd.Parameters.AddWithValue("@Password", txtConPass.Text);
                                cmd.Parameters.AddWithValue("@M_Status", cmbStatus.Text);
                                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@Tele", txtTele.Text);
                                cmd.Parameters.AddWithValue("@dob", dtpBdate.Text);
                                cmd.Parameters.AddWithValue("@doj", dtpDOJ.Text);
                                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                cmd.Parameters.AddWithValue("@staffID", txtStaffid.Text);

                                //selecting today date
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@do_reg", today.ToString());
                                cmd.ExecuteNonQuery();
                                SC.Close();
                                MessageBox.Show("Record Inserted Successfully");
                                clearData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords Doesn't match", "Please try again!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }
                }
                catch (System.Data.SqlClient.SqlException error1)
                {
                    MessageBox.Show("one or more field exceed the length!" + error1);
                }
            }
            else if (cmbType.SelectedItem.ToString() == "Patient")
            {
                try
                {
                    if (txtUID.Text != "" && txtNIC.Text != "" && cmbType.Text != "--Select an Option--" && cmbStatus.Text != "--Select an Option--" && txtConPass.Text != "")
                    {
                        if (txtPass.Text == txtConPass.Text)
                        {

                            SqlCommand cmdd = new SqlCommand("SELECT [U_ID],[NIC] from [HMS].[dbo].[PATIENT] WHERE NIC ='" + txtNIC.Text + "' OR U_ID ='" + txtUID.Text + "';", SC);
                            SqlDataReader sddr;
                            sddr = cmdd.ExecuteReader();
                            if (sddr.Read())
                            {
                                MessageBox.Show("This user is already existing!");
                                SC.Close();
                                SC.Open();
                            }
                            else
                            {
                                SC.Close();
                                SC.Open();
                                cmd = new SqlCommand("insert into [HMS].[dbo].[PATIENT](U_ID,NIC,NAME,ADDRESS,DOB,DO_REG,MARITAL_STATUS,PASSWORD,Telephone,Gender,TYPE,STATUS,ALERGIES_ANY,BLOOD_GROUP) values(@U_ID, @NIC , @Full_Name,@Address,@dob,@do_reg,@M_Status,@Password,@Tele,@Gender,'Patient','Active',@alergy,@blood)", SC);
                                cmd.Parameters.AddWithValue("@Full_Name", txtFName.Text);
                                cmd.Parameters.AddWithValue("@U_ID", txtUID.Text);
                                cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                                cmd.Parameters.AddWithValue("@U_Type", cmbType.Text);
                                cmd.Parameters.AddWithValue("@Password", txtConPass.Text);
                                cmd.Parameters.AddWithValue("@M_Status", cmbStatus.Text);
                                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@Tele", txtTele.Text);
                                cmd.Parameters.AddWithValue("@dob", dtpBdate.Text);
                                cmd.Parameters.AddWithValue("@doj", dtpDOJ.Text);
                                cmd.Parameters.AddWithValue("@blood", cmbBlood.Text);
                                cmd.Parameters.AddWithValue("@alergy", txtAlergy.Text);

                                //selecting today date
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@do_reg", today.ToString());
                                cmd.ExecuteNonQuery();
                                SC.Close();
                                MessageBox.Show("Record Inserted Successfully");
                                clearData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords Doesn't match", "Please try again!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }
                }
                catch (System.Data.SqlClient.SqlException error1)
                {
                    MessageBox.Show("one or more field exceed the length!" + error1);
                }
            }
            else
            {
                MessageBox.Show("One or more field empty!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
