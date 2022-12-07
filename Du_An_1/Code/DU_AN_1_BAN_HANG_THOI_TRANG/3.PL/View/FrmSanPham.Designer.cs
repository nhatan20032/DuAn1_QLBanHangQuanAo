namespace _3.PL.View
{
    partial class FrmSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrid_SP = new System.Windows.Forms.DataGridView();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.rbtn_ConHang = new System.Windows.Forms.RadioButton();
            this.rbtn_HetHang = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // dgrid_SP
            // 
            this.dgrid_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_SP.Location = new System.Drawing.Point(0, 262);
            this.dgrid_SP.Name = "dgrid_SP";
            this.dgrid_SP.RowHeadersWidth = 51;
            this.dgrid_SP.RowTemplate.Height = 29;
            this.dgrid_SP.Size = new System.Drawing.Size(800, 188);
            this.dgrid_SP.TabIndex = 5;
            this.dgrid_SP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SP_CellContentClick);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(126, 29);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(214, 27);
            this.txt_Ma.TabIndex = 6;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(127, 97);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(213, 27);
            this.txt_Ten.TabIndex = 7;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(661, 23);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(660, 80);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(660, 137);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // rbtn_ConHang
            // 
            this.rbtn_ConHang.AutoSize = true;
            this.rbtn_ConHang.Location = new System.Drawing.Point(132, 162);
            this.rbtn_ConHang.Name = "rbtn_ConHang";
            this.rbtn_ConHang.Size = new System.Drawing.Size(93, 24);
            this.rbtn_ConHang.TabIndex = 11;
            this.rbtn_ConHang.TabStop = true;
            this.rbtn_ConHang.Text = "Còn hàng";
            this.rbtn_ConHang.UseVisualStyleBackColor = true;
            // 
            // rbtn_HetHang
            // 
            this.rbtn_HetHang.AutoSize = true;
            this.rbtn_HetHang.Location = new System.Drawing.Point(133, 203);
            this.rbtn_HetHang.Name = "rbtn_HetHang";
            this.rbtn_HetHang.Size = new System.Drawing.Size(91, 24);
            this.rbtn_HetHang.TabIndex = 12;
            this.rbtn_HetHang.TabStop = true;
            this.rbtn_HetHang.Text = "Hết hàng";
            this.rbtn_HetHang.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(604, 185);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(184, 27);
            this.txt_TimKiem.TabIndex = 13;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimKiem_MouseClick);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.rbtn_HetHang);
            this.Controls.Add(this.rbtn_ConHang);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.dgrid_SP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgrid_SP;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.RadioButton rbtn_ConHang;
        private System.Windows.Forms.RadioButton rbtn_HetHang;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}