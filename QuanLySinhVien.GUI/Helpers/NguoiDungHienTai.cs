
using System;
using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.GUI.Helpers
{
    public static class NguoiDungHienTai
    {
        public static TaiKhoan? TaiKhoan { get; private set; }

        private static readonly HashSet<string> _danhSachQuyen =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // Kiểm tra đã đăng nhập
        public static bool DaDangNhap => TaiKhoan != null;

        // Lưu thông tin tài khoản
        public static void DangNhap(TaiKhoan taiKhoan)
        {
            TaiKhoan = taiKhoan;
            _danhSachQuyen.Clear();
        }

        // Gán danh sách quyền
        public static void GanDanhSachQuyen(
            IEnumerable<string> danhSachQuyen)
        {
            _danhSachQuyen.Clear();

            if (danhSachQuyen == null)
                return;

            foreach (string quyen in danhSachQuyen)
            {
                if (!string.IsNullOrWhiteSpace(quyen))
                {
                    _danhSachQuyen.Add(quyen.Trim());
                }
            }
        }

        // Thêm một quyền
        public static void ThemQuyen(string maQuyen)
        {
            if (!string.IsNullOrWhiteSpace(maQuyen))
            {
                _danhSachQuyen.Add(maQuyen.Trim());
            }
        }

        // Kiểm tra người dùng có quyền hay không
        public static bool CoQuyen(string maQuyen)
        {
            if (string.IsNullOrWhiteSpace(maQuyen))
                return false;

            return _danhSachQuyen.Contains(maQuyen.Trim());
        }

        // Đăng xuất
        public static void DangXuat()
        {
            TaiKhoan = null;
            _danhSachQuyen.Clear();
        }
    }
}
