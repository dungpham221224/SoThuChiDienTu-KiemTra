
namespace SoThuChiDienTu_KiemTra.GUI
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.pnlThan = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiaoDichThu = new System.Windows.Forms.Button();
            this.btnGiaoDichChi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThan
            // 
            this.pnlThan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThan.BackColor = System.Drawing.Color.White;
            this.pnlThan.Location = new System.Drawing.Point(0, 116);
            this.pnlThan.Name = "pnlThan";
            this.pnlThan.Size = new System.Drawing.Size(1065, 448);
            this.pnlThan.TabIndex = 0;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.Location = new System.Drawing.Point(79, 15);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(105, 22);
            this.txtTaiKhoan.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiaoDichThu
            // 
            this.btnGiaoDichThu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiaoDichThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaoDichThu.FlatAppearance.BorderSize = 0;
            this.btnGiaoDichThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiaoDichThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiaoDichThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDichThu.Image = global::SoThuChiDienTu_KiemTra.Properties.Resources.money_bag;
            this.btnGiaoDichThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDichThu.Location = new System.Drawing.Point(434, 75);
            this.btnGiaoDichThu.Name = "btnGiaoDichThu";
            this.btnGiaoDichThu.Size = new System.Drawing.Size(216, 41);
            this.btnGiaoDichThu.TabIndex = 6;
            this.btnGiaoDichThu.Text = "Giao dịch thu";
            this.btnGiaoDichThu.UseVisualStyleBackColor = false;
            this.btnGiaoDichThu.Click += new System.EventHandler(this.btnGiaoDichThu_Click);
            // 
            // btnGiaoDichChi
            // 
            this.btnGiaoDichChi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGiaoDichChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaoDichChi.FlatAppearance.BorderSize = 0;
            this.btnGiaoDichChi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiaoDichChi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiaoDichChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDichChi.Image = global::SoThuChiDienTu_KiemTra.Properties.Resources.money;
            this.btnGiaoDichChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDichChi.Location = new System.Drawing.Point(153, 75);
            this.btnGiaoDichChi.Name = "btnGiaoDichChi";
            this.btnGiaoDichChi.Size = new System.Drawing.Size(206, 41);
            this.btnGiaoDichChi.TabIndex = 5;
            this.btnGiaoDichChi.Text = "Giao dịch chi";
            this.btnGiaoDichChi.UseVisualStyleBackColor = false;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1065, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnGiaoDichThu);
            this.Controls.Add(this.btnGiaoDichChi);
            this.Controls.Add(this.pnlThan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlThan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnGiaoDichThu;
        private System.Windows.Forms.Button btnGiaoDichChi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}