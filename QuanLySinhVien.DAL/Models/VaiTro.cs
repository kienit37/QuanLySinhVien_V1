namespace QuanLySinhVien.DAL.Models
{
    public class VaiTro
    {
        public string MaVaiTro { get; set; } = "";

        public string TenVaiTro { get; set; } = "";

        public string? MoTa { get; set; }

        // Thuộc tính đang được chức năng gán vai trò sử dụng
        public bool DaChon { get; set; }

        // Thuộc tính được GanVaiTroRepository và frmGanVaiTro sử dụng
        public bool DuocChon { get; set; }

        public override string ToString()
        {
            return TenVaiTro;
        }
    }
}