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
    /// Interaction logic for Suasach.xaml
    /// </summary>
    public partial class Suasach : Window
    {
        private DataRowView selectedRow;
        private Quanlysach quanlysach;
        public Suasach(DataRowView selectedRow, Quanlysach quanlysach)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            UpdateBook();
            this.quanlysach = quanlysach;
        }
        void UpdateBook()
        {
            updateMaSach.Text = selectedRow["MASACH"].ToString();
            updateGianhap.Text = selectedRow["GIANHAP"].ToString() ;
            updateGiaban.Text = selectedRow["GIABAN"].ToString();
            updateLinhvuc.Text = selectedRow["LINHVUC"].ToString();
            updateLoaisach.Text = selectedRow["LOAISACH"].ToString();
            updateSoluong.Text = selectedRow["SOLUONG"].ToString();
            updateTacgia.Text = selectedRow["TACGIA"].ToString();
            updateTensach.Text = selectedRow["TENSACH"].ToString();
        }
        private void btnCapnhat_Click(object sender, RoutedEventArgs e)
        {
            string query = " UPDATE [dbo].[tblSACH] " +
                    "SET TENSACH = N'" + updateTensach.Text + "', TACGIA = N'" + updateTacgia.Text +
                    "', LINHVUC = N'" + updateLinhvuc.Text + "', LOAISACH = N'" + updateLoaisach.Text + "', GIANHAP = " +
                    updateGianhap.Text + ", GIABAN = " + updateGiaban.Text +
                    ", SOLUONG = N'" + updateSoluong.Text + "' WHERE MASACH = '" + updateMaSach.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
            Loaddata();
            updateMaSach.Text = "";
            updateGianhap.Text = "";
            updateGiaban.Text = "";
            updateLinhvuc.Text = "";
            updateLoaisach.Text = "";
            updateSoluong.Text = "";
            updateTacgia.Text = "";
            updateTensach.Text = "";

            // Đóng cửa sổ hiện tại sau khi cập nhật
            this.Close();
        }

        void Loaddata()
        {
            quanlysach.LoadDataIntoDataGrid();
        }
    }
}
