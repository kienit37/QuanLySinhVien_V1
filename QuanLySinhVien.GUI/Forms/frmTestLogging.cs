
using System;
using System.Windows.Forms;
using QuanLySinhVien.Common.Logging;

namespace QuanLySinhVien.GUI.Forms
{
    public partial class frmTestLogging : Form
    {
        public frmTestLogging()
        {
            InitializeComponent();
        }

        private void btnGhiInfo_Click(
            object sender, EventArgs e)
        {
            AppLogger.Info(
                "TEST_INFO",
                "admin",
                "Kiểm tra ghi log INFO");

            MessageBox.Show(
                "Đã gửi yêu cầu ghi INFO.\n" +
                AppLogger.LogDirectory);
        }

        private void btnGhiWarning_Click(
            object sender, EventArgs e)
        {
            AppLogger.Warning(
                "TEST_WARNING",
                "admin",
                "Kiểm tra ghi cảnh báo",
                1500);

            MessageBox.Show(
                "Đã gửi yêu cầu ghi WARNING.");
        }

        private void btnGhiError_Click(
            object sender, EventArgs e)
        {
            try
            {
                throw new InvalidOperationException(
                    "Lỗi giả lập để kiểm tra Logging");
            }
            catch (Exception ex)
            {
                string? errorId = AppLogger.Error(
                    "TEST_ERROR",
                    "admin",
                    "Kiểm tra ghi lỗi hệ thống",
                    ex);

                MessageBox.Show(
                    "Mã lỗi: " + errorId);
            }
        }
    }
}
