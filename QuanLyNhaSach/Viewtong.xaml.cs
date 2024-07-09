using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Viewtong : Window
    {
        string Phanquyen;
        string Tennguoidung;
        public Viewtong(string tennguoidung, string phanquyen)
        {
            Tennguoidung = tennguoidung;
            Phanquyen = phanquyen;
            InitializeComponent();
            Loaded += Viewtong_Loaded;
        }
        private void Viewtong_Loaded(object sender, RoutedEventArgs e)
        {
            TrangchuButton.IsChecked = true;
            Control.Content = new Trangchu(Tennguoidung);
        }
        private void TrangchuButton_Checked(object sender, RoutedEventArgs e)
        {
            Control.Content = new Trangchu(Tennguoidung);
        }
        private void QuanlysachButton_Checked(object sender, RoutedEventArgs e)
        {

            Control.Content = new Quanlysach(Phanquyen);
        }
        private void btnTaikhoan_Checked(object sender, RoutedEventArgs e)
        {
           if(Phanquyen == "admin")
            {
                Control.Content = new Taikhoan();
            }
           else
            {
                System.Windows.MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP !", "THÔNG BÁO");
            }
        }

        private void btnHoadon_Checked(object sender, RoutedEventArgs e)
        {
            Control.Content = new Hoadon(Tennguoidung);
        }

        private void btnThongke_Checked(object sender, RoutedEventArgs e)
        {
            Control.Content = new Thongke();
        }

        private void Sanpham_Checked(object sender, RoutedEventArgs e)
        {
            Control.Content = new Sanpham(Phanquyen);
        }

        private void btnDangxuat_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow f = new MainWindow();    
            f.Show();
            this.Close();

        }
    }
}
