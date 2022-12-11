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
    public partial class FrmDoiMK : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmDoiMK()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }

        private void anButtons1_Click(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.MaNV == Properties.Settings.Default.TKdaLogin).IdNv;
            var id = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == idRole);
            if (tb_mkc.Text != id.MatKhau)
            {
                MessageBox.Show("Sai mật khẩu vui lòng nhập lại");
            }
            else if (tb_mkm.Text != tb_nlmk.Text)
            {
                MessageBox.Show("Sai mật khẩu mới vui lòng nhập lại");
            }
            else
            {
                var p = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == idRole);
                p.MatKhau = tb_mkm.Text;
                _nhanVienServices.updateSanPhamChiTiets(p);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }
    }
}
