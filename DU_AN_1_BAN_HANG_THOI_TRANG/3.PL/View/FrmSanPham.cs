using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilitis;
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
    public partial class FrmSanPham : Form
    {
        private ISanPhamServices _isanPhamServices;
        private SanPham _sp;
        private Guid _id;
        public FrmSanPham()
        {
            _isanPhamServices = new SanPhamServices();
            InitializeComponent();
            LoadDataFormDb();
            rbtn_ConHang.Checked = true;
        }
        public void LoadDataFormDb()
        {
            dgrid_SP.ColumnCount = 4;
            dgrid_SP.Columns[0].Name = "Id";
            dgrid_SP.Columns[0].Visible = false;

            dgrid_SP.Columns[1].Name = "Mã";
            dgrid_SP.Columns[2].Name = "Tên SP";
            dgrid_SP.Columns[3].Name = "Trạng thái";
            dgrid_SP.Rows.Clear();
            foreach (var x in _isanPhamServices.GetAll())
            {
                dgrid_SP.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }

        public void LoadDataFormDb(string input)
        {
            dgrid_SP.ColumnCount = 4;
            dgrid_SP.Columns[0].Name = "Id";
            dgrid_SP.Columns[0].Visible = false;

            dgrid_SP.Columns[1].Name = "Mã";
            dgrid_SP.Columns[2].Name = "Tên SP";
            dgrid_SP.Columns[3].Name = "Trạng thái";
            dgrid_SP.Rows.Clear();
            foreach (var x in _isanPhamServices.GetAll(input))
            {
                dgrid_SP.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }
        public void Reset()
        {
            LoadDataFormDb();
            _sp = null;
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            rbtn_ConHang.Checked = false;
            rbtn_HetHang.Checked = true;
        }
        public bool checknhap()
        {
            if (txt_Ma.Text == "" || txt_Ten.Text == "" ) return false;
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var p = _isanPhamServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Sản phẩm đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Sản phẩm không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var sp = new SanPham()
                    {
                        ID = new Guid(),
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_ConHang.Checked ? 1 : 0,
                    };
                    _isanPhamServices.Add(sp);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_sp == null)
            {
                MessageBox.Show("Không tìm thấy mã Sản phẩm", "Cảnh báo");
            }
            else if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn Sửa Sản phẩm không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (_sp.Ma == txt_Ma.Text || _sp.Ma != txt_Ma.Text && _isanPhamServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
                    {
                        _sp.Ma = txt_Ma.Text;
                        _sp.Ten = txt_Ten.Text;
                        _sp.TrangThai = rbtn_ConHang.Checked ? 1 : 0;
                        _isanPhamServices.Update(_sp);
                        MessageBox.Show("Sửa thành công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_sp == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _isanPhamServices.Delete(_sp);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataFormDb(txt_TimKiem.Text);
        }

        private void dgrid_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                _id = Guid.Parse(dgrid_SP.Rows[rowindex].Cells[0].Value.ToString());
                _sp = _isanPhamServices.GetAll().FirstOrDefault(c => c.ID == _id);
                txt_Ma.Text = _sp.Ma;
                txt_Ten.Text = _sp.Ten;
                if (_sp.TrangThai == 1)
                {
                    rbtn_ConHang.Checked = true;
                }

                rbtn_HetHang.Checked = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            txt_Ma.Text ="SP"+ Utilities.GetMaTuSinh(txt_Ten.Text) +( _isanPhamServices.GetAll().Count+1);
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            txt_Ten.Text = Utilities.VietHoaChuCaiDau(txt_Ten.Text);
        }
    }
}
