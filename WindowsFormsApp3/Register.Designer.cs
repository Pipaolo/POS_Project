namespace WindowsFormsApp3
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.asdasd;
            this.pictureBox1.Location = new System.Drawing.Point(23, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 109);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(97, 250);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(318, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.Click += new System.EventHandler(this.username_isFocused);
            this.txtUsername.Enter += new System.EventHandler(this.username_isFocused);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(97, 308);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(318, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.Click += new System.EventHandler(this.password_isFocused);
            this.txtPassword.Enter += new System.EventHandler(this.password_isFocused);
            // 
            // txtConPass
            // 
            this.txtConPass.Depth = 0;
            this.txtConPass.Hint = "";
            this.txtConPass.Location = new System.Drawing.Point(97, 337);
            this.txtConPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '\0';
            this.txtConPass.SelectedText = "";
            this.txtConPass.SelectionLength = 0;
            this.txtConPass.SelectionStart = 0;
            this.txtConPass.Size = new System.Drawing.Size(318, 23);
            this.txtConPass.TabIndex = 5;
            this.txtConPass.Text = "Confirm Password";
            this.txtConPass.UseSystemPasswordChar = false;
            this.txtConPass.Click += new System.EventHandler(this.conPass_isFocused);
            this.txtConPass.Enter += new System.EventHandler(this.conPass_isFocused);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fangsong Std R", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(54, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Already Have an Account?";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(153, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(212, 51);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 524);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConPass;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnRegister;
    }
}