namespace _3.PL.View
{
    partial class FrmThanhToan
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
            this.txt_MA = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgrid_ThanhToan = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.rbtn_Da = new System.Windows.Forms.RadioButton();
            this.rbtn_Chua = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // txt_MA
            // 
            this.txt_MA.Location = new System.Drawing.Point(97, 24);
            this.txt_MA.Name = "txt_MA";
            this.txt_MA.Size = new System.Drawing.Size(252, 27);
            this.txt_MA.TabIndex = 3;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(94, 85);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(255, 27);
            this.txt_Ten.TabIndex = 4;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(600, 217);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(199, 27);
            this.txt_TimKiem.TabIndex = 6;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimKiem_MouseClick);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            this.txt_TimKiem.MouseLeave += new System.EventHandler(this.txt_TimKiem_MouseLeave);
            // 
            // dgrid_ThanhToan
            // 
            this.dgrid_ThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ThanhToan.Location = new System.Drawing.Point(0, 262);
            this.dgrid_ThanhToan.Name = "dgrid_ThanhToan";
            this.dgrid_ThanhToan.RowHeadersWidth = 51;
            this.dgrid_ThanhToan.RowTemplate.Height = 29;
            this.dgrid_ThanhToan.Size = new System.Drawing.Size(800, 188);
            this.dgrid_ThanhToan.TabIndex = 7;
            this.dgrid_ThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ThanhToan_CellContentClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(600, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(200, 52);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(601, 77);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(199, 58);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(601, 146);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(198, 53);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // rbtn_Da
            // 
            this.rbtn_Da.AutoSize = true;
            this.rbtn_Da.Location = new System.Drawing.Point(105, 155);
            this.rbtn_Da.Name = "rbtn_Da";
            this.rbtn_Da.Size = new System.Drawing.Size(124, 24);
            this.rbtn_Da.TabIndex = 11;
            this.rbtn_Da.TabStop = true;
            this.rbtn_Da.Text = "Đã thanh toán";
            this.rbtn_Da.UseVisualStyleBackColor = true;
            // 
            // rbtn_Chua
            // 
            this.rbtn_Chua.AutoSize = true;
            this.rbtn_Chua.Location = new System.Drawing.Point(104, 194);
            this.rbtn_Chua.Name = "rbtn_Chua";
            this.rbtn_Chua.Size = new System.Drawing.Size(139, 24);
            this.rbtn_Chua.TabIndex = 12;
            this.rbtn_Chua.TabStop = true;
            this.rbtn_Chua.Text = "Chưa thanh toán";
            this.rbtn_Chua.UseVisualStyleBackColor = true;
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_Chua);
            this.Controls.Add(this.rbtn_Da);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgrid_ThanhToan);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_MA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThanhToan";
            this.Text = "FrmThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MA;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgrid_ThanhToan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.RadioButton rbtn_Da;
        private System.Windows.Forms.RadioButton rbtn_Chua;
    }
}