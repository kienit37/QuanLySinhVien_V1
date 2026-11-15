namespace QuanLySinhVien.GUI.Forms
{
    partial class frmDangKyHocPhan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyHocPhan));
            panel1 = new Panel();
            label1 = new Label();
            pnlThongTin = new Panel();
            pnlChucNang = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnHuy = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            chkCoDiem = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            nudDiem = new NumericUpDown();
            label7 = new Label();
            nudHocKy = new NumericUpDown();
            label4 = new Label();
            dtpNgayDangKy = new DateTimePicker();
            label6 = new Label();
            cboHocPhan = new ComboBox();
            label3 = new Label();
            txtNamHoc = new TextBox();
            label5 = new Label();
            cboSinhVien = new ComboBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLamMoi = new Button();
            imageList1 = new ImageList(components);
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            dgvDangKy = new DataGridView();
            panel1.SuspendLayout();
            pnlThongTin.SuspendLayout();
            pnlChucNang.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHocKy).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDangKy).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(266, 24);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐĂNG KÝ HỌC PHẦN";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = SystemColors.ButtonFace;
            pnlThongTin.Controls.Add(pnlChucNang);
            pnlThongTin.Controls.Add(tableLayoutPanel2);
            pnlThongTin.Controls.Add(tableLayoutPanel1);
            pnlThongTin.Dock = DockStyle.Top;
            pnlThongTin.Location = new Point(0, 62);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(996, 319);
            pnlThongTin.TabIndex = 1;
            // 
            // pnlChucNang
            // 
            pnlChucNang.BackColor = SystemColors.ControlLightLight;
            pnlChucNang.Controls.Add(tableLayoutPanel4);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 244);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(996, 75);
            pnlChucNang.TabIndex = 3;
            pnlChucNang.Paint += pnlChucNang_Paint_1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnHuy, 3, 0);
            tableLayoutPanel4.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel4.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel4.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(996, 46);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkBlue;
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(750, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(243, 40);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkBlue;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(243, 40);
            btnThem.TabIndex = 1;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.DarkBlue;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(501, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(243, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkBlue;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(252, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(243, 40);
            btnSua.TabIndex = 2;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.26105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.7389555F));
            tableLayoutPanel2.Controls.Add(chkCoDiem, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 49);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(996, 195);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // chkCoDiem
            // 
            chkCoDiem.AutoSize = true;
            chkCoDiem.Dock = DockStyle.Fill;
            chkCoDiem.Location = new Point(902, 3);
            chkCoDiem.Name = "chkCoDiem";
            chkCoDiem.Size = new Size(91, 189);
            chkCoDiem.TabIndex = 12;
            chkCoDiem.Text = "Đã Có Điểm";
            chkCoDiem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5869951F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.413F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel3.Controls.Add(nudDiem, 3, 2);
            tableLayoutPanel3.Controls.Add(label7, 2, 2);
            tableLayoutPanel3.Controls.Add(nudHocKy, 1, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(dtpNgayDangKy, 3, 1);
            tableLayoutPanel3.Controls.Add(label6, 2, 1);
            tableLayoutPanel3.Controls.Add(cboHocPhan, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(txtNamHoc, 3, 0);
            tableLayoutPanel3.Controls.Add(label5, 2, 0);
            tableLayoutPanel3.Controls.Add(cboSinhVien, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4587173F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5412827F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.Size = new Size(893, 177);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 2;
            nudDiem.Location = new Point(647, 120);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(243, 27);
            nudDiem.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(572, 138);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 17;
            label7.Text = "Điểm:";
            // 
            // nudHocKy
            // 
            nudHocKy.Location = new Point(86, 120);
            nudHocKy.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudHocKy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHocKy.Name = "nudHocKy";
            nudHocKy.Size = new Size(480, 27);
            nudHocKy.TabIndex = 16;
            nudHocKy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(3, 138);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 15;
            label4.Text = "Học Kỳ:";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayDangKy.Location = new Point(647, 62);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(243, 27);
            dtpNgayDangKy.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(572, 71);
            label6.Name = "label6";
            label6.Size = new Size(60, 34);
            label6.TabIndex = 13;
            label6.Text = "Ngày Đăng Ký:";
            // 
            // cboHocPhan
            // 
            cboHocPhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHocPhan.FormattingEnabled = true;
            cboHocPhan.Location = new Point(86, 62);
            cboHocPhan.Name = "cboHocPhan";
            cboHocPhan.Size = new Size(480, 28);
            cboHocPhan.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 79);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 11;
            label3.Text = "Học Phần:";
            // 
            // txtNamHoc
            // 
            txtNamHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNamHoc.Location = new Point(647, 3);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(243, 27);
            txtNamHoc.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(572, 21);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 8;
            label5.Text = "Năm Học:";
            // 
            // cboSinhVien
            // 
            cboSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(86, 3);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(480, 28);
            cboSinhVien.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Sinh Viên:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightGray;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.698925F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.30108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(996, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.ImageIndex = 0;
            btnLamMoi.ImageList = imageList1;
            btnLamMoi.Location = new Point(878, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(115, 43);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "refresh_icon-icons.com_50052.ico");
            imageList1.Images.SetKeyName(1, "save-disk_icon-icons.com_71576.ico");
            imageList1.Images.SetKeyName(2, "searchmagnifierinterfacesymbol1_79893.ico");
            // 
            // btnTimKiem
            // 
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.ImageIndex = 2;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(747, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 43);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Location = new Point(157, 3);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "kiểm tra danh sách..";
            txtTimKiem.Size = new Size(584, 43);
            txtTimKiem.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 14);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 1;
            label8.Text = "Tìm Kiếm Học Phần:";
            // 
            // dgvDangKy
            // 
            dgvDangKy.AllowUserToAddRows = false;
            dgvDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDangKy.BackgroundColor = Color.White;
            dgvDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDangKy.Dock = DockStyle.Fill;
            dgvDangKy.Location = new Point(0, 381);
            dgvDangKy.MinimumSize = new Size(1000, 650);
            dgvDangKy.MultiSelect = false;
            dgvDangKy.Name = "dgvDangKy";
            dgvDangKy.ReadOnly = true;
            dgvDangKy.RowHeadersWidth = 51;
            dgvDangKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDangKy.Size = new Size(1000, 650);
            dgvDangKy.TabIndex = 4;
            // 
            // frmDangKyHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 703);
            Controls.Add(dgvDangKy);
            Controls.Add(pnlThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangKyHocPhan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QUẢN LÝ ĐĂNG KÝ HỌC PHẦN";
            panel1.ResumeLayout(false);
            pnlThongTin.ResumeLayout(false);
            pnlChucNang.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHocKy).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDangKy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel pnlThongTin;
        private CheckBox chkCoDiem;
        private DataGridView dgvDangKy;
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label8;
        private NumericUpDown nudDiem;
        private Label label7;
        private NumericUpDown nudHocKy;
        private Label label4;
        private DateTimePicker dtpNgayDangKy;
        private Label label6;
        private ComboBox cboHocPhan;
        private Label label3;
        private TextBox txtNamHoc;
        private Label label5;
        private ComboBox cboSinhVien;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel pnlChucNang;
    }
}