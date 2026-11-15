namespace QuanLySinhVien.GUI.Forms
{
    partial class frmTestLogging
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
            btnGhiInfo = new Button();
            btnGhiWarning = new Button();
            btnGhiError = new Button();
            SuspendLayout();
            // 
            // btnGhiInfo
            // 
            btnGhiInfo.Location = new Point(297, 97);
            btnGhiInfo.Name = "btnGhiInfo";
            btnGhiInfo.Size = new Size(169, 44);
            btnGhiInfo.TabIndex = 0;
            btnGhiInfo.Text = "Ghi Thông Tin";
            btnGhiInfo.UseVisualStyleBackColor = true;
            btnGhiInfo.Click += btnGhiInfo_Click;
            // 
            // btnGhiWarning
            // 
            btnGhiWarning.Location = new Point(306, 173);
            btnGhiWarning.Name = "btnGhiWarning";
            btnGhiWarning.Size = new Size(160, 50);
            btnGhiWarning.TabIndex = 1;
            btnGhiWarning.Text = "Cảnh Báo";
            btnGhiWarning.UseVisualStyleBackColor = true;
            btnGhiWarning.Click += btnGhiWarning_Click;
            // 
            // btnGhiError
            // 
            btnGhiError.Location = new Point(297, 253);
            btnGhiError.Name = "btnGhiError";
            btnGhiError.Size = new Size(156, 41);
            btnGhiError.TabIndex = 2;
            btnGhiError.Text = "Ghi Lỗi";
            btnGhiError.UseVisualStyleBackColor = true;
            btnGhiError.Click += btnGhiError_Click;
            // 
            // frmTestLogging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGhiError);
            Controls.Add(btnGhiWarning);
            Controls.Add(btnGhiInfo);
            Name = "frmTestLogging";
            Text = "frmTestLogging";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGhiInfo;
        private Button btnGhiWarning;
        private Button btnGhiError;
    }
}