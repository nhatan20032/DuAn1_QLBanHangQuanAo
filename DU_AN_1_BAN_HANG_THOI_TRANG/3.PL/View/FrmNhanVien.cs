using _1.DAL.ConText;
using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using _3.PL.Utilitis;
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
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _INhanVienServices;
        private IChucVuServices _IChucVuServices;
        private ICuaHangServices _ICuaHangServices;
        private Guid IdNhanvien;
        private NhanVien _nv;
        private List<ViewNhanVien> _lstViewNhanVien;
        string linkanh = "";

        public FrmNhanVien()
        {
            _INhanVienServices = new NhanVienServices();
            _IChucVuServices = new ChucVuServices();
            _ICuaHangServices = new CuaHangServices();
            _lstViewNhanVien = new List<ViewNhanVien>();
            InitializeComponent();
            loadData();
            loadcbx();
            rdb_danglam.Checked = true;
        }
        public void loadData()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 15;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã NV";
            dtg_show.Columns[2].Name = "Họ và tên";
            dtg_show.Columns[3].Name = "Giới tính";
            dtg_show.Columns[4].Name = "Ngày sinh";
            dtg_show.Columns[5].Name = "CCCD";
            dtg_show.Columns[6].Name = "SDT";
            dtg_show.Columns[7].Name = "Email";
            dtg_show.Columns[8].Name = "Mật khẩu";
            dtg_show.Columns[9].Name = "Tên cửa hàng";
            dtg_show.Columns[10].Name = "Chức vụ";
            dtg_show.Columns[11].Name = "Địa chỉ";
            dtg_show.Columns[12].Name = "Thành phố";
            dtg_show.Columns[13].Name = "Quốc gia";
            dtg_show.Columns[14].Name = "Trạng thái";
            _lstViewNhanVien = _INhanVienServices.GetViewChiTietSps();
            if (tb_timkiem.Text != "")
            {
                _lstViewNhanVien = _lstViewNhanVien.Where(p => p.MaNV.Contains(tb_timkiem.Text) || p.Ten.Contains(tb_timkiem.Text)).ToList();
            }
            foreach (var item in _lstViewNhanVien)
            {
                dtg_show.Rows.Add(item.IdNv, item.MaNV, string.Concat(item.Ho + " " + item.TenDem + " " + item.Ten), item.GioiTinh, item.NgaySinh, item.CMND, item.SDT, item.Email, item.MatKhau, item.TenCuaHang, item.ChucVu, item.DiaChi, item.ThanhPho, item.QuocGia, item.TrangThai == 1 ? "Làm việc" : "Nghỉ việc");
            }
        }
        public void reset()
        {
            loadData();
            tb_Ma.Text = "";
            tb_ho.Text = "";
            tb_tendem.Text = "";
            tb_ten.Text = "";
            tb_sdt.Text = "";
            tb_cccd.Text = "";
            tb_diachi.Text = "";
            tb_thanhpho.Text = "";
            tb_email.Text = "";
            tb_quocgia.Text = "";
            tb_matkhau.Text = "";
            rdb_danglam.Checked = true;
            rdb_dangnghi.Checked = false;
            cbx_chucvu.Text = "";
            cbx_cuahang.Text = "";
            cbx_gioitinh.Text = "";
        }
        public void loadcbx()
        {
            foreach (var item in _IChucVuServices.GetAll())
            {
                cbx_chucvu.Items.Add(item.Ten);
            }
            foreach (var item in _ICuaHangServices.GetAll())
            {
                cbx_cuahang.Items.Add(item.Ten);
            }
        }
        public bool checknhap()
        {
            if (tb_matkhau.Text == "" || tb_diachi.Text == "" || tb_ten.Text == "" || tb_thanhpho.Text == "" || tb_Ma.Text == "" || tb_ho.Text == "" || tb_email.Text == "" || tb_cccd.Text == "" || tb_sdt.Text == "" || cbx_chucvu.Text == "" || cbx_cuahang.Text == "" || cbx_gioitinh.Text == "") return false;
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var ch = _ICuaHangServices.GetAll().FirstOrDefault(p => p.Ten == cbx_cuahang.Text);
            var cv = _IChucVuServices.GetAll().FirstOrDefault(p => p.Ten == cbx_chucvu.Text);
            var p = _INhanVienServices.GetNhanViens().FirstOrDefault(c => c.Ma == tb_Ma.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(linkanh)), true);
            linkanh = Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(linkanh));
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Nhân viên không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ViewNhanVien nv = new ViewNhanVien()
                    {
                        IDCH = ch.ID,
                        IDCV = cv.ID,
                        MaNV = tb_Ma.Text,
                        Ho = tb_ho.Text,
                        MatKhau = tb_matkhau.Text,
                        AnhNV = linkanh,
                        TenDem = tb_tendem.Text,
                        Ten = tb_ten.Text,
                        GioiTinh = cbx_gioitinh.Text,
                        NgaySinh = dtp_dob.Value,
                        CMND = tb_cccd.Text,
                        SDT = tb_sdt.Text,
                        Email = tb_email.Text,
                        DiaChi = tb_diachi.Text,
                        ThanhPho = tb_thanhpho.Text,
                        QuocGia = tb_quocgia.Text,
                        TrangThai = rdb_danglam.Checked ? 1 : 0,
                    };
                    _INhanVienServices.addSanPhamChiTiet(nv);
                    MessageBox.Show("Thêm thành công");
                    reset();
                }
            }
        }
        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                IdNhanvien = Guid.Parse(dtg_show.Rows[e.RowIndex].Cells[0].Value.ToString());
                _nv = _INhanVienServices.GetNhanViens().FirstOrDefault(p => p.ID == IdNhanvien);
                tb_Ma.Text = _nv.Ma;
                tb_ho.Text = _nv.Ho;
                tb_tendem.Text = _nv.TenDem;
                tb_ten.Text = _nv.Ten;
                cbx_cuahang.Text = _ICuaHangServices.GetAll().FirstOrDefault(p => p.ID == _nv.IDCH).Ten;
                cbx_chucvu.Text = _IChucVuServices.GetAll().FirstOrDefault(p => p.ID == _nv.IDCV).Ten;
                tb_cccd.Text = _nv.CMND;
                tb_sdt.Text = _nv.SDT;
                cbx_gioitinh.Text = _nv.GioiTinh;
                tb_matkhau.Text = _nv.MatKhau;
                tb_diachi.Text = _nv.DiaChi;
                tb_email.Text = _nv.Email;
                tb_quocgia.Text = _nv.QuocGia;
                tb_thanhpho.Text = _nv.ThanhPho;
                dtp_dob.Value = _nv.NgaySinh;
                linkanh = _nv.AnhNV;
                if (linkanh != null && File.Exists(linkanh))
                {
                    pictureBox1.Image = Image.FromFile(linkanh);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }
                if (_nv.TrangThai == 1)
                {
                    rdb_danglam.Checked = true;
                }
                else
                {
                    rdb_dangnghi.Checked = true;
                }
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            var ch = _ICuaHangServices.GetAll().FirstOrDefault(p => p.Ten == cbx_cuahang.Text);
            var cv = _IChucVuServices.GetAll().FirstOrDefault(p => p.Ten == cbx_chucvu.Text);
            var _product = _INhanVienServices.GetViewChiTietSps().FirstOrDefault(p => p.MaNV == tb_Ma.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(linkanh)), true);
            linkanh = Path.Combine(projectDirectory, "Resources", "SanPham", Path.GetFileName(linkanh));
            if (_product == null)
            {
                MessageBox.Show("Không tìm thấy mã Nhân viên", "Cảnh báo");
            }
            else
            {
                if (checknhap() == false)
                {
                    MessageBox.Show("Không được để trống các trường", "Chú ý");
                }
                else
                {
                    OpenFileDialog op = new OpenFileDialog();
                    DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật Nhân viên không?", "Chú ý", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        ViewNhanVien nv = new ViewNhanVien()
                        {
                            IdNv = IdNhanvien,
                            IDCH = ch.ID,
                            IDCV = cv.ID,
                            MaNV = tb_Ma.Text,
                            Ho = tb_ho.Text,
                            AnhNV = linkanh,
                            TenDem = tb_tendem.Text,
                            MatKhau = tb_matkhau.Text,
                            Ten = tb_ten.Text,
                            GioiTinh = cbx_gioitinh.Text,
                            Email = tb_email.Text,
                            NgaySinh = dtp_dob.Value,
                            CMND = tb_cccd.Text,
                            SDT = tb_sdt.Text,
                            DiaChi = tb_diachi.Text,
                            ThanhPho = tb_thanhpho.Text,
                            QuocGia = tb_quocgia.Text,
                            TrangThai = rdb_danglam.Checked ? 1 : 0,
                        };
                        _INhanVienServices.updateSanPhamChiTiet(nv);
                        MessageBox.Show("Sửa thành công");
                        reset();
                    }
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (IdNhanvien == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn Nhân viên để xóa");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Nhân viên không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dlg = MessageBox.Show("Chú ý", "Bạn có muốn xóa sp ko", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        _INhanVienServices.deleteSanPhamChiTiet(IdNhanvien);
                        reset();
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }



        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void tb_ho_TextChanged(object sender, EventArgs e)
        {
            tb_Ma.Text = Utilities.GetMaTuSinh(tb_ho.Text + " " + tb_tendem.Text + " " + tb_ten.Text) + (_INhanVienServices.GetNhanViens().Count + 1);
            tb_email.Text = tb_Ma.Text + "@fpt.edu.vn";
        }

        private void tb_tendem_TextChanged(object sender, EventArgs e)
        {
            tb_Ma.Text = Utilities.GetMaTuSinh(tb_ho.Text + " " + tb_tendem.Text + " " + tb_ten.Text) + (_INhanVienServices.GetNhanViens().Count + 1);
            tb_email.Text = tb_Ma.Text + "@fpt.edu.vn";
        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {
            tb_Ma.Text = Utilities.GetMaTuSinh(tb_ho.Text + " " + tb_tendem.Text + " " + tb_ten.Text) + (_INhanVienServices.GetNhanViens().Count + 1);
            tb_email.Text = tb_Ma.Text + "@fpt.edu.vn";
        }

        private void tb_cccd_Leave(object sender, EventArgs e)
        {
            Utilities.checkChu(tb_cccd.Text);
        }

        private void tb_ho_Leave(object sender, EventArgs e)
        {
            tb_ho.Text = Utilities.VietHoaChuCaiDau(tb_ho.Text);
            Utilities.CheckSo(tb_ho.Text);
        }

        private void tb_tendem_Leave(object sender, EventArgs e)
        {
            tb_tendem.Text = Utilities.VietHoaChuCaiDau(tb_tendem.Text);
            Utilities.CheckSo(tb_tendem.Text);
        }

        private void tb_ten_Leave(object sender, EventArgs e)
        {
            tb_ten.Text = Utilities.VietHoaChuCaiDau(tb_ten.Text);
            Utilities.CheckSo(tb_ten.Text);
        }

        private void tb_sdt_Leave(object sender, EventArgs e)
        {
            Utilities.CheckSDT(tb_sdt.Text);
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            Utilities.checkMail(tb_email.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                linkanh = op.FileName;
                pictureBox1.Image = Image.FromFile(op.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
