namespace _3.PL.View
{
    partial class FrmMain
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
            this.btn_Hoadon = new System.Windows.Forms.Button();
            this.pnl_Load = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.btn_sp = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.pnl_Load.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Hoadon
            // 
            this.btn_Hoadon.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Hoadon.FlatAppearance.BorderSize = 0;
            this.btn_Hoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_Hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hoadon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Hoadon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Hoadon.Image = global::_3.PL.Properties.Resources.invoice1;
            this.btn_Hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hoadon.Location = new System.Drawing.Point(0, 245);
            this.btn_Hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Hoadon.Name = "btn_Hoadon";
            this.btn_Hoadon.Size = new System.Drawing.Size(197, 46);
            this.btn_Hoadon.TabIndex = 4;
            this.btn_Hoadon.Text = "Hóa đơn";
            this.btn_Hoadon.UseVisualStyleBackColor = false;
            this.btn_Hoadon.Click += new System.EventHandler(this.btn_Hoadon_Click);
            // 
            // pnl_Load
            // 
            this.pnl_Load.BackColor = System.Drawing.Color.DarkSalmon;
            this.pnl_Load.Controls.Add(this.label1);
            this.pnl_Load.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Load.Location = new System.Drawing.Point(193, 0);
            this.pnl_Load.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Load.Name = "pnl_Load";
            this.pnl_Load.Size = new System.Drawing.Size(1177, 712);
            this.pnl_Load.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(266, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Bán Hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.btn_taikhoan);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.btn_banhang);
            this.panel1.Controls.Add(this.btn_Hoadon);
            this.panel1.Controls.Add(this.btn_sp);
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 712);
            this.panel1.TabIndex = 4;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Thoat.Image = global::_3.PL.Properties.Resources.exit;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(0, 666);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(197, 46);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Đăng xuất";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ThongKe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 337);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(197, 46);
            this.btn_ThongKe.TabIndex = 6;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_banhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_banhang.FlatAppearance.BorderSize = 0;
            this.btn_banhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banhang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_banhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_banhang.Image = global::_3.PL.Properties.Resources.trolley2;
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(0, 291);
            this.btn_banhang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(197, 46);
            this.btn_banhang.TabIndex = 5;
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.UseVisualStyleBackColor = false;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // btn_sp
            // 
            this.btn_sp.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_sp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sp.FlatAppearance.BorderSize = 0;
            this.btn_sp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_sp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sp.Image = global::_3.PL.Properties.Resources.brand1;
            this.btn_sp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sp.Location = new System.Drawing.Point(0, 199);
            this.btn_sp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Size = new System.Drawing.Size(197, 46);
            this.btn_sp.TabIndex = 3;
            this.btn_sp.Text = "Sản phẩm";
            this.btn_sp.UseVisualStyleBackColor = false;
            this.btn_sp.Click += new System.EventHandler(this.btn_sp_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_khachhang.FlatAppearance.BorderSize = 0;
            this.btn_khachhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachhang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_khachhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_khachhang.Image = global::_3.PL.Properties.Resources.steward1;
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.Location = new System.Drawing.Point(0, 153);
            this.btn_khachhang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(197, 46);
            this.btn_khachhang.TabIndex = 2;
            this.btn_khachhang.Text = "Khách hàng";
            this.btn_khachhang.UseVisualStyleBackColor = false;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nhanvien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nhanvien.Image = global::_3.PL.Properties.Resources.client;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 107);
            this.btn_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(197, 46);
            this.btn_nhanvien.TabIndex = 1;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.BackgroundImage = global::_3.PL.Properties.Resources._1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 107);
            this.panel2.TabIndex = 0;
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_taikhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_taikhoan.FlatAppearance.BorderSize = 0;
            this.btn_taikhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_taikhoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_taikhoan.Image = global::_3.PL.Properties.Resources.client;
            this.btn_taikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taikhoan.Location = new System.Drawing.Point(0, 620);
            this.btn_taikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Size = new System.Drawing.Size(197, 46);
            this.btn_taikhoan.TabIndex = 8;
            this.btn_taikhoan.Text = "Tài khoản";
            this.btn_taikhoan.UseVisualStyleBackColor = false;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 712);
            this.Controls.Add(this.pnl_Load);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmMain";
            this.pnl_Load.ResumeLayout(false);
            this.pnl_Load.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hoadon;
        private System.Windows.Forms.Panel pnl_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_banhang;
        private System.Windows.Forms.Button btn_sp;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_taikhoan;
    }
}