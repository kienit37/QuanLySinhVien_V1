using System;
using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class HocPhanService
    {
        private readonly HocPhanRepository _repository;

        public HocPhanService()
        {
            _repository = new HocPhanRepository();
        }

        public List<HocPhan> GetAll()
        {
            return _repository.GetAll();
        }

        public List<HocPhan> Search(string tuKhoa)
        {
            return _repository.Search(tuKhoa ?? "");
        }

        public void Insert(HocPhan hp)
        {
            KiemTraDuLieu(hp);
            _repository.Insert(hp);
        }

        public void Update(HocPhan hp)
        {
            KiemTraDuLieu(hp);
            _repository.Update(hp);
        }

        public void Delete(string maHP)
        {
            if (string.IsNullOrWhiteSpace(maHP))
                throw new ArgumentException("Vui lòng chọn học phần cần xóa!");

            _repository.Delete(maHP);
        }

        private void KiemTraDuLieu(HocPhan hp)
        {
            if (hp == null)
                throw new ArgumentNullException(nameof(hp));

            if (string.IsNullOrWhiteSpace(hp.MaHP))
                throw new ArgumentException("Mã học phần không được để trống!");

            if (hp.MaHP.Trim().Length > 15)
                throw new ArgumentException("Mã học phần tối đa 15 ký tự!");

            if (string.IsNullOrWhiteSpace(hp.TenHP))
                throw new ArgumentException("Tên học phần không được để trống!");

            if (hp.TenHP.Trim().Length > 100)
                throw new ArgumentException("Tên học phần tối đa 100 ký tự!");

            if (hp.SoTinChi <= 0)
                throw new ArgumentException("Số tín chỉ phải lớn hơn 0!");

            if (hp.SoTinChi > 10)
                throw new ArgumentException("Số tín chỉ không được vượt quá 10!");

            if (hp.MoTa != null && hp.MoTa.Length > 255)
                throw new ArgumentException("Mô tả tối đa 255 ký tự!");
        }
    }
}