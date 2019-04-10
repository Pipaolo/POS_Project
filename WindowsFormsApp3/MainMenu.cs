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

namespace WindowsFormsApp3
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pbBreakfastClicked(object sender, EventArgs e)
        {
            gotoMenu(0, "bf");
        }

        private void pbRegularMenuClicked(object sender, EventArgs e)
        {
            gotoMenu(1, "rm");
        }

        private void pbSpecialMenuClicked(object sender, EventArgs e)
        {
            gotoMenu(2, "sm");
        }

        private void gotoMenu(int menuSelected, string menuType)
        {
            Menu menu = new Menu(menuSelected, menuType);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

    }
}
