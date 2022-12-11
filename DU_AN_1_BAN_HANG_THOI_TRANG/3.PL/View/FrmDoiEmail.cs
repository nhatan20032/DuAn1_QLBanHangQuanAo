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
    public partial class FrmDoiEmail : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmDoiEmail()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.MaNV == Properties.Settings.Default.TKdaLogin).IdNv;
            var id = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == idRole);
            if (tb_EmailMoi.Text == id.Email)
            {
                MessageBox.Show("Email này đã tồn tại vui lòng nhập lại");
            }
            else
            {
                id.Email = tb_EmailMoi.Text;
                _nhanVienServices.updateSanPhamChiTiets(id);
                MessageBox.Show("Đổi Email thành công");
            }
        }

        private void FrmDoiEmail_Load(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.MaNV == Properties.Settings.Default.TKdaLogin).IdNv;
            var id = _nhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == idRole);
            tb_Email.Text = id.Email;
        }
    }
}
