
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class TaiKhoanRepository
    {
        // 1. Lấy danh sách tài khoản
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> danhSach = new List<TaiKhoan>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT MaTaiKhoan, TenDangNhap, HoTen, TrangThai
                    FROM TaiKhoan
                    ORDER BY MaTaiKhoan DESC";

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

        // 2. Tìm kiếm tài khoản
        public List<TaiKhoan> Search(string tuKhoa)
        {
            List<TaiKhoan> danhSach = new List<TaiKhoan>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT MaTaiKhoan, TenDangNhap, HoTen, TrangThai
                    FROM TaiKhoan
                    WHERE TenDangNhap LIKE @TuKhoa
                       OR HoTen LIKE @TuKhoa
                    ORDER BY MaTaiKhoan DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 100)
                        .Value = "%" + tuKhoa + "%";

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSach.Add(new TaiKhoan
                            {
                                MaTaiKhoan = Convert.ToInt32(
                                    reader["MaTaiKhoan"]),

                                TenDangNhap = reader["TenDangNhap"].ToString()!,

                                HoTen = reader["HoTen"].ToString()!,

                                TrangThai = Convert.ToBoolean(
                                    reader["TrangThai"])
                            });
                        }
                    }
                }
            }

            return danhSach;
        }

        // 3. Thêm tài khoản
        public void Insert(TaiKhoan tk)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    INSERT INTO TaiKhoan
                    (
                        TenDangNhap,
                        MatKhauHash,
                        HoTen,
                        TrangThai
                    )
                    VALUES
                    (
                        @TenDangNhap,
                        @MatKhauHash,
                        @HoTen,
                        @TrangThai
                    )";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar, 50)
                        .Value = tk.TenDangNhap;

                    cmd.Parameters.Add("@MatKhauHash", SqlDbType.NVarChar, 500)
                        .Value = tk.MatKhauHash!;

                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                        .Value = tk.HoTen;

                    cmd.Parameters.Add("@TrangThai", SqlDbType.Bit)
                        .Value = tk.TrangThai;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. Cập nhật họ tên
        public void Update(TaiKhoan tk)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    UPDATE TaiKhoan
                    SET HoTen = @HoTen
                    WHERE MaTaiKhoan = @MaTaiKhoan";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                        .Value = tk.HoTen;

                    cmd.Parameters.Add("@MaTaiKhoan", SqlDbType.Int)
                        .Value = tk.MaTaiKhoan;

                    conn.Open();

                    if (cmd.ExecuteNonQuery() == 0)
                        throw new Exception("Không tìm thấy tài khoản!");
                }
            }
        }

        // 5. Khóa hoặc mở khóa tài khoản
        public void UpdateStatus(int maTaiKhoan, bool trangThai)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    UPDATE TaiKhoan
                    SET TrangThai = @TrangThai
                    WHERE MaTaiKhoan = @MaTaiKhoan";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TrangThai", SqlDbType.Bit)
                        .Value = trangThai;

                    cmd.Parameters.Add("@MaTaiKhoan", SqlDbType.Int)
                        .Value = maTaiKhoan;

                    conn.Open();

                    if (cmd.ExecuteNonQuery() == 0)
                        throw new Exception("Không tìm thấy tài khoản!");
                }
            }
        }

        // 6. Đặt lại mật khẩu
        public void ResetPassword(int maTaiKhoan, string matKhauHash)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    UPDATE TaiKhoan
                    SET MatKhauHash = @MatKhauHash
                    WHERE MaTaiKhoan = @MaTaiKhoan";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MatKhauHash", SqlDbType.NVarChar, 500)
                        .Value = matKhauHash;

                    cmd.Parameters.Add("@MaTaiKhoan", SqlDbType.Int)
                        .Value = maTaiKhoan;

                    conn.Open();

                    if (cmd.ExecuteNonQuery() == 0)
                        throw new Exception("Không tìm thấy tài khoản!");
                }
            }
        }
    }
}
