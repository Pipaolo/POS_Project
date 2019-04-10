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
            menus.SelectedIndex = menuSelected;
            foreach (Control controls in this.Controls)
            {
                if(controls is PictureBox)
                {
                    controls.Visible = false;
                }
                if(controls is Label)
                {
                    controls.Text = string.Empty;
                }
            }
        }

        private void getDatabaseValue()
        {

        }

        private void checkClickedItem(object sender, EventArgs e)
        {

            PictureBox menuItem = (PictureBox)sender;

            foreach (Control label in menus.SelectedTab.Controls)
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(priceList);
            this.Hide();
            checkout.ShowDialog();
            this.Show();
            
        }
    }
}
