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
    public partial class Cart : MetroForm
    {
        public List<string> priceList = new List<string>();
        public List<string> foodNameList = new List<string>();
        public List<int> quantityList = new List<int>();

        decimal totalPrice = 0;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POS_System.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        public Cart(List<string> priceList, List<string> foodNameList, List<int> quantityList)
        {
            this.priceList = priceList;
            this.foodNameList = foodNameList;
            this.quantityList = quantityList;
            InitializeComponent();
        }

        private void ShowData()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            cmd = new SqlCommand("select quantity as 'Pcs', foodName as 'Food', foodPrice as 'Price'", connection);
        }

        private void generateReceipt()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            for (int i = 0; i < foodNameList.Count; i++)
            {
                cmd = new SqlCommand("insert into [checkoutTable] values (@quantity, @foodName, @foodPrice)", connection);
                cmd.Parameters.AddWithValue("@quantity", quantityList[i]);
                cmd.Parameters.AddWithValue("@foodName", foodNameList[i]);
                cmd.Parameters.AddWithValue("@foodPrice", priceList[i]);
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    System.Diagnostics.Debug.WriteLine("Insert Complete!");
                }
            }

            displayReceipt();
        }

        private void displayReceipt()
        {
            cmd = new SqlCommand("select quantity as 'Pcs', foodName as 'Name', foodPrice as 'Price' from [checkoutTable]", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dta = new DataTable();

            for (int i = 0; i < foodNameList.Count; i++)
            {
                for (int j = 0; j < quantityList[i]; j++)
                {
                    totalPrice += Convert.ToInt32(priceList[i].Replace("PHP", ""));
                }               
            }

            totalPrice += (totalPrice * (decimal).12);

            lblTotalPrice.Text += " " + totalPrice.ToString() + "PHP";

            sda.Fill(dta);

            gCheckoutable.ReadOnly = true;
            gCheckoutable.DataSource = dta;

            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clearData();
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(priceList, foodNameList, quantityList);
            this.Hide();
            checkout.ShowDialog();
            this.Close();
        }

        private void clearData()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            cmd = new SqlCommand("delete from [checkoutTable]", connection);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                System.Diagnostics.Debug.WriteLine("Delete Complete!");
            }

            connection.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            clearData();
            generateReceipt();
            ShowData();
        }

        private void gCheckoutable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp = string.Empty;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            foreach (DataGridViewRow row in gCheckoutable.SelectedRows)
            {
                temp = Convert.ToString(gCheckoutable[1, row.Index].Value);
            }

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {temp}?", "Delete Item", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < foodNameList.Count; i++)
                {
                    if(temp == foodNameList[i])
                    {
                        quantityList.Remove(quantityList[i]);
                        foodNameList.Remove(foodNameList[i]);
                        priceList.Remove(priceList[i]);
                    }
                }

                foreach (DataGridViewRow row in gCheckoutable.SelectedRows)
                {
                    gCheckoutable.Rows.RemoveAt(row.Index);
                }

                cmd = new SqlCommand($"delete from [checkoutTable] where foodName = '{temp}'", connection);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    System.Diagnostics.Debug.WriteLine("Delete Complete!");
                }

                lblTotalPrice.Text = "SubTotal: ";

                gCheckoutable.Refresh();
                connection.Close();
            }
            else
            {

            }
        }
    }
}
