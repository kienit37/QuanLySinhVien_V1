namespace QuanLySinhVien.GUI.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            splitContainerLogin = new SplitContainer();
            pictureBox2 = new PictureBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            chkHienMatKhau = new CheckBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            lblHuongDan = new Label();
            lblTaiKhoan = new Label();
            lblChaoMung = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainerLogin).BeginInit();
            splitContainerLogin.Panel1.SuspendLayout();
            splitContainerLogin.Panel2.SuspendLayout();
            splitContainerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainerLogin
            // 
            splitContainerLogin.Dock = DockStyle.Fill;
            splitContainerLogin.FixedPanel = FixedPanel.Panel1;
            splitContainerLogin.IsSplitterFixed = true;
            splitContainerLogin.Location = new Point(0, 0);
            splitContainerLogin.Name = "splitContainerLogin";
            // 
            // splitContainerLogin.Panel1
            // 
            splitContainerLogin.Panel1.BackColor = Color.FromArgb(30, 53, 87);
            splitContainerLogin.Panel1.Controls.Add(pictureBox2);
            splitContainerLogin.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainerLogin.Panel1MinSize = 420;
            // 
            // splitContainerLogin.Panel2
            // 
            splitContainerLogin.Panel2.BackColor = Color.White;
            splitContainerLogin.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainerLogin.Panel2.BackgroundImage");
            splitContainerLogin.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainerLogin.Panel2.Controls.Add(btnThoat);
            splitContainerLogin.Panel2.Controls.Add(btnDangNhap);
            splitContainerLogin.Panel2.Controls.Add(chkHienMatKhau);
            splitContainerLogin.Panel2.Controls.Add(lblMatKhau);
            splitContainerLogin.Panel2.Controls.Add(txtMatKhau);
            splitContainerLogin.Panel2.Controls.Add(txtTaiKhoan);
            splitContainerLogin.Panel2.Controls.Add(lblHuongDan);
            splitContainerLogin.Panel2.Controls.Add(lblTaiKhoan);
            splitContainerLogin.Panel2.Controls.Add(lblChaoMung);
            splitContainerLogin.Panel2.Padding = new Padding(3);
            splitContainerLogin.Panel2.Paint += splitContainerLogin_Panel2_Paint;
            splitContainerLogin.Size = new Size(991, 492);
            splitContainerLogin.SplitterDistance = 420;
            splitContainerLogin.TabIndex = 0;
            splitContainerLogin.SplitterMoved += splitContainerLogin_SplitterMoved;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 492);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SteelBlue;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(399, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 47);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SteelBlue;
            btnDangNhap.BackgroundImageLayout = ImageLayout.Stretch;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(214, 343);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(179, 47);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click_1;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.BackColor = Color.Transparent;
            chkHienMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHienMatKhau.ForeColor = Color.White;
            chkHienMatKhau.Location = new Point(38, 280);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(126, 30);
            chkHienMatKhau.TabIndex = 7;
            chkHienMatKhau.Text = "Hiện thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = false;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.BackColor = Color.Transparent;
            lblMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMatKhau.ForeColor = Color.White;
            lblMatKhau.Location = new Point(38, 210);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(72, 20);
            lblMatKhau.TabIndex = 6;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(38, 233);
            txtMatKhau.MaxLength = 100;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(491, 31);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Anchor = AnchorStyles.Left;
            txtTaiKhoan.BackColor = Color.White;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(38, 156);
            txtTaiKhoan.MaxLength = 50;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(491, 31);
            txtTaiKhoan.TabIndex = 4;
            // 
            // lblHuongDan
            // 
            lblHuongDan.BackColor = Color.Transparent;
            lblHuongDan.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHuongDan.ForeColor = Color.White;
            lblHuongDan.Location = new Point(148, 77);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(271, 21);
            lblHuongDan.TabIndex = 2;
            lblHuongDan.Text = "Vui lòng đăng nhập để sử dụng hệ thống";
            lblHuongDan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.BackColor = Color.Transparent;
            lblTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTaiKhoan.ForeColor = Color.White;
            lblTaiKhoan.Location = new Point(38, 133);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(107, 20);
            lblTaiKhoan.TabIndex = 1;
            lblTaiKhoan.Text = "Tên đăng nhập:";
            lblTaiKhoan.Click += lblTaiKhoan_Click;
            // 
            // lblChaoMung
            // 
            lblChaoMung.BackColor = Color.Transparent;
            lblChaoMung.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblChaoMung.ForeColor = Color.White;
            lblChaoMung.Location = new Point(188, 32);
            lblChaoMung.Name = "lblChaoMung";
            lblChaoMung.Size = new Size(191, 45);
            lblChaoMung.TabIndex = 0;
            lblChaoMung.Text = "ĐĂNG NHẬP";
            lblChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(991, 492);
            Controls.Add(splitContainerLogin);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập Hệ Thống";
            Load += frmDangNhap_Load;
            splitContainerLogin.Panel1.ResumeLayout(false);
            splitContainerLogin.Panel2.ResumeLayout(false);
            splitContainerLogin.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLogin).EndInit();
            splitContainerLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerLogin;
        private Button btnThoat;
        private Button btnDangNhap;
        private CheckBox chkHienMatKhau;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label lblHuongDan;
        private Label lblTaiKhoan;
        private Label lblChaoMung;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox2;
    }
}