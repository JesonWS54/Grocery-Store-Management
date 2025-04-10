using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Grocery_Store_Management
{
    public class RoundedButton : Button
    {
        private int _radius = 10; // Bán kính bo góc

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; // Tắt viền mặc định
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

                // Vẽ nền
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Vẽ viền
                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Vẽ text của nút
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality; // Đảm bảo text hiển thị mượt mà
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit; // Chất lượng text cao
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                    {
                        // Đảm bảo vùng vẽ text nằm trong phạm vi của nút
                        RectangleF textRect = new RectangleF(0, 0, this.Width, this.Height);
                        e.Graphics.DrawString(this.Text, this.Font, textBrush, textRect, sf);
                    }
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