
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class ThongKeRepository
    {
        // ==========================================
        // 1. THỐNG KÊ TỔNG QUAN
        // ==========================================

        public ThongKeTongQuan GetTongQuan()
        {
            ThongKeTongQuan thongKe = new ThongKeTongQuan();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                "sp_ThongKe_TongQuan", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        thongKe.TongSinhVien =
                            Convert.ToInt32(reader["TongSinhVien"]);

                        thongKe.TongKhoa =
                            Convert.ToInt32(reader["TongKhoa"]);
                    }
                }
            }

            return thongKe;
        }

        // ==========================================
        // 2. THỐNG KÊ DASHBOARD
        // Tổng sinh viên, khoa, học phần, đăng ký
        // ==========================================

        public ThongKeDashboard GetThongKeDashboard()
        {
            ThongKeDashboard thongKe = new ThongKeDashboard();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                "dbo.sp_ThongKe_Dashboard", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        thongKe.TongSinhVien =
                            Convert.ToInt32(reader["TongSinhVien"]);

                        thongKe.TongKhoa =
                            Convert.ToInt32(reader["TongKhoa"]);

                        thongKe.TongHocPhan =
                            Convert.ToInt32(reader["TongHocPhan"]);

                        thongKe.TongDangKy =
                            Convert.ToInt32(reader["TongDangKy"]);
                    }
                }
            }

            return thongKe;
        }

        // ==========================================
        // 3. THỐNG KÊ SINH VIÊN THEO KHOA
        // ==========================================

        public List<SinhVienTheoKhoa> GetSinhVienTheoKhoa()
        {
            List<SinhVienTheoKhoa> danhSach =
                new List<SinhVienTheoKhoa>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                "sp_ThongKe_SinhVienTheoKhoa", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SinhVienTheoKhoa sv = new SinhVienTheoKhoa
                        {
                            MaKhoa = reader["MaKhoa"].ToString() ?? "",
                            TenKhoa = reader["TenKhoa"].ToString() ?? "",

                            SoLuongSinhVien = Convert.ToInt32(
                                reader["SoLuongSinhVien"])
                        };

                        danhSach.Add(sv);
                    }
                }
            }

            return danhSach;
        }

        // ==========================================
        // 4. THỐNG KÊ SINH VIÊN THEO GIỚI TÍNH
        // ==========================================

        public List<ThongKeTheoNhom> GetThongKeGioiTinh()
        {
            List<ThongKeTheoNhom> danhSach =
                new List<ThongKeTheoNhom>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                "sp_ThongKe_GioiTinh", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeTheoNhom item = new ThongKeTheoNhom
                        {
                            TenNhom = reader["GioiTinh"].ToString() ?? "",

                            SoLuong = Convert.ToInt32(
                                reader["SoLuong"])
                        };

                        danhSach.Add(item);
                    }
                }
            }

            return danhSach;
        }

        // ==========================================
        // 5. THỐNG KÊ SINH VIÊN THEO HỌC LỰC
        // ==========================================

        public List<ThongKeTheoNhom> GetThongKeHocLuc()
        {
            List<ThongKeTheoNhom> danhSach =
                new List<ThongKeTheoNhom>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                "sp_ThongKe_HocLuc", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongKeTheoNhom item = new ThongKeTheoNhom
                        {
                            TenNhom = reader["XepLoai"].ToString() ?? "",

                            SoLuong = Convert.ToInt32(
                                reader["SoLuong"])
                        };

                        danhSach.Add(item);
                    }
                }
            }

            return danhSach;
        }

        // ==========================================
        // 6. THỐNG KÊ ĐIỂM TRUNG BÌNH
        // ==========================================

        public ThongKeDiemTrungBinh GetDiemTrungBinh()
        {
            ThongKeDiemTrungBinh thongKe =
                new ThongKeDiemTrungBinh();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                "sp_ThongKe_DiemTrungBinh", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        thongKe.SoSinhVienCoDiem =
                            Convert.ToInt32(reader["SoSinhVienCoDiem"]);

                        thongKe.DiemTrungBinhToanTruong =
                            reader.IsDBNull(
                                reader.GetOrdinal("DiemTrungBinhToanTruong"))
                            ? null
                            : Convert.ToDecimal(
                                reader["DiemTrungBinhToanTruong"]);

                        thongKe.DiemCaoNhat =
                            reader.IsDBNull(
                                reader.GetOrdinal("DiemCaoNhat"))
                            ? null
                            : Convert.ToDecimal(reader["DiemCaoNhat"]);

                        thongKe.DiemThapNhat =
                            reader.IsDBNull(
                                reader.GetOrdinal("DiemThapNhat"))
                            ? null
                            : Convert.ToDecimal(reader["DiemThapNhat"]);
                    }
                }
            }

            return thongKe;
        }
    }
}
