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
    public partial class FrmMauSac : Form
    {
        IMauSacServices _ImausacSer;
        MauSac _ms;
        public FrmMauSac()
        {
            InitializeComponent();
            _ImausacSer = new MauSacServices();
            _ms = new MauSac();
            LoadData();
            rd_hoatdong.Checked = true;
        }
        private void LoadData()
        {
            dtg_show.ColumnCount = 4;
            dtg_show.Rows.Clear();
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            foreach (var a in _ImausacSer.GetAll())
            {
                dtg_show.Rows.Add(a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void LoadData(string intput)
        {
            dtg_show.ColumnCount = 4;
            dtg_show.Rows.Clear();
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            foreach (var a in _ImausacSer.GetAll(intput))
            {
                dtg_show.Rows.Add(a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void Reset()
        {
            LoadData();
            _ms = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            rd_khonghoatdong.Checked = false;
            rd_hoatdong.Checked = false;
        }
        public bool checknhap()
        {
            if (tb_ma.Text == "" || tb_ten.Text == "") return false;
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var p = _ImausacSer.GetAll().FirstOrDefault(x => x.Ma == tb_ma.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã Màu sắc đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Màu sắc không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var a = new MauSac()
                    {
                        ID = new Guid(),
                        Ma = tb_ma.Text,
                        Ten = tb_ten.Text,
                        TrangThai = rd_hoatdong.Checked == true ? 1 : 0
                    };
                    _ImausacSer.Add(a);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_ms == null)
            {
                MessageBox.Show("Không tìm thấy mã Màu sắc", "Cảnh báo");
            }
            else if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn Sửa Màu sắc không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    _ms.Ma = tb_ma.Text;
                    _ms.Ten = tb_ten.Text;
                    _ms.TrangThai = rd_hoatdong.Checked == true ? 1 : 0;
                    _ImausacSer.Update(_ms);
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Ok đã hủy thao tác sửa");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Cửa hàng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_ms == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _ImausacSer.Remove(_ms);
                    MessageBox.Show("Xóa màu sắc thành công");
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác xóa");
            }
        }



        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(tb_timkiem.Text);
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _ms = _ImausacSer.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
                rd_hoatdong.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
                rd_khonghoatdong.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {
            tb_ma.Text = "MS"+ Utilities.GetMaTuSinh(tb_ten.Text) + (_ImausacSer.GetAll().Count+1);
        }

        private void tb_ten_Leave(object sender, EventArgs e)
        {
            tb_ten.Text = Utilities.VietHoaChuCaiDau(tb_ten.Text);
        }
    }
}
