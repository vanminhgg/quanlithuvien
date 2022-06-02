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
    public partial class FmThemChiTietMuon : Form
    {
        QLTVContext db = new QLTVContext();
        public FmThemChiTietMuon()
        {
            InitializeComponent();
        }

        public string textBoxID { set { txtId.Text = value; } }
        public string cbBoxmaThe { set { cbMathe.Text = value; } }

        private void FmThemChiTietMuon_Load(object sender, EventArgs e)
        {
            var listSach = (from sach in db.Saches select new { Id = sach.MaSach, Name = sach.TenSach, Tacgia = sach.TacGia.TenTacGia, Nxb = sach.NXB.TenNXB, Theloai = sach.TheLoai.TenTheLoai, Namxb = sach.NamXB, Soluong = sach.SoLuong }).ToList();
            dgvSach.DataSource = listSach.Distinct().ToList();

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {

        }
    }
}
