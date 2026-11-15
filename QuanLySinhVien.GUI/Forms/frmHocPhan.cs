using System;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmHocPhan : Form
    {
        private readonly HocPhanService _hocPhanService;
        private bool _dangThem = false;

        public frmHocPhan()
        {
            InitializeComponent();

            _hocPhanService = new HocPhanService();

            this.Load += frmHocPhan_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnHuy.Click += btnHuy_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvHocPhan.CellClick += dgvHocPhan_CellClick;
        }

        // Khi mở Form
        private void frmHocPhan_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadDanhSachHocPhan();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu học phần!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Tải danh sách
        private void LoadDanhSachHocPhan()
        {
            dgvHocPhan.DataSource = null;
            dgvHocPhan.DataSource = _hocPhanService.GetAll();

            if (dgvHocPhan.Columns.Contains("MaHP"))
                dgvHocPhan.Columns["MaHP"]!.HeaderText = "Mã học phần";

            if (dgvHocPhan.Columns.Contains("TenHP"))
                dgvHocPhan.Columns["TenHP"]!.HeaderText = "Tên học phần";

            if (dgvHocPhan.Columns.Contains("SoTinChi"))
                dgvHocPhan.Columns["SoTinChi"]!.HeaderText = "Số tín chỉ";

            if (dgvHocPhan.Columns.Contains("MoTa"))
                dgvHocPhan.Columns["MoTa"]!.HeaderText = "Mô tả";
        }

        // Lấy thông tin từ Form
        private HocPhan LayThongTin()
        {
            return new HocPhan
            {
                MaHP = txtMaHP.Text.Trim(),
                TenHP = txtTenHP.Text.Trim(),
                SoTinChi = Convert.ToInt32(nudSoTinChi.Value),
                MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text)
                    ? null
                    : txtMoTa.Text.Trim()
            };
        }

        // Xóa trắng Form
        private void LamMoiForm()
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
            txtMoTa.Clear();

            nudSoTinChi.Value = 3;

            txtMaHP.Enabled = true;
            _dangThem = false;

            txtMaHP.Focus();
        }

        // Chọn dòng
        private void dgvHocPhan_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvHocPhan.Rows[e.RowIndex].DataBoundItem is HocPhan hp)
            {
                txtMaHP.Text = hp.MaHP;
                txtTenHP.Text = hp.TenHP;
                nudSoTinChi.Value = hp.SoTinChi;
                txtMoTa.Text = hp.MoTa ?? "";

                txtMaHP.Enabled = false;
                _dangThem = false;
            }
        }

        // Thêm
        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!_dangThem)
            {
                LamMoiForm();
                _dangThem = true;

                MessageBox.Show("Nhập thông tin học phần rồi nhấn Thêm lần nữa.");
                return;
            }

            try
            {
                HocPhan hp = LayThongTin();

                _hocPhanService.Insert(hp);

                MessageBox.Show("Thêm học phần thành công!");

                LoadDanhSachHocPhan();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm học phần!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Cập nhật
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text))
            {
                MessageBox.Show("Vui lòng chọn học phần cần cập nhật!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn cập nhật học phần này?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                _hocPhanService.Update(LayThongTin());

                MessageBox.Show("Cập nhật học phần thành công!");

                LoadDanhSachHocPhan();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Xóa
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string maHP = txtMaHP.Text.Trim();

            if (string.IsNullOrWhiteSpace(maHP))
            {
                MessageBox.Show("Vui lòng chọn học phần cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa học phần " + maHP + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                _hocPhanService.Delete(maHP);

                MessageBox.Show("Xóa học phần thành công!");

                LoadDanhSachHocPhan();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa học phần!\nHọc phần có thể đang được sử dụng trong đăng ký.\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // Hủy
        private void btnHuy_Click(object? sender, EventArgs e)
        {
            LamMoiForm();
        }

        // Tìm kiếm
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                dgvHocPhan.DataSource = null;

                dgvHocPhan.DataSource =
                    string.IsNullOrWhiteSpace(tuKhoa)
                    ? _hocPhanService.GetAll()
                    : _hocPhanService.Search(tuKhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // Làm mới
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                LoadDanhSachHocPhan();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message);
            }
        }
    }
}