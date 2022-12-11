using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmThongTinHD : Form
    {
        private IHoaDonChiTietServices _hoaDonChiTietServices;
        private ICHoaDonServices _cHoaDonServices;
        private IChiTietSPServices _chiTietSPServices;
        private INhanVienServices _nhanVienServices;
        private IKhachHangServices _khachHangServices;
        private ICuaHangServices _cuaHangServices;
        private Guid _ID;
        private PrintDialog printDialog;
        private PrintDocument printDocument;
        public FrmThongTinHD(Guid id)
        {
            InitializeComponent();
            _chiTietSPServices = new ChiTietSPServices();
            _nhanVienServices = new NhanVienServices();
            _khachHangServices = new KhachHangServices();
            _cHoaDonServices = new HoaDonServices();
            _cuaHangServices = new CuaHangServices();
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            loadHDCT(_ID);
            this._ID = id;
            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
        }
        public void loadHDCT(Guid id)
        {
            _ID = id;
            dataGridView1.Rows.Clear();
            foreach (var item in _hoaDonChiTietServices.GetAll(id))
            {
                dataGridView1.Rows.Add(item.IdChiTietSp, item.TenSP, item.SoLuong, item.DonGia);
            }
        }
        private void FrmThongTinHD_Load(object sender, EventArgs e)
        {
            var hd = _cHoaDonServices.GetAll().FirstOrDefault(c => c.Id == _ID);
            var nv = _nhanVienServices.GetNhanViens().FirstOrDefault(c => c.ID == hd.IdNv);
            var kh = _khachHangServices.GetAll().FirstOrDefault(c => c.Id == hd.IdKh);
            var ch = _cuaHangServices.GetAll().FirstOrDefault(c => c.ID == nv.IDCH);
            lbl_id.Text = _ID.ToString();
            lbl_ma.Text = hd.Ma;
            lbl_kh.Text = kh.Ho + " " + kh.TenDem + " " + kh.Ten;
            lbl_nv.Text = nv.Ho + " " + nv.TenDem + " " + nv.Ten;
            lbl_ch.Text = ch.Ten;
            lbl_dc.Text = ch.DiaChi;
            lbl_tien.Text = hd.ThanhTien.ToString();
            loadHDCT(_ID);
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var hd = _cHoaDonServices.GetAll().FirstOrDefault(c => c.Id == _ID);
            var nv = _nhanVienServices.GetNhanViens().FirstOrDefault(c => c.ID == hd.IdNv);
            var kh = _khachHangServices.GetAll().FirstOrDefault(c => c.Id == hd.IdKh);
            e.Graphics.DrawString("Welcome to " + lbl_ch.Text, new Font("Arial", 15), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString(lbl_dc.Text, new Font("Arial", 10), Brushes.Black, new Point(300, 130));
            e.Graphics.DrawString("REG :", new Font("Arial", 10), Brushes.Black, new Point(300, 150));
            e.Graphics.DrawString(hd.NgayTao.ToString(), new Font("Arial", 10), Brushes.Black, new Point(370, 150));
            e.Graphics.DrawString("..............................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 160));
            e.Graphics.DrawString("Mã Hóa Đơn :", new Font("Arial", 10), Brushes.Black, new Point(300, 180));
            e.Graphics.DrawString(hd.Ma, new Font("Arial", 10), Brushes.Black, new Point(420, 180));
            e.Graphics.DrawString("Tên Khách Hàng", new Font("Arial", 10), Brushes.Black, new Point(300, 200));
            e.Graphics.DrawString(lbl_kh.Text, new Font("Arial", 10), Brushes.Black, new Point(420, 200));
            e.Graphics.DrawString("..............................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 220));
            e.Graphics.DrawString("Sản phẩm", new Font("Arial", 10), Brushes.Black, new Point(300, 240));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 10), Brushes.Black, new Point(400, 240));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 10), Brushes.Black, new Point(500, 240));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 10), Brushes.Black, new Point(600, 240));
            int i = 0;
            foreach (var item in _hoaDonChiTietServices.GetAll(_ID))
            {
                int x = 260;
                int y = 261;
                e.Graphics.DrawString(item.TenSP.ToString(), new Font("Arial", 10), Brushes.Black, new Point(300, x + (i * 45)));
                e.Graphics.DrawString(item.SoLuong.ToString(), new Font("Arial", 10), Brushes.Black, new Point(400, y + (i * 45)));
                e.Graphics.DrawString(item.DonGia.ToString(), new Font("Arial", 10), Brushes.Black, new Point(500, y + (i * 45)));
                e.Graphics.DrawString(item.thanhTien.ToString(), new Font("Arial", 10), Brushes.Black, new Point(600, y + (i * 45)));
                i++;
            }
            e.Graphics.DrawString(".....................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 400));
            int sl = _hoaDonChiTietServices.GetAll(_ID).Count;
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 15), Brushes.Black, new Point(300, 245 + ((sl + 1) * 45)));
            e.Graphics.DrawString(lbl_tien.Text, new Font("Arial", 15), Brushes.Black, new Point(470, 245 + ((sl + 1) * 45)));
            e.Graphics.DrawString("CẢM ƠN QUÝ KHÁCH", new Font("Arial", 10), Brushes.Black, new Point(300, 295 + ((sl + 1) * 45)));
            e.Graphics.DrawString("HẸN GẶP LẠI!", new Font("Arial", 10), Brushes.Black, new Point(300, 315 + ((sl + 1) * 45)));
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            this.printDialog.Document = this.printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
