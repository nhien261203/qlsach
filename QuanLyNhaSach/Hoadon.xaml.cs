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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static quanlynhasach.Themhoadon;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for Hoadon.xaml
    /// </summary>
    public partial class Hoadon : UserControl
    {
        string Tennguoidung;
        public Hoadon( string tennguoidung)
        {   
            Tennguoidung = tennguoidung;    
            InitializeComponent();
            Loaddata();
        }

        private void btnAddHoadon_Click(object sender, RoutedEventArgs e)
        {
            Themhoadon themhoadon = new Themhoadon(this, Tennguoidung);
            themhoadon.Show();
        }
        public void Loaddata()
        {
            string query = "SELECT * FROM [QuanLyNhaSach].[dbo].[tblHOADON] ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgHoadon.ItemsSource = dataTable.DefaultView;
            dgHoadon.Items.Refresh();
        }
        private DataRowView selectedRow;
        private void dgHoadon_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (dgHoadon.SelectedItem != null)
            {
                selectedRow = (DataRowView)dgHoadon.SelectedItem;
            }
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearchHD.Text.Trim();
            string query = "SELECT MAHOADON, TENKHACHHANG, NGAYLAP, NHANVIENLAPHD FROM [dbo].[tblHOADON] WHERE TENKHACHHANG = '" + keyword + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgHoadon.ItemsSource = dataTable.DefaultView;
            dgHoadon.Items.Refresh();
        }

        private void btnChitiet_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRow != null)
            {
                string Tenkhachhang = selectedRow["TENKHACHHANG"].ToString();
                string Nhanvienlaphd = selectedRow["NHANVIENLAPHD"].ToString();
                string maHoaDon = selectedRow["MAHOADON"].ToString();
                string sqlQuery = "SELECT * FROM [QuanLyNhaSach].[dbo].[tblCHITIETHOADON] WHERE MAHOADON = '" + maHoaDon + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(sqlQuery);
                Chitiethoadon chiTiet = new Chitiethoadon(data, Nhanvienlaphd, Tenkhachhang);
                chiTiet.Show();

            }
        }

    
    }
}
