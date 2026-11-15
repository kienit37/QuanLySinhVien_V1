namespace QuanLySinhVien.GUI.Forms
{
    partial class frmPhanQuyen
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            cboVaiTro = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            btnDong = new Button();
            btnLuu = new Button();
            btnBoChonTatCa = new Button();
            btnChonTatCa = new Button();
            btnTaiQuyen = new Button();
            clbQuyen = new CheckedListBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHÂN QUYỀN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 29);
            label2.Name = "label2";
            label2.Size = new Size(426, 17);
            label2.TabIndex = 0;
            label2.Text = "Chọn vai trò để thiết lập các quyền được phép sử dụng trong hệ thống.";
            // 
            // panel2
            // 
            panel2.Controls.Add(cboVaiTro);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 64);
            panel2.TabIndex = 1;
            // 
            // cboVaiTro
            // 
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(124, 17);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(850, 28);
            cboVaiTro.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 25);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "Vai Trò:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDong);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnBoChonTatCa);
            panel3.Controls.Add(btnChonTatCa);
            panel3.Controls.Add(btnTaiQuyen);
            panel3.Controls.Add(clbQuyen);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(1028, 408);
            panel3.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(798, 325);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(176, 40);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(605, 325);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(176, 40);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoChonTatCa
            // 
            btnBoChonTatCa.Location = new Point(423, 325);
            btnBoChonTatCa.Name = "btnBoChonTatCa";
            btnBoChonTatCa.Size = new Size(176, 40);
            btnBoChonTatCa.TabIndex = 4;
            btnBoChonTatCa.Text = "Bỏ Chọn Tất  Cả";
            btnBoChonTatCa.UseVisualStyleBackColor = true;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.Location = new Point(232, 325);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(176, 40);
            btnChonTatCa.TabIndex = 3;
            btnChonTatCa.Text = "Chọn Tất Cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            // 
            // btnTaiQuyen
            // 
            btnTaiQuyen.Location = new Point(36, 325);
            btnTaiQuyen.Name = "btnTaiQuyen";
            btnTaiQuyen.Size = new Size(176, 40);
            btnTaiQuyen.TabIndex = 2;
            btnTaiQuyen.Text = "Tải Quyền";
            btnTaiQuyen.UseVisualStyleBackColor = true;
            // 
            // clbQuyen
            // 
            clbQuyen.CheckOnClick = true;
            clbQuyen.FormattingEnabled = true;
            clbQuyen.IntegralHeight = false;
            clbQuyen.Location = new Point(37, 54);
            clbQuyen.Name = "clbQuyen";
            clbQuyen.Size = new Size(937, 246);
            clbQuyen.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 20);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 0;
            label4.Text = "Danh Sách Quyền:";
            // 
            // frmPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 536);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPhanQuyen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phân Quyền";
            WindowState = FormWindowState.Minimized;
            Load += frmPhanQuyen_Load;
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
        private Label label2;
        private Panel panel2;
        private ComboBox cboVaiTro;
        private Label label3;
        private Panel panel3;
        private Button btnDong;
        private Button btnLuu;
        private Button btnBoChonTatCa;
        private Button btnChonTatCa;
        private Button btnTaiQuyen;
        private CheckedListBox clbQuyen;
        private Label label4;
    }
}