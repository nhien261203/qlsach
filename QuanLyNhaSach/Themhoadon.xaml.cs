using quanlynhasach.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static quanlynhasach.Themhoadon;

namespace quanlynhasach
{
    /// <summary>
    /// Interaction logic for Themhoadon.xaml
    /// </summary>
    public partial class Themhoadon : Window
    {
        string Tennguoidung;
        public class SanPham
        {
            public string Ma { get; set; }
            public string Ten { get; set; }
            public float GiaBan { get; set; }
            public int SoLuong { get; set; }
        }
        private List<SanPham> danhSachSanPham = new List<SanPham>();
        private Hoadon hoadon;
        public Themhoadon( Hoadon hoadon, string tennguoidung)
        {
            Tennguoidung = tennguoidung;
            this.hoadon = hoadon;
            InitializeComponent();
            txtMahoadon.Text = GetMahoadon();
            txtNguoilapHD.Text = Tennguoidung;

        }
        private void btnrdSach_Checked(object sender, RoutedEventArgs e)
        {
            string query = "SELECT MASACH, TENSACH, GIABAN, SOLUONG FROM [QuanLyNhaSach].[dbo].[tblSACH]";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgAddSachvaSanPham.ItemsSource = dataTable.DefaultView;
            dgAddSachvaSanPham.Items.Refresh();
        }

        private void btnrdSanpham_Checked(object sender, RoutedEventArgs e)
        {
            string query = "SELECT MASANPHAM,TENSANPHAM,SOLUONG,GIABAN FROM [QuanLyNhaSach].[dbo].[tblSPVANPHONG]";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            this.dgAddSachvaSanPham.ItemsSource = dataTable.DefaultView;
            dgAddSachvaSanPham.Items.Refresh();
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
        private DataRowView selectedRow;
        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgAddSachvaSanPham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgAddSachvaSanPham.SelectedItem != null)
            {
                selectedRow = (DataRowView)dgAddSachvaSanPham.SelectedItem;
            }
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để thêm!", "Thông báo");
                return;
            }

