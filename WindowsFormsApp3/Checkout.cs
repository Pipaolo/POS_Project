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
using MetroFramework;

namespace WindowsFormsApp3
{
    public partial class Checkout : MetroForm
    {
        List<string> priceList = new List<string>();

        public Checkout(List<string> priceList)
        {
            this.priceList = priceList;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroLabel5.Text = DateTime.Now.ToLongTimeString();
            metroLabel6.Text = DateTime.Now.ToLongDateString();

            txtPrice1.Text = priceList[0];
            txtPrice1.Text = priceList[1];
            txtPrice1.Text = priceList[2];


        }
    }
}
