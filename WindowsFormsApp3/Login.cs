using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MaterialSkin.Controls;
using MetroFramework;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Login : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciit\Documents\POS_System.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void txtPasswordFocused(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtPassword.UseSystemPasswordChar = true;
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUsernameFocused(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            if(txtPassword.Text == string.Empty)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        private void isEnterPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginUser();
            }           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginUser();
        }

        private void loginUser()
        {
            bool usernameExists = false;
            try
            {
                connection.Open();
                Console.WriteLine("Connected Successfully!");

                SqlCommand cmd = new SqlCommand($"select * from [credentialsTable] where username = '{txtUsername.Text}' and password = '{txtPassword.Text}'", connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    if (txtUsername.Text.Equals(reader[0].ToString()) && txtPassword.Text.Equals(reader[1].ToString()))
                    {
                        MessageBox.Show("Login Success!");
                        launchMainMenu();
                        usernameExists = true;
                    }
                }

                if(!usernameExists)
                {
                    MessageBox.Show("Invalid username/password!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void launchMainMenu()
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();

        }
    }
}
