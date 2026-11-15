using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.DAL.Models
{
    public class SinhVien
    {
        public string MaSV { get; set; } = string.Empty;

        public string HoTen { get; set; } = string.Empty;

        public DateTime? NgaySinh { get; set; }

        public string? GioiTinh { get; set; }

        public string? Email { get; set; }

        public string? SoDienThoai { get; set; }

        public string? DiaChi { get; set; }

        public string MaKhoa { get; set; } = string.Empty;

        public decimal DiemTB { get; set; }

        // Dùng khi JOIN với bảng Khoa
        public string? TenKhoa { get; set; }
    }
}
