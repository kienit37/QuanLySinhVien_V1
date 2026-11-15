
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class PhanQuyenService
    {
        private readonly PhanQuyenRepository _repository;

        public PhanQuyenService()
        {
            _repository = new PhanQuyenRepository();
        }

        // Lấy toàn bộ quyền
        public List<Quyen> GetAllQuyen()
        {
            return _repository.GetAllQuyen();
        }

        // Lấy quyền theo vai trò
        public List<Quyen> GetQuyenTheoVaiTro(string maVaiTro)
        {
            if (string.IsNullOrWhiteSpace(maVaiTro))
                throw new Exception("Vui lòng chọn vai trò!");

            return _repository.GetQuyenTheoVaiTro(maVaiTro);
        }

        // Lưu phân quyền
        public void LuuQuyen(
            string maVaiTro,
            List<string> danhSachMaQuyen)
        {
            if (string.IsNullOrWhiteSpace(maVaiTro))
                throw new Exception("Vui lòng chọn vai trò!");

            if (maVaiTro == "ADMIN")
                throw new Exception(
                    "Không được thay đổi quyền mặc định của ADMIN!");

            if (danhSachMaQuyen == null)
                throw new Exception("Danh sách quyền không hợp lệ!");

            // Kiểm tra mã quyền có tồn tại
            var tatCaQuyen = _repository.GetAllQuyen();

            bool hopLe = danhSachMaQuyen.All(
                ma => tatCaQuyen.Any(q => q.MaQuyen == ma));

            if (!hopLe)
                throw new Exception("Danh sách chứa quyền không hợp lệ!");

            _repository.LuuQuyen(maVaiTro, danhSachMaQuyen);
        }
    }
}
