using System;
using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class KhoaService
    {
        private readonly KhoaRepository _repository;

        public KhoaService()
        {
            _repository = new KhoaRepository();
        }

        public List<Khoa> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Khoa> Search(string tuKhoa)
        {
            return _repository.Search(tuKhoa ?? "");
        }

        public void Insert(Khoa khoa)
        {
            KiemTraDuLieu(khoa);
            _repository.Insert(khoa);
        }

        public void Update(Khoa khoa)
        {
            KiemTraDuLieu(khoa);
            _repository.Update(khoa);
        }

        public void Delete(string maKhoa)
        {
            if (string.IsNullOrWhiteSpace(maKhoa))
                throw new ArgumentException("Vui lòng chọn mã khoa cần xóa!");

            _repository.Delete(maKhoa);
        }

        private void KiemTraDuLieu(Khoa khoa)
        {
            if (khoa == null)
                throw new ArgumentNullException(nameof(khoa));

            if (string.IsNullOrWhiteSpace(khoa.MaKhoa))
                throw new ArgumentException("Mã khoa không được để trống!");

            if (khoa.MaKhoa.Trim().Length > 10)
                throw new ArgumentException("Mã khoa không được vượt quá 10 ký tự!");

            if (string.IsNullOrWhiteSpace(khoa.TenKhoa))
                throw new ArgumentException("Tên khoa không được để trống!");

            if (khoa.TenKhoa.Trim().Length > 100)
                throw new ArgumentException("Tên khoa không được vượt quá 100 ký tự!");

            if (khoa.MoTa != null && khoa.MoTa.Length > 255)
                throw new ArgumentException("Mô tả không được vượt quá 255 ký tự!");
        }
    }
}