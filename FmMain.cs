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
          /*  if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();*/
                FmSach fmSach = new FmSach();


               // fmSach.MdiParent = this;

                fmSach.Show();
           /* }
            else
            {
                FmSach fmSach = new FmSach();


                fmSach.MdiParent = this;

                fmSach.Show();
            }*/
            

        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = false;
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FmDocgia fmDocgia = new FmDocgia();
                fmDocgia.MdiParent = this;

                fmDocgia.Show();
            } else
            {
                FmDocgia fmDocgia = new FmDocgia();
                fmDocgia.MdiParent = this;

                fmDocgia.Show();

            }    
           
        }

        private void mượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmMuon fmMuon = new FmMuon();
            fmMuon.MdiParent = this;
            
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

        private void theeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTheLoai fmTheLoai = new FmTheLoai();
            fmTheLoai.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTacGia fmTacGia = new FmTacGia();
            fmTacGia.Show();
        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmNXB fmNXB = new FmNXB();
            fmNXB.Show();
        }

        private void yêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmYeuCau fmYeuCau = new FmYeuCau();
            fmYeuCau.Show();
        }

        private void trảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTra fmTra = new FmTra();
            fmTra.Show();
        }
    }
}
