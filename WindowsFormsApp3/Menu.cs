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
    public partial class Menu : MetroForm
    {
        List<string> priceList = new List<string>();
        List<string> foodNameList = new List<string>();
        
        int menuSelected;
        string menuType;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciit\Documents\POS_System.mdf;Integrated Security=True;Connect Timeout=30");

        public Menu(int menuSelected, string menuType)
        {
            this.menuSelected = menuSelected;
            this.menuType = menuType;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int index = 0;

            tpMenu.SelectedIndex = menuSelected;
            getDatabaseValue();

            foreach (Control controls in this.Controls)
            {
                if(controls is PictureBox)
                {
                    controls.Visible = false;
                }
                if (controls is Label)
                {
                    controls.Text = priceList[index];
                    index++;
                }           
            }
        }

        private void getDatabaseValue()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                Console.WriteLine("Connected Successfully!");
            }

            SqlCommand cmd = new SqlCommand($"select * from [foodTable] where Id = '{menuType}'", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    foodNameList.Add(reader[1].ToString());
                    priceList.Add(reader[2].ToString());
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void checkClickedItem(object sender, EventArgs e)
        {
            PictureBox menuItem = (PictureBox)sender;

            foreach (Control label in tpMenu.SelectedTab.Controls)
            {
                if(label is Label)
                {
                    if (label.Tag.ToString() == menuItem.Tag.ToString())
                    {              
                        priceList.Add(label.Text);                 
                        MessageBox.Show("Item Added!");
                    }
                }

            }        
        }

        private void selectedTab()
        {
            switch (tpMenu.SelectedIndex)
            {
                case 0:
                    menuType = "bf";
                    break;
                case 1:
                    menuType = "rm";
                    break;
                case 2:
                    menuType = "sm";
                    break;
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(priceList, foodNameList);
            this.Hide();
            checkout.ShowDialog();
            this.Show();
            
        }
    }
}
