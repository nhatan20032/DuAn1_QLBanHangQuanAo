namespace _3.PL.View
{
    partial class FrmThuongHieu
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.RichTextBox();
            this.rbtn_DangCungCap = new System.Windows.Forms.RadioButton();
            this.rbtn_NgungCungCap = new System.Windows.Forms.RadioButton();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgrid_ThuongHieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(84, 22);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(262, 27);
            this.txt_Ma.TabIndex = 4;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(82, 83);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(264, 27);
            this.txt_Ten.TabIndex = 5;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(82, 137);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(264, 58);
            this.txt_MoTa.TabIndex = 6;
            this.txt_MoTa.Text = "";
            // 
            // rbtn_DangCungCap
            // 
            this.rbtn_DangCungCap.AutoSize = true;
            this.rbtn_DangCungCap.Location = new System.Drawing.Point(82, 209);
            this.rbtn_DangCungCap.Name = "rbtn_DangCungCap";
            this.rbtn_DangCungCap.Size = new System.Drawing.Size(130, 24);
            this.rbtn_DangCungCap.TabIndex = 7;
            this.rbtn_DangCungCap.TabStop = true;
            this.rbtn_DangCungCap.Text = "Đang cung cấp";
            this.rbtn_DangCungCap.UseVisualStyleBackColor = true;
            // 
            // rbtn_NgungCungCap
            // 
            this.rbtn_NgungCungCap.AutoSize = true;
            this.rbtn_NgungCungCap.Location = new System.Drawing.Point(85, 246);
            this.rbtn_NgungCungCap.Name = "rbtn_NgungCungCap";
            this.rbtn_NgungCungCap.Size = new System.Drawing.Size(140, 24);
            this.rbtn_NgungCungCap.TabIndex = 8;
            this.rbtn_NgungCungCap.TabStop = true;
            this.rbtn_NgungCungCap.Text = "Ngừng cung cấp";
            this.rbtn_NgungCungCap.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(564, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(234, 54);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(565, 71);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(233, 59);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(566, 136);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(232, 59);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(566, 209);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(232, 27);
            this.txt_TimKiem.TabIndex = 12;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimKiem_MouseClick);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // dgrid_ThuongHieu
            // 
            this.dgrid_ThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ThuongHieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ThuongHieu.Location = new System.Drawing.Point(0, 305);
            this.dgrid_ThuongHieu.Name = "dgrid_ThuongHieu";
            this.dgrid_ThuongHieu.RowHeadersWidth = 51;
            this.dgrid_ThuongHieu.RowTemplate.Height = 29;
            this.dgrid_ThuongHieu.Size = new System.Drawing.Size(800, 188);
            this.dgrid_ThuongHieu.TabIndex = 13;
            this.dgrid_ThuongHieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ThuongHieu_CellContentClick);
            // 
            // FrmThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.dgrid_ThuongHieu);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rbtn_NgungCungCap);
            this.Controls.Add(this.rbtn_DangCungCap);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThuongHieu";
            this.Text = "FrmThuongHieu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThuongHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.RichTextBox txt_MoTa;
        private System.Windows.Forms.RadioButton rbtn_DangCungCap;
        private System.Windows.Forms.RadioButton rbtn_NgungCungCap;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgrid_ThuongHieu;
    }
}