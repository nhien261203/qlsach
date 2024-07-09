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
    /// Interaction logic for Themsanpham.xaml
    /// </summary>
    public partial class Themsanpham : Window
    {
        private Sanpham sanpham;
        public Themsanpham(Sanpham sanpham)
        {
            InitializeComponent();
            this.sanpham = sanpham;
            addmasp.Text = Masanpham();
        }
        private string Masanpham()
        {
            string query = "SELECT MAX(MASANPHAM) FROM [QuanLyNhaSach].[dbo].[tblSPVANPHONG] ";
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != DBNull.Value)
            {
                string maxNumber = result.ToString();
                int lastNumber = int.Parse(maxNumber.Substring(2)); // tim ra so tan cung va bo di 2 tu trong string
                int nextNumber = lastNumber + 1;
                return "SP" + nextNumber.ToString("D3"); // voi dinh dang 5 chu so
            }
            else
            {
                return "SP001";
            }

        }

        private void btnThemSP_Click(object sender, RoutedEventArgs e)
        {
            if (addtensp.Text == "" || addgiamuasp.Text == "" || addgiabansp.Text == "" || addsoluongsp.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                string query = "Insert into [QuanLyNhaSach].[dbo].[tblSPVANPHONG] values (" + "'" + addmasp.Text + "',N'" + addtensp.Text + "',N'" + addgiamuasp.Text + "',N'" + addgiabansp.Text + "',N'" + addsoluongsp.Text + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Thêm thành công!", "THÔNG BÁO");
                addmasp.Text = Masanpham();
                addtensp.Text = "";
                addgiamuasp.Text = "";
                addgiabansp.Text = "";
                addsoluongsp.Text = "";
                Loaddata();

            }
        }
        void Loaddata()
        {
            sanpham.LoadDataIntoDataGrid();

        }
    }
}
