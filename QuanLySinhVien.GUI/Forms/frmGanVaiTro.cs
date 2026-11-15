using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmGanVaiTro : Form
    {
        private readonly GanVaiTroService _service;

        public frmGanVaiTro()
        {
            InitializeComponent();

            _service = new GanVaiTroService();

            // Gắn sự kiện
            Load += frmGanVaiTro_Load;

            btnTaiQuyen.Click += btnTaiQuyen_Click;
            btnChonTatCa.Click += btnChonTatCa_Click;
            btnBoChonTatCa.Click += btnBoChonTatCa_Click;
            btnLuu.Click += btnLuu_Click;
            btnDong.Click += btnDong_Click;

            cboTaiKhoan.SelectedIndexChanged += cboTaiKhoan_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
        }
        // 1. Khi mở Form

        private void frmGanVaiTro_Load(object? sender, EventArgs e)
        {
            CauHinhGiaoDien();
            LoadTaiKhoan();
        }

        // 2. Cấu hình giao diện
        private void CauHinhGiaoDien()
        {
            cboTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            clbVaiTro.CheckOnClick = true;
            clbVaiTro.DisplayMember = "TenVaiTro";
            btnLuu.Enabled = false;
        }

        // 3. Tải danh sách tài khoản
        private void LoadTaiKhoan()
        {
            try
            {
                List<TaiKhoan> danhSach = _service.GetAllTaiKhoan();

                cboTaiKhoan.DataSource = null;
                cboTaiKhoan.DataSource = danhSach;
                cboTaiKhoan.DisplayMember = "TenDangNhap";
                cboTaiKhoan.ValueMember = "MaTaiKhoan";

                if (danhSach != null && danhSach.Count > 0)
                {
                    cboTaiKhoan.SelectedIndex = 0;
                    btnLuu.Enabled = true;
                }
                else
                {
                    clbVaiTro.Items.Clear();
                    btnLuu.Enabled = false;

                    MessageBox.Show(
                        "Chưa có tài khoản nào!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải tài khoản: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 4. Lấy mã tài khoản đang chọn
        private int LayMaTaiKhoan()
        {
            if (cboTaiKhoan.SelectedValue == null)
            {
                throw new Exception("Vui lòng chọn tài khoản!");
            }

            return Convert.ToInt32(cboTaiKhoan.SelectedValue);
        }

        // 5. Khi chọn tài khoản khác
        private void cboTaiKhoan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboTaiKhoan.SelectedValue == null)
                return;

            if (cboTaiKhoan.SelectedValue is not int)
                return;

            LoadVaiTro();
        }

        // 6. Tải vai trò theo tài khoản
        private void LoadVaiTro()
        {
            try
            {
                int maTaiKhoan = LayMaTaiKhoan();

                List<VaiTro> danhSach = _service.GetVaiTroTheoTaiKhoan(maTaiKhoan);

                clbVaiTro.Items.Clear();

                if (danhSach != null)
                {
                    foreach (VaiTro vt in danhSach)
                    {
                        clbVaiTro.Items.Add(vt, vt.DuocChon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải vai trò: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 7. Nút tải vai trò
        private void btnTaiQuyen_Click(object? sender, EventArgs e)
        {
            LoadVaiTro();
        }

        // 8. Chọn tất cả
        private void btnChonTatCa_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < clbVaiTro.Items.Count; i++)
            {
                clbVaiTro.SetItemChecked(i, true);
            }
        }

        // 9. Bỏ chọn tất cả
        private void btnBoChonTatCa_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < clbVaiTro.Items.Count; i++)
            {
                clbVaiTro.SetItemChecked(i, false);
            }
        }

        // 10. Lưu vai trò
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            try
            {
                int maTaiKhoan = LayMaTaiKhoan();

                List<string> danhSachMaVaiTro = new List<string>();

                foreach (var item in clbVaiTro.CheckedItems)
                {
                    if (item is VaiTro vt)
                    {
                        danhSachMaVaiTro.Add(vt.MaVaiTro);
                    }
                }

                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có chắc chắn muốn lưu vai trò cho tài khoản này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (xacNhan != DialogResult.Yes)
                    return;

                _service.LuuVaiTro(maTaiKhoan, danhSachMaVaiTro);

                MessageBox.Show(
                    "Gán vai trò thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadVaiTro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 11. Đóng Form
        private void btnDong_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}