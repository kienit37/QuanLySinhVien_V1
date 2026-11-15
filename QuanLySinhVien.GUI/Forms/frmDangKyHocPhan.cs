
using QuanLySinhVien.BUS;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.GUI.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmDangKyHocPhan : Form
    {
        private readonly DangKyService _dangKyService;
        private readonly SinhVienService _sinhVienService;
        private readonly HocPhanService _hocPhanService;

        private DangKy? _dangKyDangChon;

        public frmDangKyHocPhan()
        {
            InitializeComponent();

            _dangKyService = new DangKyService();
            _sinhVienService = new SinhVienService();
            _hocPhanService = new HocPhanService();

            Load += frmDangKyHocPhan_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnHuy.Click += btnHuy_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvDangKy.CellClick += dgvDangKy_CellClick;

            chkCoDiem.CheckedChanged += chkCoDiem_CheckedChanged;
        }

        // ==========================================
        // 1. KIỂM TRA QUYỀN
        // ==========================================

        private bool CoQuyen(string maQuyen)
        {
            return NguoiDungHienTai.CoQuyen(maQuyen);
        }

        private bool KiemTraQuyen(string maQuyen)
        {
            if (CoQuyen(maQuyen))
                return true;

            MessageBox.Show(
                "Bạn không có quyền thực hiện chức năng này!",
                "Không có quyền truy cập",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return false;
        }

        // ==========================================
        // 2. ÁP DỤNG PHÂN QUYỀN
        // ==========================================

        private void ApDungPhanQuyen()
        {
            bool quyenXem = CoQuyen("DK_XEM");
            bool quyenThem = CoQuyen("DK_THEM");
            bool quyenSua = CoQuyen("DK_SUA");
            bool quyenXoa = CoQuyen("DK_XOA");

            btnThem.Enabled = quyenThem;
            btnSua.Enabled = quyenSua;
            btnXoa.Enabled = quyenXoa;

            btnTimKiem.Enabled = quyenXem;
            btnLamMoi.Enabled = quyenXem;

            bool duocNhap = quyenThem || quyenSua;

            cboSinhVien.Enabled = duocNhap;
            cboHocPhan.Enabled = duocNhap;
            nudHocKy.Enabled = duocNhap;
            txtNamHoc.ReadOnly = !duocNhap;
            dtpNgayDangKy.Enabled = duocNhap;

            // Chỉ người có quyền sửa mới được nhập điểm
            chkCoDiem.Enabled = quyenSua;

            nudDiem.Enabled =
                quyenSua && chkCoDiem.Checked;

            btnHuy.Enabled = duocNhap;

            dgvDangKy.ReadOnly = true;
            dgvDangKy.AllowUserToAddRows = false;
            dgvDangKy.AllowUserToDeleteRows = false;
            dgvDangKy.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            if (!quyenXem)
            {
                MessageBox.Show(
                    "Bạn không có quyền xem đăng ký học phần!",
                    "Từ chối truy cập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                BeginInvoke(new Action(Close));
            }
        }

        // ==========================================
        // 3. FORM LOAD
        // ==========================================

        private void frmDangKyHocPhan_Load(
            object? sender, EventArgs e)
        {
            try
            {
                ApDungPhanQuyen();

                if (!CoQuyen("DK_XEM"))
                    return;

                LoadComboBox();
                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // 4. NẠP COMBOBOX
        // ==========================================

        private void LoadComboBox()
        {
            // Sinh viên
            cboSinhVien.DataSource =
                _sinhVienService.GetAll();

            cboSinhVien.DisplayMember = "HoTen";
            cboSinhVien.ValueMember = "MaSV";
            cboSinhVien.SelectedIndex = -1;

            // Học phần
            cboHocPhan.DataSource =
                _hocPhanService.GetAll();

            cboHocPhan.DisplayMember = "TenHP";
            cboHocPhan.ValueMember = "MaHP";
            cboHocPhan.SelectedIndex = -1;
        }

        // ==========================================
        // 5. NẠP DANH SÁCH ĐĂNG KÝ
        // ==========================================

        private void LoadDanhSach()
        {
            if (!KiemTraQuyen("DK_XEM"))
                return;

            List<DangKy> danhSach =
                _dangKyService.GetAll();

            dgvDangKy.DataSource = null;
            dgvDangKy.DataSource = danhSach;

            CauHinhCot();
        }

        // ==========================================
        // 6. CẤU HÌNH CỘT
        // ==========================================

        private void CauHinhCot()
        {
            if (dgvDangKy.Columns.Count == 0)
                return;

            if (dgvDangKy.Columns["MaSV"] != null)
                dgvDangKy.Columns["MaSV"]!.HeaderText =
                    "Mã SV";

            if (dgvDangKy.Columns["HoTen"] != null)
                dgvDangKy.Columns["HoTen"]!.HeaderText =
                    "Họ tên sinh viên";

            if (dgvDangKy.Columns["MaHP"] != null)
                dgvDangKy.Columns["MaHP"]!.HeaderText =
                    "Mã học phần";

            if (dgvDangKy.Columns["TenHP"] != null)
                dgvDangKy.Columns["TenHP"]!.HeaderText =
                    "Tên học phần";

            if (dgvDangKy.Columns["HocKy"] != null)
                dgvDangKy.Columns["HocKy"]!.HeaderText =
                    "Học kỳ";

            if (dgvDangKy.Columns["NamHoc"] != null)
                dgvDangKy.Columns["NamHoc"]!.HeaderText =
                    "Năm học";

            if (dgvDangKy.Columns["NgayDangKy"] != null)
            {
                dgvDangKy.Columns["NgayDangKy"]!
                    .HeaderText = "Ngày đăng ký";

                dgvDangKy.Columns["NgayDangKy"]!
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvDangKy.Columns["Diem"] != null)
            {
                dgvDangKy.Columns["Diem"]!.HeaderText =
                    "Điểm";

                dgvDangKy.Columns["Diem"]!
                    .DefaultCellStyle.Format = "0.00";
            }

            if (dgvDangKy.Columns["MaSV"] != null)
                dgvDangKy.Columns["MaSV"]!.FillWeight = 70;

            if (dgvDangKy.Columns["HoTen"] != null)
                dgvDangKy.Columns["HoTen"]!.FillWeight = 130;

            if (dgvDangKy.Columns["MaHP"] != null)
                dgvDangKy.Columns["MaHP"]!.FillWeight = 80;

            if (dgvDangKy.Columns["TenHP"] != null)
                dgvDangKy.Columns["TenHP"]!.FillWeight = 130;
        }

        // ==========================================
        // 7. LẤY THÔNG TIN TỪ FORM
        // ==========================================

        private DangKy LayThongTinTuForm()
        {
            if (cboSinhVien.SelectedValue == null)
                throw new Exception(
                    "Vui lòng chọn sinh viên!"
                );

            if (cboHocPhan.SelectedValue == null)
                throw new Exception(
                    "Vui lòng chọn học phần!"
                );

            decimal? diem = null;

            // Chỉ người có quyền sửa mới được nhập điểm
            if (CoQuyen("DK_SUA") && chkCoDiem.Checked)
            {
                diem = nudDiem.Value;
            }

            return new DangKy
            {
                MaSV = cboSinhVien.SelectedValue.ToString()!,
                MaHP = cboHocPhan.SelectedValue.ToString()!,
                HocKy = (int)nudHocKy.Value,
                NamHoc = txtNamHoc.Text.Trim(),
                NgayDangKy = dtpNgayDangKy.Value.Date,
                Diem = diem
            };
        }

        // ==========================================
        // 8. THÊM ĐĂNG KÝ
        // ==========================================

        private void btnThem_Click(
            object? sender, EventArgs e)
        {
            if (!KiemTraQuyen("DK_THEM"))
                return;

            try
            {
                DangKy dk = LayThongTinTuForm();

                _dangKyService.Insert(dk);

                MessageBox.Show(
                    "Thêm đăng ký học phần thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm đăng ký: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ==========================================
        // 9. SỬA ĐĂNG KÝ
        // ==========================================

        private void btnSua_Click(
            object? sender, EventArgs e)
        {
            if (!KiemTraQuyen("DK_SUA"))
                return;

            try
            {
                if (_dangKyDangChon == null)
                {
                    MessageBox.Show(
                        "Vui lòng chọn đăng ký cần sửa!"
                    );
                    return;
                }

                DangKy dk = LayThongTinTuForm();

                // Giữ nguyên khóa chính
                dk.MaSV = _dangKyDangChon.MaSV;
                dk.MaHP = _dangKyDangChon.MaHP;
                dk.HocKy = _dangKyDangChon.HocKy;
                dk.NamHoc = _dangKyDangChon.NamHoc;

                _dangKyService.Update(dk);

                MessageBox.Show(
                    "Cập nhật đăng ký thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ==========================================
        // 10. XÓA ĐĂNG KÝ
        // ==========================================

        private void btnXoa_Click(
            object? sender, EventArgs e)
        {
            if (!KiemTraQuyen("DK_XOA"))
                return;

            try
            {
                if (_dangKyDangChon == null)
                {
                    MessageBox.Show(
                        "Vui lòng chọn đăng ký cần xóa!"
                    );
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa đăng ký này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _dangKyService.Delete(
                        _dangKyDangChon
                    );

                    MessageBox.Show(
                        "Xóa đăng ký thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadDanhSach();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // 11. HỦY THAO TÁC
        // ==========================================

        private void btnHuy_Click(
            object? sender, EventArgs e)
        {
            LamMoiForm();
        }

        // ==========================================
        // 12. LÀM MỚI
        // ==========================================

        private void btnLamMoi_Click(
            object? sender, EventArgs e)
        {
            if (!KiemTraQuyen("DK_XEM"))
                return;

            try
            {
                txtTimKiem.Clear();

                LoadDanhSach();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi làm mới: " + ex.Message
                );
            }
        }

        // ==========================================
        // 13. TÌM KIẾM
        // ==========================================

        private void btnTimKiem_Click(
            object? sender, EventArgs e)
        {
            if (!KiemTraQuyen("DK_XEM"))
                return;

            try
            {
                string tuKhoa =
                    txtTimKiem.Text.Trim();

                dgvDangKy.DataSource = null;

                dgvDangKy.DataSource =
                    _dangKyService.Search(tuKhoa);

                CauHinhCot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ==========================================
        // 14. CHỌN DÒNG
        // ==========================================

        private void dgvDangKy_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DangKy? dk =
                dgvDangKy.Rows[e.RowIndex]
                .DataBoundItem as DangKy;

            if (dk == null)
                return;

            _dangKyDangChon = dk;

            cboSinhVien.SelectedValue = dk.MaSV;
            cboHocPhan.SelectedValue = dk.MaHP;

            nudHocKy.Value = dk.HocKy;
            txtNamHoc.Text = dk.NamHoc;

            dtpNgayDangKy.Value = dk.NgayDangKy;

            chkCoDiem.Checked = dk.Diem.HasValue;

            if (dk.Diem.HasValue)
                nudDiem.Value = dk.Diem.Value;
            else
                nudDiem.Value = 0;

            // Không cho nhân viên sửa dữ liệu đã đăng ký
            if (!CoQuyen("DK_SUA"))
            {
                cboSinhVien.Enabled = false;
                cboHocPhan.Enabled = false;
                nudHocKy.Enabled = false;
                txtNamHoc.ReadOnly = true;
                dtpNgayDangKy.Enabled = false;
                chkCoDiem.Enabled = false;
                nudDiem.Enabled = false;
            }
        }

        // ==========================================
        // 15. LÀM MỚI FORM
        // ==========================================

        private void LamMoiForm()
        {
            _dangKyDangChon = null;

            cboSinhVien.SelectedIndex = -1;
            cboHocPhan.SelectedIndex = -1;

            nudHocKy.Value = 1;

            txtNamHoc.Clear();

            dtpNgayDangKy.Value = DateTime.Today;

            chkCoDiem.Checked = false;
            nudDiem.Value = 0;

            dgvDangKy.ClearSelection();

            // Khôi phục trạng thái theo quyền
            ApDungTrangThaiNhapLieu();
        }

        // ==========================================
        // 16. TRẠNG THÁI NHẬP LIỆU
        // ==========================================

        private void ApDungTrangThaiNhapLieu()
        {
            bool duocNhap =
                CoQuyen("DK_THEM") ||
                CoQuyen("DK_SUA");

            cboSinhVien.Enabled = duocNhap;
            cboHocPhan.Enabled = duocNhap;
            nudHocKy.Enabled = duocNhap;
            txtNamHoc.ReadOnly = !duocNhap;
            dtpNgayDangKy.Enabled = duocNhap;

            chkCoDiem.Enabled =
                CoQuyen("DK_SUA");

            nudDiem.Enabled =
                CoQuyen("DK_SUA") &&
                chkCoDiem.Checked;
        }

        // ==========================================
        // 17. BẬT / TẮT NHẬP ĐIỂM
        // ==========================================

        private void chkCoDiem_CheckedChanged(
            object? sender, EventArgs e)
        {
            bool duocNhapDiem =
                CoQuyen("DK_SUA");

            nudDiem.Enabled =
                duocNhapDiem && chkCoDiem.Checked;

            if (!chkCoDiem.Checked)
                nudDiem.Value = 0;
        }

        // ==========================================
        // 18. CÁC SỰ KIỆN DESIGNER
        // ==========================================

        private void btnSua_Click_1(
            object sender, EventArgs e)
        {
        }

        private void pnlChucNang_Paint(
            object sender, PaintEventArgs e)
        {
        }

        private void pnlChucNang_Paint_1(
            object sender, PaintEventArgs e)
        {
        }
    }
}
