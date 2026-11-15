using QuanLySinhVien.Common.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using QuanLySinhVien.GUI.Helpers;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.BUS.Security;

namespace QuanLySinhVien.GUI.Forms
{

    public partial class frmMain : Form
    {

        // ==========================================
        // KHAI BÁO ĐỐI TƯỢNG
        // ==========================================

        private readonly ThongKeService _thongKeService =
            new ThongKeService();

        private List<SinhVienTheoKhoa> _dsSinhVienTheoKhoa =
            new List<SinhVienTheoKhoa>();

        private List<ThongKeTheoNhom> _dsThongKeGioiTinh =
            new List<ThongKeTheoNhom>();

        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public frmMain()
        {
            InitializeComponent();

            // Đồng hồ
            timerDongHo.Tick -= timerDongHo_Tick;
            timerDongHo.Tick += timerDongHo_Tick;

            // Tổng quan
            btnTongQuan.Click -= btnTongQuan_Click;
            btnTongQuan.Click += btnTongQuan_Click;

            // Đăng xuất
            btnDangXuat.Click -= btnDangXuat_Click;
            btnDangXuat.Click += btnDangXuat_Click;

            // Thoát
            mnuThoat.Click -= mnuThoat_Click;
            mnuThoat.Click += mnuThoat_Click;

            // Sinh viên
            btnSinhVien.Click -= btnSinhVien_Click;
            btnSinhVien.Click += btnSinhVien_Click;

            mnuSinhVien.Click -= btnSinhVien_Click;
            mnuSinhVien.Click += btnSinhVien_Click;

            tsbSinhVien.Click -= btnSinhVien_Click;
            tsbSinhVien.Click += btnSinhVien_Click;

            // Khoa
            btnKhoa.Click -= btnKhoa_Click;
            btnKhoa.Click += btnKhoa_Click;

            mnuKhoa.Click -= btnKhoa_Click;
            mnuKhoa.Click += btnKhoa_Click;

            tsbKhoa.Click -= btnKhoa_Click;
            tsbKhoa.Click += btnKhoa_Click;

            // Học phần
            btnHocPhan.Click -= btnHocPhan_Click;
            btnHocPhan.Click += btnHocPhan_Click;

            mnuHocPhan.Click -= btnHocPhan_Click;
            mnuHocPhan.Click += btnHocPhan_Click;

            tsbHocPhan.Click -= btnHocPhan_Click;
            tsbHocPhan.Click += btnHocPhan_Click;

            // Đăng ký học phần
            btnDangKy.Click -= btnDangKy_Click;
            btnDangKy.Click += btnDangKy_Click;

            mnuDangKy.Click -= btnDangKy_Click;
            mnuDangKy.Click += btnDangKy_Click;

            // Tài khoản
            btnTaiKhoan.Click -= btnTaiKhoan_Click;
            btnTaiKhoan.Click += btnTaiKhoan_Click;

            mnuQuanLyTaiKhoan.Click -= btnTaiKhoan_Click;
            mnuQuanLyTaiKhoan.Click += btnTaiKhoan_Click;

            // Gán vai trò
            btnGanVaiTro.Click -= btnGanVaiTro_Click;
            btnGanVaiTro.Click += btnGanVaiTro_Click;

            // Phân quyền
            btnPhanQuyen.Click -= btnPhanQuyen_Click;
            btnPhanQuyen.Click += btnPhanQuyen_Click;

            // Thống kê
            btnThongKe.Click -= btnThongKe_Click;
            btnThongKe.Click += btnThongKe_Click;

            mnuThongKe.Click -= btnThongKe_Click;
            mnuThongKe.Click += btnThongKe_Click;

            // Làm mới Dashboard
            btnLamMoiDashboard.Click -= btnLamMoiDashboard_Click;
            btnLamMoiDashboard.Click += btnLamMoiDashboard_Click;

            // Biểu đồ
            pnlBieuDoKhoa.Paint -= pnlBieuDoKhoa_Paint;
            pnlBieuDoKhoa.Paint += pnlBieuDoKhoa_Paint;

            pnlBieuDoGioiTinh.Paint -= pnlBieuDoGioiTinh_Paint;
            pnlBieuDoGioiTinh.Paint += pnlBieuDoGioiTinh_Paint;

            // Giới thiệu
            mnuGioiThieu.Click -= mnuGioiThieu_Click_1;
            mnuGioiThieu.Click -= mnuGioiThieu_Click;
            mnuGioiThieu.Click += mnuGioiThieu_Click;

            // Menu tài khoản
            GanSuKienMenuTaiKhoan();

            // Form Load
            this.Load -= frmMain_Load;
            this.Load += frmMain_Load;
        }

