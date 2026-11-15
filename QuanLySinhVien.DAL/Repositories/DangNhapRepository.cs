
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class DangNhapRepository
    {
        // Lấy thông tin tài khoản theo tên đăng nhập
        public TaiKhoan? GetByTenDangNhap(string tenDangNhap)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT
                        MaTaiKhoan,
                        TenDangNhap,
                        MatKhauHash,
                        HoTen,
                        TrangThai
                    FROM TaiKhoan
                    WHERE TenDangNhap = @TenDangNhap";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@TenDangNhap",
                        SqlDbType.VarChar,
                        50
                    ).Value = tenDangNhap;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TaiKhoan
                            {
                                MaTaiKhoan = Convert.ToInt32(
                                    reader["MaTaiKhoan"]
                                ),
                                TenDangNhap = reader["TenDangNhap"].ToString() ?? "",
                                MatKhauHash = reader["MatKhauHash"].ToString() ?? "",
                                HoTen = reader["HoTen"].ToString() ?? "",
                                TrangThai = reader["TrangThai"] != DBNull.Value
                                    && Convert.ToBoolean(reader["TrangThai"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Lấy toàn bộ mã quyền của tài khoản
        public List<string> GetDanhSachQuyen(int maTaiKhoan)
        {
            List<string> danhSachQuyen = new List<string>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT DISTINCT Q.MaQuyen
                    FROM TaiKhoan_VaiTro TKV
                    INNER JOIN VaiTro_Quyen VTQ
                        ON TKV.MaVaiTro = VTQ.MaVaiTro
                    INNER JOIN Quyen Q
                        ON VTQ.MaQuyen = Q.MaQuyen
                    WHERE TKV.MaTaiKhoan = @MaTaiKhoan";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@MaTaiKhoan",
                        SqlDbType.Int
                    ).Value = maTaiKhoan;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachQuyen.Add(
                                reader["MaQuyen"].ToString() ?? ""
                            );
                        }
                    }
                }
            }

            return danhSachQuyen;
        }
    }
}
