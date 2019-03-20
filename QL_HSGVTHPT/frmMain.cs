using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_HSGVTHPT
{
    public partial class frmMain : Form
    {
        private string _Ten;
        private string _ChucVu;

        public frmMain(string Ten,string ChucVu)
        {
            InitializeComponent();
            this._Ten = Ten;
            this._ChucVu = ChucVu;
            lbTaiKhoan.Text = _Ten;
            lbChucVu.Text = _ChucVu;
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            DateTime tm = DateTime.Now;
            lbTime.Text = tm.ToString("dd/MM/yyyy | hh:mm:ss");
        }

        private void HT_frmDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
            frm.Close();
            Application.Exit();
        }

        private void frmDM_HSGV_Click(object sender, EventArgs e)
        {
            int s = 0;
            frmDanhMuc frm = new frmDanhMuc(s);
            frm.ShowDialog();
        }

        private void frmDM_HSHS_Click(object sender, EventArgs e)
        {
            int s = 1;
            frmDanhMuc frm = new frmDanhMuc(s);
            frm.ShowDialog();
        }

        private void frmDM_HSGD_Click(object sender, EventArgs e)
        {
            int s = 2;
            frmDanhMuc frm = new frmDanhMuc(s);
            frm.ShowDialog();
        }

        private void frmDM_PhongHoc_Click(object sender, EventArgs e)
        {
            int s = 3;
            frmDanhMuc frm = new frmDanhMuc(s);
            frm.ShowDialog();
        }

        private void frmDM_MonHoc_Click(object sender, EventArgs e)
        {
            int s = 4;
            frmDanhMuc frm = new frmDanhMuc(s);
            frm.ShowDialog();
        }

        private void frmDM_LopHoc_Click(object sender, EventArgs e)
        {
            int s = 5;
            frmDanhMuc frm = new frmDanhMuc(s);
            frm.ShowDialog();
        }

        private void frmTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            frm.ShowDialog();
        }

       
    }
}