        // ==========================================
        // FORM LOAD
        // ==========================================

        private void frmMain_Load(
            object? sender,
            EventArgs e)
        {
            HienThiThongTinNguoiDung();

   

            ApDungPhanQuyen();
            SapXepMenuNhanVien();

            tsslTrangThai.Text =
                "Trạng thái: Sẵn sàng";

            HienThiThoiGian();

            timerDongHo.Start();

            HienThiThongKeDashboard();
        }

        // ==========================================
        // HIỂN THỊ THÔNG TIN NGƯỜI DÙNG
        // ==========================================

        private void HienThiThongTinNguoiDung()
        {
            var taiKhoan =
                NguoiDungHienTai.TaiKhoan;

            if (taiKhoan == null)
            {
                tsslNguoiDung.Text =
                    "Người dùng: Chưa đăng nhập";
            }
            else
            {
                tsslNguoiDung.Text =
                    "Người dùng: " +
                    taiKhoan.HoTen +
                    " (" +
                    taiKhoan.TenDangNhap +
                    ")";
            }
        }

        // ==========================================
        // ÁP DỤNG PHÂN QUYỀN
        // ==========================================

        private void ApDungPhanQuyen()
        {

            // Chỉ tài khoản có LOG_VIEW được thấy nút.
            btnGiamSatHeThong.Visible =
                NguoiDungHienTai.CoQuyen("LOG_VIEW");

            bool sv =
                NguoiDungHienTai.CoQuyen("SV_XEM");

            btnSinhVien.Visible = sv;
            mnuSinhVien.Visible = sv;
            tsbSinhVien.Visible = sv;

            bool khoa =
                NguoiDungHienTai.CoQuyen("KHOA_QL");

            btnKhoa.Visible = khoa;
            mnuKhoa.Visible = khoa;
            tsbKhoa.Visible = khoa;

            bool hp =
                NguoiDungHienTai.CoQuyen("HP_QL");

            btnHocPhan.Visible = hp;
            mnuHocPhan.Visible = hp;
            tsbHocPhan.Visible = hp;

            bool dk =
                NguoiDungHienTai.CoQuyen("DK_XEM");

            btnDangKy.Visible = dk;
            mnuDangKy.Visible = dk;

            bool tk =
                NguoiDungHienTai.CoQuyen("TK_QL");

            btnTaiKhoan.Visible = tk;
            mnuQuanLyTaiKhoan.Visible = tk;

            bool pq =
                NguoiDungHienTai.CoQuyen("PQ_QL");

            btnGanVaiTro.Visible = pq;
            btnPhanQuyen.Visible = pq;

            bool bc =
                NguoiDungHienTai.CoQuyen("TK_BC");

            btnThongKe.Visible = bc;
            mnuThongKe.Visible = bc;

            btnLamMoiDashboard.Enabled = bc;


            bool xemDashboard =
                NguoiDungHienTai.CoQuyen("DASHBOARD_XEM")
                || NguoiDungHienTai.CoQuyen("TK_BC");

            if (!xemDashboard)
            {
                XoaThongKeDashboard();
            }

        }

        // ==========================================
        // KIỂM TRA QUYỀN MỞ FORM
        // ==========================================

