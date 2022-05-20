using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLITHUVIENWINFORM
{
    public partial class AppDocGia : Form
    {
        QLTVContext db = new QLTVContext();
        public AppDocGia()
        {
            InitializeComponent();
            dgvDocGia.RowHeadersVisible = false;
            dgvDocGia.AllowUserToResizeColumns = false;
            dgvDocGia.AllowUserToResizeRows = false;
        }

        private void AppDocGia_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtNgayPhaiTra.Clear();
            cbMathe.Text = "";
            nud_soluong.Value = 1;
            txtNgayPhaiTra.Enabled = false;
            var listSach = from s in db.Saches
                           select new
                           {
                               name = s.TenSach,
                               tacgia = s.TacGia.TenTacGia,
                               theloai = s.TheLoai.TenTheLoai,
                               nxb = s.NXB.TenNXB,
                               soluong = s.SoLuong
                           };
            dgvDocGia.DataSource = listSach.Distinct().ToList();
            dgvDocGia.Columns["name"].HeaderText = "Tên sách";
            dgvDocGia.Columns["tacgia"].HeaderText = "Tác giả";
            dgvDocGia.Columns["theloai"].HeaderText = "Thể loại";
            dgvDocGia.Columns["nxb"].HeaderText = "Nhà xuất bản";
            dgvDocGia.Columns["soluong"].HeaderText = "Số lượng";
            
            dgvDocGia.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocGia.Columns["tacgia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocGia.Columns["theloai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocGia.Columns["nxb"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocGia.Columns["soluong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
