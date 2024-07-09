using quanlynhasach.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for Taikhoan.xaml
    /// </summary>
    public partial class Taikhoan : UserControl
    {
        private string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Persist Security Info=True;User ID=sa;Password=123456;";
        public Taikhoan()
        {
            InitializeComponent();
            LoadDataIntoDataGrid();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT [TENTAIKHOAN], [MATKHAU] FROM [QuanLyNhaSach].[dbo].[tblTAIKHOAN]";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string TenDangNhap = reader.GetString(0);
                        dgTaiKhoan.Items.Add(TenDangNhap);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnThemtaikhoan_Click(object sender, RoutedEventArgs e)
        {
            Themtaikhoan themtaikhoan = new Themtaikhoan(this);
            themtaikhoan.Show();
        }
        public void LoadDataIntoDataGrid()
        {
            string query = "SELECT TENTAIKHOAN, TENNGUOIDUNG, MATKHAU, PHANQUYEN FROM [QuanLyNhaSach].[dbo].[tblTAIKHOAN]";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgTaiKhoan.ItemsSource = dataTable.DefaultView;
            dgTaiKhoan.Items.Refresh();
        }

        private DataRowView selectedRow;

        private void dgTaiKhoan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgTaiKhoan.SelectedItem != null)
            {
                selectedRow = (DataRowView)dgTaiKhoan.SelectedItem;
            }
        }

        private void btnXoataikhoan_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRow != null)
            {
                string tentaikhoan = selectedRow["TENTAIKHOAN"].ToString();
                string query = "DELETE FROM [dbo].[tblTAIKHOAN] WHERE TENTAIKHOAN = '" + tentaikhoan + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                System.Windows.MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                LoadDataIntoDataGrid();
            }
            else
            {
                System.Windows.MessageBox.Show("Vui lòng chọn tên tài khoản để xóa!", "THÔNG BÁO");
            }
        }
        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhauHienTai = passwMKHienTai.Text;
            string matKhauMoi = passwMKMoi.Password;
            string nhapLai = passwNhapLai.Password;

            if (matKhauMoi != nhapLai)
            {
                MessageBox.Show("Mặt khẩu mới và nhập lại không khớp!");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [QuanLyNhaSach].[dbo].[tblTAIKHOAN] SET [MATKHAU] = @MatKhauMoi WHERE [TENTAIKHOAN] = @TenDangNhap AND [MATKHAU] = @MatKhauHienTai";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhauHienTai", matKhauHienTai);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!");
                        ClearInputs();
                        LoadDataIntoDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ClearInputs()
        {
            txtTenDangNhap.Text = "";
            passwMKHienTai.Text= "";
            passwMKMoi.Password = "";
            passwNhapLai.Password = "";
        }
    }
}
