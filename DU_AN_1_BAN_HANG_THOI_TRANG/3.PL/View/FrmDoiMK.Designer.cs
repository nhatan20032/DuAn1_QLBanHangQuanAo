namespace _3.PL.View
{
    partial class FrmDoiMK
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
            this.anButtons1 = new _3.PL.Custom.AnButtons();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nlmk = new System.Windows.Forms.TextBox();
            this.tb_mkm = new System.Windows.Forms.TextBox();
            this.tb_mkc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // anButtons1
            // 
            this.anButtons1.BackColor = System.Drawing.Color.OrangeRed;
            this.anButtons1.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.anButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons1.BorderRadius = 20;
            this.anButtons1.BorderSize = 0;
            this.anButtons1.FlatAppearance.BorderSize = 0;
            this.anButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anButtons1.ForeColor = System.Drawing.Color.White;
            this.anButtons1.Location = new System.Drawing.Point(262, 156);
            this.anButtons1.Name = "anButtons1";
            this.anButtons1.Size = new System.Drawing.Size(150, 40);
            this.anButtons1.TabIndex = 15;
            this.anButtons1.Text = "Xác nhận";
            this.anButtons1.TextColor = System.Drawing.Color.White;
            this.anButtons1.UseVisualStyleBackColor = false;
            this.anButtons1.Click += new System.EventHandler(this.anButtons1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // tb_nlmk
            // 
            this.tb_nlmk.Location = new System.Drawing.Point(172, 127);
            this.tb_nlmk.Name = "tb_nlmk";
            this.tb_nlmk.Size = new System.Drawing.Size(240, 23);
            this.tb_nlmk.TabIndex = 11;
            // 
            // tb_mkm
            // 
            this.tb_mkm.Location = new System.Drawing.Point(172, 69);
            this.tb_mkm.Name = "tb_mkm";
            this.tb_mkm.Size = new System.Drawing.Size(240, 23);
            this.tb_mkm.TabIndex = 10;
            // 
            // tb_mkc
            // 
            this.tb_mkc.Location = new System.Drawing.Point(172, 15);
            this.tb_mkc.Name = "tb_mkc";
            this.tb_mkc.Size = new System.Drawing.Size(240, 23);
            this.tb_mkc.TabIndex = 9;
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(435, 226);
            this.Controls.Add(this.anButtons1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nlmk);
            this.Controls.Add(this.tb_mkm);
            this.Controls.Add(this.tb_mkc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoiMK";
            this.Text = "FrmDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.AnButtons anButtons1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nlmk;
        private System.Windows.Forms.TextBox tb_mkm;
        private System.Windows.Forms.TextBox tb_mkc;
    }
}