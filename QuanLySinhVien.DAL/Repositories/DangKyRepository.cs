
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class DangKyRepository
    {
        // 1. Lấy toàn bộ danh sách đăng ký
        public List<DangKy> GetAll()
        {
            List<DangKy> danhSach = new List<DangKy>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT
                        DK.MaSV,
                        SV.HoTen,
                        DK.MaHP,
                        HP.TenHP,
                        DK.HocKy,
                        DK.NamHoc,
                        DK.NgayDangKy,
                        DK.Diem
                    FROM DangKy DK
                    INNER JOIN SinhVien SV ON DK.MaSV = SV.MaSV
                    INNER JOIN HocPhan HP ON DK.MaHP = HP.MaHP
                    ORDER BY DK.NamHoc DESC, DK.HocKy, DK.MaSV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DangKy dk = new DangKy
                            {
                                MaSV = reader["MaSV"].ToString()!,
                                HoTen = reader["HoTen"].ToString(),
                                MaHP = reader["MaHP"].ToString()!,
                                TenHP = reader["TenHP"].ToString(),
                                HocKy = Convert.ToInt32(reader["HocKy"]),
                                NamHoc = reader["NamHoc"].ToString()!,
                                NgayDangKy = Convert.ToDateTime(
                                    reader["NgayDangKy"]),
                                Diem = reader["Diem"] == DBNull.Value
                                    ? null
                                    : Convert.ToDecimal(reader["Diem"])
                            };

                            danhSach.Add(dk);
                        }
                    }
                }
            }

            return danhSach;
        }

        // 2. Tìm kiếm đăng ký theo mã SV, tên SV, mã HP hoặc tên HP
        public List<DangKy> Search(string tuKhoa)
        {
            List<DangKy> danhSach = new List<DangKy>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT
                        DK.MaSV,
                        SV.HoTen,
                        DK.MaHP,
                        HP.TenHP,
                        DK.HocKy,
                        DK.NamHoc,
                        DK.NgayDangKy,
                        DK.Diem
                    FROM DangKy DK
                    INNER JOIN SinhVien SV ON DK.MaSV = SV.MaSV
                    INNER JOIN HocPhan HP ON DK.MaHP = HP.MaHP
                    WHERE DK.MaSV LIKE @TuKhoa
                       OR SV.HoTen LIKE @TuKhoa
                       OR DK.MaHP LIKE @TuKhoa
                       OR HP.TenHP LIKE @TuKhoa
                    ORDER BY DK.NamHoc DESC, DK.HocKy";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 100)
                        .Value = "%" + tuKhoa + "%";

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DangKy dk = new DangKy
                            {
                                MaSV = reader["MaSV"].ToString()!,
                                HoTen = reader["HoTen"].ToString(),
                                MaHP = reader["MaHP"].ToString()!,
                                TenHP = reader["TenHP"].ToString(),
                                HocKy = Convert.ToInt32(reader["HocKy"]),
                                NamHoc = reader["NamHoc"].ToString()!,
                                NgayDangKy = Convert.ToDateTime(
                                    reader["NgayDangKy"]),
                                Diem = reader["Diem"] == DBNull.Value
                                    ? null
                                    : Convert.ToDecimal(reader["Diem"])
                            };

                            danhSach.Add(dk);
                        }
                    }
                }
            }

            return danhSach;
        }

        // 3. Thêm đăng ký
        public void Insert(DangKy dk)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    INSERT INTO DangKy
                    (
                        MaSV, MaHP, HocKy,
                        NamHoc, NgayDangKy, Diem
                    )
                    VALUES
                    (
                        @MaSV, @MaHP, @HocKy,
                        @NamHoc, @NgayDangKy, @Diem
                    )";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddParameters(cmd, dk);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. Cập nhật đăng ký
        public void Update(DangKy dk)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    UPDATE DangKy
                    SET NgayDangKy = @NgayDangKy,
                        Diem = @Diem
                    WHERE MaSV = @MaSV
                      AND MaHP = @MaHP
                      AND HocKy = @HocKy
                      AND NamHoc = @NamHoc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddParameters(cmd, dk);

                    conn.Open();

                    int ketQua = cmd.ExecuteNonQuery();

                    if (ketQua == 0)
                    {
                        throw new Exception(
                            "Không tìm thấy đăng ký cần cập nhật!");
                    }
                }
            }
        }

        // 5. Xóa đăng ký
        public void Delete(DangKy dk)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    DELETE FROM DangKy
                    WHERE MaSV = @MaSV
                      AND MaHP = @MaHP
                      AND HocKy = @HocKy
                      AND NamHoc = @NamHoc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                        .Value = dk.MaSV;

                    cmd.Parameters.Add("@MaHP", SqlDbType.VarChar, 15)
                        .Value = dk.MaHP;

                    cmd.Parameters.Add("@HocKy", SqlDbType.Int)
                        .Value = dk.HocKy;

                    cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar, 20)
                        .Value = dk.NamHoc;

                    conn.Open();

                    int ketQua = cmd.ExecuteNonQuery();

                    if (ketQua == 0)
                    {
                        throw new Exception(
                            "Không tìm thấy đăng ký cần xóa!");
                    }
                }
            }
        }

        // 6. Hàm tạo tham số
        private void AddParameters(SqlCommand cmd, DangKy dk)
        {
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                .Value = dk.MaSV;

            cmd.Parameters.Add("@MaHP", SqlDbType.VarChar, 15)
                .Value = dk.MaHP;

            cmd.Parameters.Add("@HocKy", SqlDbType.Int)
                .Value = dk.HocKy;

            cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar, 20)
                .Value = dk.NamHoc;

            cmd.Parameters.Add("@NgayDangKy", SqlDbType.Date)
                .Value = dk.NgayDangKy.Date;

            SqlParameter pDiem = cmd.Parameters.Add(
                "@Diem", SqlDbType.Decimal);

            pDiem.Precision = 4;
            pDiem.Scale = 2;
            pDiem.Value = dk.Diem.HasValue
                ? dk.Diem.Value
                : DBNull.Value;
        }
    }
}
