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
    /// Interaction logic for Chitiethoadon.xaml
    /// </summary>
    public partial class Chitiethoadon : Window
    {
        private DataTable dataTable;
        string Nhanvienlaphd;
        string Tenkhachhang;
        public Chitiethoadon(DataTable dataTable, string Nhanvienlaphd, string Tenkhachhang)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            dgChiTietHD.ItemsSource = dataTable.DefaultView;
            this.Nhanvienlaphd = Nhanvienlaphd;
            this.Tenkhachhang = Tenkhachhang;
            nhanvien.Content = Nhanvienlaphd;
            tenkhachhang.Content = Tenkhachhang;
        }

    }
}
