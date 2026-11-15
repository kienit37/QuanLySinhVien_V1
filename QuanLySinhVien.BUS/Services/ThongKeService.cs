
using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class ThongKeService
    {
        private readonly ThongKeRepository _repository;

        public ThongKeService()
        {
            _repository = new ThongKeRepository();
        }

        // 1. Thống kê tổng quan: tổng sinh viên và tổng khoa
        public ThongKeTongQuan GetTongQuan()
        {
            return _repository.GetTongQuan();
        }

        // 2. Thống kê Dashboard: sinh viên, khoa, học phần, đăng ký
        public ThongKeDashboard GetThongKeDashboard()
        {
            return _repository.GetThongKeDashboard();
        }

        // 3. Thống kê số lượng sinh viên theo khoa
        public List<SinhVienTheoKhoa> GetSinhVienTheoKhoa()
        {
            return _repository.GetSinhVienTheoKhoa();
        }

        // 4. Thống kê theo giới tính
        public List<ThongKeTheoNhom> GetThongKeGioiTinh()
        {
            return _repository.GetThongKeGioiTinh();
        }

        // 5. Thống kê theo học lực
        public List<ThongKeTheoNhom> GetThongKeHocLuc()
        {
            return _repository.GetThongKeHocLuc();
        }

        // 6. Thống kê điểm trung bình
        public ThongKeDiemTrungBinh GetDiemTrungBinh()
        {
            return _repository.GetDiemTrungBinh();
        }
    }
}
