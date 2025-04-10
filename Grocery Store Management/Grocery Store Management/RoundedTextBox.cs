using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Grocery_Store_Management
{
    public class RoundedTextBox : TextBox
    {
        private int _radius = 10; // Bán kính bo góc

        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None; // Tắt viền mặc định
            this.BackColor = Color.White; // Màu nền
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                int diameter = _radius * 2;

                // Tạo hình chữ nhật bo góc
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                // Vẽ viền
                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Vẽ lại khi thay đổi kích thước
        }
    }
}