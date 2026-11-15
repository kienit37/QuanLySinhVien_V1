
using System;
using System.Collections.Generic;

namespace QuanLySinhVien.BUS.Security
{
    public static class QuyenNguoiDung
    {
        private static readonly HashSet<string> _danhSachQuyen =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // Nạp quyền sau khi đăng nhập
        public static void GanDanhSachQuyen(IEnumerable<string> danhSachQuyen)
        {
            _danhSachQuyen.Clear();

            foreach (string quyen in danhSachQuyen)
            {
                if (!string.IsNullOrWhiteSpace(quyen))
                {
                    _danhSachQuyen.Add(quyen.Trim());
                }
            }
        }

        // Kiểm tra quyền
        public static bool CoQuyen(string maQuyen)
        {
            if (string.IsNullOrWhiteSpace(maQuyen))
                return false;

            return _danhSachQuyen.Contains(maQuyen.Trim());
        }

        // Bắt buộc phải có quyền
        public static void KiemTraQuyen(string maQuyen)
        {
            if (!CoQuyen(maQuyen))
            {
                throw new UnauthorizedAccessException(
                    "Bạn không có quyền thực hiện chức năng này!"
                );
            }
        }

        // Xóa quyền khi đăng xuất
        public static void DangXuat()
        {
            _danhSachQuyen.Clear();
        }
    }
}
