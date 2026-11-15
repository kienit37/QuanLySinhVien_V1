namespace QuanLySinhVien.GUI.Forms
{
    partial class frmThongKe
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
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grpDiemThapNhat = new GroupBox();
            lblDiemThapNhat = new Label();
            grpDiemCaoNhat = new GroupBox();
            lblDiemCaoNhat = new Label();
            grpDiemTB = new GroupBox();
            lblDiemTB = new Label();
            grpTongKhoa = new GroupBox();
            lblTongKhoa = new Label();
            grpTongSV = new GroupBox();
            lblTongSinhVien = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnXuatExcel = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tabHocLuc = new TabPage();
            dgvHocLuc = new DataGridView();
            tabGioiTinh = new TabPage();
            dgvGioiTinh = new DataGridView();
            tabTheoKhoa = new TabPage();
            dgvTheoKhoa = new DataGridView();
            tabThongKe = new TabControl();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpDiemThapNhat.SuspendLayout();
            grpDiemCaoNhat.SuspendLayout();
            grpDiemTB.SuspendLayout();
            grpTongKhoa.SuspendLayout();
            grpTongSV.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabHocLuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocLuc).BeginInit();
            tabGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioiTinh).BeginInit();
            tabTheoKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheoKhoa).BeginInit();
            tabThongKe.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(1182, 627);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(1172, 45);
            panel3.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(grpDiemThapNhat, 4, 0);
            tableLayoutPanel2.Controls.Add(grpDiemCaoNhat, 3, 0);
            tableLayoutPanel2.Controls.Add(grpDiemTB, 2, 0);
            tableLayoutPanel2.Controls.Add(grpTongKhoa, 1, 0);
            tableLayoutPanel2.Controls.Add(grpTongSV, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(5, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 15, 5, 5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1172, 150);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // grpDiemThapNhat
            // 
            grpDiemThapNhat.Controls.Add(lblDiemThapNhat);
            grpDiemThapNhat.Dock = DockStyle.Fill;
            grpDiemThapNhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            grpDiemThapNhat.Location = new Point(936, 18);
            grpDiemThapNhat.Name = "grpDiemThapNhat";
            grpDiemThapNhat.Size = new Size(228, 124);
            grpDiemThapNhat.TabIndex = 5;
            grpDiemThapNhat.TabStop = false;
            grpDiemThapNhat.Text = "Điểm thấp nhất";
            // 
            // lblDiemThapNhat
            // 
            lblDiemThapNhat.AutoSize = true;
            lblDiemThapNhat.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblDiemThapNhat.ForeColor = Color.CornflowerBlue;
            lblDiemThapNhat.Location = new Point(87, 40);
            lblDiemThapNhat.Name = "lblDiemThapNhat";
            lblDiemThapNhat.Size = new Size(43, 50);
            lblDiemThapNhat.TabIndex = 4;
            lblDiemThapNhat.Text = "0";
            // 
            // grpDiemCaoNhat
            // 
            grpDiemCaoNhat.Controls.Add(lblDiemCaoNhat);
            grpDiemCaoNhat.Dock = DockStyle.Fill;
            grpDiemCaoNhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            grpDiemCaoNhat.Location = new Point(704, 18);
            grpDiemCaoNhat.Name = "grpDiemCaoNhat";
            grpDiemCaoNhat.Size = new Size(226, 124);
            grpDiemCaoNhat.TabIndex = 4;
            grpDiemCaoNhat.TabStop = false;
            grpDiemCaoNhat.Text = "Điểm cao nhất";
            // 
            // lblDiemCaoNhat
            // 
            lblDiemCaoNhat.AutoSize = true;
            lblDiemCaoNhat.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblDiemCaoNhat.ForeColor = Color.CornflowerBlue;
            lblDiemCaoNhat.Location = new Point(85, 40);
            lblDiemCaoNhat.Name = "lblDiemCaoNhat";
            lblDiemCaoNhat.Size = new Size(43, 50);
            lblDiemCaoNhat.TabIndex = 3;
            lblDiemCaoNhat.Text = "0";
            // 
            // grpDiemTB
            // 
            grpDiemTB.AutoSize = true;
            grpDiemTB.Controls.Add(lblDiemTB);
            grpDiemTB.Dock = DockStyle.Fill;
            grpDiemTB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            grpDiemTB.Location = new Point(472, 18);
            grpDiemTB.Name = "grpDiemTB";
            grpDiemTB.Size = new Size(226, 124);
            grpDiemTB.TabIndex = 3;
            grpDiemTB.TabStop = false;
            grpDiemTB.Text = "Điểm trung bình";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblDiemTB.ForeColor = Color.CornflowerBlue;
            lblDiemTB.Location = new Point(83, 40);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(43, 50);
            lblDiemTB.TabIndex = 2;
            lblDiemTB.Text = "0";
            // 
            // grpTongKhoa
            // 
            grpTongKhoa.Controls.Add(lblTongKhoa);
            grpTongKhoa.Dock = DockStyle.Fill;
            grpTongKhoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            grpTongKhoa.Location = new Point(240, 18);
            grpTongKhoa.Name = "grpTongKhoa";
            grpTongKhoa.Size = new Size(226, 124);
            grpTongKhoa.TabIndex = 2;
            grpTongKhoa.TabStop = false;
            grpTongKhoa.Text = "Tổng số khoa";
            // 
            // lblTongKhoa
            // 
            lblTongKhoa.AutoSize = true;
            lblTongKhoa.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblTongKhoa.ForeColor = Color.CornflowerBlue;
            lblTongKhoa.Location = new Point(79, 40);
            lblTongKhoa.Name = "lblTongKhoa";
            lblTongKhoa.Size = new Size(43, 50);
            lblTongKhoa.TabIndex = 1;
            lblTongKhoa.Text = "0";
            // 
            // grpTongSV
            // 
            grpTongSV.Controls.Add(lblTongSinhVien);
            grpTongSV.Dock = DockStyle.Fill;
            grpTongSV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            grpTongSV.Location = new Point(8, 18);
            grpTongSV.Name = "grpTongSV";
            grpTongSV.Size = new Size(226, 124);
            grpTongSV.TabIndex = 1;
            grpTongSV.TabStop = false;
            grpTongSV.Text = "Tổng sinh viên";
            // 
            // lblTongSinhVien
            // 
            lblTongSinhVien.AutoSize = true;
            lblTongSinhVien.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            lblTongSinhVien.ForeColor = Color.CornflowerBlue;
            lblTongSinhVien.Location = new Point(81, 40);
            lblTongSinhVien.Name = "lblTongSinhVien";
            lblTongSinhVien.Size = new Size(43, 50);
            lblTongSinhVien.TabIndex = 0;
            lblTongSinhVien.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.98666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0133457F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.Controls.Add(btnLamMoi, 2, 0);
            tableLayoutPanel1.Controls.Add(btnXuatExcel, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1172, 35);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Red;
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1042, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(127, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 192, 0);
            btnXuatExcel.Dock = DockStyle.Fill;
            btnXuatExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(897, 3);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(139, 29);
            btnXuatExcel.TabIndex = 3;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(334, 28);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ THỐNG KÊ TỔNG QUAN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 53);
            panel1.TabIndex = 0;
            // 
            // tabHocLuc
            // 
            tabHocLuc.Controls.Add(dgvHocLuc);
            tabHocLuc.Location = new Point(4, 29);
            tabHocLuc.Name = "tabHocLuc";
            tabHocLuc.Padding = new Padding(3);
            tabHocLuc.Size = new Size(1174, 353);
            tabHocLuc.TabIndex = 2;
            tabHocLuc.Text = "Theo Học Lực";
            tabHocLuc.UseVisualStyleBackColor = true;
            // 
            // dgvHocLuc
            // 
            dgvHocLuc.AllowUserToAddRows = false;
            dgvHocLuc.AllowUserToDeleteRows = false;
            dgvHocLuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHocLuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocLuc.Dock = DockStyle.Fill;
            dgvHocLuc.Location = new Point(3, 3);
            dgvHocLuc.MultiSelect = false;
            dgvHocLuc.Name = "dgvHocLuc";
            dgvHocLuc.ReadOnly = true;
            dgvHocLuc.RowHeadersVisible = false;
            dgvHocLuc.RowHeadersWidth = 51;
            dgvHocLuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocLuc.Size = new Size(1168, 347);
            dgvHocLuc.TabIndex = 0;
            // 
            // tabGioiTinh
            // 
            tabGioiTinh.Controls.Add(dgvGioiTinh);
            tabGioiTinh.Location = new Point(4, 29);
            tabGioiTinh.Name = "tabGioiTinh";
            tabGioiTinh.Padding = new Padding(3);
            tabGioiTinh.Size = new Size(1174, 353);
            tabGioiTinh.TabIndex = 1;
            tabGioiTinh.Text = "Theo Giới Tính";
            tabGioiTinh.UseVisualStyleBackColor = true;
            // 
            // dgvGioiTinh
            // 
            dgvGioiTinh.AllowUserToAddRows = false;
            dgvGioiTinh.AllowUserToDeleteRows = false;
            dgvGioiTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioiTinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioiTinh.Dock = DockStyle.Fill;
            dgvGioiTinh.Location = new Point(3, 3);
            dgvGioiTinh.MultiSelect = false;
            dgvGioiTinh.Name = "dgvGioiTinh";
            dgvGioiTinh.ReadOnly = true;
            dgvGioiTinh.RowHeadersVisible = false;
            dgvGioiTinh.RowHeadersWidth = 51;
            dgvGioiTinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioiTinh.Size = new Size(1168, 347);
            dgvGioiTinh.TabIndex = 0;
            // 
            // tabTheoKhoa
            // 
            tabTheoKhoa.Controls.Add(dgvTheoKhoa);
            tabTheoKhoa.Location = new Point(4, 29);
            tabTheoKhoa.Name = "tabTheoKhoa";
            tabTheoKhoa.Padding = new Padding(3);
            tabTheoKhoa.Size = new Size(1174, 372);
            tabTheoKhoa.TabIndex = 0;
            tabTheoKhoa.Text = "Theo Khoa";
            tabTheoKhoa.UseVisualStyleBackColor = true;
            // 
            // dgvTheoKhoa
            // 
            dgvTheoKhoa.AllowUserToAddRows = false;
            dgvTheoKhoa.AllowUserToDeleteRows = false;
            dgvTheoKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheoKhoa.BackgroundColor = SystemColors.ButtonFace;
            dgvTheoKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheoKhoa.Dock = DockStyle.Fill;
            dgvTheoKhoa.Location = new Point(3, 3);
            dgvTheoKhoa.MultiSelect = false;
            dgvTheoKhoa.Name = "dgvTheoKhoa";
            dgvTheoKhoa.ReadOnly = true;
            dgvTheoKhoa.RowHeadersVisible = false;
            dgvTheoKhoa.RowHeadersWidth = 51;
            dgvTheoKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheoKhoa.Size = new Size(1168, 366);
            dgvTheoKhoa.TabIndex = 0;
            // 
            // tabThongKe
            // 
            tabThongKe.Controls.Add(tabTheoKhoa);
            tabThongKe.Controls.Add(tabGioiTinh);
            tabThongKe.Controls.Add(tabHocLuc);
            tabThongKe.Dock = DockStyle.Bottom;
            tabThongKe.Location = new Point(0, 294);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.SelectedIndex = 0;
            tabThongKe.Size = new Size(1182, 405);
            tabThongKe.TabIndex = 2;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1182, 699);
            Controls.Add(tabThongKe);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 650);
            Name = "frmThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THỐNG KÊ - BÁO CÁO SINH VIÊN";
            Load += frmThongKe_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            grpDiemThapNhat.ResumeLayout(false);
            grpDiemThapNhat.PerformLayout();
            grpDiemCaoNhat.ResumeLayout(false);
            grpDiemCaoNhat.PerformLayout();
            grpDiemTB.ResumeLayout(false);
            grpDiemTB.PerformLayout();
            grpTongKhoa.ResumeLayout(false);
            grpTongKhoa.PerformLayout();
            grpTongSV.ResumeLayout(false);
            grpTongSV.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabHocLuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocLuc).EndInit();
            tabGioiTinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioiTinh).EndInit();
            tabTheoKhoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTheoKhoa).EndInit();
            tabThongKe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLamMoi;
        private Button btnXuatExcel;
        private Label label1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grpDiemThapNhat;
        private Label lblDiemThapNhat;
        private GroupBox grpDiemCaoNhat;
        private Label lblDiemCaoNhat;
        private GroupBox grpDiemTB;
        private Label lblDiemTB;
        private GroupBox grpTongKhoa;
        private Label lblTongKhoa;
        private GroupBox grpTongSV;
        private Label lblTongSinhVien;
        private Panel panel1;
        private TabPage tabHocLuc;
        private DataGridView dgvHocLuc;
        private TabPage tabGioiTinh;
        private DataGridView dgvGioiTinh;
        private TabPage tabTheoKhoa;
        private DataGridView dgvTheoKhoa;
        private TabControl tabThongKe;
    }
}