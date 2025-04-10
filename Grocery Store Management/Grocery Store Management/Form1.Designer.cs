namespace Grocery_Store_Management
{
    partial class Login
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pic_ShowPassword = new System.Windows.Forms.PictureBox();
            this.pic_UsernameIcon = new System.Windows.Forms.PictureBox();
            this.pic_PasswordIcon = new System.Windows.Forms.PictureBox();
            this.txt_Password = new Grocery_Store_Management.RoundedTextBox();
            this.txt_Username = new Grocery_Store_Management.RoundedTextBox();
            this.btn_Cancel = new Grocery_Store_Management.RoundedButton();
            this.btn_Login = new Grocery_Store_Management.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UsernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(97, 82);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 17);
            this.lblUsername.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Gray;
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(358, 12);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.Text = "−";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackColor = System.Drawing.Color.Gray;
            this.btn_Maximize.Enabled = false;
            this.btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.btn_Maximize.Location = new System.Drawing.Point(394, 12);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 6;
            this.btn_Maximize.Text = "□";
            this.btn_Maximize.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(430, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(12, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // pic_ShowPassword
            // 
            this.pic_ShowPassword.BackColor = System.Drawing.Color.White;
            this.pic_ShowPassword.Image = global::Grocery_Store_Management.Properties.Resources.EyeClosed;
            this.pic_ShowPassword.Location = new System.Drawing.Point(320, 150);
            this.pic_ShowPassword.Name = "pic_ShowPassword";
            this.pic_ShowPassword.Size = new System.Drawing.Size(40, 21);
            this.pic_ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ShowPassword.TabIndex = 9;
            this.pic_ShowPassword.TabStop = false;
            // 
            // pic_UsernameIcon
            // 
            this.pic_UsernameIcon.Image = global::Grocery_Store_Management.Properties.Resources.UserIcon;
            this.pic_UsernameIcon.Location = new System.Drawing.Point(103, 82);
            this.pic_UsernameIcon.Name = "pic_UsernameIcon";
            this.pic_UsernameIcon.Size = new System.Drawing.Size(46, 35);
            this.pic_UsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_UsernameIcon.TabIndex = 10;
            this.pic_UsernameIcon.TabStop = false;
            // 
            // pic_PasswordIcon
            // 
            this.pic_PasswordIcon.Image = global::Grocery_Store_Management.Properties.Resources.LockIcon;
            this.pic_PasswordIcon.Location = new System.Drawing.Point(103, 141);
            this.pic_PasswordIcon.Name = "pic_PasswordIcon";
            this.pic_PasswordIcon.Size = new System.Drawing.Size(46, 35);
            this.pic_PasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_PasswordIcon.TabIndex = 10;
            this.pic_PasswordIcon.TabStop = false;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(166, 146);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(198, 28);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(166, 88);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(198, 27);
            this.txt_Username.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(289, 222);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(200, 222);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 31);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(483, 275);
            this.Controls.Add(this.pic_PasswordIcon);
            this.Controls.Add(this.pic_UsernameIcon);
            this.Controls.Add(this.pic_ShowPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Maximize);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UsernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PasswordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private RoundedButton btn_Login;
        private RoundedButton btn_Cancel;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Close;
        private RoundedTextBox txt_Username;
        private RoundedTextBox txt_Password;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pic_ShowPassword;
        private System.Windows.Forms.PictureBox pic_UsernameIcon;
        private System.Windows.Forms.PictureBox pic_PasswordIcon;
    }
}

