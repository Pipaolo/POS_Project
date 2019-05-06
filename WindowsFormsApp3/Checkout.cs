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
            clearData();
            generateReceipt();
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

        private void generateReceipt()
        {
            if(connection.State == ConnectionState.Closed)
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

                if(result == 1)
                {
                    System.Diagnostics.Debug.WriteLine("Insert Complete!");
                }
            }


            displayReceipt();
        }

        private void displayReceipt()
        {
            cmd = new SqlCommand("select * from [checkoutTable]", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dta = new DataTable();

            sda.Fill(dta);

            gCheckoutTable.ReadOnly = true;
            gCheckoutTable.DataSource = dta;

            connection.Close();
        }
    }
}
