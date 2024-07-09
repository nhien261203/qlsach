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
    /// Interaction logic for Suasanpham.xaml
    /// </summary>
    public partial class Suasanpham : Window
    {
        private DataRowView selectedRow;
        private Sanpham sanpham;
        public Suasanpham(DataRowView selectedRow, Sanpham sanpham)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.sanpham = sanpham;
            UpdateSP();
        }

        void UpdateSP()
        {
            updateMasp.Text = selectedRow["MASANPHAM"].ToString();
            updateTensp.Text = selectedRow["TENSANPHAM"].ToString();
            updateSoluong.Text = selectedRow["SOLUONG"].ToString();
            updateGianhap.Text = selectedRow["GIANHAP"].ToString();
            updateGiaban.Text = selectedRow["GIABAN"].ToString();
        }

        private void BtnUpdateSP_Click(object sender, RoutedEventArgs e)
        {
           
                string query = " UPDATE [dbo].[tblSPVANPHONG] " +
                        "SET TENSANPHAM = N'" + updateTensp.Text +  "', GIANHAP = " +
                         updateGianhap.Text + ", GIABAN = " + updateGiaban.Text +
                        ", SOLUONG = N'" + updateSoluong.Text + "' WHERE MASANPHAM = '" + updateMasp.Text + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
                Loaddata();
            updateMasp.Text = "";
            updateTensp.Text = "";
            updateSoluong.Text = "";
            updateGianhap.Text = "";
            updateGiaban.Text = "";
            // Đóng cửa sổ hiện tại sau khi cập nhật
            this.Close();
        }
        void Loaddata()
        {
            sanpham.LoadDataIntoDataGrid();
        }
    }
}
