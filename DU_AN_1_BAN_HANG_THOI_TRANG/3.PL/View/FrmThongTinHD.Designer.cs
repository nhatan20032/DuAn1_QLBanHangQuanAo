namespace _3.PL.View
{
    partial class FrmThongTinHD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ma = new System.Windows.Forms.Label();
            this.lbl_dc = new System.Windows.Forms.Label();
            this.lbl_ch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nv = new System.Windows.Forms.Label();
            this.lbl_kh = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_in = new _3.PL.Custom.AnButtons();
            this.lbl_tien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.SoLuong,
            this.DonGia});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(471, 171);
            this.dataGridView1.TabIndex = 2;
            // 
            // lbl_ma
            // 
            this.lbl_ma.AutoSize = true;
            this.lbl_ma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ma.Location = new System.Drawing.Point(208, 85);
            this.lbl_ma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ma.Name = "lbl_ma";
            this.lbl_ma.Size = new System.Drawing.Size(45, 19);
            this.lbl_ma.TabIndex = 3;
            this.lbl_ma.Text = "label3";
            // 
            // lbl_dc
            // 
            this.lbl_dc.AutoSize = true;
            this.lbl_dc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dc.Location = new System.Drawing.Point(192, 34);
            this.lbl_dc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dc.Name = "lbl_dc";
            this.lbl_dc.Size = new System.Drawing.Size(50, 19);
            this.lbl_dc.TabIndex = 4;
            this.lbl_dc.Text = "Địa chỉ";
            // 
            // lbl_ch
            // 
            this.lbl_ch.AutoSize = true;
            this.lbl_ch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ch.Location = new System.Drawing.Point(192, 15);
            this.lbl_ch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ch.Name = "lbl_ch";
            this.lbl_ch.Size = new System.Drawing.Size(59, 21);
            this.lbl_ch.TabIndex = 5;
            this.lbl_ch.Text = "Tên ch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Nhân Viên :";
            // 
            // lbl_nv
            // 
            this.lbl_nv.AutoSize = true;
            this.lbl_nv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nv.Location = new System.Drawing.Point(208, 120);
            this.lbl_nv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nv.Name = "lbl_nv";
            this.lbl_nv.Size = new System.Drawing.Size(45, 19);
            this.lbl_nv.TabIndex = 7;
            this.lbl_nv.Text = "label7";
            // 
            // lbl_kh
            // 
            this.lbl_kh.AutoSize = true;
            this.lbl_kh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kh.Location = new System.Drawing.Point(208, 155);
            this.lbl_kh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kh.Name = "lbl_kh";
            this.lbl_kh.Size = new System.Drawing.Size(45, 19);
            this.lbl_kh.TabIndex = 8;
            this.lbl_kh.Text = "label8";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.Location = new System.Drawing.Point(208, 59);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 19);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "id";
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_in.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_in.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_in.BorderRadius = 20;
            this.btn_in.BorderSize = 0;
            this.btn_in.FlatAppearance.BorderSize = 0;
            this.btn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in.ForeColor = System.Drawing.Color.White;
            this.btn_in.Image = global::_3.PL.Properties.Resources.invoice3;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(348, 186);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(123, 27);
            this.btn_in.TabIndex = 47;
            this.btn_in.Text = "in";
            this.btn_in.TextColor = System.Drawing.Color.White;
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // lbl_tien
            // 
            this.lbl_tien.AutoSize = true;
            this.lbl_tien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tien.Location = new System.Drawing.Point(208, 190);
            this.lbl_tien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tien.Name = "lbl_tien";
            this.lbl_tien.Size = new System.Drawing.Size(45, 19);
            this.lbl_tien.TabIndex = 49;
            this.lbl_tien.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Thành Tiền :";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            // 
            // FrmThongTinHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(471, 389);
            this.Controls.Add(this.lbl_tien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_kh);
            this.Controls.Add(this.lbl_nv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ch);
            this.Controls.Add(this.lbl_dc);
            this.Controls.Add(this.lbl_ma);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmThongTinHD";
            this.Text = "FrmThongTinHD";
            this.Load += new System.EventHandler(this.FrmThongTinHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ma;
        private System.Windows.Forms.Label lbl_dc;
        private System.Windows.Forms.Label lbl_ch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nv;
        private System.Windows.Forms.Label lbl_kh;
        private System.Windows.Forms.Label lbl_id;
        private Custom.AnButtons btn_in;
        private System.Windows.Forms.Label lbl_tien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}