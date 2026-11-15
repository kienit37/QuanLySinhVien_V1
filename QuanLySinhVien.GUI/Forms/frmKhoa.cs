using System;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmKhoa : Form
    {
        private readonly KhoaService _khoaService;
        private bool _dangThem = false;

        public frmKhoa()
        {
            InitializeComponent();
            _khoaService = new KhoaService();

            this.Load += frmKhoa_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnHuy.Click += btnHuy_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvKhoa.CellClick += dgvKhoa_CellClick;
        }

        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhoa();
            LamMoiForm();
        }

        // Tải danh sách khoa
        private void LoadDanhSachKhoa()
        {
            dgvKhoa.DataSource = null;
            dgvKhoa.DataSource = _khoaService.GetAll();

            if (dgvKhoa.Columns.Contains("MaKhoa"))
                dgvKhoa.Columns["MaKhoa"]!.HeaderText = "Mã khoa";

            if (dgvKhoa.Columns.Contains("TenKhoa"))
                dgvKhoa.Columns["TenKhoa"]!.HeaderText = "Tên khoa";

            if (dgvKhoa.Columns.Contains("MoTa"))
                dgvKhoa.Columns["MoTa"]!.HeaderText = "Mô tả";
        }

        // Lấy dữ liệu từ Form
        private Khoa LayThongTin()
        {
            return new Khoa
            {
                MaKhoa = txtMaKhoa.Text.Trim(),
                TenKhoa = txtTenKhoa.Text.Trim(),
                MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text)
                    ? null
                    : txtMoTa.Text.Trim()
            };
        }

        // Xóa dữ liệu nhập
        private void LamMoiForm()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMoTa.Clear();

            txtMaKhoa.Enabled = true;
            _dangThem = false;

            txtMaKhoa.Focus();
        }

        // Chọn dòng trên Grid
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvKhoa.Rows[e.RowIndex].DataBoundItem is Khoa khoa)
            {
                txtMaKhoa.Text = khoa.MaKhoa;
                txtTenKhoa.Text = khoa.TenKhoa;
                txtMoTa.Text = khoa.MoTa ?? "";

                txtMaKhoa.Enabled = false;
                _dangThem = false;
            }
        }

        // Thêm khoa
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!_dangThem)
            {
                LamMoiForm();
                _dangThem = true;

                MessageBox.Show("Nhập thông tin khoa mới rồi nhấn Thêm lần nữa.");
                return;
            }

            try
            {
                Khoa khoa = LayThongTin();
                _khoaService.Insert(khoa);

                MessageBox.Show("Thêm khoa thành công!");

                LoadDanhSachKhoa();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thêm khoa!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Cập nhật khoa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khoa cần cập nhật!");
                return;
            }

            try
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có chắc chắn muốn cập nhật khoa này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (ketQua != DialogResult.Yes)
                    return;

                _khoaService.Update(LayThongTin());

                MessageBox.Show("Cập nhật khoa thành công!");

                LoadDanhSachKhoa();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật!\n" + ex.Message);
            }
        }

        // Xóa khoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();

            if (string.IsNullOrWhiteSpace(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khoa " + maKhoa + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                _khoaService.Delete(maKhoa);

                MessageBox.Show("Xóa khoa thành công!");

                LoadDanhSachKhoa();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa khoa!\nKhoa có thể đang được sinh viên sử dụng.\n"
                    + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // Hủy thao tác
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        // Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                dgvKhoa.DataSource = null;
                dgvKhoa.DataSource = string.IsNullOrWhiteSpace(tuKhoa)
                    ? _khoaService.GetAll()
                    : _khoaService.Search(tuKhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Clear();
                LoadDanhSachKhoa();
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}