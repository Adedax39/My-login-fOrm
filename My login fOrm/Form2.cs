using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace My_login_fOrm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://mail.google.com/mail/u/0/#inbox?compose=new");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFname.Text ==
                "")
            {
                MessageBox.Show("Enter the firstname");
            }
            else if (txtLname.Text ==
                "")
            {
                MessageBox.Show("Enter your Lastname");
            }
            else if (txtAddress.Text ==
                "")
            {
                MessageBox.Show("Enter your Address");
            }
            else if (txtAge.Text ==
                "")
            {
                MessageBox.Show("Enter your Age");
            }
            else if (cmdGender.Text ==
                "")
            {
                MessageBox.Show("Enter your Gender");
            }
            else if (txtPhone.Text ==
                "")
            {
                MessageBox.Show("Enter your ContactNo");
            }
            else if (txtEmail.Text ==
                "")
            {
                MessageBox.Show("Enter your Email");
            }
            else if (txtUser.Text ==
                "")
            {
                MessageBox.Show("Enter your Username");

            }
            else if (txtPass.Text ==
                "")
            {
                MessageBox.Show("Enter your Password");

            }
            else if (pickerDate.Text ==
                "")
            {
                MessageBox.Show("Enter your DoB");
            }
            else
            {
                try
                {
                    string married;
                     if (rbyes.Checked){
                        married = "Yes";
                    }
                    else
                    {
                        married = "No";
                    }
           SqlConnection con = new SqlConnection("Data Source=LASATH-PC;Initial Catalog=loginfoem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Table_login]
           ([UserId]
           ,[username]
           ,[password]
           ,[firstname]
           ,[lastname]
           ,[age]
           ,[dateofbirth]
           ,[gender]
           ,[address]
           ,[contactno]
           ,[email]
           ,[married])
     VALUES
           ("+txtId.Text+",'" + txtUser.Text + "','" + txtPass.Text + "','" + txtFname.Text+"','"+txtLname.Text+ "','" + txtAge.Text + "','" + pickerDate.Value + "','" + cmdGender.SelectedItem.ToString() + "','" + txtAddress.Text+"','"+txtPhone.Text+"','"+txtEmail.Text+"','"+married+"')" ,con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration Successful!!");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }



             }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want clear the fields");
            txtUser.Clear();
            txtPass.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtFname.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to LogOut?";
            string title = "Log Out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                // Do something
            }

        }

        private void cmdGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=LASATH-PC;Initial Catalog=loginfoem;Integrated Security=True");
                con.Open();
                string query = "UPDATE dbo.Table_login SET username = '"+txtUser.Text+"', password = '"+ txtPass.Text + "', firstname = '"+txtFname.Text+ "' ,lastname = '"+txtLname.Text+ "', age = '"+txtAge.Text+ "',dateofbirth = '"+ pickerDate.Value + "', gender = '"+ cmdGender.SelectedItem.ToString() + "',address = '"+ txtAddress.Text + "',contactno = '"+ txtPhone.Text + "', email = '"+ txtEmail.Text + "' WHERE UserId = "+ txtId.Text + "   ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updated");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LASATH-PC;Initial Catalog=loginfoem;Integrated Security=True");
            con.Open();
            string query = "DELETE from dbo.Table_login WHERE UserId = " + txtId.Text + "  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Sucessfully");
            con.Close();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
