namespace QuanLySinhVien.GUI.Forms
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            btnLamMoi = new Button();
            imageList1 = new ImageList(components);
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            pnlThongTin = new Panel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            cboKhoa = new ComboBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            cboGioiTinh = new ComboBox();
            label4 = new Label();
            nudDiemTB = new NumericUpDown();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label6 = new Label();
            txtSoDienThoai = new TextBox();
            label9 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtMaSV = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblThongTin = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnXuatExcel = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlThongTin.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiemTB).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.ImageIndex = 1;
            btnLamMoi.ImageList = imageList1;
            btnLamMoi.Location = new Point(958, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 29);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icon-icons.ico");
            imageList1.Images.SetKeyName(1, "refresh_icon-icons.com_50052.ico");
            imageList1.Images.SetKeyName(2, "searchmagnifierinterfacesymbol1_79893.ico");
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.ImageIndex = 2;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(833, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(119, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(176, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã sinh viên hoặc họ tên...";
            txtTimKiem.Size = new Size(651, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Anchor = AnchorStyles.Left;
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(3, 7);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(149, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm Kiếm Sinh Viên";
            lblTimKiem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(panel2);
            pnlThongTin.Controls.Add(tableLayoutPanel1);
            pnlThongTin.Dock = DockStyle.Top;
            pnlThongTin.ForeColor = Color.Black;
            pnlThongTin.Location = new Point(0, 80);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1082, 296);
            pnlThongTin.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 269);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.62847F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.7911263F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5693159F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.01109F));
            tableLayoutPanel3.Controls.Add(cboKhoa, 1, 4);
            tableLayoutPanel3.Controls.Add(label3, 0, 4);
            tableLayoutPanel3.Controls.Add(txtDiaChi, 3, 3);
            tableLayoutPanel3.Controls.Add(label5, 2, 3);
            tableLayoutPanel3.Controls.Add(cboGioiTinh, 1, 3);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(nudDiemTB, 3, 2);
            tableLayoutPanel3.Controls.Add(label7, 2, 2);
            tableLayoutPanel3.Controls.Add(dtpNgaySinh, 1, 2);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(txtSoDienThoai, 3, 1);
            tableLayoutPanel3.Controls.Add(label9, 2, 1);
            tableLayoutPanel3.Controls.Add(txtHoTen, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(txtEmail, 3, 0);
            tableLayoutPanel3.Controls.Add(label8, 2, 0);
            tableLayoutPanel3.Controls.Add(txtMaSV, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 37);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 44.23077F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 55.76923F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.Size = new Size(1082, 223);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // cboKhoa
            // 
            cboKhoa.Dock = DockStyle.Fill;
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(118, 180);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(457, 28);
            cboKhoa.TabIndex = 29;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 190);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 28;
            label3.Text = "Khoa:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Location = new Point(717, 140);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(362, 27);
            txtDiaChi.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(581, 147);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 26;
            label5.Text = "Địa Chỉ:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ ", "Khác" });
            cboGioiTinh.Location = new Point(118, 140);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(457, 28);
            cboGioiTinh.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(3, 147);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 24;
            label4.Text = "Giới Tính:";
            // 
            // nudDiemTB
            // 
            nudDiemTB.DecimalPlaces = 2;
            nudDiemTB.Dock = DockStyle.Fill;
            nudDiemTB.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            nudDiemTB.Location = new Point(717, 100);
            nudDiemTB.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiemTB.Name = "nudDiemTB";
            nudDiemTB.Size = new Size(362, 27);
            nudDiemTB.TabIndex = 23;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(581, 107);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 22;
            label7.Text = "Điểm Trung Bình:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(118, 100);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(457, 27);
            dtpNgaySinh.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(3, 107);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 20;
            label6.Text = "Ngày Sinh:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Dock = DockStyle.Fill;
            txtSoDienThoai.Location = new Point(717, 46);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(362, 27);
            txtSoDienThoai.TabIndex = 19;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(581, 60);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 18;
            label9.Text = "Số Điện Thoại:";
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(118, 46);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(457, 27);
            txtHoTen.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 16;
            label2.Text = "Họ Và Tên:";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(717, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 27);
            txtEmail.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(581, 11);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 13;
            label8.Text = "Emai:";
            // 
            // txtMaSV
            // 
            txtMaSV.Dock = DockStyle.Fill;
            txtMaSV.Location = new Point(118, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(457, 27);
            txtMaSV.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã Sinh Viên:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblThongTin, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1082, 37);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblThongTin
            // 
            lblThongTin.Anchor = AnchorStyles.Left;
            lblThongTin.AutoSize = true;
            lblThongTin.BackColor = Color.Transparent;
            lblThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblThongTin.ForeColor = Color.DimGray;
            lblThongTin.Location = new Point(3, 7);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(196, 23);
            lblThongTin.TabIndex = 1;
            lblThongTin.Text = "THÔNG TIN SINH VIÊN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8683472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.13165F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel1.Controls.Add(lblTimKiem, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1082, 35);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 51);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(btnXuatExcel, 4, 0);
            tableLayoutPanel4.Controls.Add(btnHuy, 3, 0);
            tableLayoutPanel4.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel4.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel4.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1082, 50);
            tableLayoutPanel4.TabIndex = 5;
            tableLayoutPanel4.TabStop = true;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 192);
            btnXuatExcel.Dock = DockStyle.Fill;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(867, 3);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(212, 44);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "XUẤT EXCEL";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(0, 0, 192);
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(651, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(210, 44);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 0, 192);
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(435, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(210, 44);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 0, 192);
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(219, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(210, 44);
            btnSua.TabIndex = 2;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 0, 192);
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(210, 44);
            btnThem.TabIndex = 1;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 53, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 53, 87);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSinhVien.Dock = DockStyle.Top;
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.Location = new Point(0, 427);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1082, 448);
            dgvSinhVien.TabIndex = 4;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1082, 799);
            Controls.Add(dgvSinhVien);
            Controls.Add(panel1);
            Controls.Add(pnlThongTin);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(1100, 700);
            Name = "frmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tQUẢN LÝ SINH VIÊN";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlThongTin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiemTB).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Panel pnlThongTin;
        private Panel panel1;
        private DataGridView dgvSinhVien;
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lblThongTin;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cboKhoa;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label5;
        private ComboBox cboGioiTinh;
        private Label label4;
        private NumericUpDown nudDiemTB;
        private Label label7;
        private DateTimePicker dtpNgaySinh;
        private Label label6;
        private TextBox txtSoDienThoai;
        private Label label9;
        private TextBox txtHoTen;
        private Label label2;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtMaSV;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnXuatExcel;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}