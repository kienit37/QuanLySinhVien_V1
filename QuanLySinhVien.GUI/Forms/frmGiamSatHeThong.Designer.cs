namespace QuanLySinhVien.GUI.Forms
{
    partial class frmGiamSatHeThong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            lblTieuDe = new Label();
            tlpThongKe = new TableLayoutPanel();
            pnlTongSuKien = new Panel();
            lblTongSuKien = new Label();
            label1 = new Label();
            pnlTongLoi = new Panel();
            lblTongLoi = new Label();
            label3 = new Label();
            pnlThaoTacCham = new Panel();
            lblCanhBaoCham = new Label();
            label5 = new Label();
            pnlThoiGianTB = new Panel();
            lblThoiGianTB = new Label();
            label7 = new Label();
            pnlBoLoc = new Panel();
            label10 = new Label();
            label9 = new Label();
            cboHanhDong = new ComboBox();
            cboTaiKhoan = new ComboBox();
            btnXuatCSV = new Button();
            btnXemChiTiet = new Button();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnLamMoi = new Button();
            btnLoc = new Button();
            txtTimKiemLog = new TextBox();
            cboMucDo = new ComboBox();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            dgvNhatKy = new DataGridView();
            tlpMain.SuspendLayout();
            tlpThongKe.SuspendLayout();
            pnlTongSuKien.SuspendLayout();
            pnlTongLoi.SuspendLayout();
            pnlThaoTacCham.SuspendLayout();
            pnlThoiGianTB.SuspendLayout();
            pnlBoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(lblTieuDe, 0, 0);
            tlpMain.Controls.Add(tlpThongKe, 0, 1);
            tlpMain.Controls.Add(pnlBoLoc, 0, 2);
            tlpMain.Controls.Add(dgvNhatKy, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.ForeColor = Color.MidnightBlue;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(15);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1082, 673);
            tlpMain.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(18, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(291, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Giám Sát Hệ Thống";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpThongKe
            // 
            tlpThongKe.ColumnCount = 4;
            tlpThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongKe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongKe.Controls.Add(pnlTongSuKien, 0, 0);
            tlpThongKe.Controls.Add(pnlTongLoi, 1, 0);
            tlpThongKe.Controls.Add(pnlThaoTacCham, 2, 0);
            tlpThongKe.Controls.Add(pnlThoiGianTB, 3, 0);
            tlpThongKe.Dock = DockStyle.Fill;
            tlpThongKe.Location = new Point(18, 78);
            tlpThongKe.Name = "tlpThongKe";
            tlpThongKe.RowCount = 1;
            tlpThongKe.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpThongKe.Size = new Size(1046, 114);
            tlpThongKe.TabIndex = 1;
            // 
            // pnlTongSuKien
            // 
            pnlTongSuKien.BackColor = Color.White;
            pnlTongSuKien.Controls.Add(lblTongSuKien);
            pnlTongSuKien.Controls.Add(label1);
            pnlTongSuKien.Dock = DockStyle.Fill;
            pnlTongSuKien.Location = new Point(5, 5);
            pnlTongSuKien.Margin = new Padding(5);
            pnlTongSuKien.Name = "pnlTongSuKien";
            pnlTongSuKien.Size = new Size(251, 104);
            pnlTongSuKien.TabIndex = 0;
            // 
            // lblTongSuKien
            // 
            lblTongSuKien.AutoSize = true;
            lblTongSuKien.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblTongSuKien.Location = new Point(105, 39);
            lblTongSuKien.Name = "lblTongSuKien";
            lblTongSuKien.Size = new Size(40, 46);
            lblTongSuKien.TabIndex = 1;
            lblTongSuKien.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "TỔNG SỰ KIỆN";
            // 
            // pnlTongLoi
            // 
            pnlTongLoi.BackColor = Color.White;
            pnlTongLoi.Controls.Add(lblTongLoi);
            pnlTongLoi.Controls.Add(label3);
            pnlTongLoi.Dock = DockStyle.Fill;
            pnlTongLoi.Location = new Point(266, 5);
            pnlTongLoi.Margin = new Padding(5);
            pnlTongLoi.Name = "pnlTongLoi";
            pnlTongLoi.Size = new Size(251, 104);
            pnlTongLoi.TabIndex = 1;
            // 
            // lblTongLoi
            // 
            lblTongLoi.AutoSize = true;
            lblTongLoi.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblTongLoi.Location = new Point(106, 39);
            lblTongLoi.Name = "lblTongLoi";
            lblTongLoi.Size = new Size(40, 46);
            lblTongLoi.TabIndex = 1;
            lblTongLoi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 13);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "TỔNG LỖI";
            // 
            // pnlThaoTacCham
            // 
            pnlThaoTacCham.BackColor = Color.White;
            pnlThaoTacCham.Controls.Add(lblCanhBaoCham);
            pnlThaoTacCham.Controls.Add(label5);
            pnlThaoTacCham.Dock = DockStyle.Fill;
            pnlThaoTacCham.Location = new Point(527, 5);
            pnlThaoTacCham.Margin = new Padding(5);
            pnlThaoTacCham.Name = "pnlThaoTacCham";
            pnlThaoTacCham.Size = new Size(251, 104);
            pnlThaoTacCham.TabIndex = 2;
            // 
            // lblCanhBaoCham
            // 
            lblCanhBaoCham.AutoSize = true;
            lblCanhBaoCham.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblCanhBaoCham.Location = new Point(94, 39);
            lblCanhBaoCham.Name = "lblCanhBaoCham";
            lblCanhBaoCham.Size = new Size(40, 46);
            lblCanhBaoCham.TabIndex = 1;
            lblCanhBaoCham.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 12);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 0;
            label5.Text = "THAO TÁC CHẬM";
            // 
            // pnlThoiGianTB
            // 
            pnlThoiGianTB.BackColor = Color.White;
            pnlThoiGianTB.Controls.Add(lblThoiGianTB);
            pnlThoiGianTB.Controls.Add(label7);
            pnlThoiGianTB.Dock = DockStyle.Fill;
            pnlThoiGianTB.Location = new Point(788, 5);
            pnlThoiGianTB.Margin = new Padding(5);
            pnlThoiGianTB.Name = "pnlThoiGianTB";
            pnlThoiGianTB.Size = new Size(253, 104);
            pnlThoiGianTB.TabIndex = 3;
            // 
            // lblThoiGianTB
            // 
            lblThoiGianTB.AutoSize = true;
            lblThoiGianTB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            lblThoiGianTB.Location = new Point(53, 39);
            lblThoiGianTB.Name = "lblThoiGianTB";
            lblThoiGianTB.Size = new Size(66, 46);
            lblThoiGianTB.TabIndex = 1;
            lblThoiGianTB.Text = "ms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 13);
            label7.Name = "label7";
            label7.Size = new Size(173, 20);
            label7.TabIndex = 0;
            label7.Text = "THỜI GIAN TRUNG BÌNH";
            // 
            // pnlBoLoc
            // 
            pnlBoLoc.Controls.Add(label10);
            pnlBoLoc.Controls.Add(label9);
            pnlBoLoc.Controls.Add(cboHanhDong);
            pnlBoLoc.Controls.Add(cboTaiKhoan);
            pnlBoLoc.Controls.Add(btnXuatCSV);
            pnlBoLoc.Controls.Add(btnXemChiTiet);
            pnlBoLoc.Controls.Add(label8);
            pnlBoLoc.Controls.Add(label6);
            pnlBoLoc.Controls.Add(label4);
            pnlBoLoc.Controls.Add(label2);
            pnlBoLoc.Controls.Add(btnLamMoi);
            pnlBoLoc.Controls.Add(btnLoc);
            pnlBoLoc.Controls.Add(txtTimKiemLog);
            pnlBoLoc.Controls.Add(cboMucDo);
            pnlBoLoc.Controls.Add(dtpDenNgay);
            pnlBoLoc.Controls.Add(dtpTuNgay);
            pnlBoLoc.Dock = DockStyle.Fill;
            pnlBoLoc.Location = new Point(18, 198);
            pnlBoLoc.Name = "pnlBoLoc";
            pnlBoLoc.Size = new Size(1046, 139);
            pnlBoLoc.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(632, 61);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 15;
            label10.Text = "Hành Động:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(282, 102);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 14;
            label9.Text = "Tài Khoản:";
            // 
            // cboHanhDong
            // 
            cboHanhDong.FormattingEnabled = true;
            cboHanhDong.Location = new Point(726, 56);
            cboHanhDong.Name = "cboHanhDong";
            cboHanhDong.Size = new Size(146, 28);
            cboHanhDong.TabIndex = 13;
            // 
            // cboTaiKhoan
            // 
            cboTaiKhoan.FormattingEnabled = true;
            cboTaiKhoan.Location = new Point(364, 94);
            cboTaiKhoan.Name = "cboTaiKhoan";
            cboTaiKhoan.Size = new Size(241, 28);
            cboTaiKhoan.TabIndex = 12;
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.Location = new Point(920, 97);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(109, 29);
            btnXuatCSV.TabIndex = 11;
            btnXuatCSV.Text = "Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            btnXuatCSV.Click += btnXuatCSV_Click;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Location = new Point(920, 63);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(109, 29);
            btnXemChiTiet.TabIndex = 10;
            btnXemChiTiet.Text = "Xem Chi Tiết";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 18);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 9;
            label8.Text = "Tìm Kiếm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 61);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 8;
            label6.Text = "Mức Độ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 102);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Đến Ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 6;
            label2.Text = "Từ Ngày:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(920, 33);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(109, 29);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(920, 9);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(109, 29);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc Dữ Liệu";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // txtTimKiemLog
            // 
            txtTimKiemLog.Location = new Point(102, 10);
            txtTimKiemLog.Name = "txtTimKiemLog";
            txtTimKiemLog.PlaceholderText = "Tìm tài khoản, hành động...";
            txtTimKiemLog.Size = new Size(770, 27);
            txtTimKiemLog.TabIndex = 3;
            // 
            // cboMucDo
            // 
            cboMucDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDo.FormattingEnabled = true;
            cboMucDo.Location = new Point(364, 53);
            cboMucDo.Name = "cboMucDo";
            cboMucDo.Size = new Size(241, 28);
            cboMucDo.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(102, 97);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(154, 27);
            dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(102, 54);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(154, 27);
            dtpTuNgay.TabIndex = 0;
            // 
            // dgvNhatKy
            // 
            dgvNhatKy.AllowUserToAddRows = false;
            dgvNhatKy.AllowUserToDeleteRows = false;
            dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhatKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhatKy.Dock = DockStyle.Fill;
            dgvNhatKy.Location = new Point(18, 343);
            dgvNhatKy.MultiSelect = false;
            dgvNhatKy.Name = "dgvNhatKy";
            dgvNhatKy.ReadOnly = true;
            dgvNhatKy.RowHeadersVisible = false;
            dgvNhatKy.RowHeadersWidth = 51;
            dgvNhatKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhatKy.Size = new Size(1046, 312);
            dgvNhatKy.TabIndex = 3;
            // 
            // frmGiamSatHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1082, 673);
            Controls.Add(tlpMain);
            Name = "frmGiamSatHeThong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Giám sát hệ thống";
            Load += frmGiamSatHeThong_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpThongKe.ResumeLayout(false);
            pnlTongSuKien.ResumeLayout(false);
            pnlTongSuKien.PerformLayout();
            pnlTongLoi.ResumeLayout(false);
            pnlTongLoi.PerformLayout();
            pnlThaoTacCham.ResumeLayout(false);
            pnlThaoTacCham.PerformLayout();
            pnlThoiGianTB.ResumeLayout(false);
            pnlThoiGianTB.PerformLayout();
            pnlBoLoc.ResumeLayout(false);
            pnlBoLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label lblTieuDe;
        private TableLayoutPanel tlpThongKe;
        private Panel pnlTongSuKien;
        private Label lblTongSuKien;
        private Label label1;
        private Panel pnlTongLoi;
        private Label lblTongLoi;
        private Label label3;
        private Panel pnlThaoTacCham;
        private Label lblCanhBaoCham;
        private Label label5;
        private Panel pnlThoiGianTB;
        private Label lblThoiGianTB;
        private Label label7;
        private Panel pnlBoLoc;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button btnLamMoi;
        private Button btnLoc;
        private TextBox txtTimKiemLog;
        private ComboBox cboMucDo;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private DataGridView dgvNhatKy;
        private ComboBox cboHanhDong;
        private ComboBox cboTaiKhoan;
        private Button btnXuatCSV;
        private Button btnXemChiTiet;
        private Label label10;
        private Label label9;
    }
}