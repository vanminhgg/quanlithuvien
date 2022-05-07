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
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmSach fmSach = new FmSach();
            fmSach.Show();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDocgia fmDocgia = new FmDocgia();
            fmDocgia.Show();
        }

        private void mượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmMuon fmMuon = new FmMuon();
            fmMuon.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTheTV fmTheTV = new FmTheTV();
            fmTheTV.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmTTTaiKhoan fmTTTaiKhoan = new FmTTTaiKhoan();
            fmTTTaiKhoan.Show();

        }
    }
}
