using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySinhVien.BUS;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmTaiKhoan : Form
    {
        private readonly TaiKhoanService _taiKhoanService;
        private TaiKhoan? _taiKhoanDangChon;

        public frmTaiKhoan()
        {
            InitializeComponent();

            _taiKhoanService = new TaiKhoanService();

            // Gắn sự kiện
            Load += frmTaiKhoan_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnKhoa.Click += btnKhoa_Click;
            btnDatLaiMatKhau.Click += btnDatLaiMatKhau_Click;
            btnHuy.Click += btnHuy_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;

            if (chkHienMatKhau != null)
            {
                chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            }
        }

        // 1. Khởi động Form
        private void frmTaiKhoan_Load(object? sender, EventArgs e)
        {
            try
            {
                CauHinhGiaoDien();
                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách tài khoản:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 2. Cấu hình giao diện
        private void CauHinhGiaoDien()
        {
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.RowHeadersVisible = false;

            txtMatKhau.UseSystemPasswordChar = true;

            // Trạng thái được thay đổi bằng nút Khóa/Mở khóa
            chkTrangThai.Enabled = false;
        }

        // 3. Tải danh sách tài khoản
        private void LoadDanhSach()
        {
            List<TaiKhoan> danhSach = _taiKhoanService.GetAll();

            dgvTaiKhoan.DataSource = null;
            dgvTaiKhoan.DataSource = danhSach;

            CauHinhCot();
        }

        // 4. Đặt tên các cột
        private void CauHinhCot()
        {
            if (dgvTaiKhoan.Columns.Count == 0)
                return;

            if (dgvTaiKhoan.Columns.Contains("MaTaiKhoan"))
                dgvTaiKhoan.Columns["MaTaiKhoan"]!.HeaderText = "Mã tài khoản";

            if (dgvTaiKhoan.Columns.Contains("TenDangNhap"))
                dgvTaiKhoan.Columns["TenDangNhap"]!.HeaderText = "Tên đăng nhập";

            if (dgvTaiKhoan.Columns.Contains("HoTen"))
                dgvTaiKhoan.Columns["HoTen"]!.HeaderText = "Họ và tên";

            if (dgvTaiKhoan.Columns.Contains("TrangThai"))
                dgvTaiKhoan.Columns["TrangThai"]!.HeaderText = "Trạng thái";

            // Không hiển thị mật khẩu đã băm
            if (dgvTaiKhoan.Columns.Contains("MatKhauHash"))
            {
                dgvTaiKhoan.Columns["MatKhauHash"]!.Visible = false;
            }

            if (dgvTaiKhoan.Columns.Contains("MaTaiKhoan"))
                dgvTaiKhoan.Columns["MaTaiKhoan"]!.FillWeight = 70;
            if (dgvTaiKhoan.Columns.Contains("TenDangNhap"))
                dgvTaiKhoan.Columns["TenDangNhap"]!.FillWeight = 110;
            if (dgvTaiKhoan.Columns.Contains("HoTen"))
                dgvTaiKhoan.Columns["HoTen"]!.FillWeight = 150;
            if (dgvTaiKhoan.Columns.Contains("TrangThai"))
            {
                dgvTaiKhoan.Columns["TrangThai"]!.FillWeight = 90;
                dgvTaiKhoan.Columns["TrangThai"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // 5. Tạo tài khoản
        private void btnThem_Click(object? sender, EventArgs e)
        {
            try
            {
                _taiKhoanService.Insert(
                    txtTenDangNhap.Text,
                    txtMatKhau.Text,
                    txtHoTen.Text
                );

                MessageBox.Show(
                    "Tạo tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tạo tài khoản:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // 6. Cập nhật họ tên
        private void btnSua_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_taiKhoanDangChon == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
                    return;
                }

                _taiKhoanService.Update(
                    _taiKhoanDangChon.MaTaiKhoan,
                    txtHoTen.Text
                );

                MessageBox.Show(
                    "Cập nhật tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // 7. Khóa hoặc mở khóa tài khoản
        private void btnKhoa_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_taiKhoanDangChon == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản!");
                    return;
                }

                bool trangThaiMoi = !_taiKhoanDangChon.TrangThai;

                string thongBao = trangThaiMoi
                    ? "Bạn muốn mở khóa tài khoản này?"
                    : "Bạn muốn khóa tài khoản này?";

                DialogResult result = MessageBox.Show(
                    thongBao,
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _taiKhoanService.UpdateStatus(
                    _taiKhoanDangChon.MaTaiKhoan,
                    trangThaiMoi
                );

                MessageBox.Show(
                    trangThaiMoi ? "Đã mở khóa tài khoản!" : "Đã khóa tài khoản!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thay đổi trạng thái:\n" + ex.Message);
            }
        }

        // 8. Đặt lại mật khẩu
        private void btnDatLaiMatKhau_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_taiKhoanDangChon == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản!");
                    return;
                }

                string matKhauMoi = txtMatKhau.Text;

                if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới vào ô Mật khẩu!");
                    txtMatKhau.Focus();
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn đặt lại mật khẩu cho tài khoản " + _taiKhoanDangChon.TenDangNhap + "?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _taiKhoanService.ResetPassword(
                    _taiKhoanDangChon.MaTaiKhoan,
                    matKhauMoi
                );

                MessageBox.Show(
                    "Đặt lại mật khẩu thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtMatKhau.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể đặt lại mật khẩu:\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // 9. Tìm kiếm
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                dgvTaiKhoan.DataSource = null;
                dgvTaiKhoan.DataSource = string.IsNullOrWhiteSpace(tuKhoa)
                    ? _taiKhoanService.GetAll()
                    : _taiKhoanService.Search(tuKhoa);

                CauHinhCot();
                _taiKhoanDangChon = null;

                txtTenDangNhap.Clear();
                txtHoTen.Clear();
                txtMatKhau.Clear();
                chkTrangThai.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // 10. Làm mới danh sách
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message);
            }
        }

        // 11. Chọn tài khoản trong DataGridView
        private void dgvTaiKhoan_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TaiKhoan? tk = dgvTaiKhoan.Rows[e.RowIndex].DataBoundItem as TaiKhoan;

            if (tk == null)
                return;

            _taiKhoanDangChon = tk;

            txtTenDangNhap.Text = tk.TenDangNhap;
            txtHoTen.Text = tk.HoTen;
            txtMatKhau.Clear();
            chkTrangThai.Checked = tk.TrangThai;

            // Khi chọn tài khoản, khóa ô Tên đăng nhập để tránh sửa key
            txtTenDangNhap.ReadOnly = true;
        }

        // 12. Hiện hoặc ẩn mật khẩu
        private void chkHienMatKhau_CheckedChanged(object? sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        // 13. Hủy thao tác
        private void btnHuy_Click(object? sender, EventArgs e)
        {
            LamMoiForm();
        }
        private void dgvTaiKhoan_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý gì ở đây vì ta đã dùng CellClick rồi
        }

        // 14. Làm sạch thông tin
        private void LamMoiForm()
        {
            _taiKhoanDangChon = null;

            txtTenDangNhap.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();

            txtTenDangNhap.ReadOnly = false;

            chkTrangThai.Checked = true;
            if (chkHienMatKhau != null)
            {
                chkHienMatKhau.Checked = false;
            }

            txtMatKhau.UseSystemPasswordChar = true;

            dgvTaiKhoan.ClearSelection();
            txtTenDangNhap.Focus();
        }
    }
}