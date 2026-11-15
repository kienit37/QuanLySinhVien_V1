namespace QuanLySinhVien.GUI.Forms
{
    partial class frmHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhan));
            pnlTieuDe = new Panel();
            label1 = new Label();
            pnlTimKiem = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtMoTa = new TextBox();
            label6 = new Label();
            nudSoTinChi = new NumericUpDown();
            label5 = new Label();
            txtTenHP = new TextBox();
            label4 = new Label();
            txtMaHP = new TextBox();
            label3 = new Label();
            pnlChucNang = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvHocPhan = new DataGridView();
            pnlTieuDe.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).BeginInit();
            pnlChucNang.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocPhan).BeginInit();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.FromArgb(0, 0, 192);
            pnlTieuDe.Controls.Add(label1);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(1082, 48);
            pnlTieuDe.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HỌC PHẦN";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.Controls.Add(tableLayoutPanel1);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 48);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1082, 42);
            pnlTimKiem.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.765028F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.23497F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 2, 0);
            tableLayoutPanel1.Controls.Add(txtTimKiem, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1082, 43);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Location = new Point(943, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(136, 37);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.Location = new Point(793, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(144, 37);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Location = new Point(167, 3);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã hoặc tên học phần...";
            txtTimKiem.Size = new Size(620, 37);
            txtTimKiem.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm học phần";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 99);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3780918F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.62191F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 382F));
            tableLayoutPanel2.Controls.Add(txtMoTa, 3, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 1);
            tableLayoutPanel2.Controls.Add(nudSoTinChi, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTenHP, 3, 0);
            tableLayoutPanel2.Controls.Add(label4, 2, 0);
            tableLayoutPanel2.Controls.Add(txtMaHP, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.63291F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.36709F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1082, 93);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtMoTa
            // 
            txtMoTa.Dock = DockStyle.Fill;
            txtMoTa.Location = new Point(702, 50);
            txtMoTa.MaxLength = 255;
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(377, 40);
            txtMoTa.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(569, 60);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Mô Tả:";
            // 
            // nudSoTinChi
            // 
            nudSoTinChi.Dock = DockStyle.Fill;
            nudSoTinChi.Location = new Point(124, 50);
            nudSoTinChi.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudSoTinChi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoTinChi.Name = "nudSoTinChi";
            nudSoTinChi.Size = new Size(439, 27);
            nudSoTinChi.TabIndex = 9;
            nudSoTinChi.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(3, 60);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 8;
            label5.Text = "Số Tin Chỉ:";
            // 
            // txtTenHP
            // 
            txtTenHP.Dock = DockStyle.Fill;
            txtTenHP.Location = new Point(702, 3);
            txtTenHP.Name = "txtTenHP";
            txtTenHP.Size = new Size(377, 27);
            txtTenHP.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(569, 13);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên Học Phần:";
            // 
            // txtMaHP
            // 
            txtMaHP.Dock = DockStyle.Fill;
            txtMaHP.Location = new Point(124, 3);
            txtMaHP.Name = "txtMaHP";
            txtMaHP.Size = new Size(439, 27);
            txtMaHP.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã Học Phần:";
            // 
            // pnlChucNang
            // 
            pnlChucNang.BackColor = Color.White;
            pnlChucNang.Controls.Add(tableLayoutPanel3);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 189);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(1082, 57);
            pnlChucNang.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnHuy, 3, 0);
            tableLayoutPanel3.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel3.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel3.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1082, 54);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(0, 0, 192);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(813, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(240, 42);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(0, 0, 192);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(543, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(240, 42);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(0, 0, 192);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(273, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(240, 42);
            btnSua.TabIndex = 2;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 0, 192);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(240, 42);
            btnThem.TabIndex = 1;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvHocPhan
            // 
            dgvHocPhan.AllowUserToAddRows = false;
            dgvHocPhan.AllowUserToDeleteRows = false;
            dgvHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHocPhan.BackgroundColor = Color.White;
            dgvHocPhan.BorderStyle = BorderStyle.None;
            dgvHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocPhan.Dock = DockStyle.Fill;
            dgvHocPhan.Location = new Point(0, 246);
            dgvHocPhan.MultiSelect = false;
            dgvHocPhan.Name = "dgvHocPhan";
            dgvHocPhan.ReadOnly = true;
            dgvHocPhan.RowHeadersVisible = false;
            dgvHocPhan.RowHeadersWidth = 51;
            dgvHocPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocPhan.Size = new Size(1082, 407);
            dgvHocPhan.TabIndex = 4;
            // 
            // frmHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1082, 653);
            Controls.Add(dgvHocPhan);
            Controls.Add(pnlChucNang);
            Controls.Add(panel1);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlTieuDe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 700);
            Name = "frmHocPhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ HỌC PHẦN";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).EndInit();
            pnlChucNang.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocPhan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label label1;
        private Panel pnlTimKiem;
        private Panel panel1;
        private Panel pnlChucNang;
        private DataGridView dgvHocPhan;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtMoTa;
        private Label label6;
        private NumericUpDown nudSoTinChi;
        private Label label5;
        private TextBox txtTenHP;
        private Label label4;
        private TextBox txtMaHP;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}