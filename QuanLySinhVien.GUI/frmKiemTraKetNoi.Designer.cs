namespace QuanLySinhVien.GUI
{
    partial class frmKiemTraKetNoi
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
            btnKiemTra = new Button();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(46, 107);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(389, 48);
            btnKiemTra.TabIndex = 0;
            btnKiemTra.Text = "Kiểm Tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.ForeColor = Color.Blue;
            lblKetQua.Location = new Point(46, 57);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(105, 20);
            lblKetQua.TabIndex = 1;
            lblKetQua.Text = "Chưa Kiểm Tra";
            // 
            // frmKiemTraKetNoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 191);
            Controls.Add(lblKetQua);
            Controls.Add(btnKiemTra);
            Name = "frmKiemTraKetNoi";
            Text = "Kiểm Tra Kết Nối";
            Load += frmKiemTraKetNoi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKiemTra;
        private Label lblKetQua;
    }
}