
using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.DAL.Models;
using ClosedXML.Excel;
using System.IO;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmThongKe : Form
    {
        private readonly ThongKeService _thongKeService;

        public frmThongKe()
        {
            InitializeComponent();

            _thongKeService = new ThongKeService();

            // Thiết lập giao diện DataGridView
            CauHinhDataGridView();

            // Đăng ký sự kiện
            this.Load += frmThongKe_Load;
            btnLamMoi.Click += btnLamMoi_Click;


            // Xuất báo cáo Excel
            btnXuatExcel.Click += btnXuatExcel_Click;

        }

        // ==========================================
        // 1. SỰ KIỆN LOAD FORM
        // ==========================================
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            HienThiThongKe();
        }

        // ==========================================
        // 2. HIỂN THỊ TOÀN BỘ THỐNG KÊ
        // ==========================================

        // ==========================================
        // XUẤT BÁO CÁO THỐNG KÊ RA EXCEL
        // ==========================================
        private void btnXuatExcel_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    saveFile.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                    saveFile.Title = "Lưu báo cáo thống kê";
                    saveFile.FileName =
                        "BaoCaoThongKeSinhVien_" +
                        DateTime.Now.ToString("ddMMyyyy_HHmmss") +
                        ".xlsx";

                    if (saveFile.ShowDialog() != DialogResult.OK)
                        return;

                    XuatBaoCaoExcel(saveFile.FileName);

                    MessageBox.Show(
                        "Xuất báo cáo Excel thành công!\n\n" +
                        "Đường dẫn: " + saveFile.FileName,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xuất báo cáo Excel!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TẠO FILE EXCEL
        // ==========================================
        private void XuatBaoCaoExcel(string duongDan)
        {
            // Lấy dữ liệu mới nhất từ BUS
            var tongQuan = _thongKeService.GetTongQuan();

            var diemTB = _thongKeService.GetDiemTrungBinh();

            var danhSachTheoKhoa =
                _thongKeService.GetSinhVienTheoKhoa();

            var danhSachGioiTinh =
                _thongKeService.GetThongKeGioiTinh();

            var danhSachHocLuc =
                _thongKeService.GetThongKeHocLuc();

            using (XLWorkbook workbook = new XLWorkbook())
            {
                // ==================================
                // SHEET 1: TỔNG QUAN
                // ==================================
                var wsTongQuan =
                    workbook.Worksheets.Add("TongQuan");

                wsTongQuan.Cell("A1").Value =
                    "BÁO CÁO THỐNG KÊ SINH VIÊN";

                wsTongQuan.Range("A1:B1").Merge();

                wsTongQuan.Cell("A1").Style.Font.Bold = true;
                wsTongQuan.Cell("A1").Style.Font.FontSize = 16;
                wsTongQuan.Cell("A1").Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                wsTongQuan.Cell("A3").Value = "Nội dung";
                wsTongQuan.Cell("B3").Value = "Kết quả";

                wsTongQuan.Cell("A4").Value = "Tổng số sinh viên";
                wsTongQuan.Cell("B4").Value = tongQuan.TongSinhVien;

                wsTongQuan.Cell("A5").Value = "Tổng số khoa";
                wsTongQuan.Cell("B5").Value = tongQuan.TongKhoa;

                wsTongQuan.Cell("A6").Value = "Số sinh viên có điểm";
                wsTongQuan.Cell("B6").Value = diemTB.SoSinhVienCoDiem;

                wsTongQuan.Cell("A7").Value = "Điểm trung bình toàn trường";
                wsTongQuan.Cell("B7").Value =
                    diemTB.DiemTrungBinhToanTruong.HasValue
                    ? diemTB.DiemTrungBinhToanTruong.Value
                    : "Chưa có";

                wsTongQuan.Cell("A8").Value = "Điểm cao nhất";
                wsTongQuan.Cell("B8").Value =
                    diemTB.DiemCaoNhat.HasValue
                    ? diemTB.DiemCaoNhat.Value
                    : "Chưa có";

                wsTongQuan.Cell("A9").Value = "Điểm thấp nhất";
                wsTongQuan.Cell("B9").Value =
                    diemTB.DiemThapNhat.HasValue
                    ? diemTB.DiemThapNhat.Value
                    : "Chưa có";

                wsTongQuan.Cell("A11").Value = "Ngày xuất báo cáo";
                wsTongQuan.Cell("B11").Value = DateTime.Now;

                wsTongQuan.Cell("B11").Style.DateFormat.Format =
                    "dd/MM/yyyy HH:mm:ss";

                DinhDangExcel(wsTongQuan, 3, 11, 2);

                // ==================================
                // SHEET 2: SINH VIÊN THEO KHOA
                // ==================================
                var wsKhoa =
                    workbook.Worksheets.Add("TheoKhoa");

                wsKhoa.Cell("A1").Value =
                    "THỐNG KÊ SINH VIÊN THEO KHOA";

                wsKhoa.Range("A1:C1").Merge();

                wsKhoa.Cell("A3").Value = "Mã khoa";
                wsKhoa.Cell("B3").Value = "Tên khoa";
                wsKhoa.Cell("C3").Value = "Số lượng sinh viên";

                int dongKhoa = 4;

                foreach (var item in danhSachTheoKhoa)
                {
                    wsKhoa.Cell(dongKhoa, 1).Value = item.MaKhoa;
                    wsKhoa.Cell(dongKhoa, 2).Value = item.TenKhoa;
                    wsKhoa.Cell(dongKhoa, 3).Value =
                        item.SoLuongSinhVien;

                    dongKhoa++;
                }

                DinhDangExcel(
                    wsKhoa,
                    3,
                    dongKhoa - 1,
                    3);

                // ==================================
                // SHEET 3: THỐNG KÊ GIỚI TÍNH
                // ==================================
                var wsGioiTinh =
                    workbook.Worksheets.Add("GioiTinh");

                wsGioiTinh.Cell("A1").Value =
                    "THỐNG KÊ SINH VIÊN THEO GIỚI TÍNH";

                wsGioiTinh.Range("A1:B1").Merge();

                wsGioiTinh.Cell("A3").Value = "Giới tính";
                wsGioiTinh.Cell("B3").Value = "Số lượng sinh viên";

                int dongGioiTinh = 4;

                foreach (var item in danhSachGioiTinh)
                {
                    wsGioiTinh.Cell(dongGioiTinh, 1).Value =
                        item.TenNhom;

                    wsGioiTinh.Cell(dongGioiTinh, 2).Value =
                        item.SoLuong;

                    dongGioiTinh++;
                }

                DinhDangExcel(
                    wsGioiTinh,
                    3,
                    dongGioiTinh - 1,
                    2);

                // ==================================
                // SHEET 4: THỐNG KÊ HỌC LỰC
                // ==================================
                var wsHocLuc =
                    workbook.Worksheets.Add("HocLuc");

                wsHocLuc.Cell("A1").Value =
                    "THỐNG KÊ SINH VIÊN THEO HỌC LỰC";

                wsHocLuc.Range("A1:B1").Merge();

                wsHocLuc.Cell("A3").Value = "Xếp loại học lực";
                wsHocLuc.Cell("B3").Value = "Số lượng sinh viên";

                int dongHocLuc = 4;

                foreach (var item in danhSachHocLuc)
                {
                    wsHocLuc.Cell(dongHocLuc, 1).Value =
                        item.TenNhom;

                    wsHocLuc.Cell(dongHocLuc, 2).Value =
                        item.SoLuong;

                    dongHocLuc++;
                }

                DinhDangExcel(
                    wsHocLuc,
                    3,
                    dongHocLuc - 1,
                    2);

                // ==================================
                // LƯU FILE EXCEL
                // ==================================
                workbook.SaveAs(duongDan);
            }
        }

        // ==========================================
        // ĐỊNH DẠNG CÁC SHEET EXCEL
        // ==========================================
        private void DinhDangExcel(
            IXLWorksheet ws,
            int dongTieuDe,
            int dongCuoi,
            int soCot)
        {
            // Định dạng tiêu đề lớn
            ws.Row(1).Height = 30;

            ws.Range(1, 1, 1, soCot).Style.Font.Bold = true;
            ws.Range(1, 1, 1, soCot).Style.Font.FontSize = 16;

            ws.Range(1, 1, 1, soCot).Style.Alignment.Horizontal =
                XLAlignmentHorizontalValues.Center;

            ws.Range(1, 1, 1, soCot).Style.Fill.BackgroundColor =
                XLColor.LightBlue;

            // Định dạng hàng tiêu đề bảng
            var header = ws.Range(
                dongTieuDe,
                1,
                dongTieuDe,
                soCot);

            header.Style.Font.Bold = true;
            header.Style.Font.FontColor = XLColor.White;

            header.Style.Fill.BackgroundColor =
                XLColor.FromHtml("#2980B9");

            header.Style.Alignment.Horizontal =
                XLAlignmentHorizontalValues.Center;

            // Kẻ khung bảng nếu có dữ liệu
            if (dongCuoi >= dongTieuDe)
            {
                var bang = ws.Range(
                    dongTieuDe,
                    1,
                    dongCuoi,
                    soCot);

                bang.Style.Border.OutsideBorder =
                    XLBorderStyleValues.Thin;

                bang.Style.Border.InsideBorder =
                    XLBorderStyleValues.Thin;
            }

            // Tự động điều chỉnh độ rộng cột
            ws.Columns().AdjustToContents();

            // Căn giữa các cột dữ liệu
            if (dongCuoi > dongTieuDe)
            {
                ws.Range(
                    dongTieuDe + 1,
                    1,
                    dongCuoi,
                    soCot
                ).Style.Alignment.Vertical =
                    XLAlignmentVerticalValues.Center;
            }
        }

        private void HienThiThongKe()
        {
            try
            {
                // Thống kê tổng quan
                HienThiTongQuan();

                // Thống kê sinh viên theo khoa
                dgvTheoKhoa.DataSource =
                    _thongKeService.GetSinhVienTheoKhoa();

                // Thống kê theo giới tính
                dgvGioiTinh.DataSource =
                    _thongKeService.GetThongKeGioiTinh();

                // Thống kê theo học lực
                dgvHocLuc.DataSource =
                    _thongKeService.GetThongKeHocLuc();

                // Định dạng các bảng
                DinhDangBang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu thống kê!\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 3. HIỂN THỊ THÔNG TIN TỔNG QUAN
        // ==========================================
        private void HienThiTongQuan()
        {
            // Tổng sinh viên và tổng khoa
            ThongKeTongQuan tongQuan =
                _thongKeService.GetTongQuan();

            lblTongSinhVien.Text =
                tongQuan.TongSinhVien.ToString();

            lblTongKhoa.Text =
                tongQuan.TongKhoa.ToString();

            // Điểm trung bình toàn trường
            ThongKeDiemTrungBinh diem =
                _thongKeService.GetDiemTrungBinh();

            lblDiemTB.Text =
                diem.DiemTrungBinhToanTruong.HasValue
                ? diem.DiemTrungBinhToanTruong.Value.ToString("0.00")
                : "Chưa có";

            // Điểm cao nhất
            lblDiemCaoNhat.Text =
                diem.DiemCaoNhat.HasValue
                ? diem.DiemCaoNhat.Value.ToString("0.00")
                : "Chưa có";

            // Điểm thấp nhất
            lblDiemThapNhat.Text =
                diem.DiemThapNhat.HasValue
                ? diem.DiemThapNhat.Value.ToString("0.00")
                : "Chưa có";
        }

        // ==========================================
        // 4. CẤU HÌNH DATAGRIDVIEW
        // ==========================================
        private void CauHinhDataGridView()
        {
            CauHinhMotBang(dgvTheoKhoa);
            CauHinhMotBang(dgvGioiTinh);
            CauHinhMotBang(dgvHocLuc);
        }

        private void CauHinhMotBang(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(41, 128, 185);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.RowTemplate.Height = 32;
        }

        // ==========================================
        // 5. ĐỊNH DẠNG TÊN CỘT
        // ==========================================
        private void DinhDangBang()
        {
            // Bảng theo khoa
            if (dgvTheoKhoa.Columns.Count > 0)
            {
                dgvTheoKhoa.Columns["MaKhoa"].HeaderText =
                    "Mã khoa";

                dgvTheoKhoa.Columns["TenKhoa"].HeaderText =
                    "Tên khoa";

                dgvTheoKhoa.Columns["SoLuongSinhVien"].HeaderText =
                    "Số lượng sinh viên";
            }

            // Bảng theo giới tính
            if (dgvGioiTinh.Columns.Count > 0)
            {
                dgvGioiTinh.Columns["TenNhom"].HeaderText =
                    "Giới tính";

                dgvGioiTinh.Columns["SoLuong"].HeaderText =
                    "Số lượng sinh viên";
            }

            // Bảng theo học lực
            if (dgvHocLuc.Columns.Count > 0)
            {
                dgvHocLuc.Columns["TenNhom"].HeaderText =
                    "Xếp loại học lực";

                dgvHocLuc.Columns["SoLuong"].HeaderText =
                    "Số lượng sinh viên";
            }
        }

        // ==========================================
        // 6. NÚT LÀM MỚI
        // ==========================================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiThongKe();

            MessageBox.Show(
                "Đã cập nhật dữ liệu thống kê!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTheoKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
