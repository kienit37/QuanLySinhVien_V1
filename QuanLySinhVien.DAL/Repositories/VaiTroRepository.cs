
using System.Collections.Generic;
using System.Data.SqlClient;
using QuanLySinhVien.DAL.Database;
using QuanLySinhVien.DAL.Models;

namespace QuanLySinhVien.DAL.Repositories
{
    public class VaiTroRepository
    {
        public List<VaiTro> GetAll()
        {
            List<VaiTro> danhSach = new List<VaiTro>();

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                string sql = @"
                    SELECT MaVaiTro, TenVaiTro, MoTa
                    FROM VaiTro
                    ORDER BY MaVaiTro";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VaiTro vt = new VaiTro();

                            vt.MaVaiTro = reader["MaVaiTro"].ToString()!;
                            vt.TenVaiTro = reader["TenVaiTro"].ToString()!;
                            vt.MoTa = reader["MoTa"] == DBNull.Value
                                ? null
                                : reader["MoTa"].ToString();

                            danhSach.Add(vt);
                        }
                    }
                }
            }

            return danhSach;
        }
    }
}
