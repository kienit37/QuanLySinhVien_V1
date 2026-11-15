using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.Common.Logging;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.GUI.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmSinhVien : Form
    {
        private readonly SinhVienService _sinhVienService;
        private readonly KhoaService _khoaService;

        private bool _dangThem = false;

        private const long NguongChamMs = 1000;

        // Lấy tài khoản đang đăng nhập.
        private string LayNguoiDungLog()
        {
            return NguoiDungHienTai.TaiKhoan?.TenDangNhap
                ?? "Unknown";
        }

        // Ghi nhận thao tác thành công.
        private void GhiLogThanhCong(
            string hanhDong,
            long thoiGianMs)
        {
            AppLogger.Info(
                hanhDong,
                LayNguoiDungLog(),
                "Thao tác hoàn thành thành công",
                thoiGianMs
            );

            if (thoiGianMs >= AppLogger.SlowOperationThresholdMs)
            {
                AppLogger.Warning(
                    "SLOW_OPERATION",
                    LayNguoiDungLog(),
                    "Thao tác chậm: " + hanhDong,
                    thoiGianMs
                );
            }
        }

        // Ghi nhận lỗi thao tác.
        private string? GhiLogLoi(
            string hanhDong,
            Exception ex)
        {
            return AppLogger.Error(
                "STUDENT_ERROR",
                LayNguoiDungLog(),
                "Thao tác thất bại: " + hanhDong,
                ex
            );
        }

        public frmSinhVien()
        {
            InitializeComponent();

            _sinhVienService = new SinhVienService();
            _khoaService = new KhoaService();

            // Gắn sự kiện
            this.Load += frmSinhVien_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnHuy.Click += btnHuy_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;

            // Thiết lập bảng
            dgvSinhVien.AutoGenerateColumns = true;
        }

        // Khi mở Form
        private void frmSinhVien_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadKhoa();
                LoadDanhSachSinhVien();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Tải danh sách khoa
        private void LoadKhoa()
        {
            List<Khoa> danhSachKhoa = _khoaService.GetAll();

            cboKhoa.DataSource = danhSachKhoa;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;
        }

        // Tải danh sách sinh viên
        private void LoadDanhSachSinhVien()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = _sinhVienService.GetAll();

            if (dgvSinhVien.Columns.Contains("MaSV"))
                dgvSinhVien.Columns["MaSV"]!.HeaderText = "Mã sinh viên";

            if (dgvSinhVien.Columns.Contains("HoTen"))
                dgvSinhVien.Columns["HoTen"]!.HeaderText = "Họ và tên";

            if (dgvSinhVien.Columns.Contains("NgaySinh"))
            {
                dgvSinhVien.Columns["NgaySinh"]!.HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["NgaySinh"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvSinhVien.Columns.Contains("GioiTinh"))
                dgvSinhVien.Columns["GioiTinh"]!.HeaderText = "Giới tính";

            if (dgvSinhVien.Columns.Contains("Email"))
                dgvSinhVien.Columns["Email"]!.HeaderText = "Email";

            if (dgvSinhVien.Columns.Contains("SoDienThoai"))
                dgvSinhVien.Columns["SoDienThoai"]!.HeaderText = "Số điện thoại";

            if (dgvSinhVien.Columns.Contains("DiaChi"))
                dgvSinhVien.Columns["DiaChi"]!.HeaderText = "Địa chỉ";

            if (dgvSinhVien.Columns.Contains("MaKhoa"))
                dgvSinhVien.Columns["MaKhoa"]!.Visible = false;

            if (dgvSinhVien.Columns.Contains("TenKhoa"))
                dgvSinhVien.Columns["TenKhoa"]!.HeaderText = "Khoa";

            if (dgvSinhVien.Columns.Contains("DiemTB"))
                dgvSinhVien.Columns["DiemTB"]!.HeaderText = "Điểm trung bình";
        }

        // Lấy dữ liệu từ Form
        private SinhVien LayThongTinTuForm()
        {
            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                MaKhoa = cboKhoa.SelectedValue?.ToString() ?? "",
                DiemTB = nudDiemTB.Value
            };
        }

        // Hiển thị thông tin lên Form
        private void HienThiThongTin(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;

            if (sv.NgaySinh.HasValue)
                dtpNgaySinh.Value = sv.NgaySinh.Value;

            cboGioiTinh.SelectedItem = sv.GioiTinh;

            txtEmail.Text = sv.Email ?? "";
            txtSoDienThoai.Text = sv.SoDienThoai ?? "";
            txtDiaChi.Text = sv.DiaChi ?? "";

            cboKhoa.SelectedValue = sv.MaKhoa;
            nudDiemTB.Value = sv.DiemTB;
        }

        // Xóa trắng dữ liệu nhập
        private void LamMoiForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();

            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = -1;
            cboKhoa.SelectedIndex = -1;
            nudDiemTB.Value = 0;

            _dangThem = false;
            txtMaSV.Enabled = true;

            txtMaSV.Focus();
        }

        // Chọn dòng trong DataGridView
        private void dgvSinhVien_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
            {
                HienThiThongTin(sv);
                _dangThem = false;
                txtMaSV.Enabled = false;
            }
        }

        // Nút Thêm
        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!_dangThem)
            {
                LamMoiForm();
                _dangThem = true;

                MessageBox.Show(
                    "Hãy nhập thông tin sinh viên mới.",
                    "Thêm sinh viên",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }


            try
            {
                SinhVien sv = LayThongTinTuForm();

                Stopwatch dongHo = Stopwatch.StartNew();

                try
                {
                    _sinhVienService.Insert(sv);
                }
                catch (Exception ex)
                {
                    dongHo.Stop();

                    string? maLoi = GhiLogLoi(
                        "STUDENT_INSERT", ex);

                    MessageBox.Show(
                        "Không thể thêm sinh viên!\n" +
                        "Mã theo dõi: " + (maLoi ?? "Không có"),
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                dongHo.Stop();

                GhiLogThanhCong(
                    "STUDENT_INSERT",
                    dongHo.ElapsedMilliseconds
                );

                MessageBox.Show(
                    "Thêm sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDanhSachSinhVien();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                string? maLoi = GhiLogLoi(
                    "STUDENT_INSERT_UI", ex);

                MessageBox.Show(
                    "Không thể hoàn thành chức năng thêm sinh viên.\n" +
                    "Mã theo dõi: " + (maLoi ?? "Không có"),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // Nút Cập nhật
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn cập nhật thông tin sinh viên này?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes)
                return;


            try
            {
                SinhVien sv = LayThongTinTuForm();

                Stopwatch dongHo = Stopwatch.StartNew();

                try
                {
                    _sinhVienService.Update(sv);
                }
                catch (Exception ex)
                {
                    dongHo.Stop();

                    string? maLoi = GhiLogLoi(
                        "STUDENT_UPDATE", ex);

                    MessageBox.Show(
                        "Không thể cập nhật sinh viên!\n" +
                        "Mã theo dõi: " + (maLoi ?? "Không có"),
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                dongHo.Stop();

                GhiLogThanhCong(
                    "STUDENT_UPDATE",
                    dongHo.ElapsedMilliseconds
                );

                MessageBox.Show(
                    "Cập nhật sinh viên thành công!");

                LoadDanhSachSinhVien();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                string? maLoi = GhiLogLoi(
                    "STUDENT_UPDATE_UI", ex);

                MessageBox.Show(
                    "Không thể hoàn thành chức năng cập nhật.\n" +
                    "Mã theo dõi: " + (maLoi ?? "Không có"),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        // Nút Xóa
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên " + maSV + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (ketQua != DialogResult.Yes)
                return;


            try
            {
                Stopwatch dongHo = Stopwatch.StartNew();

                try
                {
                    _sinhVienService.Delete(maSV);
                }
                catch (Exception ex)
                {
                    dongHo.Stop();

                    string? maLoi = GhiLogLoi(
                        "STUDENT_DELETE", ex);

                    MessageBox.Show(
                        "Không thể xóa sinh viên!\n" +
                        "Mã theo dõi: " + (maLoi ?? "Không có"),
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                dongHo.Stop();

                GhiLogThanhCong(
                    "STUDENT_DELETE",
                    dongHo.ElapsedMilliseconds
                );

                MessageBox.Show(
                    "Xóa sinh viên thành công!");

                LoadDanhSachSinhVien();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                string? maLoi = GhiLogLoi(
                    "STUDENT_DELETE_UI", ex);

                MessageBox.Show(
                    "Không thể hoàn thành chức năng xóa.\n" +
                    "Mã theo dõi: " + (maLoi ?? "Không có"),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        // Nút Hủy
        private void btnHuy_Click(object? sender, EventArgs e)
        {
            LamMoiForm();
        }

        // Nút Tìm kiếm

        private void btnTimKiem_Click(
            object? sender, EventArgs e)
        {
            Stopwatch dongHo = Stopwatch.StartNew();

            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                var ketQua = string.IsNullOrWhiteSpace(tuKhoa)
                    ? _sinhVienService.GetAll()
                    : _sinhVienService.Search(tuKhoa);

                dongHo.Stop();

                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = ketQua;

                GhiLogThanhCong(
                    "STUDENT_SEARCH",
                    dongHo.ElapsedMilliseconds
                );
            }
            catch (Exception ex)
            {
                dongHo.Stop();

                string? maLoi = GhiLogLoi(
                    "STUDENT_SEARCH", ex);

                MessageBox.Show(
                    "Không thể tìm kiếm sinh viên.\n" +
                    "Mã theo dõi: " + (maLoi ?? "Không có"),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // Nút Làm mới
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                LoadDanhSachSinhVien();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại dữ liệu: " + ex.Message);
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}