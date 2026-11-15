using System.Data.SqlClient;
using System.Configuration;

namespace QuanLySinhVien.DAL.Database
{
    public static class DbConnectionFactory
    {
        public static SqlConnection Create()
        {
            string? connectionString =
                ConfigurationManager
                    .ConnectionStrings["QuanLySinhVien"]?
                    .ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Không tìm thấy chuỗi kết nối QuanLySinhVien!"
                );
            }

            return new SqlConnection(connectionString);
        }
    }
}