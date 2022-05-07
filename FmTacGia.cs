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
    public partial class FmTacGia : Form
    {
        QLTVContext db = new QLTVContext();
        public FmTacGia()
        {
            InitializeComponent();
        }

        private void FmTacGia_Load(object sender, EventArgs e)
        {
            var query = from tg in db.TacGias
                        select tg;
            dgvTacgia.DataSource = query.ToList();
        }
    }
}
