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

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for Trangchu.xaml
    /// </summary>
    public partial class Trangchu : UserControl
    {
        string Tennguoidung;
        public Trangchu(string tennguoidung)
        {
            Tennguoidung = tennguoidung;
            InitializeComponent();
            Loaded();
        }
        void Loaded()
        {
            DateTime tg = DateTime.Now;
            lblTime.Content = tg.ToString("dddd, dd/MM/yyyy");
            tennguoidung.Content = Tennguoidung;
            string timenow = DateTime.Now.ToString("yyyy-MM-dd");
            string query = $"SELECT SUM(TONGTIEN) AS [DOANHTHU] FROM [QuanLyNhaSach].[dbo].[tblHOADON] WHERE NGAYLAP BETWEEN '{timenow} 00:00:00' AND '{timenow} 23:59:59'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0 && data.Rows[0][0] != DBNull.Value)
            {
                // Lấy giá trị tổng doanh thu từ cơ sở dữ liệu
                decimal doanhThu = Convert.ToDecimal(data.Rows[0][0]);
                // Chuyển đổi giá trị số sang định dạng tiền tệ Việt Nam
                Doanhthu.Content = string.Format("{0:N0} VNĐ", doanhThu);
            }
            else
            {
                Doanhthu.Content = "0 VNĐ"; // Nếu không có dữ liệu, hiển thị giá trị mặc định là 0 VNĐ
            }
            string query2 = $"SELECT COUNT(MAHOADON) FROM [QuanLyNhaSach].[dbo].[tblHOADON] WHERE NGAYLAP BETWEEN '{timenow} 00:00:00' AND '{timenow} 23:59:59'";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            if (data2.Rows.Count > 0 && data2.Rows[0][0] != DBNull.Value)
            {
                Soluongkhach.Content = data2.Rows[0][0].ToString() + " người";
            }
            else
            {
                Soluongkhach.Content = "0 người";
            }

        }
    }
}
