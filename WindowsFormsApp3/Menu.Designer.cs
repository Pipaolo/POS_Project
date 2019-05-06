namespace WindowsFormsApp3
{
    partial class Menu
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tpMenu = new MetroFramework.Controls.MetroTabControl();
            this.breakfastmenu = new MetroFramework.Controls.MetroTabPage();
            this.regularmenu = new MetroFramework.Controls.MetroTabPage();
            this.specialmenu = new MetroFramework.Controls.MetroTabPage();
            this.tpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(263, 615);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(119, 46);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Order";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.breakfastmenu);
            this.tpMenu.Controls.Add(this.regularmenu);
            this.tpMenu.Controls.Add(this.specialmenu);
            this.tpMenu.Location = new System.Drawing.Point(23, 89);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.SelectedIndex = 2;
            this.tpMenu.Size = new System.Drawing.Size(598, 520);
            this.tpMenu.TabIndex = 1;
            this.tpMenu.UseSelectable = true;
            this.tpMenu.SelectedIndexChanged += new System.EventHandler(this.SelectedTab);
            // 
            // breakfastmenu
            // 
            this.breakfastmenu.AutoScroll = true;
            this.breakfastmenu.HorizontalScrollbar = true;
            this.breakfastmenu.HorizontalScrollbarBarColor = false;
            this.breakfastmenu.HorizontalScrollbarHighlightOnWheel = false;
            this.breakfastmenu.HorizontalScrollbarSize = 10;
            this.breakfastmenu.Location = new System.Drawing.Point(4, 38);
            this.breakfastmenu.Name = "breakfastmenu";
            this.breakfastmenu.Size = new System.Drawing.Size(590, 478);
            this.breakfastmenu.TabIndex = 0;
            this.breakfastmenu.Text = "Breakfast Menu";
            this.breakfastmenu.VerticalScrollbar = true;
            this.breakfastmenu.VerticalScrollbarBarColor = true;
            this.breakfastmenu.VerticalScrollbarHighlightOnWheel = false;
            this.breakfastmenu.VerticalScrollbarSize = 10;
            // 
            // regularmenu
            // 
            this.regularmenu.HorizontalScrollbarBarColor = true;
            this.regularmenu.HorizontalScrollbarHighlightOnWheel = false;
            this.regularmenu.HorizontalScrollbarSize = 10;
            this.regularmenu.Location = new System.Drawing.Point(4, 38);
            this.regularmenu.Name = "regularmenu";
            this.regularmenu.Size = new System.Drawing.Size(590, 478);
            this.regularmenu.TabIndex = 2;
            this.regularmenu.Text = "Regular Menu";
            this.regularmenu.VerticalScrollbarBarColor = true;
            this.regularmenu.VerticalScrollbarHighlightOnWheel = false;
            this.regularmenu.VerticalScrollbarSize = 10;
            // 
            // specialmenu
            // 
            this.specialmenu.HorizontalScrollbarBarColor = true;
            this.specialmenu.HorizontalScrollbarHighlightOnWheel = false;
            this.specialmenu.HorizontalScrollbarSize = 10;
            this.specialmenu.Location = new System.Drawing.Point(4, 38);
            this.specialmenu.Name = "specialmenu";
            this.specialmenu.Size = new System.Drawing.Size(590, 478);
            this.specialmenu.TabIndex = 3;
            this.specialmenu.Text = "Special Menu";
            this.specialmenu.VerticalScrollbarBarColor = true;
            this.specialmenu.VerticalScrollbarHighlightOnWheel = false;
            this.specialmenu.VerticalScrollbarSize = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 695);
            this.Controls.Add(this.tpMenu);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MetroFramework.Controls.MetroTabControl tpMenu;
        private MetroFramework.Controls.MetroTabPage breakfastmenu;
        private MetroFramework.Controls.MetroTabPage regularmenu;
        private MetroFramework.Controls.MetroTabPage specialmenu;
    }
}