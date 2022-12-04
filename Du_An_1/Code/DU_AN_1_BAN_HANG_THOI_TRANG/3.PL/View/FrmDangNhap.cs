using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmDangNhap : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmDangNhap()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }
        public void saveInfor()
        {
            if (cb_nmk.Checked == true)
            {
                Properties.Settings.Default.User = tb_taikhoan.Text;
                Properties.Settings.Default.Pass = tb_matkhau.Text;
                Properties.Settings.Default.TKdaLogin = tb_taikhoan.Text;
                Properties.Settings.Default.MKdaLogin = tb_matkhau.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Pass = "";
                Properties.Settings.Default.TKdaLogin = tb_taikhoan.Text;
                Properties.Settings.Default.MKdaLogin = tb_matkhau.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var login = _nhanVienServices.GetViewChiTietSps().Where(p => p.MaNV == tb_taikhoan.Text && p.MatKhau == tb_matkhau.Text).FirstOrDefault();
            if (login != null )
            {
                saveInfor();
                this.Hide();
                FrmBanHang frmBanHang = new FrmBanHang();
                frmBanHang.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmtk = new FrmTimKiem();
            frmtk.ShowDialog();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            //tb_taikhoan.Text = Properties.Settings.Default.User;
            //tb_matkhau.Text = Properties.Settings.Default.Pass;
            //if (Properties.Settings.Default.User != "")
            //{
            //    cb_nmk.Checked = true;
            //}
        }

        private void cb_nmk_CheckedChanged(object sender, EventArgs e)
        {
            //if (tb_taikhoan.Text != "" && tb_matkhau.Text != "")
            //{
            //    if (cb_nmk.Checked == true)
            //    {
            //        string use = tb_taikhoan.Text;
            //        string pass = tb_matkhau.Text;
            //        Properties.Settings.Default.User = use;
            //        Properties.Settings.Default.Pass = pass;
            //        Properties.Settings.Default.Save();
            //    }
            //    else
            //    {
            //        Properties.Settings.Default.Reset();
            //    }
            //}
        }
    }
}
