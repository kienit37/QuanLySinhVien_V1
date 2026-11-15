using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.DAL.Models
{
    // Thống kê tổng quan
    public class ThongKeTongQuan
    {
        public int TongSinhVien { get; set; }

        public int TongKhoa { get; set; }
    }

    // Thống kê sinh viên theo khoa
    public class SinhVienTheoKhoa
    {
        public string MaKhoa { get; set; } = "";

        public string TenKhoa { get; set; } = "";

        public int SoLuongSinhVien { get; set; }
    }

    // Thống kê theo giới tính hoặc học lực
    public class ThongKeTheoNhom
    {
        public string TenNhom { get; set; } = "";

        public int SoLuong { get; set; }
    }

    // Thống kê điểm trung bình
    public class ThongKeDiemTrungBinh
    {
        public int SoSinhVienCoDiem { get; set; }

        public decimal? DiemTrungBinhToanTruong { get; set; }

        public decimal? DiemCaoNhat { get; set; }

        public decimal? DiemThapNhat { get; set; }
    }
}
