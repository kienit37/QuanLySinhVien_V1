
using System;
using System.Collections.Generic;
using QuanLySinhVien.BUS.Security;
using QuanLySinhVien.Common.Logging;

namespace QuanLySinhVien.BUS.Services
{
    public class GiamSatService
    {
        private void KiemTraQuyen()
        {
            if (!QuyenNguoiDung.CoQuyen("LOG_VIEW"))
            {
                throw new UnauthorizedAccessException(
                    "Bạn không có quyền xem nhật ký hệ thống.");
            }
        }

        public List<LogEntry> GetLogs(
            DateTime tuNgay,
            DateTime denNgay)
        {
            KiemTraQuyen();

            return LogReader.GetLogs(
                tuNgay,
                denNgay);
        }

        public LogStatistics GetStatistics(
            DateTime tuNgay,
            DateTime denNgay)
        {
            KiemTraQuyen();

            List<LogEntry> logs =
                LogReader.GetLogs(tuNgay, denNgay);

            return LogStatistics.Calculate(logs);
        }
    }
}
