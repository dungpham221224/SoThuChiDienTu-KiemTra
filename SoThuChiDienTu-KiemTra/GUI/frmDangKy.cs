using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SoThuChiDienTu_KiemTra.DAO;
using SoThuChiDienTu_KiemTra.GUI;


namespace SoThuChiDienTu_KiemTra.GUI
{
    public partial class frmDangKy : Form
    {
        

        public frmDangKy()
        {
           
            InitializeComponent();
            cboTinh.SelectedIndexChanged += cboTinh_SelectedIndexChanged;
        }

       

        // Hàm tải danh sách tỉnh/thành phố từ bảng TinhThanhPho
        private void LoadTinhThanhPho()
        {
            string query = "SELECT ID, tenTinhThanhPho FROM dbo.TinhThanhPho";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            cboTinh.DataSource = dt;
            cboTinh.DisplayMember = "tenTinhThanhPho";
            cboTinh.ValueMember = "ID";
            cboTinh.SelectedIndex = -1; // Đưa combobox về trạng thái không chọn
           
            

        }

        // Khi người dùng chọn một tỉnh, cập nhật danh sách Quận/Huyện tương ứng
        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.SelectedValue == null || cboTinh.SelectedValue is DBNull)
                return;

            if (long.TryParse(cboTinh.SelectedValue.ToString(), out long tinhID))
            {
                LoadQuanHuyen(tinhID);
            }
        }

        // Hàm tải danh sách Quận/Huyện từ bảng QuanHuyen theo mã tỉnh
        private void LoadQuanHuyen(long tinhID)
        {
            string query = "SELECT ID, tenQuanHuyen FROM dbo.QuanHuyen WHERE tinhThanhPhoId = @tinhID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tinhID });
            cboHuyen.DataSource = dt;
            cboHuyen.DisplayMember = "tenQuanHuyen";
            cboHuyen.ValueMember = "ID";
            cboHuyen.SelectedIndex = -1; // Reset lại lựa chọn
            

        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ form
                string hoTen = txtHoTen.Text.Trim();
                string matKhau = txtMatKhau.Text;
                string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                string sdt = mtxtSDT.Text.Trim();
                string diaChi = $"{cboTinh.Text}/{cboHuyen.Text}";
                DateTime ngaySinh = dtpNgaySinh.Value;
                string taiKhoan = txtTaiKhoan.Text.Trim();

                // Validate dữ liệu
                if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được để trống!");
                    return;
                }

                // Gọi phương thức đăng ký
                bool result = TaiKhoanDAO.Instance.DangKy(taiKhoan, matKhau, gioiTinh, sdt, diaChi, ngaySinh, hoTen);

                if (result)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close(); // Đóng form sau khi đăng ký thành công
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại! Tài khoản có thể đã tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}");
            }
        }

        private void frmDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmDangKy_Load_1(object sender, EventArgs e)
        {
            this.Load += new System.EventHandler(this.frmDangKy_Load_1);

            LoadTinhThanhPho();
    }

        private void lbNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lbTinh_Click(object sender, EventArgs e)
        {

        }

        private void mtxtSDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}