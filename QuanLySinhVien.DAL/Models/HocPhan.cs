using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.DAL.Models
{
    public class HocPhan
    {
        public string MaHP { get; set; } = string.Empty;

        public string TenHP { get; set; } = string.Empty;

        public int SoTinChi { get; set; }

        public string? MoTa { get; set; }
    }
}
