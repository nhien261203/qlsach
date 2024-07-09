using quanlynhasach.Data;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for ThemTaiKhoan.xaml
    /// </summary>
    public partial class Themtaikhoan : Window
    {
        private Taikhoan taikhoan;
        public Themtaikhoan(Taikhoan taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (addTenTaiKhoan.Text == "" || addTenNguoiDung.Text == "" || addMatKhau.Text == "" || addPhanQuyen.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                string query = "Insert into [QuanLyNhaSach].[dbo].[tblTAIKHOAN] values (" + "'" + addTenTaiKhoan.Text + "',N'" + addTenNguoiDung.Text + "',N'" + addMatKhau.Text + "',N'" + addPhanQuyen.Text + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Thêm thành công!", "THÔNG BÁO");
                Loaddata();
                addTenTaiKhoan.Text = "";
                addTenNguoiDung.Text = "";
                addMatKhau.Text = "";
                addPhanQuyen.Text = "";
            }
        }

        void Loaddata()
        {
            taikhoan.LoadDataIntoDataGrid();
        }

    }
}
