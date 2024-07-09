using System;
using System.Data;
using System.Windows;
using System.Windows.Input;
using quanlynhasach.Data;
namespace quanlynhasach
{
    public partial class MainWindow : Window
    {
        private int count = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐẦY ĐỦ THÔNG TIN", "THÔNG BÁO");
            }
            else
            {
                string query = "SELECT * FROM [QuanLyNhaSach].[dbo].[tblTAIKHOAN] WHERE TENTAIKHOAN = '" + username + "'  AND MATKHAU = '" + password + "'";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    Viewtong f = new Viewtong(result.Rows[0][1].ToString(), result.Rows[0][3].ToString());
                    f.Show();
                    this.Close();
                }
                else
                {
                    count++;

                    if (count <= 3)
                    {
                        MessageBox.Show("TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU KHÔNG ĐÚNG, VUI LÒNG THỬ LẠI", "THÔNG BÁO");
                    }
                    else
                    {
                        MessageBoxResult r = MessageBox.Show("BẠN ĐÃ NHẬP SAI 3 LẦN LIÊN TIẾP. THOÁT CHƯƠNG TRÌNH ?", "THÔNG BÁO", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (r == MessageBoxResult.Yes)
                        {
                            Application.Current.Shutdown();
                        }
                        count = 1;
                    }
                }
                txtTaikhoan.Text = "";
                txtMatkhau.Password = "";
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (r == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
