using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QL_HSGVTHPT
{
    public partial class frmDangNhap : Form
    {
        private string _MatKhauDN;
        public string _TenDN;
        public string _ChucVu;

        private string conn= @"Data Source=DESKTOP-HFIR0F6;Initial Catalog=QL_GVHSTHPT;Integrated Security=True";

        public frmDangNhap()
        {
            InitializeComponent();

            this.txtChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // không cho phép nhập vào ComboBox
        }
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Phải nhập Tên ĐĂNG NHẬP, không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtTenDN;
                return;
            }
            if (txtMKDN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Phải nhập MẬT KHẨU, không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtMKDN;
                return;
            }
            if(txtChucVu.Text.Trim()=="")
            {
                MessageBox.Show("Bạn Phải Chọn Chức Vụ, không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtChucVu;
                return;
            }
            _TenDN = txtTenDN.Text;
            _MatKhauDN = txtMKDN.Text;
            _ChucVu = txtChucVu.Text;

            string Query = "Select*from GiaoVien where HoTen = N'" + _TenDN + "' AND MatKhauDN = N'" + _MatKhauDN + "' AND ChucVu = N'" + _ChucVu + "'";
            using (SqlConnection sql = new SqlConnection(conn))
            {
                sql.Open();
                SqlCommand commad = new SqlCommand(Query, sql);
                SqlDataReader data = commad.ExecuteReader();
                if (data.Read() == true)
                {
                    frmMain fr = new frmMain(_TenDN, _ChucVu);
                    this.Hide();
                    fr.ShowDialog();
                    fr.Close();
                    //this.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Không Thành Công (Bạn nhập sai Tài khoản hoặc Mật khẩu)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ActiveControl = txtTenDN;
                }
            }

        }
        private void txtThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();// thoát đăng nhập
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
    
}
