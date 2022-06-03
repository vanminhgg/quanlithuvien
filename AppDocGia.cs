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
            dgvSach.RowHeadersVisible = false;
            dgvSach.AllowUserToResizeColumns = false;
            dgvSach.AllowUserToResizeRows = false;
        }

        private void AppDocGia_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtNgayPhaiTra.Clear();
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
            dgvSach.DataSource = listSach.Distinct().ToList();
            dgvSach.Columns["name"].HeaderText = "Tên sách";
            dgvSach.Columns["tacgia"].HeaderText = "Tác giả";
            dgvSach.Columns["theloai"].HeaderText = "Thể loại";
            dgvSach.Columns["nxb"].HeaderText = "Nhà xuất bản";
            dgvSach.Columns["soluong"].HeaderText = "Số lượng";
            
            dgvSach.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["tacgia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["theloai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["nxb"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["soluong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public AppDocGia(string mt) : this()
        {
            string mathe = mt;
            cbMathe.Text = mathe;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from sach in db.Saches
                                   where sach.TenSach.Contains(txtSearch.Text.ToString())
                                   select new { Name = sach.TenSach, Tacgia = sach.TacGia.TenTacGia,  Theloai = sach.TheLoai.TenTheLoai, Nxb = sach.NXB.TenNXB, Soluong = sach.SoLuong }).ToList();

                dgvSach.DataSource = listTimKiem.Distinct().ToList();

            }
            else
            {
                this.AppDocGia_Load(sender, e);

            }
        }
    }
}
