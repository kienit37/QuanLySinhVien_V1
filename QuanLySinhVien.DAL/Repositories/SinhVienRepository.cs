using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class SinhVienRepository
    {
        // Câu lệnh lấy danh sách sinh viên kèm tên khoa
        private const string SqlSelect = @"
            SELECT
                SV.MaSV,
                SV.HoTen,
                SV.NgaySinh,
                SV.GioiTinh,
                SV.Email,
                SV.SoDienThoai,
                SV.DiaChi,
                SV.MaKhoa,
                K.TenKhoa,
                SV.DiemTB
            FROM SinhVien SV
            INNER JOIN Khoa K ON SV.MaKhoa = K.MaKhoa ";

        // Đọc dữ liệu từ SQL Server
        private SinhVien MapSinhVien(SqlDataReader reader)
        {
            return new SinhVien
            {
                MaSV = reader["MaSV"].ToString()!,
                HoTen = reader["HoTen"].ToString()!,
                NgaySinh = reader["NgaySinh"] == DBNull.Value
                    ? null
                    : Convert.ToDateTime(reader["NgaySinh"]),
                GioiTinh = reader["GioiTinh"] == DBNull.Value
                    ? null
                    : reader["GioiTinh"].ToString(),
                Email = reader["Email"] == DBNull.Value
                    ? null
                    : reader["Email"].ToString(),
                SoDienThoai = reader["SoDienThoai"] == DBNull.Value
                    ? null
                    : reader["SoDienThoai"].ToString(),
                DiaChi = reader["DiaChi"] == DBNull.Value
                    ? null
                    : reader["DiaChi"].ToString(),
                MaKhoa = reader["MaKhoa"].ToString()!,
                TenKhoa = reader["TenKhoa"].ToString(),
                DiemTB = Convert.ToDecimal(reader["DiemTB"])
            };
        }

        // Thêm tham số cho câu lệnh SQL
        private void AddParameters(SqlCommand cmd, SinhVien sv)
        {
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20).Value = sv.MaSV;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = sv.HoTen;

            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value =
                sv.NgaySinh.HasValue ? (object)sv.NgaySinh.Value.Date : DBNull.Value;

            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value =
                (object?)sv.GioiTinh ?? DBNull.Value;

            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value =
                (object?)sv.Email ?? DBNull.Value;

            cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 15).Value =
                (object?)sv.SoDienThoai ?? DBNull.Value;

            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value =
                (object?)sv.DiaChi ?? DBNull.Value;

            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = sv.MaKhoa;

            SqlParameter diem = cmd.Parameters.Add("@DiemTB", SqlDbType.Decimal);
            diem.Precision = 4;
            diem.Scale = 2;
            diem.Value = sv.DiemTB;
        }

        // 1. Lấy toàn bộ sinh viên
        public List<SinhVien> GetAll()
        {
            List<SinhVien> danhSach = new List<SinhVien>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(
                SqlSelect + " ORDER BY SV.MaSV", conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(MapSinhVien(reader));
                    }
                }
            }

            return danhSach;
        }

        // 2. Tìm kiếm theo mã hoặc họ tên
        public List<SinhVien> Search(string tuKhoa)
        {
            List<SinhVien> danhSach = new List<SinhVien>();

            string sql = SqlSelect + @"
                WHERE SV.MaSV LIKE @TuKhoa
                   OR SV.HoTen LIKE @TuKhoa
                ORDER BY SV.MaSV";

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
                        danhSach.Add(MapSinhVien(reader));
                    }
                }
            }

            return danhSach;
        }

        // 3. Lấy sinh viên theo mã
        public SinhVien? GetById(string maSV)
        {
            string sql = SqlSelect + " WHERE SV.MaSV = @MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20).Value = maSV;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return MapSinhVien(reader);
                }
            }

            return null;
        }

        // 4. Thêm sinh viên
        public void Insert(SinhVien sv)
        {
            string sql = @"
                INSERT INTO SinhVien
                (
                    MaSV, HoTen, NgaySinh, GioiTinh,
                    Email, SoDienThoai, DiaChi, MaKhoa, DiemTB
                )
                VALUES
                (
                    @MaSV, @HoTen, @NgaySinh, @GioiTinh,
                    @Email, @SoDienThoai, @DiaChi, @MaKhoa, @DiemTB
                )";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, sv);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 5. Cập nhật sinh viên
        public void Update(SinhVien sv)
        {
            string sql = @"
                UPDATE SinhVien
                SET HoTen = @HoTen,
                    NgaySinh = @NgaySinh,
                    GioiTinh = @GioiTinh,
                    Email = @Email,
                    SoDienThoai = @SoDienThoai,
                    DiaChi = @DiaChi,
                    MaKhoa = @MaKhoa,
                    DiemTB = @DiemTB
                WHERE MaSV = @MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, sv);
                conn.Open();

                int soDong = cmd.ExecuteNonQuery();

                if (soDong == 0)
                    throw new Exception("Không tìm thấy sinh viên cần cập nhật!");
            }
        }

        // 6. Xóa sinh viên
        public void Delete(string maSV)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20).Value = maSV;

                conn.Open();

                int soDong = cmd.ExecuteNonQuery();

                if (soDong == 0)
                    throw new Exception("Không tìm thấy sinh viên cần xóa!");
            }
        }
    }
}