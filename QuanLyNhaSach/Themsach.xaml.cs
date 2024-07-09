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
    /// Interaction logic for Themsach.xaml
    /// </summary>
    public partial class Themsach : Window
    {
        private Quanlysach quanlysach;
        public Themsach( Quanlysach quanlysach)
        {
            InitializeComponent();
            this.quanlysach = quanlysach;
            addMaSach.Text = Masach();
        }
        private string Masach()
        {
            string query = "SELECT MAX(MASACH) FROM [QuanLyNhaSach].[dbo].[tblSACH] ";
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != DBNull.Value)
            {
                string maxNumber = result.ToString();
                int lastNumber = int.Parse(maxNumber.Substring(2)); // tim ra so tan cung va bo di 2 tu trong string
                int nextNumber = lastNumber + 1;
                return "MS" + nextNumber.ToString("D3"); // voi dinh dang 5 chu so
            }
            else
            {
                return "MS001"; 
            }
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (addGianhap.Text == "" || addGiaban.Text == "" || addLinhvuc.Text =="" ||  addLoaisach.Text == ""||  addSoluong.Text == ""||  addTacgia.Text == ""||  addTensach.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                string query = "Insert into [QuanLyNhaSach].[dbo].[tblSACH] values (" + "'" + addMaSach.Text + "',N'" + addTensach.Text + "',N'" + addTacgia.Text + "',N'" + addLoaisach.Text + "',N'" + addLinhvuc.Text + "',N'" + addGianhap.Text + "',N'" + addGiaban.Text + "',N'" + addSoluong.Text + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Thêm thành công!", "THÔNG BÁO");
                Loaddata();
                addMaSach.Text = Masach();
                addTensach.Text = "";
                addTacgia.Text = "";
                addLoaisach.Text = "";
                addLinhvuc.Text = "";
                addGianhap.Text = "";
                addGiaban.Text = "";
                addSoluong.Text = "";
            }
        }
        void Loaddata()
        {
            quanlysach.LoadDataIntoDataGrid();
        }
    }
}
