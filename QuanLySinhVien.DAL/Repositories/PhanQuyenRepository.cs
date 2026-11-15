
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class PhanQuyenRepository
    {
        // Lấy toàn bộ danh sách quyền
        public List<Quyen> GetAllQuyen()
        {
            List<Quyen> danhSach = new List<Quyen>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT MaQuyen, TenQuyen, MoTa
                    FROM Quyen
                    ORDER BY MaQuyen";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSach.Add(new Quyen
                            {
                                MaQuyen = reader["MaQuyen"].ToString()!,
                                TenQuyen = reader["TenQuyen"].ToString()!,
                                MoTa = reader["MoTa"] == DBNull.Value
                                    ? null
                                    : reader["MoTa"].ToString()
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        // Lấy danh sách quyền theo vai trò
        public List<Quyen> GetQuyenTheoVaiTro(string maVaiTro)
        {
            List<Quyen> danhSach = new List<Quyen>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT
                        Q.MaQuyen,
                        Q.TenQuyen,
                        Q.MoTa,
                        CASE
                            WHEN VTQ.MaQuyen IS NULL THEN 0
                            ELSE 1
                        END AS DuocChon
                    FROM Quyen Q
                    LEFT JOIN VaiTro_Quyen VTQ
                        ON Q.MaQuyen = VTQ.MaQuyen
                        AND VTQ.MaVaiTro = @MaVaiTro
                    ORDER BY Q.MaQuyen";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaVaiTro", SqlDbType.VarChar, 20)
                        .Value = maVaiTro;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSach.Add(new Quyen
                            {
                                MaQuyen = reader["MaQuyen"].ToString()!,
                                TenQuyen = reader["TenQuyen"].ToString()!,
                                MoTa = reader["MoTa"] == DBNull.Value
                                    ? null
                                    : reader["MoTa"].ToString(),
                                DuocChon = Convert.ToBoolean(reader["DuocChon"])
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        // Lưu danh sách quyền cho vai trò
        public void LuuQuyen(
            string maVaiTro,
            List<string> danhSachMaQuyen)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlXoa = @"
                            DELETE FROM VaiTro_Quyen
                            WHERE MaVaiTro = @MaVaiTro";

                        using (SqlCommand cmd = new SqlCommand(
                            sqlXoa, conn, transaction))
                        {
                            cmd.Parameters.Add("@MaVaiTro",
                                SqlDbType.VarChar, 20).Value = maVaiTro;

                            cmd.ExecuteNonQuery();
                        }

                        string sqlThem = @"
                            INSERT INTO VaiTro_Quyen
                            (MaVaiTro, MaQuyen)
                            VALUES (@MaVaiTro, @MaQuyen)";

                        foreach (string maQuyen in danhSachMaQuyen)
                        {
                            using (SqlCommand cmd = new SqlCommand(
                                sqlThem, conn, transaction))
                            {
                                cmd.Parameters.Add("@MaVaiTro",
                                    SqlDbType.VarChar, 20).Value = maVaiTro;

                                cmd.Parameters.Add("@MaQuyen",
                                    SqlDbType.VarChar, 30).Value = maQuyen;

                                cmd.ExecuteNonQuery();
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
}
