
using System;
using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;
using QuanLySinhVien.BUS.Validators;

namespace QuanLySinhVien.BUS.Services
{
    public class SinhVienService
    {
        private readonly SinhVienRepository _repository;

        public SinhVienService()
        {
            _repository = new SinhVienRepository();
        }

        // 1. Lấy toàn bộ danh sách sinh viên
        public List<SinhVien> GetAll()
        {
            return _repository.GetAll();
        }

        // 2. Tìm kiếm sinh viên
        public List<SinhVien> Search(string tuKhoa)
        {
            return _repository.Search(tuKhoa ?? "");
        }

        // 3. Lấy sinh viên theo mã
        public SinhVien? GetById(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
            {
                throw new ArgumentException(
                    "Mã sinh viên không được để trống!"
                );
            }

            return _repository.GetById(maSV.Trim());
        }

        // 4. Thêm sinh viên
        public void Insert(SinhVien sv)
        {
            string loi = SinhVienValidator.Validate(sv);

            if (!string.IsNullOrEmpty(loi))
            {
                throw new ArgumentException(loi);
            }

            _repository.Insert(sv);
        }

        // 5. Cập nhật sinh viên
        public void Update(SinhVien sv)
        {
            string loi = SinhVienValidator.Validate(sv);

            if (!string.IsNullOrEmpty(loi))
            {
                throw new ArgumentException(loi);
            }

            _repository.Update(sv);
        }

        // 6. Xóa sinh viên
        public void Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
            {
                throw new ArgumentException(
                    "Mã sinh viên không được để trống!"
                );
            }

            _repository.Delete(maSV.Trim());
        }
    }
}
