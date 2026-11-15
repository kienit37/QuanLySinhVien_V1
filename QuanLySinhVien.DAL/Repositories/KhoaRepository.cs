using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class KhoaRepository
    {
        // 1. Lấy toàn bộ danh sách khoa
        public List<Khoa> GetAll()
        {
            List<Khoa> danhSach = new List<Khoa>();

            string sql = @"
                SELECT MaKhoa, TenKhoa, MoTa
                FROM Khoa
                ORDER BY MaKhoa";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new Khoa
                        {
                            MaKhoa = reader["MaKhoa"].ToString()!,
                            TenKhoa = reader["TenKhoa"].ToString()!,
                            MoTa = reader["MoTa"] == DBNull.Value
                                ? null
                                : reader["MoTa"].ToString()
                        });
                    }
                }
            }

            return danhSach;
        }

        // 2. Tìm kiếm khoa
        public List<Khoa> Search(string tuKhoa)
        {
            List<Khoa> danhSach = new List<Khoa>();

            string sql = @"
                SELECT MaKhoa, TenKhoa, MoTa
                FROM Khoa
                WHERE MaKhoa LIKE @TuKhoa
                   OR TenKhoa LIKE @TuKhoa
                ORDER BY MaKhoa";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 100)
                    .Value = "%" + tuKhoa + "%";

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new Khoa
                        {
                            MaKhoa = reader["MaKhoa"].ToString()!,
                            TenKhoa = reader["TenKhoa"].ToString()!,
                            MoTa = reader["MoTa"] == DBNull.Value
                                ? null
                                : reader["MoTa"].ToString()
                        });
                    }
                }
            }

            return danhSach;
        }

        // 3. Thêm khoa
        public void Insert(Khoa khoa)
        {
            string sql = @"
                INSERT INTO Khoa(MaKhoa, TenKhoa, MoTa)
                VALUES(@MaKhoa, @TenKhoa, @MoTa)";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, khoa);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 4. Cập nhật khoa
        public void Update(Khoa khoa)
        {
            string sql = @"
                UPDATE Khoa
                SET TenKhoa = @TenKhoa,
                    MoTa = @MoTa
                WHERE MaKhoa = @MaKhoa";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, khoa);

                conn.Open();

                int soDong = cmd.ExecuteNonQuery();

                if (soDong == 0)
                    throw new Exception("Không tìm thấy khoa cần cập nhật!");
            }
        }

        // 5. Xóa khoa
        public void Delete(string maKhoa)
        {
            string sql = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                    .Value = maKhoa;

                conn.Open();

                int soDong = cmd.ExecuteNonQuery();

                if (soDong == 0)
                    throw new Exception("Không tìm thấy khoa cần xóa!");
            }
        }

        // Hàm dùng chung để truyền tham số
        private void AddParameters(SqlCommand cmd, Khoa khoa)
        {
            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                .Value = khoa.MaKhoa;

            cmd.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 100)
                .Value = khoa.TenKhoa;

            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 255)
                .Value = (object?)khoa.MoTa ?? DBNull.Value;
        }
    }
}