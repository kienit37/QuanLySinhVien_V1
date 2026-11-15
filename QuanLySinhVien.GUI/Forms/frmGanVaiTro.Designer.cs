namespace QuanLySinhVien.GUI.Forms
{
    partial class frmGanVaiTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGanVaiTro));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnTaiQuyen = new Button();
            imageList1 = new ImageList(components);
            cboTaiKhoan = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            btnDong = new Button();
            btnLuu = new Button();
            btnBoChonTatCa = new Button();
            btnChonTatCa = new Button();
            clbVaiTro = new CheckedListBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(218, 23);
            label1.TabIndex = 0;
            label1.Text = "PHÂN QUYỀN TÀI KHOẢN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnTaiQuyen);
            panel2.Controls.Add(cboTaiKhoan);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 89);
            panel2.TabIndex = 1;
            // 
            // btnTaiQuyen
            // 
            btnTaiQuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiQuyen.ImageIndex = 4;
            btnTaiQuyen.ImageList = imageList1;
            btnTaiQuyen.Location = new Point(694, 36);
            btnTaiQuyen.Name = "btnTaiQuyen";
            btnTaiQuyen.Size = new Size(113, 28);
            btnTaiQuyen.TabIndex = 2;
            btnTaiQuyen.Text = "Tải Vai Trò";
            btnTaiQuyen.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "4115230-cancel-close-cross-delete_114048.ico");
            imageList1.Images.SetKeyName(1, "deselect_all_empty_icon_132729.ico");
            imageList1.Images.SetKeyName(2, "save-disk_icon-icons.com_71576.ico");
            imageList1.Images.SetKeyName(3, "select_all_icon_132738.ico");
            imageList1.Images.SetKeyName(4, "seo-social-web-network-internet_12_icon-icons.com_61498.ico");
            // 
            // cboTaiKhoan
            // 
            cboTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTaiKhoan.FormattingEnabled = true;
            cboTaiKhoan.Location = new Point(29, 36);
            cboTaiKhoan.Name = "cboTaiKhoan";
            cboTaiKhoan.Size = new Size(635, 28);
            cboTaiKhoan.TabIndex = 1;
            cboTaiKhoan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 12);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 0;
            label2.Text = "Chọn tài khoản:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDong);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnBoChonTatCa);
            panel3.Controls.Add(btnChonTatCa);
            panel3.Controls.Add(clbVaiTro);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(832, 409);
            panel3.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.WhiteSmoke;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 9F);
            btnDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDong.ImageIndex = 0;
            btnDong.ImageList = imageList1;
            btnDong.Location = new Point(617, 347);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(190, 38);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.WhiteSmoke;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9F);
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.ImageIndex = 2;
            btnLuu.ImageList = imageList1;
            btnLuu.Location = new Point(421, 347);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(190, 38);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu thay đổi";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBoChonTatCa
            // 
            btnBoChonTatCa.BackColor = Color.WhiteSmoke;
            btnBoChonTatCa.FlatStyle = FlatStyle.Flat;
            btnBoChonTatCa.Font = new Font("Segoe UI", 9F);
            btnBoChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoChonTatCa.ImageIndex = 1;
            btnBoChonTatCa.ImageList = imageList1;
            btnBoChonTatCa.Location = new Point(224, 347);
            btnBoChonTatCa.Name = "btnBoChonTatCa";
            btnBoChonTatCa.Size = new Size(190, 38);
            btnBoChonTatCa.TabIndex = 3;
            btnBoChonTatCa.Text = "Bỏ chọn tất cả";
            btnBoChonTatCa.UseVisualStyleBackColor = false;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.BackColor = Color.WhiteSmoke;
            btnChonTatCa.FlatStyle = FlatStyle.Flat;
            btnChonTatCa.Font = new Font("Segoe UI", 9F);
            btnChonTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnChonTatCa.ImageKey = "select_all_icon_132738.ico";
            btnChonTatCa.ImageList = imageList1;
            btnChonTatCa.Location = new Point(28, 347);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(190, 38);
            btnChonTatCa.TabIndex = 2;
            btnChonTatCa.Text = "Chọn tất cả";
            btnChonTatCa.UseVisualStyleBackColor = false;
            // 
            // clbVaiTro
            // 
            clbVaiTro.CheckOnClick = true;
            clbVaiTro.FormattingEnabled = true;
            clbVaiTro.IntegralHeight = false;
            clbVaiTro.Location = new Point(30, 44);
            clbVaiTro.Name = "clbVaiTro";
            clbVaiTro.Size = new Size(777, 290);
            clbVaiTro.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 9);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 0;
            label3.Text = "Danh sách vai trò:";
            // 
            // frmGanVaiTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 553);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGanVaiTro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Vai Trò Tài Khoản";
            Load += frmGanVaiTro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnTaiQuyen;
        private ComboBox cboTaiKhoan;
        private Label label2;
        private Panel panel3;
        private CheckedListBox clbVaiTro;
        private Label label3;
        private Button btnDong;
        private Button btnLuu;
        private Button btnBoChonTatCa;
        private Button btnChonTatCa;
        private ImageList imageList1;
    }
}