using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Grocery_Store_Management
{
    public partial class Login : Form
    {
        private const char BULLET = '\u2022'; // Dấu chấm tròn đen (bullet)
        private bool isPasswordVisible = false; 
        public Login()
        {
            InitializeComponent();
            btn_Login.Click += btn_Login_Click;
            btn_Cancel.Click += btn_Cancel_Click;
            btn_Login.MouseEnter += btn_Login_MouseEnter;
            btn_Login.MouseLeave += btn_Login_MouseLeave;
            btn_Cancel.MouseEnter += btn_Cancel_MouseEnter;
            btn_Cancel.MouseLeave += btn_Cancel_MouseLeave;
            btn_Close.Click += btn_Close_Click;
            btn_Minimize.Click += btn_Minimize_Click;
            btn_Maximize.Click += btn_Maximize_Click;
            pic_ShowPassword.Click += Pic_ShowPassword_Click;
            //chk_ShowPassword.CheckedChanged += chk_ShowPassword_CheckedChanged;
            txt_Password.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) btn_Login_Click(s, e);
            };

            this.StartPosition = FormStartPosition.CenterScreen;
            txt_Username.Focus();

            // Bo góc cho form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = CreateRoundedRegion(20);
            this.Resize += Login_Resize;
        }

        private Region CreateRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return new Region(path);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            this.Region = CreateRoundedRegion(20);
            if (this.Controls.ContainsKey("pic_Logo"))
            {
                Control pic_Logo = this.Controls["pic_Logo"];
                pic_Logo.Location = new Point((this.ClientSize.Width - pic_Logo.Width) / 2, 10);
            }
            btn_Minimize.Location = new Point(this.ClientSize.Width - 120, 10);
            btn_Maximize.Location = new Point(this.ClientSize.Width - 80, 10);
            btn_Close.Location = new Point(this.ClientSize.Width - 40, 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                int diameter = 20 * 2;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                    path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90);
                    path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90);
                    path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90);
                    path.CloseFigure();

                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 147, 77);

            btn_Login.BackColor = Color.FromArgb(255, 140, 0);
            btn_Login.ForeColor = Color.White;
            btn_Cancel.BackColor = Color.FromArgb(200, 200, 200);
            btn_Cancel.ForeColor = Color.Black;
            //txt_Username.Font = new Font("Roboto", 12, FontStyle.Regular);
            //txt_Password.Font = new Font("Roboto", 12, FontStyle.Regular);
            //btn_Login.Font = new Font("Roboto", 14, FontStyle.Bold);
            //btn_Cancel.Font = new Font("Roboto", 14, FontStyle.Bold);
            pic_UsernameIcon.MouseEnter += (s, args) => pic_UsernameIcon.BackColor = Color.FromArgb(200, 200, 200);
            pic_UsernameIcon.MouseLeave += (s, args) => pic_UsernameIcon.BackColor = Color.Transparent;
            pic_PasswordIcon.MouseEnter += (s, args) => pic_PasswordIcon.BackColor = Color.FromArgb(200, 200, 200);
            pic_PasswordIcon.MouseLeave += (s, args) => pic_PasswordIcon.BackColor = Color.Transparent;
            // Tắt khả năng nhấn của logo
            //if (this.Controls.ContainsKey("pic_Logo"))
            //{
            //    pic_Logo.Enabled = false;
            //}

            // Thiết lập placeholder
            SetupPlaceholder(txt_Username, "Enter username");
            SetupPlaceholder(txt_Password, "Enter password");
        }

        private void SetupPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (textBox == txt_Password && !isPasswordVisible)
                    {
                        textBox.PasswordChar = BULLET;
                    }
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    if (textBox == txt_Password)
                    {
                        textBox.PasswordChar = '\0'; // Đảm bảo không áp dụng PasswordChar khi hiển thị placeholder
                    }
                }
            };

            if (textBox == txt_Password)
            {
                textBox.TextChanged += (s, e) =>
                {
                    if (textBox.Text != placeholder && !isPasswordVisible)
                    {
                        textBox.PasswordChar = BULLET;
                    }
                    else if (textBox.Text == placeholder)
                    {
                        textBox.ForeColor = Color.Gray;
                        textBox.PasswordChar = '\0'; // Đảm bảo không áp dụng PasswordChar khi hiển thị placeholder
                    }
                };
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Enter username" || txt_Password.Text == "Enter password")
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Đặt DialogResult để báo hiệu đăng nhập thành công và đóng form Login
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Login_MouseEnter(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.FromArgb(255, 165, 0);
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.FromArgb(255, 140, 0);
        }

        private void btn_Cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancel.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancel.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void Pic_ShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible; // Chuyển đổi trạng thái

            if (isPasswordVisible)
            {
                // Hiển thị mật khẩu
                pic_ShowPassword.Image = Properties.Resources.EyeOpen;
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                pic_ShowPassword.Image = Properties.Resources.EyeClosed;
                if (txt_Password.Text != "Enter password")
                {
                    txt_Password.PasswordChar = BULLET;
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {

        }
    }
}