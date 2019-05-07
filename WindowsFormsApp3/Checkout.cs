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
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Checkout : MetroForm
    {
        List<string> priceList = new List<string>();
        List<string> foodNameList = new List<string>();
        List<int> quantityList = new List<int>();

        decimal totalPrice = 0;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POS_System.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        public Checkout(List<string> priceList, List<string> foodNameList, List<int> quantityList)
        {
            this.priceList = priceList;
            this.foodNameList = foodNameList;
            this.quantityList = quantityList;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroLabel5.Text = DateTime.Now.ToLongTimeString();
            metroLabel6.Text = DateTime.Now.ToLongDateString();

            displayReceipt();
            clearData();

        }

        private void clearData()
        {
            connection.Open();
            cmd = new SqlCommand("delete from [checkoutTable]",connection);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                System.Diagnostics.Debug.WriteLine("Delete Complete!");
            }

            connection.Close();
        }

        private void displayReceipt()
        {
            cmd = new SqlCommand("select quantity as 'Pcs', foodName as 'Name', foodPrice as 'Price' from [checkoutTable]", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dta = new DataTable();

            foreach (var item in priceList)
            {
                totalPrice += Convert.ToInt32(item.Replace("PHP", ""));
            }

            totalPrice += (totalPrice * (decimal).12);

            lblTotalPrice.Text += " " + totalPrice.ToString() + "PHP";

            sda.Fill(dta);

            gCheckoutTable.ReadOnly = true;
            gCheckoutTable.DataSource = dta;

            connection.Close();
        }

        private void Checkout_FormClosed(object sender, FormClosedEventArgs e)
        {
            lblTotalPrice.Text = "Subtotal: ";
        }

        private void IsFocused(object sender, EventArgs e)
        {
            if(txtPayment.Text == "ENTER PAYMENT (eg. 500)")
            {
                txtPayment.Text = "";
            }
            else
            {
                txtPayment.Text = "ENTER PAYMENT (eg. 500)";
            }
        }

        private void IsEnterPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(Convert.ToDecimal(txtPayment.Text) < totalPrice)
                {
                    MessageBox.Show("Insufficient Funds!");
                }
                else
                {
                    decimal change = Convert.ToDecimal(txtPayment.Text) - totalPrice;
                    MessageBox.Show($"Your change is : {change}");
                    MessageBox.Show("Thank You For Ordering! \nPlease be Patient in Waiting For Your Order");
                    Application.Exit();
                }
            }
        }
    }
}
