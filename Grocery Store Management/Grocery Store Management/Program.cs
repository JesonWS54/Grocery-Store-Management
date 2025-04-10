using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Grocery_Store_Management
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị SplashScreen và chờ nó đóng
            using (SplashScreen splash = new SplashScreen())
            {
                splash.ShowDialog();
            }

            // Mở form Login
            using (Login loginForm = new Login())
            {
                loginForm.Opacity = 0;
                loginForm.Load += async (loadSender, loadArgs) =>
                {
                    await CustomApplicationContext.FadeIn(loginForm);
                };
                if (loginForm.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Sử dụng ApplicationContext để quản lý vòng đời ứng dụng
            var context = new CustomApplicationContext();
            Application.Run(context);
        }
    }

    public class CustomApplicationContext : ApplicationContext
    {
        private static bool _isLoggingOut = false;

        public CustomApplicationContext()
        {
            // Mở form Inventory ngay sau khi ApplicationContext được khởi tạo
            var inventoryForm = new Inventory();
            inventoryForm.FormClosed += Form_FormClosed; // Đảm bảo xử lý chính xác khi form bị đóng
            inventoryForm.Show();
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0 && !_isLoggingOut)
            {
                var loginForm = new Login();
                loginForm.FormClosed += (loginSender, loginArgs) =>
                {
                    if (Application.OpenForms.Count == 0)
                    {
                        Application.Exit(); // Thoát ứng dụng nếu không còn form nào
                    }
                };
                loginForm.Show();
            }
        }


        public static async Task SwitchForm(Form currentForm, Form newForm)
        {
            newForm.Show(); // Hiển thị form mới
            currentForm.Hide(); // Ẩn form hiện tại thay vì đóng
        }


        public static async Task FadeIn(Form form)
        {
            form.Opacity = 1; // Đảm bảo form hiển thị ngay lập tức
        }

        public static async Task FadeOut(Form form)
        {
            form.Opacity = 0; // Đảm bảo form ẩn ngay lập tức
        }

        public static async Task Logout(Form currentForm)
        {
            try
            {
                _isLoggingOut = true;
                currentForm.Close(); // Đóng form hiện tại

                var loginForm = new Login();
                loginForm.FormClosed += (loginSender, loginArgs) =>
                {
                    if (Application.OpenForms.Count == 0)
                    {
                        Application.Exit(); // Thoát ứng dụng nếu không còn form nào
                    }
                };
                loginForm.Show();
            }
            finally
            {
                _isLoggingOut = false;
            }
        }
    }
}
