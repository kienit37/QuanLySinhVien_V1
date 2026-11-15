
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QuanLySinhVien.Common.Logging;

namespace QuanLySinhVien.DAL.Logging
{
    public class NhatKyHeThongDAL : ILogStore
    {
        public void Save(LogEntry log)
        {
            string? connectionString =
                ConfigurationManager
                    .ConnectionStrings["QuanLySinhVien"]
                    ?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Chưa cấu hình kết nối QuanLySinhVien.");
            }

            const string sql = @"
                INSERT INTO dbo.NhatKyHeThong
                (
                    ThoiGian, MucDo, TenDangNhap,
                    HanhDong, NoiDung, ThoiGianXuLyMs,
                    MaLoi, TenMay
                )
                VALUES
                (
                    @ThoiGian, @MucDo, @TenDangNhap,
                    @HanhDong, @NoiDung, @ThoiGianXuLyMs,
                    @MaLoi, @TenMay
                );";

            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd =
                new SqlCommand(sql, conn);


            cmd.Parameters.Add(
                "@ThoiGian",
                SqlDbType.DateTime2
            ).Value = log.Timestamp.LocalDateTime;


            cmd.Parameters.Add("@MucDo",
                SqlDbType.NVarChar, 20).Value =
                log.Level ?? "INFORMATION";

            cmd.Parameters.Add("@TenDangNhap",
                SqlDbType.NVarChar, 100).Value =
                (object?)log.Username ?? DBNull.Value;

            cmd.Parameters.Add("@HanhDong",
                SqlDbType.NVarChar, 150).Value =
                (object?)log.Action ?? DBNull.Value;

            cmd.Parameters.Add("@NoiDung",
                SqlDbType.NVarChar, -1).Value =
                (object?)log.Message ?? DBNull.Value;

            cmd.Parameters.Add("@ThoiGianXuLyMs",
                SqlDbType.Float).Value =
                (object?)log.DurationMs ?? DBNull.Value;

            cmd.Parameters.Add("@MaLoi",
                SqlDbType.NVarChar, 200).Value =
                (object?)log.ErrorId ?? DBNull.Value;

            cmd.Parameters.Add("@TenMay",
                SqlDbType.NVarChar, 128).Value =
                Environment.MachineName;

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
