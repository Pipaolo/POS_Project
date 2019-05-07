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
using System.IO;

namespace WindowsFormsApp3
{
    public partial class AdminMenu : MetroForm
    {
        private string mImageLocation = string.Empty;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POS_System.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlCommand cmd;

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void CheckBoxSelected(object sender, EventArgs e)
        {
            foreach(Control control in pCheckBox.Controls)
            {
                if(control is MetroFramework.Controls.MetroCheckBox)
                {
                    if (control == sender)
                    {
                        MetroFramework.Controls.MetroCheckBox temp1 = (MetroFramework.Controls.MetroCheckBox) sender;
                        foreach (Control controls in pCheckBox.Controls)
                        {                       
                            if (controls is MetroFramework.Controls.MetroCheckBox && controls != sender)
                            {
                                temp1 = (MetroFramework.Controls.MetroCheckBox) controls;
                                temp1.Checked = false;
                            }
                        }
                    }
                    break;
                }
            }
        }

        private void FoodName_Focused(object sender, EventArgs e)
        {
            txtFoodName.Text = "";

            if(txtPrice.Text == String.Empty)
            {
                txtPrice.Text = "Price";
            }          
        }

        private void Price_Focused(object sender, EventArgs e)
        {
            txtPrice.Text = "";

            if (txtFoodName.Text == String.Empty)
            {
                txtFoodName.Text = "Food Name";
            }
        }

        private void btnPickPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                mImageLocation = dialog.FileName.ToString();
                pbFoodImage.ImageLocation = mImageLocation;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = string.Empty;
                byte[] images = null;
                FileStream Stream = new FileStream(mImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(Stream);
                images = binaryReader.ReadBytes((int)Stream.Length);

                if (chkBreakfast.Checked)
                {
                    id = "bf";
                }
                else if (chkRegular.Checked)
                {
                    id = "rm";
                }
                else if (chkSpecial.Checked)
                {
                    id = "sm";
                }

                string query = $"Insert into foodTable(Id, foodName, foodPrice, foodPicture) " +
                                  $"Values('{id}', '{txtFoodName.Text}','{txtPrice.Text}',@images)";

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();

                connection.Close();

                updateData();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void updateData()
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                cmd = new SqlCommand("select Id as 'Menu Type', foodName as 'Food', foodPrice as 'Price', foodPicture as 'Picture' from [foodTable]", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                gAdminTable.ReadOnly = true;
                gAdminTable.DataSource = dt;

                connection.Close();

            }
            catch (Exception ex)
            {            
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            updateData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            this.Close();
        }

        private void gAdminTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string temp = string.Empty;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            foreach (DataGridViewRow row in gAdminTable.SelectedRows)
            {
                temp = Convert.ToString(gAdminTable[1, row.Index].Value);
            }

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {temp}?", "Delete Item", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
            
                foreach (DataGridViewRow row in gAdminTable.SelectedRows)
                {
                    gAdminTable.Rows.RemoveAt(row.Index);
                }

                cmd = new SqlCommand($"delete from [foodTable] where foodName = '{temp}'", connection);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    System.Diagnostics.Debug.WriteLine("Delete Complete!");
                }

                gAdminTable.Refresh();
                connection.Close();
            }
            else
            {

            }
        }
    }
}
