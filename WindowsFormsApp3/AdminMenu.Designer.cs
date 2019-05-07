namespace WindowsFormsApp3
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCheckBox = new MetroFramework.Controls.MetroPanel();
            this.chkRegular = new MetroFramework.Controls.MetroCheckBox();
            this.chkSpecial = new MetroFramework.Controls.MetroCheckBox();
            this.chkBreakfast = new MetroFramework.Controls.MetroCheckBox();
            this.txtFoodName = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnPickPicture = new MetroFramework.Controls.MetroButton();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.gAdminTable = new MetroFramework.Controls.MetroGrid();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.pCheckBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAdminTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pCheckBox
            // 
            this.pCheckBox.Controls.Add(this.chkRegular);
            this.pCheckBox.Controls.Add(this.chkSpecial);
            this.pCheckBox.Controls.Add(this.chkBreakfast);
            this.pCheckBox.HorizontalScrollbarBarColor = true;
            this.pCheckBox.HorizontalScrollbarHighlightOnWheel = false;
            this.pCheckBox.HorizontalScrollbarSize = 10;
            this.pCheckBox.Location = new System.Drawing.Point(23, 64);
            this.pCheckBox.Name = "pCheckBox";
            this.pCheckBox.Size = new System.Drawing.Size(202, 69);
            this.pCheckBox.TabIndex = 0;
            this.pCheckBox.VerticalScrollbarBarColor = true;
            this.pCheckBox.VerticalScrollbarHighlightOnWheel = false;
            this.pCheckBox.VerticalScrollbarSize = 10;
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(3, 47);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(97, 15);
            this.chkRegular.TabIndex = 4;
            this.chkRegular.Text = "Regular Menu";
            this.chkRegular.UseSelectable = true;
            this.chkRegular.CheckedChanged += new System.EventHandler(this.CheckBoxSelected);
            this.chkRegular.Click += new System.EventHandler(this.CheckBoxSelected);
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(3, 25);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(94, 15);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special Menu";
            this.chkSpecial.UseSelectable = true;
            this.chkSpecial.CheckedChanged += new System.EventHandler(this.CheckBoxSelected);
            this.chkSpecial.Click += new System.EventHandler(this.CheckBoxSelected);
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(3, 3);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(105, 15);
            this.chkBreakfast.TabIndex = 2;
            this.chkBreakfast.Text = "Breakfast Menu";
            this.chkBreakfast.UseSelectable = true;
            this.chkBreakfast.CheckedChanged += new System.EventHandler(this.CheckBoxSelected);
            this.chkBreakfast.Click += new System.EventHandler(this.CheckBoxSelected);
            // 
            // txtFoodName
            // 
            // 
            // 
            // 
            this.txtFoodName.CustomButton.Image = null;
            this.txtFoodName.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtFoodName.CustomButton.Name = "";
            this.txtFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFoodName.CustomButton.TabIndex = 1;
            this.txtFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFoodName.CustomButton.UseSelectable = true;
            this.txtFoodName.CustomButton.Visible = false;
            this.txtFoodName.Lines = new string[] {
        "Food Name"};
            this.txtFoodName.Location = new System.Drawing.Point(23, 140);
            this.txtFoodName.MaxLength = 32767;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFoodName.SelectedText = "";
            this.txtFoodName.SelectionLength = 0;
            this.txtFoodName.SelectionStart = 0;
            this.txtFoodName.ShortcutsEnabled = true;
            this.txtFoodName.Size = new System.Drawing.Size(202, 23);
            this.txtFoodName.TabIndex = 1;
            this.txtFoodName.Text = "Food Name";
            this.txtFoodName.UseSelectable = true;
            this.txtFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFoodName.Click += new System.EventHandler(this.FoodName_Focused);
            this.txtFoodName.Enter += new System.EventHandler(this.FoodName_Focused);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[] {
        "Price"};
            this.txtPrice.Location = new System.Drawing.Point(23, 169);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(202, 23);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "Price";
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Click += new System.EventHandler(this.Price_Focused);
            this.txtPrice.Enter += new System.EventHandler(this.Price_Focused);
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.Location = new System.Drawing.Point(41, 314);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(156, 40);
            this.btnPickPicture.TabIndex = 2;
            this.btnPickPicture.Text = "Choose Picture";
            this.btnPickPicture.UseSelectable = true;
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.Location = new System.Drawing.Point(55, 198);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(133, 110);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodImage.TabIndex = 3;
            this.pbFoodImage.TabStop = false;
            // 
            // gAdminTable
            // 
            this.gAdminTable.AllowUserToOrderColumns = true;
            this.gAdminTable.AllowUserToResizeRows = false;
            this.gAdminTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gAdminTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gAdminTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gAdminTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gAdminTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gAdminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gAdminTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.gAdminTable.EnableHeadersVisualStyles = false;
            this.gAdminTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gAdminTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gAdminTable.Location = new System.Drawing.Point(9, 368);
            this.gAdminTable.Name = "gAdminTable";
            this.gAdminTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gAdminTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gAdminTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gAdminTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gAdminTable.Size = new System.Drawing.Size(540, 223);
            this.gAdminTable.TabIndex = 4;
            this.gAdminTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gAdminTable_CellClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(351, 63);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 40);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Logout";
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Food";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 601);
            this.Controls.Add(this.gAdminTable);
            this.Controls.Add(this.pbFoodImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPickPicture);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.pCheckBox);
            this.Name = "AdminMenu";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.pCheckBox.ResumeLayout(false);
            this.pCheckBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAdminTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pCheckBox;
        private MetroFramework.Controls.MetroCheckBox chkBreakfast;
        private MetroFramework.Controls.MetroCheckBox chkRegular;
        private MetroFramework.Controls.MetroCheckBox chkSpecial;
        private MetroFramework.Controls.MetroTextBox txtFoodName;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroButton btnPickPicture;
        private System.Windows.Forms.PictureBox pbFoodImage;
        private MetroFramework.Controls.MetroGrid gAdminTable;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}