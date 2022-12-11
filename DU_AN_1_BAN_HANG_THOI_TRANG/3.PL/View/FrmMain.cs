using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmMain : Form
    {
        INhanVienServices _nhanVienServices;
        IChucVuServices _chucVuServices;
        public FrmMain()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
            _chucVuServices = new ChucVuServices();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.MaNV == Properties.Settings.Default.TKdaLogin).IdNv;
            var id = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == idRole).IDCV;
            var idcv = _chucVuServices.GetAll().FirstOrDefault(p => p.ID == id).Ten;
            if (idcv == "Sếp")
            {
                //btn_nhanvien.BackColor = Color.FromArgb(46, 51, 73);
                //btn_Hoadon.BackColor = Color.FromArgb(24, 30, 54);
                //btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
                //btn_sp.BackColor = Color.FromArgb(24, 30, 54);
                //btn_banhang.BackColor = Color.FromArgb(24, 30, 54);
                this.pnl_Load.Controls.Clear();
                FrmCV_NV frmQLNhanVien = new FrmCV_NV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnl_Load.Controls.Add(frmQLNhanVien);
                frmQLNhanVien.Show();
            }
            else if (idcv != "Sếp")
            {
                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
            }
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            //btn_khachhang.BackColor = Color.FromArgb(46, 51, 73);
            //btn_Hoadon.BackColor = Color.FromArgb(24, 30, 54);
            //btn_sp.BackColor = Color.FromArgb(24, 30, 54);
            //btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
            //btn_banhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_ThongKe.BackColor = Color.FromArgb(24, 30, 54);
            this.pnl_Load.Controls.Clear();
            FrmKhachHang frmQLKhachHang = new FrmKhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Load.Controls.Add(frmQLKhachHang);
            frmQLKhachHang.Show();
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            //btn_sp.BackColor = Color.FromArgb(46, 51, 73);
            //btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
            //btn_Hoadon.BackColor = Color.FromArgb(24, 30, 54);
            //btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_banhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_ThongKe.BackColor = Color.FromArgb(24, 30, 54);
            this.pnl_Load.Controls.Clear();
            FrmQuanLy frmQLChiTietSP = new FrmQuanLy() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Load.Controls.Add(frmQLChiTietSP);
            frmQLChiTietSP.Show();
        }

        private void btn_Hoadon_Click(object sender, EventArgs e)
        {
            //btn_Hoadon.BackColor = Color.FromArgb(46, 51, 73);
            //btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
            //btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_sp.BackColor = Color.FromArgb(24, 30, 54);
            //btn_banhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_ThongKe.BackColor = Color.FromArgb(24, 30, 54);
            this.pnl_Load.Controls.Clear();
            FrmHoaDon frmHoaDon = new FrmHoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Load.Controls.Add(frmHoaDon);
            frmHoaDon.Show();
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            //btn_banhang.BackColor = Color.FromArgb(46, 51, 73);
            //btn_Hoadon.BackColor = Color.FromArgb(24, 30, 54);
            //btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
            //btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_ThongKe.BackColor = Color.FromArgb(24, 30, 54);
            //btn_sp.BackColor = Color.FromArgb(24, 30, 54);
            this.pnl_Load.Controls.Clear();
            FrmBanHang frmBanHang = new FrmBanHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Load.Controls.Add(frmBanHang);
            frmBanHang.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            //btn_banhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_Hoadon.BackColor = Color.FromArgb(24, 30, 54);
            //btn_sp.BackColor = Color.FromArgb(24, 30, 54);
            //btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
            //btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
            //btn_ThongKe.BackColor = Color.FromArgb(46, 51, 73);
            this.pnl_Load.Controls.Clear();
            FrmThongKe frmThongKe = new FrmThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Load.Controls.Add(frmThongKe);
            frmThongKe.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            this.pnl_Load.Controls.Clear();
            FrmThongTinNhanVien frmBanHang = new FrmThongTinNhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Load.Controls.Add(frmBanHang);
            frmBanHang.Show();
        }
    }
}
