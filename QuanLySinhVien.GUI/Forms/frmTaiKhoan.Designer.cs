namespace QuanLySinhVien.GUI.Forms
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            panel1 = new Panel();
            label1 = new Label();
            pnlThongTin = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlTimKiem = new Panel();
            imageList1 = new ImageList(components);
            pnlChucNang = new Panel();
            dgvTaiKhoan = new DataGridView();
            label6 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            chkTrangThai = new CheckBox();
            chkHienMatKhau = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnKhoa = new Button();
            btnDatLaiMatKhau = new Button();
            btnHuy = new Button();
            panel1.SuspendLayout();
            pnlThongTin.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 47);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // pnlThongTin
            // 
            pnlThongTin.Controls.Add(tableLayoutPanel1);
            pnlThongTin.Dock = DockStyle.Top;
            pnlThongTin.Location = new Point(0, 47);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1015, 79);
            pnlThongTin.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.9400549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.0599442F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1015, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(tableLayoutPanel2);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 126);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1015, 265);
            pnlTimKiem.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add_insert_plus_1588.ico");
            imageList1.Images.SetKeyName(1, "iconfinder-lock-open-4341301_120523.ico");
            imageList1.Images.SetKeyName(2, "icon-icons.ico");
            imageList1.Images.SetKeyName(3, "security-protection-protect-key-password-login_108554.ico");
            imageList1.Images.SetKeyName(4, "xbutton_83749.ico");
            imageList1.Images.SetKeyName(5, "searchmagnifierinterfacesymbol1_79893.ico");
            imageList1.Images.SetKeyName(6, "refresh_icon-icons.com_50052.ico");
            // 
            // pnlChucNang
            // 
            pnlChucNang.Controls.Add(tableLayoutPanel4);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 391);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(1015, 67);
            pnlChucNang.TabIndex = 3;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 458);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(1015, 210);
            dgvTaiKhoan.TabIndex = 4;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 2;
            label6.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(124, 3);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(632, 38);
            txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.ImageIndex = 5;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(762, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 38);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.ImageIndex = 6;
            btnLamMoi.ImageList = imageList1;
            btnLamMoi.Location = new Point(891, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 38);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.7931061F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2068958F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1015, 234);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5244751F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.4755249F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            tableLayoutPanel3.Controls.Add(chkHienMatKhau, 0, 4);
            tableLayoutPanel3.Controls.Add(chkTrangThai, 1, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 3);
            tableLayoutPanel3.Controls.Add(txtMatKhau, 1, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtHoTen, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(txtTenDangNhap, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 44.0366974F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 55.9633026F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel3.Size = new Size(743, 228);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(752, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Dock = DockStyle.Fill;
            txtTenDangNhap.Location = new Point(192, 3);
            txtTenDangNhap.MaxLength = 50;
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(548, 34);
            txtTenDangNhap.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(3, 40);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(192, 43);
            txtHoTen.MaxLength = 100;
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(548, 45);
            txtHoTen.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 8;
            label3.Text = "Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Dock = DockStyle.Fill;
            txtMatKhau.Location = new Point(192, 94);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(548, 41);
            txtMatKhau.TabIndex = 9;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(3, 138);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 10;
            label5.Text = "Trạng Thái:";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Location = new Point(192, 141);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(145, 24);
            chkTrangThai.TabIndex = 11;
            chkTrangThai.Text = "Đang Hoạt Động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            chkHienMatKhau.Location = new Point(3, 187);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(134, 24);
            chkHienMatKhau.TabIndex = 12;
            chkHienMatKhau.Text = "Hiện Mật Khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(btnHuy, 4, 0);
            tableLayoutPanel4.Controls.Add(btnDatLaiMatKhau, 3, 0);
            tableLayoutPanel4.Controls.Add(btnKhoa, 2, 0);
            tableLayoutPanel4.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel4.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1015, 48);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 0, 192);
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnThem.ForeColor = Color.White;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.ImageIndex = 0;
            btnThem.ImageList = imageList1;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(197, 42);
            btnThem.TabIndex = 1;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 0, 192);
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSua.ForeColor = Color.White;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.ImageIndex = 2;
            btnSua.ImageList = imageList1;
            btnSua.Location = new Point(206, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(197, 42);
            btnSua.TabIndex = 2;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnKhoa
            // 
            btnKhoa.BackColor = Color.FromArgb(0, 0, 192);
            btnKhoa.Dock = DockStyle.Fill;
            btnKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnKhoa.ForeColor = Color.White;
            btnKhoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoa.ImageIndex = 1;
            btnKhoa.ImageList = imageList1;
            btnKhoa.Location = new Point(409, 3);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(197, 42);
            btnKhoa.TabIndex = 3;
            btnKhoa.Text = "KHÓA / MỞ KHÓA";
            btnKhoa.UseVisualStyleBackColor = false;
            // 
            // btnDatLaiMatKhau
            // 
            btnDatLaiMatKhau.BackColor = Color.FromArgb(0, 0, 192);
            btnDatLaiMatKhau.Dock = DockStyle.Fill;
            btnDatLaiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDatLaiMatKhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDatLaiMatKhau.ForeColor = Color.White;
            btnDatLaiMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatLaiMatKhau.ImageIndex = 3;
            btnDatLaiMatKhau.ImageList = imageList1;
            btnDatLaiMatKhau.Location = new Point(612, 3);
            btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            btnDatLaiMatKhau.Size = new Size(197, 42);
            btnDatLaiMatKhau.TabIndex = 4;
            btnDatLaiMatKhau.Text = "ĐẶT LẠI MẬT KHẨU";
            btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(0, 0, 192);
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnHuy.ForeColor = Color.White;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.ImageIndex = 4;
            btnHuy.ImageList = imageList1;
            btnHuy.Location = new Point(815, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(197, 42);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 668);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(pnlChucNang);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlThongTin);
            Controls.Add(panel1);
            Name = "frmTaiKhoan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmTaiKhoan";
            Load += frmTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel pnlThongTin;
        private Panel pnlTimKiem;
        private Panel pnlChucNang;
        private DataGridView dgvTaiKhoan;
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtTenDangNhap;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox chkHienMatKhau;
        private CheckBox chkTrangThai;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnHuy;
        private Button btnDatLaiMatKhau;
        private Button btnKhoa;
        private Button btnSua;
        private Button btnThem;
    }
}