using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.DAL.Models
{
    public class Khoa
    {
        public string MaKhoa { get; set; } = string.Empty;

        public string TenKhoa { get; set; } = string.Empty;

        public string? MoTa { get; set; }
    }
}
