using QuanLySinhVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class frmKiemTraKetNoi : Form
    {
        public frmKiemTraKetNoi()
        {
            InitializeComponent();
        }

        private void frmKiemTraKetNoi_Load(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            DatabaseTest db = new DatabaseTest();

            string ketQua = db.KiemTraKetNoi();

            lblKetQua.Text = ketQua;

            MessageBox.Show(
                ketQua,
                "Kiểm tra cơ sở dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
