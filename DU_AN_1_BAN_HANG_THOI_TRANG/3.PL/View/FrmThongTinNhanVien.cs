using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmThongTinNhanVien : Form
    {
        INhanVienServices _nhanVienServices;
        string linkanh = "";
        public FrmThongTinNhanVien()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmDoiMK frmThongKe = new FrmDoiMK() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmThongKe);
            frmThongKe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmDoiEmail frmThongKe = new FrmDoiEmail() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmThongKe);
            frmThongKe.Show();
        }

        private void FrmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.MaNV == Properties.Settings.Default.TKdaLogin).IdNv;
            var id = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == idRole);
            label1.Text = id.Ho + " " + id.TenDem + " " + id.Ten;
            label2.Text = id.Email;
            label3.Text = id.SDT;
            label4.Text = id.DiaChi + " " + id.ThanhPho + " " + id.ThanhPho;
            linkanh = id.AnhNV;
            if (linkanh != null && File.Exists(linkanh))
            {
                pictureBox1.Image = Image.FromFile(linkanh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
