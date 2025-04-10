using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Grocery_Store_Management
{
    public partial class Employee : Form
    {
        private Button currentButton;

        public Employee()
        {
            InitializeComponent();
            SetupForm();
            SetupMenu();
            ActivateButton(btn_Employee);
            this.FormClosing += Employee_FormClosing;
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Region = CreateRoundedRegion(20);
            panelMenu.BackColor = Color.FromArgb(255, 140, 0);
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

        private void SetupMenu()
        {
            SetupButton(btn_Inventory, "Inventory");
            SetupButton(btn_Sales, "Sales");
            SetupButton(btn_Customer, "Customer");
            SetupButton(btn_Employee, "Employee");
            SetupButton(btn_Finance, "Finance");

            SetupButton(btn_Logout, "Logout");
            btn_Logout.MouseEnter += (s, e) => btn_Logout.BackColor = Color.FromArgb(255, 165, 0);
            btn_Logout.MouseLeave += (s, e) => btn_Logout.BackColor = Color.FromArgb(255, 140, 0);

            btn_Inventory.Click += BtnInventory_Click;
            btn_Sales.Click += BtnSales_Click;
            btn_Customer.Click += BtnCustomer_Click;
            btn_Employee.Click += BtnEmployee_Click;
            btn_Finance.Click += BtnFinance_Click;
            btn_Logout.Click += BtnLogout_Click;
        }

        private void SetupButton(Button btn, string text)
        {
            btn.Text = text;
            btn.BackColor = Color.FromArgb(255, 140, 0);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            btn.Region = CreateRoundedRegion(10);
            btn.MouseEnter += (s, e) =>
            {
                if (btn != currentButton) btn.BackColor = Color.FromArgb(255, 165, 0);
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn != currentButton) btn.BackColor = Color.FromArgb(255, 140, 0);
            };
            btn.Tag = text;
        }

        private void ActivateButton(Button btn)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(255, 140, 0);
            }
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(255, 120, 0);
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_Inventory);
            Inventory inventoryForm = new Inventory();
            CustomApplicationContext.SwitchForm(this, inventoryForm);
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_Sales);
            Sales salesForm = new Sales();
            CustomApplicationContext.SwitchForm(this, salesForm);
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_Customer);
            Customer customerForm = new Customer();
            CustomApplicationContext.SwitchForm(this, customerForm);
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_Employee);
        }

        private void BtnFinance_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_Finance);
            Finance financeForm = new Finance();
            CustomApplicationContext.SwitchForm(this, financeForm);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            CustomApplicationContext.Logout(this);
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                BtnLogout_Click(sender, new EventArgs());
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra kết quả người dùng chọn
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form nếu chọn "Yes"
            }
            // Nếu chọn "No", không làm gì cả (giữ form mở)
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            // Logic khởi tạo nếu cần
        }

    }
}
