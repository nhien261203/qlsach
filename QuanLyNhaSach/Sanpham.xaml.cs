using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using quanlynhasach.Data;
using System.Text.RegularExpressions;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for Sanpham.xaml
    /// </summary>
    public partial class Sanpham : System.Windows.Controls.UserControl
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        
        private DataRowView selectedRow;
        string phanquyen;
        public Sanpham(string phanquyen)
        {
            InitializeComponent();
            LoadDataIntoDataGrid();
            this.phanquyen = phanquyen;
        }

        public void LoadDataIntoDataGrid()
        {
            string query = "SELECT * FROM [QuanLyNhaSach].[dbo].[tblSPVANPHONG]";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgSanpham.ItemsSource = dataTable.DefaultView;
            dgSanpham.Items.Refresh();

        }
        public void dgSanpham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgSanpham.SelectedItem != null)
            {
                selectedRow = (DataRowView)dgSanpham.SelectedItem;
            }
        }



        private void BtnThemsanpham_Click(object sender, RoutedEventArgs e)
        {
            if (phanquyen == "admin")
            {
                Themsanpham themsanpham = new Themsanpham(this);
                themsanpham.Show();
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "THÔNG BÁO");
            }
           
        }

      

        private void BtnSuasanpham_Click(object sender, RoutedEventArgs e)
        {
           if(phanquyen == "admin")
            {
                if (selectedRow != null)
                {

                    Suasanpham suasanpham = new Suasanpham(selectedRow, this);
                    suasanpham.Show();
                }
                else
                {
                    System.Windows.MessageBox.Show("Vui lòng chọn sách để sửa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "THÔNG BÁO");
            }


        }
     
        
        private void btnLammoiSP_Click(object sender, RoutedEventArgs e)
        {
            LoadDataIntoDataGrid();
        }
        private void btnTimkiemSP_Click(object sender, RoutedEventArgs e)
        {
            String keyword = txtSearchSP.Text.Trim();
            string query = "SELECT * FROM [dbo].[tblSPVANPHONG] WHERE TENSANPHAM LIKE '%" + keyword + "%'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgSanpham.ItemsSource = dataTable.DefaultView;
            dgSanpham.Items.Refresh();
        } 
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
            if (textBox.Text == "Tìm kiếm")
            {
                textBox.Text = "";
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Tìm kiếm";
            }
        }

        private void BtnXoaSP_Click(object sender, RoutedEventArgs e)
        {
            if (phanquyen == "admin")
            {
                if (selectedRow != null)
                {
                    string maSp = selectedRow["MASANPHAM"].ToString();

                    string query = "DELETE FROM [dbo].[tblSPVANPHONG] WHERE MASANPHAM = '" + maSp + "'";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    System.Windows.MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                    LoadDataIntoDataGrid();
                }
                else
                {
                    MessageBox.Show("VUI LÒNG CHỌN SẢN PHẨM ĐỂ XÓA", "THÔNG BÁO");
                }
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "THÔNG BÁO");
            }
        }


    }
}
