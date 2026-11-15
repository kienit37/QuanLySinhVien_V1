using System.IO;
using System.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLySinhVien.BUS.Services;
using QuanLySinhVien.BUS.Security;
using QuanLySinhVien.Common.Logging;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmGiamSatHeThong : Form
    {
        private List<LogEntry> _logDangHienThi = new();
        private readonly GiamSatService _giamSatService
            = new GiamSatService();

        private List<LogEntry> _danhSachLog = new();

        public frmGiamSatHeThong()
        {
            InitializeComponent();

            // Gắn sự kiện một lần.
            this.Load -= frmGiamSatHeThong_Load;
            this.Load += frmGiamSatHeThong_Load;

            btnLoc.Click -= btnLoc_Click;
            btnLoc.Click += btnLoc_Click;

            btnLamMoi.Click -= btnLamMoi_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void frmGiamSatHeThong_Load(
            object? sender, EventArgs e)
        {
            // Kiểm tra quyền trước khi tải dữ liệu.
            if (!QuyenNguoiDung.CoQuyen("LOG_VIEW"))
            {
                MessageBox.Show(
                    "Bạn không có quyền giám sát hệ thống.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                BeginInvoke(new Action(Close));
                return;
            }

            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;

            KhoiTaoBoLoc();
            KhoiTaoBang();

            TaiDuLieu();
        }

        private void btnXuatCSV_Click(
            object? sender, EventArgs e)
        {
            if (!QuyenNguoiDung.CoQuyen("LOG_VIEW"))
            {
                MessageBox.Show("Bạn không có quyền xuất nhật ký.");
                return;
            }

            if (dgvNhatKy.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName =
                $"NhatKyHeThong_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                using StreamWriter writer = new StreamWriter(
                    sfd.FileName,
                    false,
                    new UTF8Encoding(true));

                // Ghi tiêu đề cột.
                writer.WriteLine(
                    "Thời gian,Mức độ,Tài khoản,Hành động,Nội dung,Xử lý (ms),Mã lỗi");

                foreach (DataGridViewRow row in dgvNhatKy.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string[] giaTri = new string[
                        dgvNhatKy.Columns.Count];

                    for (int i = 0; i < giaTri.Length; i++)
                    {
                        string value =
                            row.Cells[i].Value?.ToString() ?? "";

                        // Ngăn Excel diễn giải dữ liệu log
                        // thành công thức khi mở CSV.
                        string trimmed = value.TrimStart();

                        if (trimmed.StartsWith("=") ||
                            trimmed.StartsWith("+") ||
                            trimmed.StartsWith("-") ||
                            trimmed.StartsWith("@"))
                        {
                            value = "'" + value;
                        }

                        giaTri[i] =
                            "\"" + value.Replace("\"", "\"\"") + "\"";
                    }

                    writer.WriteLine(string.Join(",", giaTri));
                }

                MessageBox.Show(
                    "Xuất nhật ký CSV thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Không thể xuất file CSV.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXemChiTiet_Click(
            object? sender, EventArgs e)
        {
            if (dgvNhatKy.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một nhật ký.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int viTri = dgvNhatKy.CurrentRow.Index;

            if (dgvNhatKy.CurrentRow.Tag is not LogEntry log)
            {
                MessageBox.Show("Không tìm thấy thông tin nhật ký.");
                return;
            }

            using (var frm = new frmChiTietLog(log))
            {
                frm.ShowDialog(this);
            }
        }


        private void KhoiTaoBoLoc()
        {
            cboMucDo.Items.Clear();

            cboMucDo.Items.Add("Tất cả");
            cboMucDo.Items.Add("INFORMATION");
            cboMucDo.Items.Add("WARNING");
            cboMucDo.Items.Add("ERROR");
            cboMucDo.Items.Add("CRITICAL");
            cboMucDo.Items.Add("DEBUG");

            cboMucDo.SelectedIndex = 0;
        }

        private void KhoiTaoBang()
        {
            dgvNhatKy.Columns.Clear();

            ThemCot("ThoiGian", "Thời gian", 165);
            ThemCot("MucDo", "Mức độ", 95);
            ThemCot("TaiKhoan", "Tài khoản", 110);
            ThemCot("HanhDong", "Hành động", 150);
            ThemCot("NoiDung", "Nội dung", 230);
            ThemCot("ThoiGianXuLy", "Xử lý (ms)", 105);
            ThemCot("MaLoi", "Mã lỗi", 190);

            dgvNhatKy.CellFormatting -=
                dgvNhatKy_CellFormatting;

            dgvNhatKy.CellFormatting +=
                dgvNhatKy_CellFormatting;
        }

        private void ThemCot(
            string ten, string tieuDe, int doRong)
        {
            var cot = new DataGridViewTextBoxColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                Width = doRong,
                SortMode =
                    DataGridViewColumnSortMode.Automatic
            };

            dgvNhatKy.Columns.Add(cot);
        }

        private void TaiDuLieu()
        {
            try
            {
                if (dtpTuNgay.Value.Date >
                    dtpDenNgay.Value.Date)
                {
                    MessageBox.Show(
                        "Ngày bắt đầu không được lớn hơn ngày kết thúc.");
                    return;
                }

                _danhSachLog = _giamSatService.GetLogs(
                    dtpTuNgay.Value.Date,
                    dtpDenNgay.Value.Date
                );

                HienThiDuLieu();
                NapBoLocNangCao();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "Bạn không có quyền xem nhật ký.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Không thể tải nhật ký hệ thống.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void HienThiDuLieu()
        {
            string mucDo =
                cboMucDo.SelectedItem?.ToString()
                ?? "Tất cả";

            string tuKhoa =
                txtTimKiemLog.Text.Trim();

            var ketQua = _danhSachLog

                .Where(x =>
                    mucDo == "Tất cả" ||
                    string.Equals(
                        x.Level,
                        mucDo,
                        StringComparison.OrdinalIgnoreCase))
                .Where(x =>
                    string.IsNullOrWhiteSpace(tuKhoa) ||
                    x.Username.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) ||
                    x.Action.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) ||
                    x.Message.Contains(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Timestamp)
                .ToList();
            string taiKhoan =
    cboTaiKhoan.SelectedItem?.ToString() ?? "Tất cả";

            string hanhDong =
                cboHanhDong.SelectedItem?.ToString() ?? "Tất cả";
            _logDangHienThi = ketQua;

            dgvNhatKy.Rows.Clear();

            foreach (LogEntry log in ketQua)
            {
                int index = dgvNhatKy.Rows.Add(
     log.Timestamp.ToString("dd/MM/yyyy HH:mm:ss"),
     log.Level,
     log.Username,
     log.Action,
     log.Message,
     log.DurationMs?.ToString() ?? "",
     log.ErrorId ?? ""
 );

                dgvNhatKy.Rows[index].Tag = log;
            }

            CapNhatThongKe(ketQua);
        }

        private void NapBoLocNangCao()
        {
            cboTaiKhoan.Items.Clear();
            cboHanhDong.Items.Clear();

            cboTaiKhoan.Items.Add("Tất cả");
            cboHanhDong.Items.Add("Tất cả");

            foreach (string taiKhoan in _danhSachLog
                .Select(x => x.Username ?? "")
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x))
            {
                cboTaiKhoan.Items.Add(taiKhoan);
            }

            foreach (string hanhDong in _danhSachLog
                .Select(x => x.Action ?? "")
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x))
            {
                cboHanhDong.Items.Add(hanhDong);
            }

            cboTaiKhoan.SelectedIndex = 0;
            cboHanhDong.SelectedIndex = 0;
        }

        private void CapNhatThongKe(
            List<LogEntry> logs)
        {
            LogStatistics thongKe =
                LogStatistics.Calculate(logs);

            lblTongSuKien.Text =
                thongKe.TongSuKien.ToString("N0");

            lblTongLoi.Text =
                thongKe.TongLoi.ToString("N0");

            lblCanhBaoCham.Text =
                thongKe.TongThaoTacCham.ToString("N0");

            lblThoiGianTB.Text =
                thongKe.ThoiGianTrungBinhMs
                    .ToString("N1") + " ms";
        }

        private void dgvNhatKy_CellFormatting(
            object? sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvNhatKy.Columns[e.ColumnIndex].Name
                != "MucDo")
                return;

            string mucDo =
                e.Value?.ToString() ?? "";

            if (mucDo == "ERROR" ||
                mucDo == "CRITICAL")
            {
                e.CellStyle.ForeColor = Color.Firebrick;
                e.CellStyle.Font = new Font(
                    dgvNhatKy.Font, FontStyle.Bold);
            }
            else if (mucDo == "WARNING")
            {
                e.CellStyle.ForeColor =
                    Color.DarkOrange;
            }
            else
            {
                e.CellStyle.ForeColor =
                    Color.DarkGreen;
            }
        }

        private void btnLoc_Click(
            object? sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnLamMoi_Click(
            object? sender, EventArgs e)
        {
            dtpTuNgay.Value =
                DateTime.Today.AddDays(-7);

            dtpDenNgay.Value = DateTime.Today;

            cboMucDo.SelectedIndex = 0;
            txtTimKiemLog.Clear();

            TaiDuLieu();
        }
    }
}
