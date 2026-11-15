namespace QuanLySinhVien.GUI.Forms
{
    partial class frmChiTietLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietLog));
            lblThoiGian = new Label();
            label2 = new Label();
            lblTaiKhoan = new Label();
            label4 = new Label();
            label5 = new Label();
            lblMucDo = new Label();
            label7 = new Label();
            lblHanhDong = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNoiDung = new TextBox();
            txtChiTietLoi = new TextBox();
            btnDong = new Button();
            SuspendLayout();
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Location = new Point(140, 32);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(49, 20);
            lblThoiGian.TabIndex = 0;
            lblThoiGian.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Mức Độ:";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Location = new Point(141, 111);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(50, 20);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(32, 155);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Hành Động:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(32, 32);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Thời Gian:";
            // 
            // lblMucDo
            // 
            lblMucDo.AutoSize = true;
            lblMucDo.Location = new Point(140, 73);
            lblMucDo.Name = "lblMucDo";
            lblMucDo.Size = new Size(51, 20);
            lblMucDo.TabIndex = 5;
            lblMucDo.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(32, 111);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 6;
            label7.Text = "Tài Khoản:";
            // 
            // lblHanhDong
            // 
            lblHanhDong.AutoSize = true;
            lblHanhDong.Location = new Point(140, 155);
            lblHanhDong.Name = "lblHanhDong";
            lblHanhDong.Size = new Size(51, 20);
            lblHanhDong.TabIndex = 7;
            lblHanhDong.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(32, 197);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 8;
            label9.Text = "Nội Dung:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(26, 268);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 9;
            label10.Text = "Chi Tiết Lỗi:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(138, 190);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ReadOnly = true;
            txtNoiDung.Size = new Size(654, 34);
            txtNoiDung.TabIndex = 10;
            // 
            // txtChiTietLoi
            // 
            txtChiTietLoi.Location = new Point(140, 265);
            txtChiTietLoi.Multiline = true;
            txtChiTietLoi.Name = "txtChiTietLoi";
            txtChiTietLoi.ReadOnly = true;
            txtChiTietLoi.ScrollBars = ScrollBars.Both;
            txtChiTietLoi.Size = new Size(650, 89);
            txtChiTietLoi.TabIndex = 11;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(686, 385);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(106, 29);
            btnDong.TabIndex = 12;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // frmChiTietLog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(btnDong);
            Controls.Add(txtChiTietLoi);
            Controls.Add(txtNoiDung);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lblHanhDong);
            Controls.Add(label7);
            Controls.Add(lblMucDo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTaiKhoan);
            Controls.Add(label2);
            Controls.Add(lblThoiGian);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChiTietLog";
            Text = "Chi Tiết Lỗi";
            Load += frmChiTietLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThoiGian;
        private Label label2;
        private Label lblTaiKhoan;
        private Label label4;
        private Label label5;
        private Label lblMucDo;
        private Label label7;
        private Label lblHanhDong;
        private Label label9;
        private Label label10;
        private TextBox txtNoiDung;
        private TextBox txtChiTietLoi;
        private Button btnDong;
    }
}