            int soluongmua;
            if (!int.TryParse(txtSoluong.Text, out soluongmua) || soluongmua <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng mua hợp lệ!", "Thông báo");
                return;
            }
            if (btnrdSanpham.IsChecked == true)
            {
                string masanpham = selectedRow["MASANPHAM"].ToString();
                string tensanpham = selectedRow["TENSANPHAM"].ToString();
                float dongiasp = float.Parse(selectedRow["GIABAN"].ToString());

                SanPham sanpham = new SanPham
                {
                    Ma = masanpham,
                    Ten = tensanpham,
                    GiaBan = dongiasp,
                    SoLuong = soluongmua
                };

                danhSachSanPham.Add(sanpham);
                // Thêm thông báo
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else if (btnrdSach.IsChecked == true)
            {
                string masach = selectedRow["MASACH"].ToString();
                string tensach = selectedRow["TENSACH"].ToString();
                float dongia = float.Parse(selectedRow["GIABAN"].ToString());

                SanPham sach = new SanPham
                {
                    Ma = masach,
                    Ten = tensach,
                    GiaBan = dongia,
                    SoLuong = soluongmua
                };

                danhSachSanPham.Add(sach);

                // Thêm thông báo
                MessageBox.Show("Thêm sách thành công!");
            }

            // Cập nhật danh sách hiển thị
            UpdateListView();
            int soluongHienTai = int.Parse(selectedRow["SOLUONG"].ToString());
            int soluongSauKhiMua = soluongHienTai - soluongmua;
            selectedRow["SOLUONG"] = soluongSauKhiMua.ToString();
            dgAddSachvaSanPham.Items.Refresh();
            TinhTongTien();


        }
        private void UpdateListView()
        {
            dgChiTiet.Items.Clear();

            foreach (var item in danhSachSanPham)
            {
                float thanhTien = item.GiaBan * item.SoLuong; // Tính toán thành tiền

                // Tạo một đối tượng mới chứa thông tin để hiển thị trong ListView
                var newItem = new
                {
                    Ma = item.Ma,
                    Ten = item.Ten,
                    Soluong = item.SoLuong,
                    Giaban = item.GiaBan,
                    Thanhtien = thanhTien // Thêm thuộc tính Thanhtien
                };

                dgChiTiet.Items.Add(newItem);
            }
           
        }
        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            int index = dgChiTiet.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo");
                return;
            }
            // Lấy thông tin về mục bị xóa từ danh sách sản phẩm
            SanPham sanPhamRemoved = danhSachSanPham[index];
            // Lặp qua mỗi dòng trong dgAddSachvaSanPham để tìm mục cần cập nhật số lượng
            foreach (DataRowView row in dgAddSachvaSanPham.Items)
            {
                if (btnrdSach.IsChecked == true && row["MASACH"].ToString() == sanPhamRemoved.Ma)
                {
                    // Cập nhật số lượng cho sách
                    int soluongHienTai = int.Parse(row["SOLUONG"].ToString());
                    int soluongSauKhiXoa = soluongHienTai + sanPhamRemoved.SoLuong; // Phục hồi số lượng
                    row["SOLUONG"] = soluongSauKhiXoa.ToString();
                    break;
                }
                else if (btnrdSanpham.IsChecked == true && row["MASANPHAM"].ToString() == sanPhamRemoved.Ma)
                {
                    // Cập nhật số lượng cho sản phẩm văn phòng
                    int soluongHienTai = int.Parse(row["SOLUONG"].ToString());
                    int soluongSauKhiXoa = soluongHienTai + sanPhamRemoved.SoLuong; // Phục hồi số lượng
                    row["SOLUONG"] = soluongSauKhiXoa.ToString();
                    break;
                }
            }
            // Xóa mục khỏi danhSachSanPham
            danhSachSanPham.RemoveAt(index);
            // Xóa mục khỏi dgChiTiet
            dgChiTiet.Items.RemoveAt(index);
            // Làm mới dgAddSachvaSanpham để hiển thị dữ liệu đã được cập nhật
            dgAddSachvaSanPham.Items.Refresh();
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            float tongTien = 0;
            foreach (var item in danhSachSanPham)
            {
                tongTien += item.GiaBan * item.SoLuong;
            }
            // Hiển thị tổng số tiền
            Sum.Text = tongTien.ToString("c").Replace("Rp", "") + " VNĐ"; // Hiển thị số tiền dưới dạng tiền tệ
        }

        private string GetMahoadon()
        {
            string query = "SELECT MAX(MAHOADON) FROM [QuanLyNhaSach].[dbo].[tblHOADON]";
            object result = DataProvider.Instance.ExecuteScalar(query);

            if (result != DBNull.Value)
            {
                string maxNumber = result.ToString();
                int lastNumber = int.Parse(maxNumber.Substring(2)); // tim ra so tan cung va bo di 2 tu trong string
                int nextNumber = lastNumber + 1;
                return "HD" + nextNumber.ToString("D3"); // voi dinh dang 5 chu so
            }
            else
            {
                return "HD001"; // bat dau voi hd00001
            }
        }
        private void btnHoanthanhhd_Click(object sender, RoutedEventArgs e)
        {
            double tongTien = 0;
            string mahoadon = GetMahoadon();
            foreach (var item in danhSachSanPham)
            {
                tongTien += item.GiaBan * item.SoLuong;
            }
            if (txtTenkhachhang.Text == "" || txtNguoilapHD.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                string query = "INSERT INTO [dbo].[tblHOADON] VALUES ('" + mahoadon + "', N'" + txtTenkhachhang.Text + "', GETDATE(), N'" + txtNguoilapHD.Text + "','" + tongTien + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                
                    foreach (var item in danhSachSanPham)
                    {
                        string maSanpham = item.Ma;
                        int soLuong = item.SoLuong;
                        string tenSanpham = item.Ten; // Sửa tên biến thành tenSanpham
                        double giaTien = item.GiaBan;
                        double thanhTien = item.GiaBan * item.SoLuong; // Sửa thành tiền tính lại ở đây
                        string insertChiTietQuery = $"INSERT INTO [dbo].[tblCHITIETHOADON]" +
                        $"([MAHOADON],[MASANPHAM],[TENSANPHAM],[SOLUONGSP],[GIABAN],[THANHTIEN]) " +
                        $"VALUES('{mahoadon}', '{maSanpham}', N'{tenSanpham}', {soLuong}, {giaTien}, {thanhTien})";
                        string updateSoLuongSach = $"UPDATE [dbo].[tblSACH] SET SOLUONG = SOLUONG - {soLuong} WHERE MASACH = '{maSanpham}'";
                        string updateSoLuongSp = $"UPDATE [dbo].[tblSPVANPHONG] SET SOLUONG = SOLUONG - {soLuong} WHERE MASANPHAM = '{maSanpham}'";
                        DataProvider.Instance.ExecuteNonQuery(insertChiTietQuery);
                        DataProvider.Instance.ExecuteNonQuery(updateSoLuongSach);
                        DataProvider.Instance.ExecuteNonQuery(updateSoLuongSp);
                    }
                     reLoaddata();
                     MessageBox.Show("Thêm hóa đơn thành công!", "THÔNG BÁO");
                     this.Close();
            }      
        }
        void reLoaddata()
        {
            hoadon.Loaddata();
        }

        private void btnTimkiem_Click(object sender, RoutedEventArgs e)
        {
            String keyword = txtSearchBookorSanpham.Text.Trim();
            if(btnrdSach.IsChecked == true)
            {
                string query = "SELECT MASACH, TENSACH, TACGIA, LINHVUC, LOAISACH, GIANHAP, GIABAN, SOLUONG FROM [dbo].[tblSACH] WHERE MASACH LIKE '%" + keyword + "%' OR TENSACH LIKE '%" + keyword + "%' OR TACGIA LIKE '%" + keyword + "%' OR LINHVUC LIKE '%" + keyword + "%' OR LOAISACH LIKE '%" + keyword + "%'";
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
                this.dgAddSachvaSanPham.ItemsSource = dataTable.DefaultView;
                dgAddSachvaSanPham.Items.Refresh();
            }
            else
            {
                string query = "SELECT * FROM [dbo].[tblSPVANPHONG] WHERE MASANPHAM LIKE '%" + keyword + "%' OR TENSANPHAM LIKE '%" + keyword + "%' OR SOLUONG LIKE '%" + keyword + "%'";
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
                this.dgAddSachvaSanPham.ItemsSource = dataTable.DefaultView;
                dgAddSachvaSanPham.Items.Refresh();
            }
        }
        private void Enter_keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnTimkiem_Click(sender, e);
            }
        }
    }

}

