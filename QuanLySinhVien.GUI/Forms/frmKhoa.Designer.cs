namespace QuanLySinhVien.GUI.Forms
{
    partial class frmKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            pnlTieuDe = new Panel();
            label5 = new Label();
            label1 = new Label();
            pnlTimKiem = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLamMoi = new Button();
            imageList1 = new ImageList(components);
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            pnlChucNang = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtMoTa = new TextBox();
            label4 = new Label();
            txtMaKhoa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTenKhoa = new TextBox();
            pictureBox1 = new PictureBox();
            dgvKhoa = new DataGridView();
            pnlTieuDe.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlChucNang.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.MidnightBlue;
            pnlTieuDe.Controls.Add(label5);
            pnlTieuDe.Controls.Add(label1);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(982, 52);
            pnlTieuDe.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(190, 17);
            label5.Name = "label5";
            label5.Size = new Size(297, 20);
            label5.TabIndex = 4;
            label5.Text = "Quản lý thông tin và hoạt động của các khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHOA";
            label1.Click += label1_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.Controls.Add(tableLayoutPanel1);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 52);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(982, 44);
            pnlTimKiem.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.136055F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.863945F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTimKiem, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(982, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.ImageIndex = 1;
            btnLamMoi.ImageList = imageList1;
            btnLamMoi.Location = new Point(858, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 38);
            btnLamMoi.TabIndex = 4;
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
            imageList1.Images.SetKeyName(3, "select_all_icon_132738.ico");
            imageList1.Images.SetKeyName(4, "xbutton_83749.ico");
            imageList1.Images.SetKeyName(5, "1486504331-burn-fire-flame-danger-burning-hot_81317.ico");
            imageList1.Images.SetKeyName(6, "1486504332-check-document-ok-contract-file-success_81315.ico");
            imageList1.Images.SetKeyName(7, "1486504352-checklist-clipboard-inventory-list-report-tasks-todo_81326.ico");
            imageList1.Images.SetKeyName(8, "1486504369-change-edit-options-pencil-settings-tools-write_81307.ico");
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = true;
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.ImageIndex = 2;
            btnTimKiem.ImageList = imageList1;
            btnTimKiem.Location = new Point(738, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 38);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(151, 3);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã khoa hoặc tên khoa...";
            txtTimKiem.Size = new Size(581, 38);
            txtTimKiem.TabIndex = 2;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Anchor = AnchorStyles.Left;
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(3, 12);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(111, 20);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm Kiếm Khoa";
            // 
            // pnlChucNang
            // 
            pnlChucNang.BackColor = Color.White;
            pnlChucNang.Controls.Add(tableLayoutPanel4);
            pnlChucNang.Controls.Add(tableLayoutPanel2);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 96);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(982, 216);
            pnlChucNang.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnHuy, 3, 0);
            tableLayoutPanel4.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel4.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel4.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 166);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(982, 57);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Navy;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(738, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(241, 51);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Navy;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(493, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(239, 51);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Navy;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(248, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(239, 51);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.AutoEllipsis = true;
            btnThem.BackColor = Color.Navy;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.ImageIndex = 8;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(239, 51);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.34623F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6537685F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(982, 166);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5185184F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.48148F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(txtMoTa, 1, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(txtMaKhoa, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(txtTenKhoa, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 45.7364349F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 54.2635651F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel3.Size = new Size(783, 160);
            tableLayoutPanel3.TabIndex = 0;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMoTa.Location = new Point(148, 104);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(632, 53);
            txtMoTa.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 8;
            label4.Text = "Mô Tả:";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaKhoa.Location = new Point(148, 49);
            txtMaKhoa.Multiline = true;
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(632, 49);
            txtMaKhoa.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 63);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã Khoa:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Khoa:";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKhoa.Location = new Point(148, 3);
            txtTenKhoa.Multiline = true;
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(632, 40);
            txtTenKhoa.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(792, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.AllowUserToDeleteRows = false;
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoa.BackgroundColor = Color.White;
            dgvKhoa.BorderStyle = BorderStyle.None;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Dock = DockStyle.Fill;
            dgvKhoa.Location = new Point(0, 312);
            dgvKhoa.MultiSelect = false;
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.ReadOnly = true;
            dgvKhoa.RowHeadersVisible = false;
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.Size = new Size(982, 291);
            dgvKhoa.TabIndex = 4;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(982, 603);
            Controls.Add(dgvKhoa);
            Controls.Add(pnlChucNang);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlTieuDe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 650);
            Name = "frmKhoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ KHOA";
            Load += frmKhoa_Load;
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlChucNang.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label label1;
        private Panel pnlTimKiem;
        private Panel pnlChucNang;
        private DataGridView dgvKhoa;
        private ImageList imageList1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtMoTa;
        private Label label4;
        private TextBox txtMaKhoa;
        private Label label2;
        private Label label3;
        private TextBox txtTenKhoa;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}