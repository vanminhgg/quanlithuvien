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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        QLTVContext db = new QLTVContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txbUsername.Text) && String.IsNullOrWhiteSpace(txbPassword.Text))
                {
                    MessageBox.Show("Ô nhập không có thông tin!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (rbtnDocgia.Checked)
                {
                    int id = Convert.ToInt32(txbUsername.Text);
                    var the = db.Thes.Where(i => i.MaThe == id).Count();
                    if(the == 1)
                    {
                        AppDocGia app = new AppDocGia();
                        app.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mã thẻ không tồn tại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rbtnDocgia.Checked = true;
                        txbUsername.Clear();
                    }
                }
                if (rbtnNhanvien.Checked)
                {
                    string usrname = txbUsername.Text;
                    string pass = txbPassword.Text;
                    var acc = db.TaiKhoans.Where(i => usrname == i.TenDangNhap && pass == i.MatKhau).Count();
                    if(acc == 1)
                    {
                        FmMain fmMain = new FmMain();
                        fmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rbtnNhanvien.Checked = true;
                        txbUsername.Clear();
                        txbPassword.Clear();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void rbtnDocgia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDocgia.Checked)
            {
                label1.Visible = true;
                lbPassword.Visible = false;
                txbUsername.Visible = true;
                txbPassword.Visible = false;
                label1.Text = "Mã thẻ";
            }
            if (rbtnNhanvien.Checked)
            {
                label1.Visible = true;
                lbPassword.Visible = true;
                txbUsername.Visible = true;
                txbPassword.Visible = true;
                label1.Text = "Tài khoản";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            lbPassword.Visible = false;
            txbUsername.Visible = true;
            txbPassword.Visible = false;
            label1.Text = "Mã thẻ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
