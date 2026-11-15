
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Common.Logging
{
    public class LogStatistics
    {
        public int TongSuKien { get; set; }

        public int TongLoi { get; set; }

        public int TongCanhBao { get; set; }

        public int TongThaoTacCham { get; set; }

        public double ThoiGianTrungBinhMs { get; set; }

        public static LogStatistics Calculate(
            IEnumerable<LogEntry> logs)
        {
            var danhSach = logs.ToList();

            var coThoiGian = danhSach
                .Where(x => x.DurationMs.HasValue)
                .ToList();

            return new LogStatistics
            {
                TongSuKien = danhSach.Count,

                TongLoi = danhSach.Count(x =>
                    x.Level == "ERROR" ||
                    x.Level == "CRITICAL"),

                TongCanhBao = danhSach.Count(x =>
                    x.Level == "WARNING"),

                TongThaoTacCham = danhSach.Count(x =>
                    x.Action == "SLOW_OPERATION"),

                ThoiGianTrungBinhMs =
                    coThoiGian.Count == 0
                        ? 0
                        : coThoiGian.Average(x =>
                            x.DurationMs!.Value)
            };
        }
    }
}
