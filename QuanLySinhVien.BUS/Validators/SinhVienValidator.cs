using QuanLySinhVien.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.BUS.Validators
{
    public static class SinhVienValidator
    {
        public static string Validate(SinhVien sv)
        {
            if (sv == null)
            {
                return "Thông tin sinh viên không hợp lệ!";
            }

            if (string.IsNullOrWhiteSpace(sv.MaSV))
            {
                return "Mã sinh viên không được để trống!";
            }

            if (sv.MaSV.Trim().Length > 20)
            {
                return "Mã sinh viên không được vượt quá 20 ký tự!";
            }

            if (string.IsNullOrWhiteSpace(sv.HoTen))
            {
                return "Họ tên không được để trống!";
            }

            if (sv.HoTen.Trim().Length > 100)
            {
                return "Họ tên không được vượt quá 100 ký tự!";
            }

            if (sv.NgaySinh.HasValue &&
                sv.NgaySinh.Value.Date > DateTime.Today)
            {
                return "Ngày sinh không được lớn hơn ngày hiện tại!";
            }

            if (!string.IsNullOrWhiteSpace(sv.GioiTinh) &&
                sv.GioiTinh.Length > 10)
            {
                return "Giới tính không được vượt quá 10 ký tự!";
            }

            if (!string.IsNullOrWhiteSpace(sv.Email) &&
                sv.Email.Length > 100)
            {
                return "Email không được vượt quá 100 ký tự!";
            }

            if (!string.IsNullOrWhiteSpace(sv.SoDienThoai) &&
                sv.SoDienThoai.Length > 15)
            {
                return "Số điện thoại không được vượt quá 15 ký tự!";
            }

            if (!string.IsNullOrWhiteSpace(sv.DiaChi) &&
                sv.DiaChi.Length > 255)
            {
                return "Địa chỉ không được vượt quá 255 ký tự!";
            }

            if (string.IsNullOrWhiteSpace(sv.MaKhoa))
            {
                return "Vui lòng chọn khoa!";
            }

            if (sv.MaKhoa.Trim().Length > 10)
            {
                return "Mã khoa không được vượt quá 10 ký tự!";
            }

            if (sv.DiemTB < 0 || sv.DiemTB > 10)
            {
                return "Điểm trung bình phải nằm trong khoảng từ 0 đến 10!";
            }

            return string.Empty;
        }
    }
}
