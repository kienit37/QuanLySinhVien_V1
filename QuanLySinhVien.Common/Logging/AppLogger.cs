
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Diagnostics;

namespace QuanLySinhVien.Common.Logging
{
    public static class AppLogger
    {
        // ==========================================
        // 1. CẤU HÌNH CHUNG
        // ==========================================

        // Khóa đồng bộ khi ghi file.
        private static readonly object _lock = new object();

        // Thư mục lưu nhật ký JSONL.
        private static readonly string _logDirectory =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "QuanLySinhVien",
                "Logs");

        public static string LogDirectory => _logDirectory;

        // Bật hoặc tắt hệ thống Logging.
        public static bool EnableLogging { get; set; } = true;

        // Mức độ ghi nhật ký tối thiểu.
        public static LogLevel MinimumLevel { get; set; }
            = LogLevel.Information;

        // Số ngày lưu giữ file nhật ký.
        public static int RetentionDays { get; set; } = 30;

        // Ngưỡng cảnh báo thao tác chậm (ms).
        public static long SlowOperationThresholdMs { get; set; }
            = 1000;


        // ==========================================
        // 2. CẤU HÌNH LOGGING TỪ APP.CONFIG
        // ==========================================

        public static void Configure(LogSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(
                    nameof(settings));
            }

            EnableLogging = settings.EnableLogging;

            MinimumLevel = settings.MinimumLevel;

            RetentionDays = Math.Max(
                1,
                settings.RetentionDays);

            SlowOperationThresholdMs = Math.Max(
                1,
                settings.SlowOperationThresholdMs);
        }


        // ==========================================
        // 3. ĐĂNG KÝ LƯU LOG VÀO DATABASE
        // ==========================================

        private static ILogStore? _databaseStore;

        public static void SetDatabaseStore(ILogStore store)
        {
            if (store == null)
            {
                throw new ArgumentNullException(
                    nameof(store));
            }

            _databaseStore = store;
        }


        // ==========================================
        // 4. LƯU NHẬT KÝ VÀO SQL SERVER
        // ==========================================

        private static void SaveToDatabase(LogEntry log)
        {
            try
            {
                if (_databaseStore == null)
                {
                    Debug.WriteLine(
                        "Database Logging chưa được đăng ký.");

                    return;
                }

                // Gọi tầng DAL để lưu nhật ký.
                _databaseStore.Save(log);
            }
            catch (Exception ex)
            {
                // Không gọi AppLogger.Error() tại đây,
                // tránh vòng lặp ghi nhật ký vô hạn.
                Debug.WriteLine(
                    "LỖI GHI LOG VÀO SQL SERVER: "
                    + ex.ToString());
            }
        }


        // ==========================================
        // 5. PHƯƠNG THỨC GHI LOG CHUNG
        // ==========================================

        public static string? Write(
            LogLevel level,
            string action,
            string username,
            string message,
            long? durationMs = null,
            Exception? exception = null)
        {
            // Kiểm tra cấu hình Logging.
            if (!EnableLogging || level < MinimumLevel)
            {
                return null;
            }

            // Tạo mã theo dõi nếu có ngoại lệ.
            string? errorId = exception == null
                ? null
                : Guid.NewGuid().ToString("N");

            // Tạo đối tượng nhật ký.
            LogEntry entry = new LogEntry
            {
                Timestamp = DateTimeOffset.Now,

                Level = level
                    .ToString()
                    .ToUpperInvariant(),

                Action = action,

                Username = username,

                Message = message,

                DurationMs = durationMs,

                ExceptionType =
                    exception?.GetType().Name,

                ErrorId = errorId
            };


            // ======================================
            // 5.1. GHI VÀO FILE JSONL
            // ======================================

            try
            {
                // Tạo thư mục nếu chưa tồn tại.
                Directory.CreateDirectory(
                    _logDirectory);

                // Tên file theo ngày.
                string fileName =
                    $"app-{DateTime.Now:yyyy-MM-dd}.jsonl";

                string filePath =
                    Path.Combine(
                        _logDirectory,
                        fileName);

                // Chuyển đối tượng thành JSON.
                string json =
                    JsonSerializer.Serialize(entry);

                // Ghi file an toàn giữa các luồng.
                lock (_lock)
                {
                    File.AppendAllText(
                        filePath,
                        json + Environment.NewLine,
                        Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                // Lỗi ghi file không làm gián đoạn
                // chức năng chính của ứng dụng.
                Debug.WriteLine(
                    "LỖI GHI FILE JSONL: "
                    + ex.ToString());
            }


            // ======================================
            // 5.2. GHI VÀO SQL SERVER
            // ======================================

            // Ghi database độc lập với ghi file.
            // Không gọi lại chính SaveToDatabase().
            SaveToDatabase(entry);

            // Trả mã theo dõi cho chức năng gọi.
            return errorId;
        }


        // ==========================================
        // 6. XÓA FILE NHẬT KÝ HẾT HẠN
        // ==========================================

        public static void DeleteExpiredLogs()
        {
            try
            {
                if (!Directory.Exists(_logDirectory))
                {
                    return;
                }

                DateTime ngayGioiHan =
                    DateTime.Today.AddDays(
                        -RetentionDays);

                string[] files = Directory.GetFiles(
                    _logDirectory,
                    "app-*.jsonl");

                foreach (string file in files)
                {
                    string tenFile =
                        Path.GetFileNameWithoutExtension(
                            file);

                    string ngay =
                        tenFile.Replace("app-", "");

                    if (DateTime.TryParseExact(
                        ngay,
                        "yyyy-MM-dd",
                        System.Globalization
                            .CultureInfo.InvariantCulture,
                        System.Globalization
                            .DateTimeStyles.None,
                        out DateTime ngayLog))
                    {
                        if (ngayLog < ngayGioiHan)
                        {
                            File.Delete(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    "LỖI XÓA FILE LOG HẾT HẠN: "
                    + ex.ToString());
            }
        }


        // ==========================================
        // 7. GHI NHẬT KÝ THÔNG THƯỜNG
        // ==========================================

        public static void Info(
            string action,
            string username,
            string message,
            long? durationMs = null)
        {
            Write(
                LogLevel.Information,
                action,
                username,
                message,
                durationMs);
        }


        // ==========================================
        // 8. GHI NHẬT KÝ CẢNH BÁO
        // ==========================================

        public static void Warning(
            string action,
            string username,
            string message,
            long? durationMs = null)
        {
            Write(
                LogLevel.Warning,
                action,
                username,
                message,
                durationMs);
        }


        // ==========================================
        // 9. GHI NHẬT KÝ LỖI
        // ==========================================

        public static string? Error(
            string action,
            string username,
            string message,
            Exception exception)
        {
            return Write(
                LogLevel.Error,
                action,
                username,
                message,
                exception: exception);
        }


        // ==========================================
        // 10. GHI NHẬT KÝ LỖI NGHIÊM TRỌNG
        // ==========================================

        public static string? Critical(
            string action,
            string username,
            string message,
            Exception exception)
        {
            return Write(
                LogLevel.Critical,
                action,
                username,
                message,
                exception: exception);
        }
    }
}
