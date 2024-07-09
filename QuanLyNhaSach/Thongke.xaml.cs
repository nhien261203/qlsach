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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for Thongke.xaml
    /// </summary>
    public partial class Thongke : UserControl
    {
        public Thongke()
        {
            InitializeComponent();
        }

        public void LoadDataIntoDataGrid()
        {
            DateTime tungay = DatePickerTuNgay.SelectedDate.Value;
            DateTime denngay = DatePickerDenNgay.SelectedDate.Value;
            string formattedTuNgay = tungay.ToString("yyyy-MM-dd");
            string formattedDenNgay = denngay.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM [QuanLyNhaSach].[dbo].[tblHOADON] WHERE NGAYLAP BETWEEN '" + formattedTuNgay + "' AND '" + formattedDenNgay + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgThongke.ItemsSource = dataTable.DefaultView;
            dgThongke.Items.Refresh();
            double Sum = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                double amount = Convert.ToDouble(row["TONGTIEN"]);
                Sum += amount;
            }
            tongdoanhthu.Content = string.Format("{0:N0} VNĐ", Sum);
        }

        private void timkiem_Click(object sender, RoutedEventArgs e)
        {
            LoadDataIntoDataGrid();
        }
    }
}
