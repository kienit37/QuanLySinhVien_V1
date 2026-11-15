
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmPhanQuyen : Form
    {
        private readonly PhanQuyenService _phanQuyenService;
        private readonly VaiTroService _vaiTroService;
        private readonly PhanQuyenService _service;

        public frmPhanQuyen()
        {
            InitializeComponent();

            _service = new PhanQuyenService();

            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            clbQuyen.CheckOnClick = true;

            Load += frmPhanQuyen_Load;

            btnTaiQuyen.Click += btnTaiQuyen_Click;
            btnChonTatCa.Click += btnChonTatCa_Click;
            btnBoChonTatCa.Click += btnBoChonTatCa_Click;
            btnLuu.Click += btnLuu_Click;
            btnDong.Click += btnDong_Click;
            _phanQuyenService = new PhanQuyenService();
            _vaiTroService = new VaiTroService();
            Load += frmPhanQuyen_Load;

            cboVaiTro.SelectedIndexChanged +=
                cboVaiTro_SelectedIndexChanged;
        }

        // Khởi tạo Form
        private void frmPhanQuyen_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadVaiTro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách vai trò: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Tải danh sách vai trò
        private void LoadVaiTro()
        {
            try
            {
                List<VaiTro> danhSach = _vaiTroService.GetAll();

                cboVaiTro.DataSource = null;

                cboVaiTro.DisplayMember = "TenVaiTro";
                cboVaiTro.ValueMember = "MaVaiTro";

                cboVaiTro.DataSource = danhSach;

                if (danhSach.Count > 0)
                {
                    cboVaiTro.SelectedIndex = 0;
                }
                else
                {
                    clbQuyen.Items.Clear();

                    MessageBox.Show(
                        "Không tìm thấy vai trò nào trong cơ sở dữ liệu!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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

        private void cboVaiTro_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (cboVaiTro.SelectedValue == null)
                return;

            btnTaiQuyen.PerformClick();
        }

        // Tải quyền của vai trò được chọn
        private void btnTaiQuyen_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cboVaiTro.SelectedValue == null)
                    return;

                string maVaiTro =
                    cboVaiTro.SelectedValue.ToString()!;

                List<Quyen> danhSach =
                    _service.GetQuyenTheoVaiTro(maVaiTro);

                clbQuyen.Items.Clear();

                foreach (Quyen q in danhSach)
                {
                    int index = clbQuyen.Items.Add(q);

                    clbQuyen.SetItemChecked(
                        index, q.DuocChon);
                }

                clbQuyen.DisplayMember = "TenQuyen";
                clbQuyen.Enabled = maVaiTro != "ADMIN";
                btnLuu.Enabled = maVaiTro != "ADMIN";
                btnChonTatCa.Enabled = maVaiTro != "ADMIN";
                btnBoChonTatCa.Enabled = maVaiTro != "ADMIN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải quyền: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Chọn tất cả quyền
        private void btnChonTatCa_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < clbQuyen.Items.Count; i++)
            {
                clbQuyen.SetItemChecked(i, true);
            }
        }

        // Bỏ chọn tất cả quyền
        private void btnBoChonTatCa_Click(
            object? sender, EventArgs e)
        {
            for (int i = 0; i < clbQuyen.Items.Count; i++)
            {
                clbQuyen.SetItemChecked(i, false);
            }
        }

        // Lưu phân quyền
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cboVaiTro.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!");
                    return;
                }

                string maVaiTro =
                    cboVaiTro.SelectedValue.ToString()!;

                List<string> danhSachMaQuyen =
                    new List<string>();

                foreach (var item in clbQuyen.CheckedItems)
                {
                    if (item is Quyen q)
                    {
                        danhSachMaQuyen.Add(q.MaQuyen);
                    }
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn lưu phân quyền?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _service.LuuQuyen(maVaiTro, danhSachMaQuyen);

                MessageBox.Show(
                    "Lưu phân quyền thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnTaiQuyen.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lưu phân quyền: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
