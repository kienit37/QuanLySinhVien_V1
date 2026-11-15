
using System;
using System.Collections.Generic;
using QuanLySinhVien.BUS.Security;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class DangNhapService
    {
        private readonly DangNhapRepository _repository;

        public DangNhapService()
        {
            _repository = new DangNhapRepository();
        }

        // Xác thực tài khoản
        public TaiKhoan DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                throw new Exception("Vui lòng nhập tên đăng nhập!");

            if (string.IsNullOrWhiteSpace(matKhau))
                throw new Exception("Vui lòng nhập mật khẩu!");

            TaiKhoan? taiKhoan =
                _repository.GetByTenDangNhap(tenDangNhap.Trim());

            if (taiKhoan == null)
                throw new Exception("Tên đăng nhập hoặc mật khẩu không chính xác!");

            if (!taiKhoan.TrangThai)
                throw new Exception("Tài khoản đã bị khóa hoặc ngừng hoạt động!");

            bool hopLe = PasswordHelper.VerifyPassword(
                matKhau,
                taiKhoan.MatKhauHash
            );

            if (!hopLe)
                throw new Exception("Tên đăng nhập hoặc mật khẩu không chính xác!");

            return taiKhoan;
        }

        // Lấy quyền theo mã tài khoản
        public List<string> GetDanhSachQuyen(int maTaiKhoan)
        {
            return _repository.GetDanhSachQuyen(maTaiKhoan);
        }
    }
}
