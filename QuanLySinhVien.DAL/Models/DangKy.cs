
namespace QuanLySinhVien.DAL.Models
{
    public class DangKy
    {
        public string MaSV { get; set; } = string.Empty;

        public string MaHP { get; set; } = string.Empty;

        public int HocKy { get; set; }

        public string NamHoc { get; set; } = string.Empty;

        public DateTime NgayDangKy { get; set; }

        public decimal? Diem { get; set; }

        // Các thuộc tính bổ sung để hiển thị lên DataGridView
        public string? HoTen { get; set; }

        public string? TenHP { get; set; }
    }
}
