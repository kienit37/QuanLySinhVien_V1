using QuanLySinhVien.Common.Logging;
using System;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.GUI.Helpers;
using QuanLySinhVien.BUS.Security;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmDangNhap : Form
    {
        private readonly DangNhapService _dangNhapService =
            new DangNhapService();

        // Ngăn xử lý đăng nhập nhiều lần
        private bool _dangXuLyDangNhap = false;

        public frmDangNhap()
        {
            InitializeComponent();

            // ==========================================
            // 1. ĐĂNG KÝ SỰ KIỆN
            // ==========================================

            // Gỡ các handler có thể đã đăng ký trong Designer
            // rồi chỉ đăng ký một handler đăng nhập.
            btnDangNhap.Click -= btnDangNhap_Click;
            btnDangNhap.Click -= btnDangNhap_Click_1;

            btnDangNhap.Click += btnDangNhap_Click;

            // Đăng ký một lần cho nút Thoát
            btnThoat.Click -= btnThoat_Click;
            btnThoat.Click += btnThoat_Click;

            // Đăng ký một lần cho CheckBox
            chkHienMatKhau.CheckedChanged -=
                chkHienMatKhau_CheckedChanged;

            chkHienMatKhau.CheckedChanged +=
                chkHienMatKhau_CheckedChanged;

            // Nhấn Enter để đăng nhập
            this.AcceptButton = btnDangNhap;

            // ==========================================
            // 2. THIẾT LẬP Ô MẬT KHẨU
            // ==========================================

            txtMatKhau.Multiline = false;

            txtMatKhau.UseSystemPasswordChar = false;

            txtMatKhau.PasswordChar = '●';

            // Mặc định không hiện mật khẩu
            chkHienMatKhau.Checked = false;

            CapNhatHienThiMatKhau();

            // Đặt con trỏ vào ô tài khoản
            this.Shown += (sender, e) =>
            {
                txtTaiKhoan.Focus();
            };
        }

        // ==========================================
        // 3. HIỆN / ẨN MẬT KHẨU
        // ==========================================

        private void CapNhatHienThiMatKhau()
        {
            txtMatKhau.UseSystemPasswordChar = false;

            if (chkHienMatKhau.Checked)
            {
                // Hiển thị mật khẩu
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtMatKhau.PasswordChar = '●';
            }
        }

        private void chkHienMatKhau_CheckedChanged(
            object? sender,
            EventArgs e)
        {
            CapNhatHienThiMatKhau();
        }

        // ==========================================
        // 4. XỬ LÝ ĐĂNG NHẬP
        // ==========================================

        private void btnDangNhap_Click(
            object? sender,
            EventArgs e)
        {
            // Không cho đăng nhập nhiều lần cùng lúc
            if (_dangXuLyDangNhap)
                return;

            // Xóa thông báo lỗi cũ
            errorProvider1.Clear();

            bool hopLe = true;

            string tenDangNhap =
                txtTaiKhoan.Text.Trim();

            string matKhau =
                txtMatKhau.Text;

            // ======================================
            // KIỂM TRA TÊN ĐĂNG NHẬP
            // ======================================

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                errorProvider1.SetError(
                    txtTaiKhoan,
                    "Vui lòng nhập tên đăng nhập!"
                );

                hopLe = false;
            }

            // ======================================
            // KIỂM TRA MẬT KHẨU
            // ======================================

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Vui lòng nhập mật khẩu!"
                );

                hopLe = false;
            }

            if (!hopLe)
                return;

            // Bắt đầu xử lý đăng nhập
            _dangXuLyDangNhap = true;

            // Khóa nút để tránh nhấn liên tục
            btnDangNhap.Enabled = false;

            try
            {
                // ======================================
                // BƯỚC 1: XÁC THỰC TÀI KHOẢN
                // ======================================

                var taiKhoan =
                    _dangNhapService.DangNhap(
                        tenDangNhap,
                        matKhau
                    );

                // ======================================
                // BƯỚC 2: LẤY DANH SÁCH QUYỀN
                // ======================================

                var danhSachQuyen =
                    _dangNhapService.GetDanhSachQuyen(
                        taiKhoan.MaTaiKhoan
                    );

            

                // ======================================
                // BƯỚC 3: LƯU TÀI KHOẢN HIỆN TẠI
                // ======================================

                NguoiDungHienTai.DangNhap(
                    taiKhoan
                );

                // ======================================
                // BƯỚC 4: LƯU QUYỀN Ở GUI
                // ======================================

                NguoiDungHienTai.GanDanhSachQuyen(
                    danhSachQuyen
                );

                // ======================================
                // BƯỚC 5: LƯU QUYỀN Ở BUS
                // ======================================

                QuyenNguoiDung.GanDanhSachQuyen(
                    danhSachQuyen
                );

                // ======================================
                // BƯỚC 6: THÔNG BÁO THÀNH CÔNG
                // ======================================
                AppLogger.Info(
    "LOGIN_SUCCESS",
    tenDangNhap,
    "Đăng nhập hệ thống thành công"
);

                MessageBox.Show(

                    "Đăng nhập thành công!\n" +
                    "Xin chào: " + taiKhoan.HoTen,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // ======================================
                // BƯỚC 7: KẾT THÚC FORM ĐĂNG NHẬP
                // ======================================

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                AppLogger.Warning(
    "LOGIN_FAILED",
    tenDangNhap,
    "Đăng nhập không thành công"
);

                // Xóa thông tin phiên đăng nhập
                NguoiDungHienTai.DangXuat();

                QuyenNguoiDung.DangXuat();

                MessageBox.Show(
                    ex.Message,
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Xóa mật khẩu
                txtMatKhau.Clear();

                // Đưa mật khẩu về trạng thái ẩn
                chkHienMatKhau.Checked = false;

                CapNhatHienThiMatKhau();

                txtMatKhau.Focus();
            }
            finally
            {
                // Cho phép thử lại nếu Form vẫn mở
                _dangXuLyDangNhap = false;

                if (!IsDisposed && !Disposing)
                {
                    btnDangNhap.Enabled = true;
                }
            }
        }

        // ==========================================
        // 5. THOÁT CHƯƠNG TRÌNH
        // ==========================================

        private void btnThoat_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;

                this.Close();
            }
        }

        // ==========================================
        // 6. CÁC SỰ KIỆN DESIGNER
        // ==========================================

        private void splitContainer1_Panel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void splitContainerLogin_Panel2_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void frmDangNhap_Load(
            object sender,
            EventArgs e)
        {
            CapNhatHienThiMatKhau();
        }

        // Giữ lại để Designer không báo lỗi
        private void btnDangNhap_Click_1(
            object sender,
            EventArgs e)
        {
            btnDangNhap_Click(sender, e);
        }

        private void lblTaiKhoan_Click(
            object sender,
            EventArgs e)
        {
        }

        private void splitContainerLogin_SplitterMoved(
            object sender,
            SplitterEventArgs e)
        {
        }
    }
}
