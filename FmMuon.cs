﻿using System;
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
    public partial class FmMuon : Form
    {
        public FmMuon()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FmThemChiTietMuon fmThemChiTietMuon = new FmThemChiTietMuon();
            fmThemChiTietMuon.Show();
        }

        private void btnCTMuon_Click(object sender, EventArgs e)
        {
            FmChiTietMuon fmChiTietMuon = new FmChiTietMuon();
            fmChiTietMuon.Show();

        }
    }
}
