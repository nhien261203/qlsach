using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using quanlynhasach.Data;

namespace quanlynhasach
{
    public partial class Quanlysach : UserControl
    {
        string Phanquyen;
        private DataRowView selectedRow;

        public Quanlysach(string phanquyen)
        {
            Phanquyen = phanquyen;
            InitializeComponent();
            LoadDataIntoDataGrid();
        }

        public void LoadDataIntoDataGrid()
        {
            string query = "SELECT MASACH, TENSACH, TACGIA, LOAISACH, LINHVUC, GIANHAP, GIABAN, SOLUONG FROM [QuanLyNhaSach].[dbo].[tblSACH]";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgSach.ItemsSource = dataTable.DefaultView;
            dgSach.Items.Refresh();
        }

        private void BtnThemsach_Click(object sender, RoutedEventArgs e)
        {

            if (Phanquyen == "admin")
            {
                Themsach themsach = new Themsach(this);
                themsach.Show();
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "THÔNG BÁO");
            }
        }

        private void dgSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgSach.SelectedItem != null)
            {
                selectedRow = (DataRowView)dgSach.SelectedItem;
            }
        }

        private void BtnSuasach_Click(object sender, RoutedEventArgs e)
        {
            if (Phanquyen == "admin")
            {
                if (selectedRow != null)
                {
                    Suasach suasach = new Suasach(selectedRow, this);
                    suasach.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sách để sửa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "THÔNG BÁO");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (Phanquyen == "admin")
            {
                if (selectedRow != null)
                {
                    string masach = selectedRow["MASACH"].ToString();
                    string query = "DELETE FROM [dbo].[tblSACH] WHERE MASACH = '" + masach + "'";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                    LoadDataIntoDataGrid();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sách để xóa!", "THÔNG BÁO");
                }
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN TRUY CẬP", "THÔNG BÁO");
            }
        }

        private void btnTimkiem_Click(object sender, RoutedEventArgs e)
        {
            String keyword = txtSearchBook.Text.Trim();
            string query = "SELECT MASACH, TENSACH, TACGIA, LINHVUC, LOAISACH, GIANHAP, GIABAN, SOLUONG FROM [dbo].[tblSACH] WHERE MASACH LIKE '%" + keyword + "%' OR TENSACH LIKE '%" + keyword + "%' OR TACGIA LIKE '%" + keyword + "%' OR LINHVUC LIKE '%" + keyword + "%' OR LOAISACH LIKE '%" + keyword + "%'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgSach.ItemsSource = dataTable.DefaultView;
            dgSach.Items.Refresh();
        }

        private void btnLammoi_Click(object sender, RoutedEventArgs e)
        {
            LoadDataIntoDataGrid();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Tìm kiếm")
            {
                textBox.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Tìm kiếm";
            }
        }

        private void txtSearchBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnTimkiem_Click(sender, e);
            }
        }
    }
}
