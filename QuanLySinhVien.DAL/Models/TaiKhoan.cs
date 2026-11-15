
namespace QuanLySinhVien.DAL.Models
{
    public class TaiKhoan
    {
        public int MaTaiKhoan { get; set; }

        public string TenDangNhap { get; set; } = string.Empty;

        public string? MatKhauHash { get; set; }

        public string HoTen { get; set; } = string.Empty;

        public bool TrangThai { get; set; }
    }
}