        private bool KiemTraQuyenMoForm(
            string maQuyen)
        {
            if (NguoiDungHienTai.CoQuyen(maQuyen))
            {
                return true;
            }

            MessageBox.Show(
                "Bạn không có quyền truy cập chức năng này!",
                "Không có quyền",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return false;
        }

        // ==========================================
        // HÀM MỞ FORM CHỨC NĂNG
        // ĐÃ KHẮC PHỤC LỖI VỊ TRÍ
        // ==========================================

        private void MoFormChucNang(
            Form frm,
            string tenChucNang)
        {
            try
            {
                tsslTrangThai.Text =
                    "Trạng thái: Đang mở " +
                    tenChucNang;

                using (frm)
                {
                    // Căn giữa theo frmMain
                    frm.StartPosition =
                        FormStartPosition.CenterParent;

                    // Không tạo cửa sổ Taskbar riêng
                    frm.ShowInTaskbar = false;

                    // Form không nằm trong Panel
                    frm.TopLevel = true;

                    // Trạng thái bình thường
                    frm.WindowState =
                        FormWindowState.Normal;

                    // Mở Form phía trước frmMain
                    // và đặt frmMain làm Form sở hữu
                    frm.ShowDialog(this);
                }

                tsslTrangThai.Text =
                    "Trạng thái: Sẵn sàng";

                // Làm mới Dashboard
                HienThiThongKeDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể mở chức năng " +
                    tenChucNang +
                    "!\n\nChi tiết: " +
                    ex.Message,
                    "Lỗi mở Form",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                tsslTrangThai.Text =
                    "Trạng thái: Có lỗi xảy ra";
            }
        }

        // ==========================================
        // QUẢN LÝ SINH VIÊN
        // ==========================================

        private void btnSinhVien_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("SV_XEM"))
                return;

            MoFormChucNang(
                new frmSinhVien(),
                "Quản lý sinh viên"
            );
        }

        // ==========================================
        // QUẢN LÝ KHOA
        // ==========================================

