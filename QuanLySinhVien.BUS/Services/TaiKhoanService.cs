
using System;
using System.Collections.Generic;

using QuanLySinhVien.BUS.Security;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS
{
    public class TaiKhoanService
    {
        private readonly TaiKhoanRepository _repository;

        public TaiKhoanService()
        {
            _repository = new TaiKhoanRepository();
        }

        public List<TaiKhoan> GetAll()
        {
            return _repository.GetAll();
        }

        public List<TaiKhoan> Search(string tuKhoa)
        {
            return _repository.Search(tuKhoa.Trim());
        }

        // Tạo tài khoản
        public void Insert(
            string tenDangNhap,
            string matKhau,
            string hoTen)
        {
            tenDangNhap = tenDangNhap.Trim();
            hoTen = hoTen.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
                throw new Exception("Vui lòng nhập tên đăng nhập!");

            if (tenDangNhap.Length > 50)
                throw new Exception("Tên đăng nhập tối đa 50 ký tự!");

            if (string.IsNullOrWhiteSpace(matKhau))
                throw new Exception("Vui lòng nhập mật khẩu!");

            if (matKhau.Length < 8)
                throw new Exception("Mật khẩu phải có ít nhất 8 ký tự!");

            if (string.IsNullOrWhiteSpace(hoTen))
                throw new Exception("Vui lòng nhập họ tên!");

            if (hoTen.Length > 100)
                throw new Exception("Họ tên tối đa 100 ký tự!");

            TaiKhoan tk = new TaiKhoan
            {
                TenDangNhap = tenDangNhap,
                MatKhauHash = PasswordHelper.HashPassword(matKhau),
                HoTen = hoTen,
                TrangThai = true
            };

            _repository.Insert(tk);
        }

        // Cập nhật họ tên
        public void Update(int maTaiKhoan, string hoTen)
        {
            hoTen = hoTen.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
                throw new Exception("Vui lòng nhập họ tên!");

            if (hoTen.Length > 100)
                throw new Exception("Họ tên tối đa 100 ký tự!");

            TaiKhoan tk = new TaiKhoan
            {
                MaTaiKhoan = maTaiKhoan,
                HoTen = hoTen
            };

            _repository.Update(tk);
        }

        // Khóa / mở khóa
        public void UpdateStatus(int maTaiKhoan, bool trangThai)
        {
            _repository.UpdateStatus(maTaiKhoan, trangThai);
        }

        // Đặt lại mật khẩu
        public void ResetPassword(int maTaiKhoan, string matKhauMoi)
        {
            if (string.IsNullOrWhiteSpace(matKhauMoi))
                throw new Exception("Vui lòng nhập mật khẩu mới!");

            if (matKhauMoi.Length < 8)
                throw new Exception("Mật khẩu phải có ít nhất 8 ký tự!");

            string hash = PasswordHelper.HashPassword(matKhauMoi);

            _repository.ResetPassword(maTaiKhoan, hash);
        }
    }
}
