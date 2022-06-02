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
    public partial class FmChiTietMuon : Form
    {
        QLTVContext db = new QLTVContext();
        public FmChiTietMuon()
        {
            InitializeComponent();
        }
        public string textBoxID { set { txtId.Text = value; } }
        public string cbBoxmaThe { set { cbMathe.Text = value; } }

        private void FmChiTietMuon_Load(object sender, EventArgs e)
        {
            var list = db.ChiTietMuons.Where(i => i.MaMuon == Convert.ToInt32(cbMathe.Text));
            var listSach = (from sach in list select new { Id = sach.MaSach, daTra = sach.DaTra, ngayMuon = sach.NgayTra, hanTra = sach.NgayHetHan, tt = sach.TinhTrangSach });
            dgvChitietmuon.DataSource = listSach.Distinct().ToList();

            dgvChitietmuon.Columns["Id"].HeaderText = "Mã sách";
            dgvChitietmuon.Columns["daTra"].HeaderText = "Đã Trả";
            dgvChitietmuon.Columns["ngayMuon"].HeaderText = "Ngày Trả";
            dgvChitietmuon.Columns["hanTra"].HeaderText = "Hạn Trả";
            dgvChitietmuon.Columns["tt"].HeaderText = "Tình Trạng Sách";

        }
    }
}
