namespace _3.PL.View
{
    partial class FrmChatLieu
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
            this.btn_them = new System.Windows.Forms.Button();
            this.dtgv_chatlieu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.rbtn_conhang = new System.Windows.Forms.RadioButton();
            this.rbtn_hethang = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(136, 185);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtgv_chatlieu
            // 
            this.dtgv_chatlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_chatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_chatlieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_chatlieu.Location = new System.Drawing.Point(0, 262);
            this.dtgv_chatlieu.Name = "dtgv_chatlieu";
            this.dtgv_chatlieu.RowHeadersWidth = 51;
            this.dtgv_chatlieu.RowTemplate.Height = 29;
            this.dtgv_chatlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_chatlieu.Size = new System.Drawing.Size(800, 188);
            this.dtgv_chatlieu.TabIndex = 4;
            this.dtgv_chatlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_chatlieu_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô tả";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 1;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(88, 26);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(125, 27);
            this.txt_ma.TabIndex = 1;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(351, 23);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(125, 27);
            this.txt_ten.TabIndex = 1;
            this.txt_ten.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(632, 23);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(125, 27);
            this.txt_mota.TabIndex = 1;
            this.txt_mota.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(269, 185);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 29);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(413, 185);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(538, 229);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(250, 27);
            this.txt_timkiem.TabIndex = 1;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(550, 185);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // rbtn_conhang
            // 
            this.rbtn_conhang.AutoSize = true;
            this.rbtn_conhang.Location = new System.Drawing.Point(148, 129);
            this.rbtn_conhang.Name = "rbtn_conhang";
            this.rbtn_conhang.Size = new System.Drawing.Size(93, 24);
            this.rbtn_conhang.TabIndex = 5;
            this.rbtn_conhang.TabStop = true;
            this.rbtn_conhang.Text = "Còn hàng";
            this.rbtn_conhang.UseVisualStyleBackColor = true;
            // 
            // rbtn_hethang
            // 
            this.rbtn_hethang.AutoSize = true;
            this.rbtn_hethang.Location = new System.Drawing.Point(284, 129);
            this.rbtn_hethang.Name = "rbtn_hethang";
            this.rbtn_hethang.Size = new System.Drawing.Size(91, 24);
            this.rbtn_hethang.TabIndex = 5;
            this.rbtn_hethang.TabStop = true;
            this.rbtn_hethang.Text = "Hết hàng";
            this.rbtn_hethang.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_hethang);
            this.Controls.Add(this.rbtn_conhang);
            this.Controls.Add(this.dtgv_chatlieu);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "FrmChatLieu";
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chatlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dtgv_chatlieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.RadioButton rbtn_conhang;
        private System.Windows.Forms.RadioButton rbtn_hethang;
        private System.Windows.Forms.Label label6;
    }
}