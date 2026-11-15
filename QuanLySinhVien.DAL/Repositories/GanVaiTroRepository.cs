
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class GanVaiTroRepository
    {
        // 1. Lấy danh sách tài khoản
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            List<TaiKhoan> danhSach = new List<TaiKhoan>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT MaTaiKhoan,
                           TenDangNhap,
                           HoTen,
                           TrangThai
                    FROM TaiKhoan
                    ORDER BY TenDangNhap";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TaiKhoan tk = new TaiKhoan
                            {
                                MaTaiKhoan = Convert.ToInt32(
                                    reader["MaTaiKhoan"]),

                                TenDangNhap = reader["TenDangNhap"].ToString()!,

                                HoTen = reader["HoTen"].ToString()!,

                                TrangThai = Convert.ToBoolean(
                                    reader["TrangThai"])
                            };

                            danhSach.Add(tk);
                        }
                    }
                }
            }

            return danhSach;
        }

        // 2. Lấy danh sách vai trò và trạng thái được gán
        public List<VaiTro> GetVaiTroTheoTaiKhoan(int maTaiKhoan)
        {
            List<VaiTro> danhSach = new List<VaiTro>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT
                        VT.MaVaiTro,
                        VT.TenVaiTro,
                        CAST(
                            CASE
                                WHEN TV.MaVaiTro IS NULL THEN 0
                                ELSE 1
                            END
                        AS BIT) AS DuocChon
                    FROM VaiTro VT
                    LEFT JOIN TaiKhoan_VaiTro TV
                        ON VT.MaVaiTro = TV.MaVaiTro
                        AND TV.MaTaiKhoan = @MaTaiKhoan
                    ORDER BY VT.MaVaiTro";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@MaTaiKhoan", SqlDbType.Int).Value = maTaiKhoan;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VaiTro vt = new VaiTro
                            {
                                MaVaiTro = reader["MaVaiTro"].ToString()!,
                                TenVaiTro = reader["TenVaiTro"].ToString()!,
                                DuocChon = Convert.ToBoolean(
                                    reader["DuocChon"])
                            };

                            danhSach.Add(vt);
                        }
                    }
                }
            }

            return danhSach;
        }

        // 3. Lưu danh sách vai trò cho tài khoản
        public void LuuVaiTro(
            int maTaiKhoan,
            List<string> danhSachMaVaiTro)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Xóa các vai trò cũ
                    string sqlXoa = @"
                        DELETE FROM TaiKhoan_VaiTro
                        WHERE MaTaiKhoan = @MaTaiKhoan";

                    using (SqlCommand cmdXoa =
                        new SqlCommand(sqlXoa, conn, transaction))
                    {
                        cmdXoa.Parameters.Add(
                            "@MaTaiKhoan", SqlDbType.Int).Value = maTaiKhoan;

                        cmdXoa.ExecuteNonQuery();
                    }

                    // Thêm lại các vai trò được chọn
                    string sqlThem = @"
                        INSERT INTO TaiKhoan_VaiTro
                            (MaTaiKhoan, MaVaiTro)
                        VALUES
                            (@MaTaiKhoan, @MaVaiTro)";

                    foreach (string maVaiTro in danhSachMaVaiTro)
                    {
                        using (SqlCommand cmdThem =
                            new SqlCommand(sqlThem, conn, transaction))
                        {
                            cmdThem.Parameters.Add(
                                "@MaTaiKhoan", SqlDbType.Int).Value =
                                maTaiKhoan;

                            cmdThem.Parameters.Add(
                                "@MaVaiTro", SqlDbType.VarChar, 20).Value =
                                maVaiTro;

                            cmdThem.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
