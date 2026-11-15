
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class GanVaiTroService
    {
        private readonly GanVaiTroRepository _repository;

        public GanVaiTroService()
        {
            _repository = new GanVaiTroRepository();
        }

        // Lấy danh sách tài khoản
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return _repository.GetAllTaiKhoan();
        }

        // Lấy vai trò theo tài khoản
        public List<VaiTro> GetVaiTroTheoTaiKhoan(int maTaiKhoan)
        {
            if (maTaiKhoan <= 0)
            {
                throw new Exception("Mã tài khoản không hợp lệ!");
            }

            return _repository.GetVaiTroTheoTaiKhoan(maTaiKhoan);
        }

        // Lưu vai trò
        public void LuuVaiTro(
            int maTaiKhoan,
            List<string> danhSachMaVaiTro)
        {
            if (maTaiKhoan <= 0)
            {
                throw new Exception("Vui lòng chọn tài khoản!");
            }

            if (danhSachMaVaiTro == null ||
                danhSachMaVaiTro.Count == 0)
            {
                throw new Exception(
                    "Tài khoản phải được gán ít nhất một vai trò!");
            }

            // Loại bỏ mã vai trò trùng lặp
            danhSachMaVaiTro = danhSachMaVaiTro
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .ToList();

            // Kiểm tra tài khoản có tồn tại không
            List<TaiKhoan> danhSachTaiKhoan =
                _repository.GetAllTaiKhoan();

            bool tonTai = danhSachTaiKhoan.Any(
                x => x.MaTaiKhoan == maTaiKhoan);

            if (!tonTai)
            {
                throw new Exception("Tài khoản không tồn tại!");
            }

            _repository.LuuVaiTro(
                maTaiKhoan,
                danhSachMaVaiTro);
        }
    }
}