        private void btnKhoa_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("KHOA_QL"))
                return;

            MoFormChucNang(
                new frmKhoa(),
                "Quản lý khoa"
            );
        }

        // ==========================================
        // QUẢN LÝ HỌC PHẦN
        // ==========================================

        private void btnHocPhan_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("HP_QL"))
                return;

            MoFormChucNang(
                new frmHocPhan(),
                "Quản lý học phần"
            );
        }

        // ==========================================
        // ĐĂNG KÝ HỌC PHẦN
        // ==========================================

        private void btnDangKy_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("DK_XEM"))
                return;

            MoFormChucNang(
                new frmDangKyHocPhan(),
                "Quản lý đăng ký học phần"
            );
        }

        // ==========================================
        // QUẢN LÝ TÀI KHOẢN
        // ==========================================

        private void btnTaiKhoan_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("TK_QL"))
                return;

            MoFormChucNang(
                new frmTaiKhoan(),
                "Quản lý tài khoản"
            );
        }

        // ==========================================
        // GÁN VAI TRÒ
        // ==========================================

        private void btnGanVaiTro_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("PQ_QL"))
                return;

            MoFormChucNang(
                new frmGanVaiTro(),
                "Gán vai trò cho tài khoản"
            );
        }

        // ==========================================
        // PHÂN QUYỀN
        // ĐÃ CẬP NHẬT
        // ==========================================

        private void btnPhanQuyen_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("PQ_QL"))
                return;

            frmPhanQuyen frm =
                new frmPhanQuyen();

            frm.StartPosition =
                FormStartPosition.CenterParent;

            frm.WindowState =
                FormWindowState.Normal;

            frm.ShowInTaskbar = false;

            MoFormChucNang(
                frm,
                "Phân quyền theo vai trò"
            );
        }

        // ==========================================
        // THỐNG KÊ
        // ==========================================

        private void btnThongKe_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("TK_BC"))
                return;

            MoFormChucNang(
                new frmThongKe(),
                "Thống kê - Báo cáo sinh viên"
            );
        }

        // ==========================================
        // GIỚI THIỆU
        // ==========================================

        private void mnuGioiThieu_Click(
            object sender,
            EventArgs e)
        {
            MoFormChucNang(
                new frmThongTin(),
                "Giới thiệu phần mềm"
            );
        }

        // ==========================================
        // TỔNG QUAN
        // ==========================================

        private void btnTongQuan_Click(
            object? sender,
            EventArgs e)
        {
            tsslTrangThai.Text =
                "Trạng thái: Đang ở trang tổng quan";

            HienThiThongKeDashboard();
        }

        // ==========================================
        // LÀM MỚI DASHBOARD
        // ==========================================

        private void btnLamMoiDashboard_Click(
            object? sender,
            EventArgs e)
        {
            HienThiThongKeDashboard();
        }

        // ==========================================
        // HIỂN THỊ DASHBOARD
        // ==========================================

        private void HienThiThongKeDashboard()
        {
            if (!NguoiDungHienTai.CoQuyen("DASHBOARD_XEM")
     && !NguoiDungHienTai.CoQuyen("TK_BC"))
            {
                XoaThongKeDashboard();
                return;
            }
            try
            {
                ThongKeDashboard thongKe =
                    _thongKeService.GetThongKeDashboard();

                lblTongSinhVien.Text =
                    thongKe.TongSinhVien.ToString("N0");

                lblTongKhoa.Text =
                    thongKe.TongKhoa.ToString("N0");

                lblTongHocPhan.Text =
                    thongKe.TongHocPhan.ToString("N0");

                lblTongDangKy.Text =
                    thongKe.TongDangKy.ToString("N0");

                _dsSinhVienTheoKhoa =
                    _thongKeService.GetSinhVienTheoKhoa();

                _dsThongKeGioiTinh =
                    _thongKeService.GetThongKeGioiTinh();

                pnlBieuDoKhoa.Invalidate();
                pnlBieuDoGioiTinh.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu Dashboard!\n\n" +
                    ex.Message,
                    "Lỗi thống kê",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // XÓA THỐNG KÊ DASHBOARD
        // ==========================================

        private void XoaThongKeDashboard()
        {
            lblTongSinhVien.Text = "--";
            lblTongKhoa.Text = "--";
            lblTongHocPhan.Text = "--";
            lblTongDangKy.Text = "--";

            _dsSinhVienTheoKhoa.Clear();
            _dsThongKeGioiTinh.Clear();

            pnlBieuDoKhoa.Invalidate();
            pnlBieuDoGioiTinh.Invalidate();
        }

        // ==========================================
        // BIỂU ĐỒ SINH VIÊN THEO KHOA
        // ==========================================

        private void pnlBieuDoKhoa_Paint(
            object? sender,
            PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (_dsSinhVienTheoKhoa == null ||
                _dsSinhVienTheoKhoa.Count == 0)
            {
                using (Font font = new Font("Arial", 10))
                {
                    g.DrawString(
                        "Chưa có dữ liệu thống kê",
                        font,
                        Brushes.Gray,
                        20,
                        30
                    );
                }

                return;
            }

            int left = 110;
            int top = 30;
            int barHeight = 22;
            int spacing = 15;

            int maxValue = Math.Max(
                1,
                _dsSinhVienTheoKhoa.Max(
                    x => x.SoLuongSinhVien
                )
            );

            int maxBarWidth = Math.Max(
                50,
                pnlBieuDoKhoa.Width - left - 55
            );

            using Font fontBieuDo =
                new Font("Arial", 9);

            using Brush barBrush =
                new SolidBrush(
                    Color.FromArgb(52, 152, 219)
                );

            int y = top;

            foreach (SinhVienTheoKhoa item
                in _dsSinhVienTheoKhoa)
            {
                string tenKhoa = item.TenKhoa;

                g.DrawString(
                    tenKhoa,
                    fontBieuDo,
                    Brushes.Black,
                    10,
                    y + 3
                );

                int barWidth = (int)(
                    (double)item.SoLuongSinhVien /
                    maxValue * maxBarWidth
                );

                g.FillRectangle(
                    barBrush,
                    left,
                    y,
                    barWidth,
                    barHeight
                );

                g.DrawString(
                    item.SoLuongSinhVien.ToString(),
                    fontBieuDo,
                    Brushes.Black,
                    left + barWidth + 5,
                    y + 3
                );

                y += barHeight + spacing;
            }
        }

        // ==========================================
        // BIỂU ĐỒ GIỚI TÍNH
        // ==========================================

        private void pnlBieuDoGioiTinh_Paint(
            object? sender,
            PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (_dsThongKeGioiTinh == null ||
                _dsThongKeGioiTinh.Count == 0)
            {
                using (Font font = new Font("Arial", 10))
                {
                    g.DrawString(
                        "Chưa có dữ liệu thống kê",
                        font,
                        Brushes.Gray,
                        20,
                        30
                    );
                }

                return;
            }

            int tongSoLuong =
                _dsThongKeGioiTinh.Sum(
                    x => x.SoLuong
                );

            if (tongSoLuong <= 0)
                return;

            int x = 20;
            int y = 30;

            int kichThuoc = Math.Min(
                160,
                Math.Min(
                    pnlBieuDoGioiTinh.Width / 2,
                    pnlBieuDoGioiTinh.Height - 30
                )
            );

            if (kichThuoc <= 0)
                return;

            Color[] mauSac =
            {
                Color.FromArgb(52, 152, 219),
                Color.FromArgb(231, 76, 60),
                Color.FromArgb(46, 204, 113)
            };

            float gocBatDau = 0;

            for (int i = 0;
                 i < _dsThongKeGioiTinh.Count;
                 i++)
            {
                ThongKeTheoNhom item =
                    _dsThongKeGioiTinh[i];

                float goc =
                    (float)item.SoLuong /
                    tongSoLuong * 360f;

                using Brush brush =
                    new SolidBrush(
                        mauSac[i % mauSac.Length]
                    );

                g.FillPie(
                    brush,
                    x,
                    y,
                    kichThuoc,
                    kichThuoc,
                    gocBatDau,
                    goc
                );

                gocBatDau += goc;
            }

            int legendX = x + kichThuoc + 15;
            int legendY = y + 10;

            using Font fontChuThich =
                new Font("Arial", 9);

            for (int i = 0;
                 i < _dsThongKeGioiTinh.Count;
                 i++)
            {
                ThongKeTheoNhom item =
                    _dsThongKeGioiTinh[i];

                using Brush brush =
                    new SolidBrush(
                        mauSac[i % mauSac.Length]
                    );

                g.FillRectangle(
                    brush,
                    legendX,
                    legendY,
                    14,
                    14
                );

                double phanTram =
                    (double)item.SoLuong /
                    tongSoLuong * 100;

                string noiDung =
                    $"{item.TenNhom}: {item.SoLuong} " +
                    $"({phanTram:F1}%)";

                g.DrawString(
                    noiDung,
                    fontChuThich,
                    Brushes.Black,
                    legendX + 22,
                    legendY
                );

                legendY += 28;
            }
        }

        // ==========================================
        // ĐỒNG HỒ
        // ==========================================

        private void timerDongHo_Tick(
            object? sender,
            EventArgs e)
        {
            HienThiThoiGian();
        }

        private void HienThiThoiGian()
        {
            tsslThoiGian.Text =
                "Thời gian: " +
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss"
                );
        }

        // ==========================================
        // MENU TÀI KHOẢN
        // ==========================================

        private void GanSuKienMenuTaiKhoan()
        {
            foreach (ToolStripMenuItem menu
                in LayTatCaMenu(menuStrip1.Items))
            {
                string ten =
                    ChuanHoaTenMenu(menu.Text);

                if (ten == "dang xuat")
                {
                    menu.Click -= btnDangXuat_Click;
                    menu.Click += btnDangXuat_Click;
                }
                else if (ten == "doi mat khau")
                {
                    menu.Click -= mnuDoiMatKhau_Click;
                    menu.Click += mnuDoiMatKhau_Click;
                }
            }
        }

        private IEnumerable<ToolStripMenuItem>
            LayTatCaMenu(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item is ToolStripMenuItem menu)
                {
                    yield return menu;

                    foreach (ToolStripMenuItem con
                        in LayTatCaMenu(menu.DropDownItems))
                    {
                        yield return con;
                    }
                }
            }
        }

        private string ChuanHoaTenMenu(string ten)
        {
            string s = (ten ?? "")
                .Replace("&", "")
                .Trim()
                .ToLowerInvariant();

            string normalized = s.Normalize(
                System.Text.NormalizationForm.FormD
            );

            var result =
                new System.Text.StringBuilder();

            foreach (char c in normalized)
            {
                if (System.Globalization.CharUnicodeInfo
                    .GetUnicodeCategory(c) !=
                    System.Globalization.UnicodeCategory
                        .NonSpacingMark)
                {
                    result.Append(
                        c == 'đ' ? 'd' : c
                    );
                }
            }

            return result.ToString().Normalize(
                System.Text.NormalizationForm.FormC
            );
        }

        // ==========================================
        // ĐỔI MẬT KHẨU
        // ==========================================

        private void mnuDoiMatKhau_Click(
            object? sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Chức năng đổi mật khẩu chưa được " +
                "kết nối với BUS và DAL.",
                "Đổi mật khẩu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ==========================================
        // ĐĂNG XUẤT
        // ==========================================


        private void btnDangXuat_Click(
           object? sender,
           EventArgs e)
        {
            DangXuat();
        }


        private void DangXuat()
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes)
                return;

            // Xóa phiên đăng nhập hiện tại.
            NguoiDungHienTai.DangXuat();
            QuyenNguoiDung.DangXuat();

            // Xóa dữ liệu Dashboard của phiên cũ.
            XoaThongKeDashboard();

            // Ẩn cửa sổ chính trước khi mở đăng nhập.
            this.Hide();

            using (frmDangNhap frm = new frmDangNhap())
            {
                // Hiển thị Form đăng nhập.
                DialogResult ketQuaDangNhap = frm.ShowDialog();

                if (ketQuaDangNhap == DialogResult.OK &&
                    NguoiDungHienTai.DaDangNhap)
                {
                    // Đăng nhập lại thành công.
                    HienThiThongTinNguoiDung();
                    ApDungPhanQuyen();
                    SapXepMenuNhanVien();

                    tsslTrangThai.Text = "Trạng thái: Sẵn sàng";

                    // Hiển thị lại cửa sổ chính.
                    this.Show();

                    HienThiThongKeDashboard();
                }
                else
                {
                    // Đóng Form đăng nhập mà không đăng nhập lại.
                    NguoiDungHienTai.DangXuat();
                    QuyenNguoiDung.DangXuat();

                    this.Close();
                }
            }
        }


        // ==========================================
        // THOÁT CHƯƠNG TRÌNH
        // ==========================================

        private void mnuThoat_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ==========================================
        // CÁC SỰ KIỆN DESIGNER
        // ==========================================

        private void btnGioiThieu_Click(
            object sender,
            EventArgs e)
        {
            mnuGioiThieu_Click(sender, e);
        }

        private void mnuDanhMuc_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void mnuGioiThieu_Click_1(
            object sender,
            EventArgs e)
        {
            // Giữ lại cho Designer.
        }

        private void tableLayoutPanel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void pnlThongKeSinhVien_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        // ==========================================
        // SIDEBAR: GỌN, ĐÚNG QUYỀN, KHÔNG KÉO DÀI NÚT
        // ==========================================

        private void SapXepMenuNhanVien()
        {
            // Các nút chức năng, không bao gồm Đăng xuất.
            Button[] cacNut =
            {
        btnTongQuan,
        btnSinhVien,
        btnKhoa,
        btnHocPhan,
        btnDangKy,
        btnTaiKhoan,
        btnPhanQuyen,
        btnGanVaiTro,
        btnThongKe,
        btnGiamSatHeThong
    };

            string[] quyen =
            {
        "",
        "SV_XEM",
        "KHOA_QL",
        "HP_QL",
        "DK_XEM",
        "TK_QL",
        "PQ_QL",
        "PQ_QL",
        "TK_BC",
        "LOG_VIEW"
    };

            bool[] hienThi = new bool[cacNut.Length];

            for (int i = 0; i < cacNut.Length; i++)
            {
                hienThi[i] =
                    i == 0 ||
                    NguoiDungHienTai.CoQuyen(quyen[i]);
            }

            tableLayoutPanel3.SuspendLayout();

            try
            {
                tableLayoutPanel3.AutoSize = false;
                tableLayoutPanel3.RowCount = 13;
                tableLayoutPanel3.GrowStyle =
                    TableLayoutPanelGrowStyle.FixedSize;

                tableLayoutPanel3.RowStyles.Clear();

                // Hàng tiêu đề.
                tableLayoutPanel3.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 54F));

                // 10 hàng chức năng.
                for (int i = 0; i < cacNut.Length; i++)
                {
                    tableLayoutPanel3.RowStyles.Add(
                        new RowStyle(
                            SizeType.Absolute,
                            hienThi[i] ? 50F : 0F
                        ));
                }

                // Hàng giãn.
                tableLayoutPanel3.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100F));

                // Hàng Đăng xuất.
                tableLayoutPanel3.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 60F));

                lblTieuDeMenu.AutoSize = false;
                lblTieuDeMenu.Dock = DockStyle.Fill;
                lblTieuDeMenu.Text = "QUẢN LÝ SINH VIÊN";
                lblTieuDeMenu.TextAlign =
                    ContentAlignment.MiddleLeft;

                for (int i = 0; i < cacNut.Length; i++)
                {
                    Button nut = cacNut[i];

                    nut.AutoSize = false;
                    nut.Dock = DockStyle.Fill;
                    nut.Margin = new Padding(4, 3, 4, 3);

                    nut.FlatStyle = FlatStyle.Flat;
                    nut.FlatAppearance.BorderSize = 0;

                    nut.FlatAppearance.MouseOverBackColor =
                        Color.FromArgb(52, 89, 137);

                    nut.BackColor =
                        Color.FromArgb(39, 65, 101);

                    nut.ForeColor = Color.White;
                    nut.TextAlign =
                        ContentAlignment.MiddleLeft;

                    nut.Cursor = Cursors.Hand;
                    nut.Visible = hienThi[i];
                }

                // Giữ nút Đăng xuất độc lập với phân quyền.
                btnDangXuat.AutoSize = false;
                btnDangXuat.Dock = DockStyle.Fill;
                btnDangXuat.Margin =
                    new Padding(4, 5, 4, 5);

                btnDangXuat.FlatStyle = FlatStyle.Flat;
                btnDangXuat.FlatAppearance.BorderSize = 0;

                btnDangXuat.BackColor =
                    Color.FromArgb(158, 52, 62);

                btnDangXuat.ForeColor = Color.White;
                btnDangXuat.TextAlign =
                    ContentAlignment.MiddleCenter;

                btnDangXuat.Cursor = Cursors.Hand;
                btnDangXuat.Enabled = true;
                btnDangXuat.Visible = true;
            }
            finally
            {
                tableLayoutPanel3.ResumeLayout(true);
            }
        }


        private void btnGiamSatHeThong_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraQuyenMoForm("LOG_VIEW"))
                return;

            MoFormChucNang(
                new frmGiamSatHeThong(),
                "Giám sát hệ thống"
            );
        }

        private void tableLayoutPanel1_Paint_1(
            object sender,
            PaintEventArgs e)
        {
        }

        private void pnlBieuDoGioiTinh_Paint_1(
            object sender,
            PaintEventArgs e)
        {
        }

        private void lblTongSinhVien_Click(
            object sender,
            EventArgs e)
        {
        }

        private void btnTestLogging_Click(object sender, EventArgs e)
        {
            using (frmTestLogging form = new frmTestLogging())
            {
                form.ShowDialog(this);
            }
        }
    }
}
