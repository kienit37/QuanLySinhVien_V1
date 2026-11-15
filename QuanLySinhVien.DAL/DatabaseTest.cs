using System;
using QuanLySinhVien.DAL.Database;

namespace QuanLySinhVien.DAL
{
    public class DatabaseTest
    {
        public string KiemTraKetNoi()
        {
            try
            {
                using (var conn = DbConnectionFactory.Create())
                {
                    conn.Open();

                    return "Kết nối SQL Server thành công!";
                }
            }
            catch (Exception ex)
            {
                return "Kết nối thất bại: " + ex.Message;
            }
        }
    }
}