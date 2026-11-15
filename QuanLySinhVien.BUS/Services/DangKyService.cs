
using System;
using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;
using QuanLySinhVien.BUS.Security;

namespace QuanLySinhVien.BUS
{
    public class DangKyService
    {
        private readonly DangKyRepository _repository;

        public DangKyService()
        {
            _repository = new DangKyRepository();
        }

        // ==========================================
        // 1. LẤY DANH SÁCH ĐĂNG KÝ
        // Quyền: DK_XEM
        // ==========================================

        public List<DangKy> GetAll()
        {
            // Kiểm tra quyền xem
            QuyenNguoiDung.KiemTraQuyen("DK_XEM");

            // Gọi DAL lấy danh sách
            return _repository.GetAll();
        }

        // ==========================================
        // 2. TÌM KIẾM ĐĂNG KÝ
        // Quyền: DK_XEM
        // ==========================================

        public List<DangKy> Search(string tuKhoa)
        {
            // Kiểm tra quyền xem
            QuyenNguoiDung.KiemTraQuyen("DK_XEM");

            // Xử lý từ khóa
            string tuKhoaTimKiem = (tuKhoa ?? "").Trim();

            // Gọi DAL tìm kiếm
            return _repository.Search(tuKhoaTimKiem);
        }

        // ==========================================
        // 3. THÊM ĐĂNG KÝ
        // Quyền: DK_THEM
        // ==========================================

        public void Insert(DangKy dk)
        {
            // Kiểm tra quyền thêm
            QuyenNguoiDung.KiemTraQuyen("DK_THEM");

            // Kiểm tra dữ liệu đầu vào
            KiemTraDuLieu(dk);

            // Nhân viên không có quyền sửa
            // không được nhập điểm khi thêm đăng ký
            if (!QuyenNguoiDung.CoQuyen("DK_SUA") &&
                dk.Diem.HasValue)
            {
                throw new UnauthorizedAccessException(
                    "Bạn không có quyền nhập điểm!"
                );
            }

            // Gọi DAL thêm dữ liệu
            _repository.Insert(dk);
        }

        // ==========================================
        // 4. CẬP NHẬT ĐĂNG KÝ
        // Quyền: DK_SUA
        // ==========================================

        public void Update(DangKy dk)
        {
            // Kiểm tra quyền sửa
            QuyenNguoiDung.KiemTraQuyen("DK_SUA");

            // Kiểm tra dữ liệu đầu vào
            KiemTraDuLieu(dk);

            // Gọi DAL cập nhật
            _repository.Update(dk);
        }

        // ==========================================
        // 5. XÓA ĐĂNG KÝ
        // Quyền: DK_XOA
        // ==========================================

        public void Delete(DangKy dk)
        {
            // Kiểm tra quyền xóa
            QuyenNguoiDung.KiemTraQuyen("DK_XOA");

            // Kiểm tra bản ghi cần xóa
            if (dk == null)
            {
                throw new ArgumentException(
                    "Vui lòng chọn đăng ký!"
                );
            }

            // Gọi DAL xóa dữ liệu
            _repository.Delete(dk);
        }

        // ==========================================
        // 6. KIỂM TRA DỮ LIỆU
        // ==========================================

        private void KiemTraDuLieu(DangKy dk)
        {
            // Kiểm tra đối tượng đăng ký
            if (dk == null)
            {
                throw new ArgumentException(
                    "Thông tin đăng ký không hợp lệ!"
                );
            }

            // Kiểm tra mã sinh viên
            if (string.IsNullOrWhiteSpace(dk.MaSV))
            {
                throw new ArgumentException(
                    "Vui lòng chọn sinh viên!"
                );
            }

            // Kiểm tra mã học phần
            if (string.IsNullOrWhiteSpace(dk.MaHP))
            {
                throw new ArgumentException(
                    "Vui lòng chọn học phần!"
                );
            }

            // Kiểm tra học kỳ
            if (dk.HocKy < 1 || dk.HocKy > 3)
            {
                throw new ArgumentException(
                    "Học kỳ phải từ 1 đến 3!"
                );
            }

            // Kiểm tra năm học
            if (string.IsNullOrWhiteSpace(dk.NamHoc))
            {
                throw new ArgumentException(
                    "Vui lòng nhập năm học!"
                );
            }

            if (dk.NamHoc.Trim().Length > 20)
            {
                throw new ArgumentException(
                    "Năm học không được vượt quá 20 ký tự!"
                );
            }

            // Kiểm tra điểm
            if (dk.Diem.HasValue)
            {
                if (dk.Diem.Value < 0 ||
                    dk.Diem.Value > 10)
                {
                    throw new ArgumentException(
                        "Điểm phải từ 0 đến 10!"
                    );
                }
            }
        }
    }
}
