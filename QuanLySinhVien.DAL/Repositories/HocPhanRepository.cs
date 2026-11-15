using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class HocPhanRepository
    {
        // 1. Lấy danh sách học phần
        public List<HocPhan> GetAll()
        {
            List<HocPhan> danhSach = new List<HocPhan>();

            string sql = @"
                SELECT MaHP, TenHP, SoTinChi, MoTa
                FROM HocPhan
                ORDER BY MaHP";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new HocPhan
                        {
                            MaHP = reader["MaHP"].ToString()!,
                            TenHP = reader["TenHP"].ToString()!,
                            SoTinChi = Convert.ToInt32(reader["SoTinChi"]),
                            MoTa = reader["MoTa"] == DBNull.Value
                                ? null
                                : reader["MoTa"].ToString()
                        });
                    }
                }
            }

            return danhSach;
        }

        // 2. Tìm kiếm học phần
        public List<HocPhan> Search(string tuKhoa)
        {
            List<HocPhan> danhSach = new List<HocPhan>();

            string sql = @"
                SELECT MaHP, TenHP, SoTinChi, MoTa
                FROM HocPhan
                WHERE MaHP LIKE @TuKhoa
                   OR TenHP LIKE @TuKhoa
                ORDER BY MaHP";

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
                        danhSach.Add(new HocPhan
                        {
                            MaHP = reader["MaHP"].ToString()!,
                            TenHP = reader["TenHP"].ToString()!,
                            SoTinChi = Convert.ToInt32(reader["SoTinChi"]),
                            MoTa = reader["MoTa"] == DBNull.Value
                                ? null
                                : reader["MoTa"].ToString()
                        });
                    }
                }
            }

            return danhSach;
        }

        // 3. Thêm học phần
        public void Insert(HocPhan hp)
        {
            string sql = @"
                INSERT INTO HocPhan(MaHP, TenHP, SoTinChi, MoTa)
                VALUES(@MaHP, @TenHP, @SoTinChi, @MoTa)";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, hp);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 4. Cập nhật học phần
        public void Update(HocPhan hp)
        {
            string sql = @"
                UPDATE HocPhan
                SET TenHP = @TenHP,
                    SoTinChi = @SoTinChi,
                    MoTa = @MoTa
                WHERE MaHP = @MaHP";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, hp);

                conn.Open();

                int soDong = cmd.ExecuteNonQuery();

                if (soDong == 0)
                    throw new Exception("Không tìm thấy học phần cần cập nhật!");
            }
        }

        // 5. Xóa học phần
        public void Delete(string maHP)
        {
            string sql = "DELETE FROM HocPhan WHERE MaHP = @MaHP";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaHP", SqlDbType.VarChar, 15)
                    .Value = maHP;

                conn.Open();

                int soDong = cmd.ExecuteNonQuery();

                if (soDong == 0)
                    throw new Exception("Không tìm thấy học phần cần xóa!");
            }
        }

        // 6. Thêm tham số
        private void AddParameters(SqlCommand cmd, HocPhan hp)
        {
            cmd.Parameters.Add("@MaHP", SqlDbType.VarChar, 15)
                .Value = hp.MaHP;

            cmd.Parameters.Add("@TenHP", SqlDbType.NVarChar, 100)
                .Value = hp.TenHP;

            cmd.Parameters.Add("@SoTinChi", SqlDbType.Int)
                .Value = hp.SoTinChi;

            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 255)
                .Value = (object?)hp.MoTa ?? DBNull.Value;
        }
    }
}