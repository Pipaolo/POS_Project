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
        List<string> foodNameList = new List<string>();

        public Checkout(List<string> priceList, List<string> foodNameList)
        {
            this.priceList = priceList;
            this.foodNameList = foodNameList;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroLabel5.Text = DateTime.Now.ToLongTimeString();
            metroLabel6.Text = DateTime.Now.ToLongDateString();
        }

        private void generateReceipt()
        {
            string receipt = "";

            for (int i = 0; i < foodNameList.Count(); i++)
            {
                receipt = $"1     {foodNameList[i]}      {priceList[i]}";
                txtCheckout.Text += receipt;
            }
        }
    }
}
