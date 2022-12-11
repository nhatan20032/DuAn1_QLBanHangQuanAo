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
    public partial class FrmThuongHieu : Form
    {
        private IThuongHieuServices _ithuongHieuServices;
        private Guid _id;
        private ThuongHieu _th;
        public FrmThuongHieu()
        {
            _ithuongHieuServices = new ThuongHieuServices();
            InitializeComponent();
            LoadDataFormDb();
            rbtn_DangCungCap.Checked = true;
        }
        public void LoadDataFormDb()
        {
            dgrid_ThuongHieu.ColumnCount = 5;
            dgrid_ThuongHieu.Columns[0].Name = "Id";
            dgrid_ThuongHieu.Columns[0].Visible = false;
            dgrid_ThuongHieu.Columns[1].Name = "Mã";
            dgrid_ThuongHieu.Columns[2].Name = "Tên thương hiệu";
            dgrid_ThuongHieu.Columns[3].Name = "Mô tả";
            dgrid_ThuongHieu.Columns[4].Name = "Trạng thái";
            dgrid_ThuongHieu.Rows.Clear();
            foreach (var x in _ithuongHieuServices.GetAll())
            {
                dgrid_ThuongHieu.Rows.Add(x.ID, x.Ma, x.Ten, x.MoTa, x.TrangThai == 1 ? "Đang cung cấp" : "Ngừng cung cấp");
            }
        }
        public void LoadDataFormDb(string input)
        {
            dgrid_ThuongHieu.ColumnCount = 5;
            dgrid_ThuongHieu.Columns[0].Name = "Id";
            dgrid_ThuongHieu.Columns[1].Name = "Mã";
            dgrid_ThuongHieu.Columns[2].Name = "Tên thương hiệu";
            dgrid_ThuongHieu.Columns[3].Name = "Mô tả";
            dgrid_ThuongHieu.Columns[4].Name = "Trạng thái";
            dgrid_ThuongHieu.Rows.Clear();
            foreach (var x in _ithuongHieuServices.GetAll(input))
            {
                dgrid_ThuongHieu.Rows.Add(x.ID, x.Ma, x.Ten, x.MoTa, x.TrangThai == 1 ? "Đang cung cấp" : "Ngừng cung cấp");
            }
        }
        public void Reset()
        {
            LoadDataFormDb();
            _th = null;
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_MoTa.Text = "";
            rbtn_DangCungCap.Checked = false;
            rbtn_NgungCungCap.Checked = true;
        }
        public bool checknhap()
        {
            if (txt_Ma.Text == "" || txt_Ten.Text == "" ) return false;
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var p = _ithuongHieuServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Thương hiệu đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Thương hiệu không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var th = new ThuongHieu()
                    {
                        ID = new Guid(),
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        MoTa = txt_MoTa.Text,
                        TrangThai = rbtn_DangCungCap.Checked ? 1 : 0,

                    };
                    _ithuongHieuServices.Add(th);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_th == null)
            {
                MessageBox.Show("Không tìm thấy mã Cửa hàng", "Cảnh báo");
            }
            else if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn Sửa Cửa hàng không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (_th.Ma == txt_Ma.Text || _th.Ma != txt_Ma.Text && _ithuongHieuServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
                    {
                        _th.Ma = txt_Ma.Text;
                        _th.Ten = txt_Ten.Text;
                        _th.MoTa = txt_MoTa.Text;
                        _th.TrangThai = rbtn_DangCungCap.Checked ? 1 : 0;
                        _ithuongHieuServices.Update(_th);
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Cửa hàng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_th == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _ithuongHieuServices.Delete(_th);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataFormDb(txt_TimKiem.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgrid_ThuongHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                _id = Guid.Parse(dgrid_ThuongHieu.Rows[row].Cells[0].Value.ToString());
                _th = _ithuongHieuServices.GetAll().FirstOrDefault(c => c.ID == _id);
                txt_Ma.Text = _th.Ma;
                txt_Ten.Text = _th.Ten;
                txt_MoTa.Text = _th.MoTa;
                rbtn_DangCungCap.Checked = dgrid_ThuongHieu.Rows[row].Cells[4].Value.ToString() == "Đang cung cấp";
                rbtn_NgungCungCap.Checked = dgrid_ThuongHieu.Rows[row].Cells[4].Value.ToString() == "Ngừng cung cấp";
            }
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            txt_Ma.Text ="TH"+ Utilities.GetMaTuSinh(txt_Ten.Text) + (_ithuongHieuServices.GetAll().Count + 1);
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            txt_Ten.Text = Utilities.VietHoaChuCaiDau(txt_Ten.Text);
        }
    }
}
