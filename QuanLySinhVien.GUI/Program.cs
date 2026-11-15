
using System;
using System.Configuration;
using System.Windows.Forms;

using QuanLySinhVien.Common.Logging;
using QuanLySinhVien.DAL.Logging;
using QuanLySinhVien.GUI.Forms;
using QuanLySinhVien.GUI.Helpers;
using QuanLySinhVien.BUS.Security;

namespace QuanLySinhVien.GUI
{
    internal static class Program
    {
        // ==========================================
        // 1. CẤU HÌNH LOGGING
        // ==========================================

        private static void CauHinhLogging()
        {
            // Mặc định bật Logging
            bool batLogging = true;

            string? giaTriLogging =
                ConfigurationManager.AppSettings[
                    "EnableLogging"];

            if (bool.TryParse(
                giaTriLogging,
                out bool ketQua))
            {
                batLogging = ketQua;
            }

            // Mức độ Logging
            string mucLog =
                ConfigurationManager.AppSettings["LogLevel"]
                ?? "Information";

            if (!Enum.TryParse(
                mucLog,
                true,
                out LogLevel logLevel))
            {
                logLevel = LogLevel.Information;
            }

            // Thời gian lưu file
            if (!int.TryParse(
                ConfigurationManager.AppSettings[
                    "LogRetentionDays"],
                out int soNgayLuu) || soNgayLuu < 1)
            {
                soNgayLuu = 30;
            }

            // Ngưỡng thao tác chậm
            if (!long.TryParse(
                ConfigurationManager.AppSettings[
                    "SlowOperationThresholdMs"],
                out long nguongCham) || nguongCham < 1)
            {
                nguongCham = 1000;
            }

            // Áp dụng cấu hình
            AppLogger.Configure(new LogSettings
            {
                EnableLogging = batLogging,
                MinimumLevel = logLevel,
                RetentionDays = soNgayLuu,
                SlowOperationThresholdMs = nguongCham
            });
        }


        // ==========================================
        // 2. KHỞI ĐỘNG ỨNG DỤNG
        // ==========================================

        [STAThread]
        static void Main()
        {
            // BƯỚC 1: Cấu hình Logging
            CauHinhLogging();

            // BƯỚC 2: Đăng ký lưu log vào SQL Server
            AppLogger.SetDatabaseStore(
                new NhatKyHeThongDAL()

            );

            // BƯỚC 3: Xóa file log hết hạn
            AppLogger.DeleteExpiredLogs();

            // BƯỚC 4: Ghi log kiểm tra khởi động
            AppLogger.Info(
                "APP_START",
                "SYSTEM",
                "Ứng dụng quản lý sinh viên được khởi động"
            );

            // BƯỚC 5: Xử lý lỗi giao diện
            Application.ThreadException += (sender, e) =>
            {
                string? errorId = AppLogger.Error(
                    "UNHANDLED_UI",
                    "SYSTEM",
                    "Lỗi giao diện chưa được xử lý",
                    e.Exception
                );

                MessageBox.Show(
                    "Ứng dụng gặp lỗi chưa được xử lý.\n" +
                    "Mã theo dõi: " +
                    (errorId ?? "Không có"),
                    "Lỗi hệ thống",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            };

            // BƯỚC 6: Xử lý lỗi nghiêm trọng
            AppDomain.CurrentDomain.UnhandledException +=
                (sender, e) =>
                {
                    if (e.ExceptionObject is Exception ex)
                    {
                        AppLogger.Critical(
                            "UNHANDLED_PROCESS",
                            "SYSTEM",
                            "Lỗi nghiêm trọng của ứng dụng",
                            ex
                        );
                    }
                };

            // BƯỚC 7: Khởi tạo Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // BƯỚC 8: Xóa phiên đăng nhập cũ
            NguoiDungHienTai.DangXuat();
            QuyenNguoiDung.DangXuat();

            // BƯỚC 9: Hiển thị Form đăng nhập
            using (frmDangNhap frm = new frmDangNhap())
            {
                DialogResult ketQua = frm.ShowDialog();

                if (ketQua == DialogResult.OK &&
                    NguoiDungHienTai.DaDangNhap)
                {
                    Application.Run(new frmMain());
                }
            }

            // BƯỚC 10: Ghi nhật ký thoát ứng dụng
            AppLogger.Info(
                "APP_EXIT",
                "SYSTEM",
                "Ứng dụng quản lý sinh viên đã kết thúc"
            );

            // BƯỚC 11: Xóa phiên đăng nhập
            NguoiDungHienTai.DangXuat();
            QuyenNguoiDung.DangXuat();
        }
    }
}
