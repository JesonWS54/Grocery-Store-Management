using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Grocery_Store_Management
{
    public partial class SplashScreen : Form
    {
        private Timer timer;

        public SplashScreen()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = CreateRoundedRegion(20);
            this.Resize += SplashScreen_Resize;

            timer = new Timer();
            timer.Interval = 3000; // Thời gian hiển thị SplashScreen
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close(); // Đóng SplashScreen mà không cần hiệu ứng
            };
            timer.Start();
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

        private void SplashScreen_Resize(object sender, EventArgs e)
        {
            this.Region = CreateRoundedRegion(20);
            if (this.Controls.ContainsKey("pic_Loading"))
            {
                Control pic_Loading = this.Controls["pic_Loading"];
                pic_Loading.Location = new Point((this.ClientSize.Width - pic_Loading.Width) / 2, (this.ClientSize.Height - pic_Loading.Height) / 2);
            }
            if (this.Controls.ContainsKey("lbl_Loading"))
            {
                Control lbl_Loading = this.Controls["lbl_Loading"];
                lbl_Loading.Location = new Point((this.ClientSize.Width - lbl_Loading.Width) / 2, this.ClientSize.Height - 80);
            }
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

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Bạn có thể thêm logic khởi tạo nếu cần
        }
    }
}
