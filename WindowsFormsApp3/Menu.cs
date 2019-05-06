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
        private static readonly ImageConverter _imageConverter = new ImageConverter();

        //PictureBox Coordinates
        // X = 154
        // Y = 135

        //Label Coordinates
        // X = 155
        // Y = 135

        private static int pictureX = 154;
        private static int pictureY = 135;
                
        private static int labelX = 155;
        private static int labelY = 135;

        private int pX = 0;
        private int pY = 21;

        private int lX = 42;
        private int lY = 134;

        List<string> priceList = new List<string>();
        List<string> foodNameList = new List<string>();
        List<int> quantityList = new List<int>();

        DataTable dt;
        
        int menuSelected;
        string menuType;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POS_System.mdf;Integrated Security=True;Connect Timeout=30");

        public Menu(int menuSelected, string menuType)
        {
            this.menuSelected = menuSelected;
            this.menuType = menuType;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {             
            tpMenu.SelectedIndex = menuSelected;
        }

        private void ClearData()
        {
            pX = 0;
            pY = 21;
            lX = 42;
            lY = 134;
            UpdateMenu();
        }

        private void UpdateMenu()
        {
            GetDatabaseValue();
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(pX > pictureX * 3)
                    {
                        pX = 0;
                        lX = 42;
                        pY += pictureY;
                        lY += labelY;
                    }

                    var picture = new PictureBox
                    {
                        Name = "picture" + i,
                        Size = new Size(133, 110),
                        Location = new Point(pX, pY),
                        SizeMode = PictureBoxSizeMode.StretchImage,          
                        Tag = dt.Rows[i][1],
                        Image = GetImageFromByteArray((byte[])dt.Rows[i][3]),
                    };

                    var label = new MetroFramework.Controls.MetroLabel
                    {
                        Name = "label" + i,
                        Location = new Point(lX, lY),
                        AutoSize = true,
                        Text = Convert.ToString(dt.Rows[i][2]) + "PHP",
                        Tag = dt.Rows[i][1],
                    };

                    pX += pictureX;
                    lX += labelX;

                    tpMenu.SelectedTab.Controls.Add(picture);
                    tpMenu.SelectedTab.Controls.Add(label);

                    picture.MouseClick += new MouseEventHandler(CheckClickedItem);                
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ControlsTag: " + ex.Message);
            }
        }

        private void GetDatabaseValue()
        {
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Connected Successfully!");
                }

                SqlCommand cmd = new SqlCommand($"select * from [foodTable] where Id = '{menuType}'", connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                dt = new DataTable();

                sda.Fill(dt);

                connection.Close();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void CheckClickedItem(object sender, EventArgs e)
        {
            PictureBox menuItem = (PictureBox)sender;
            foreach (Control label in tpMenu.SelectedTab.Controls)
            {
                if(label is Label)
                {               
                    if(label.Tag.ToString() == menuItem.Tag.ToString())
                    {
                        addItem(1, label.Text, menuItem.Tag.ToString());

                        MessageBox.Show($"{label.Tag} Added!");
                    }                 
                }
                System.Diagnostics.Debug.WriteLine("CheckClickedItem: NotFound!");
            }        
        }

        private void addItem(int foodQuantity, string foodPrice, string foodName)
        {
            //Check Duplicates
            for (int i = 0; i < foodNameList.Count; i++)
            {
                if (foodName.Equals(foodNameList[i]))
                {
                    foodNameList.Remove(foodName);
                    quantityList[i] += 1;
                }
            }

            quantityList.Add(foodQuantity);
            priceList.Add(foodPrice);
            foodNameList.Add(foodName);
        }

        private void SelectedTab(object sender, EventArgs e)
        {
            switch (tpMenu.SelectedIndex)
            {
                case 0:
                    menuType = "bf";
                    ClearData();
                    break;
                case 1:
                    menuType = "rm";
                    ClearData();
                    break;
                case 2:
                    menuType = "sm";
                    ClearData();
                    break;
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(priceList, foodNameList, quantityList);
            this.Hide();
            checkout.ShowDialog();
            this.Show();
            
        }

        private static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }
    }
}
