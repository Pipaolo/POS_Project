using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Register : MetroForm
    {
        SqlConnection connection = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciit\Documents\POS_System.mdf;Integrated Security=True;Connect Timeout=30");

        public Register()
        {
            InitializeComponent();
        }

        private void username_isFocused(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
        }

        private void password_isFocused(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtPassword.UseSystemPasswordChar = true;
            if (txtUsername.Text.Equals(String.Empty))
            {
                txtUsername.Text = "Username";
            }
        }

        private void conPass_isFocused(object sender, EventArgs e)
        {
            txtConPass.Text = string.Empty;
            txtConPass.UseSystemPasswordChar = true;
            if (txtUsername.Text.Equals(String.Empty))
            {
                txtUsername.Text = "Username";
            }

            if(txtPassword.Text.Equals(string.Empty))
            {
                txtPassword.Text = "Password";
            }

        }
    
        private void Form3_Load(object sender, EventArgs e)
        {
       
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                Console.WriteLine("Connected Successfully!");
                if (!checkDuplicates(txtUsername.Text))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"insert into [credentialsTable] (username, password) values ('{txtUsername.Text}', '{txtPassword.Text}')";
                    cmd.ExecuteNonQuery();
                    

                    MessageBox.Show("Registered Successfully");
                    this.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Username is Taken!");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
        }

        private bool checkDuplicates(string username)
        {
            List<string> usernameList = new List<string>();

            try
            {
                connection.Open();
                Console.WriteLine("Connected Successfully!");
                SqlCommand cmd = new SqlCommand("select username from [credentialsTable]", connection);

                SqlDataReader dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
                {
                    usernameList.Add(dataReader[0].ToString());
                }

                foreach (string a in usernameList)
                {
                    Console.WriteLine(a);
                    if(a.Equals(username))
                    {
                        connection.Close();
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }
    }
}
