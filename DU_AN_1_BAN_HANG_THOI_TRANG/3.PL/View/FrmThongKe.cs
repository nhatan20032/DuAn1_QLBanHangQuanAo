using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
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
    public partial class FrmThongKe : Form
    {
        private IHoaDonChiTietServices _hoaDonChiTietServices;
        private ICHoaDonServices _cHoaDonServices;
        private INhanVienServices _nhanVienServices;
        private IKhachHangServices _khachHangServices;
        private IChiTietSPServices _chiTietSPServices;
        public List<ViewHoaDon> _lstOrder;
        public List<HoaDonChiTiet> _lstOrderDetail;
        public List<KhachHang> _lstCustomer;
        public FrmThongKe()
        {
            _cHoaDonServices = new HoaDonServices();
            _nhanVienServices = new NhanVienServices();
            _khachHangServices = new KhachHangServices();
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            _chiTietSPServices = new ChiTietSPServices();
            _lstOrder = _cHoaDonServices.GetAll();
            InitializeComponent();
            loadDate();
        }
        public void loadDate()
        {
            for (int i = 1; i < 13; i++)
            {
                cmb_Thang.Items.Add(i);
            }
            var x = Convert.ToInt32(_cHoaDonServices.GetAll().First().NgayTao.ToString("yyyy"));
            var y = Convert.ToInt32(_cHoaDonServices.GetAll().Last().NgayTao.ToString("yyyy"));
            for (int i = x; i <= y; i++)
            {
                cmb_Nam.Items.Add(i);
            }
            //if (cmb_Thang.Text == "1" || cmb_Thang.Text == "3" || cmb_Thang.Text == "5" || cmb_Thang.Text == "7" || cmb_Thang.Text == "8" || cmb_Thang.Text == "10" || cmb_Thang.Text == "12")
            //{
            //    for (int i = 1; i <= 31; i++)
            //    {
            //        cbx_ngay.Items.Add(i);
            //    }
            //}
            //else if (cmb_Thang.Text == "2" )
            //{
            //    if (Convert.ToInt32(cmb_Nam.Text) % 4 == 0)
            //    {
            //        for (int i = 1; i < 30; i++)
            //        {
            //            cbx_ngay.Items.Add(i);
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 1; i < 29; i++)
            //        {
            //            cbx_ngay.Items.Add(i);
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i < 31; i++)
            //    {
            //        cbx_ngay.Items.Add(i);
            //    }
            //}
        }
        public void loadData()
        {
            dgrid_Show.Rows.Clear();
            var x = (from a in _lstOrder
                     join b in _khachHangServices.GetAll() on a.IdKh equals b.Id
                     join c in _hoaDonChiTietServices.GetAll() on a.Id equals c.IdHoaDon
                     join d in _chiTietSPServices.GetViewChiTietSps() on c.IdChiTietSp equals d.ID
                     where b.Sdt.Contains(txt_sdt.Text) && d.TenSP.ToLower().Contains(txt_TK.Text.ToLower())
                     select new { a, b, c, d });

            foreach (var i in x)
            {
                dgrid_Show.Rows.Add(i.a.Id, i.d.TenSP, i.c.SoLuong, i.c.DonGia, i.c.SoLuong * i.c.DonGia, i.b.Sdt == "0" ? "Khách vãng lai" : i.b.Sdt);
            }

            lbl_DoanhThu.Text = x.Select(x => x.a).Distinct().Sum(x => x.ThanhTien).ToString();
            lbl_HD.Text = x.GroupBy(x => x.a).Count().ToString();
            lbl_HDCTT.Text = x.Select(x => x.a).Distinct().Where(x => x.TrangThai != 1).Count().ToString();
            lbl_KH.Text = x.GroupBy(x => x.b).Count().ToString();
        }
        private void date_Ngay_ValueChanged(object sender, EventArgs e)
        {
                 //_lstOrder = _cHoaDonServices.GetAll().Where(x => x.NgayTao.ToString("dd-MM-yyyy") == date_Ngay.Value.ToString("dd-MM-yyyy")).ToList();
                dgrid_Show.Rows.Clear();
                var x = (from a in _cHoaDonServices.GetAll().Where(x => x.NgayTao.ToString("dd-MM-yyyy") == date_Ngay.Value.ToString("dd-MM-yyyy")).ToList()
                         join b in _khachHangServices.GetAll() on a.IdKh equals b.Id
                         join c in _hoaDonChiTietServices.GetAll() on a.Id equals c.IdHoaDon
                         join d in _chiTietSPServices.GetViewChiTietSps() on c.IdChiTietSp equals d.ID
                         where b.Sdt.Contains(txt_sdt.Text) && d.TenSP.ToLower().Contains(txt_TK.Text.ToLower())
                         select new { a, b, c, d });

                foreach (var i in x)
                {
                    dgrid_Show.Rows.Add(i.a.Id, i.d.TenSP, i.c.SoLuong, i.c.DonGia, i.c.SoLuong * i.c.DonGia, i.b.Sdt == "0" ? "Khách vãng lai" : i.b.Sdt);
                }

                lbl_DoanhThu.Text = x.Select(x => x.a).Distinct().Sum(x => x.ThanhTien).ToString();
                lbl_HD.Text = x.GroupBy(x => x.a).Count().ToString();
                lbl_HDCTT.Text = x.Select(x => x.a).Distinct().Where(x => x.TrangThai != 1).Count().ToString();
                lbl_KH.Text = x.GroupBy(x => x.b).Count().ToString();
        }

        private void cmb_Thang_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Nam.Text != "")
            {
                _lstOrder = _cHoaDonServices.GetAll().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text)).ToList();
                loadData();
            }
        }

        private void cmb_Nam_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Thang.Text != "")
            {
                _lstOrder = _cHoaDonServices.GetAll().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text)).ToList();
                loadData();
            }
            else
            {
                _lstOrder = _cHoaDonServices.GetAll().Where(x => x.NgayTao.Year.ToString() == cmb_Nam.Text).ToList();
                loadData();
            }
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_sdt.Text, out int x) || txt_sdt.Text.Length <= 10)
            {
                loadData();
            }
            else
            {
                dgrid_Show.Rows.Clear();
            }
        }

        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbx_ngay_TextChanged(object sender, EventArgs e)
        {
            //if (cmb_Thang.Text != "" && cmb_Nam.Text != "")
            //{
            //    _lstOrder = _cHoaDonServices.GetAll().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text && x.NgayTao.Date.ToString() == cbx_ngay.Text)).ToList();
            //    loadData();
            //}
        }
    }
}
