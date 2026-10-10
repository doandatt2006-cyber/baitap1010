using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút ĐĂNG KÝ
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Xóa các biểu tượng lỗi cũ
            epCheck.Clear();

            bool isValid = true;

            // 2. Kiểm tra Tên đăng nhập không được để trống
            if (string.IsNullOrWhiteSpace(txtTenDN.Text))
            {
                epCheck.SetError(txtTenDN, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Mật khẩu không được để trống
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                isValid = false;
            }

            // 4. Kiểm tra Mật khẩu nhập lại phải khớp
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                epCheck.SetError(txtXacNhanMK, "Mật khẩu nhập lại phải khớp với Mật khẩu ban đầu!");
                isValid = false;
            }

            // 5. Kiểm tra Độ tuổi từ Ngày sinh phải >= 18 tuổi
            DateTime ngaySinh = dtpNgaySinh.Value;
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi))
            {
                tuoi--;
            }

            if (tuoi < 18)
            {
                epCheck.SetError(dtpNgaySinh, "Độ tuổi tính từ Ngày sinh phải từ 18 tuổi trở lên!");
                isValid = false;
            }

            // 6. Kiểm tra phải tích chọn đồng ý Điều khoản dịch vụ
            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Phải tích chọn đồng ý Điều khoản dịch vụ!");
                isValid = false;
            }

            // 7. Nếu tất cả đều hợp lệ
            if (isValid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện khi nhấn nút LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa tất cả dấu thông báo lỗi
            epCheck.Clear();

            // Đặt lại các ô về trạng thái ban đầu
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtXacNhanMK.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            chkDieuKhoan.Checked = false;

            // Đưa con trỏ chuột về ô Tên đăng nhập
            txtTenDN.Focus();
        }
    }
}