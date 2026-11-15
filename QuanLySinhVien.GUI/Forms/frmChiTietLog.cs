using QuanLySinhVien.Common.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmChiTietLog : Form
    {
        public frmChiTietLog(LogEntry log)
        {
            InitializeComponent();

            lblThoiGian.Text =
                "Thời gian: " +
                log.Timestamp.ToString("dd/MM/yyyy HH:mm:ss");

            lblMucDo.Text =
                "Mức độ: " + log.Level;

            lblTaiKhoan.Text =
                "Tài khoản: " + log.Username;

            lblHanhDong.Text =
                "Hành động: " + log.Action;

            txtNoiDung.Text = log.Message;

            // Hiện mã lỗi; bổ sung chi tiết ngoại lệ
            // khi LogEntry có trường tương ứng.
            txtChiTietLoi.Text = log.ErrorId ?? "";

            btnDong.Click += (s, e) => Close();
        }
        private void frmChiTietLog_Load(object sender, EventArgs e)
        {

        }
    }
}
