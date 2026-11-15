
namespace QuanLySinhVien.DAL.Models
{
    public class Quyen
    {
        public string MaQuyen { get; set; } = string.Empty;

        public string TenQuyen { get; set; } = string.Empty;

        public string? MoTa { get; set; }

        // Cho biết quyền có được gán cho vai trò đang chọn hay không
        public bool DuocChon { get; set; }
    }
}
