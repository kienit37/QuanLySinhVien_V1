
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace QuanLySinhVien.Common.Logging
{
    public static class LogReader
    {
        // Đọc các nhật ký trong khoảng ngày.
        public static List<LogEntry> GetLogs(
            DateTime tuNgay,
            DateTime denNgay)
        {
            List<LogEntry> ketQua = new();

            string thuMuc = AppLogger.LogDirectory;

            if (!Directory.Exists(thuMuc))
                return ketQua;

            if (tuNgay.Date > denNgay.Date)
                throw new ArgumentException(
                    "Ngày bắt đầu không được lớn hơn ngày kết thúc.");

            // Chỉ đọc các file theo khoảng ngày yêu cầu.
            for (DateTime ngay = tuNgay.Date;
                 ngay <= denNgay.Date;
                 ngay = ngay.AddDays(1))
            {
                string tenFile =
                    $"app-{ngay:yyyy-MM-dd}.jsonl";

                string duongDan =
                    Path.Combine(thuMuc, tenFile);

                if (!File.Exists(duongDan))
                    continue;

                try
                {
                    foreach (string dong
                        in File.ReadLines(duongDan))
                    {
                        if (string.IsNullOrWhiteSpace(dong))
                            continue;

                        try
                        {
                            LogEntry? log =
                                JsonSerializer.Deserialize<LogEntry>(
                                    dong);

                            if (log != null)
                                ketQua.Add(log);
                        }
                        catch (JsonException)
                        {
                            // Bỏ qua dòng JSON bị hỏng.
                        }
                    }
                }
                catch (IOException)
                {
                    // File có thể đang bị khóa hoặc không đọc được.
                }
                catch (UnauthorizedAccessException)
                {
                    // Không có quyền đọc file.
                }
            }

            return ketQua
                .OrderByDescending(x => x.Timestamp)
                .ToList();
        }
    }
}
