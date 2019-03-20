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
using System.IO;

using BLL;

namespace QL_HSGVTHPT
{
    public partial class frmDanhMuc : Form
    {
        frmDM_GiaoVien obj = new frmDM_GiaoVien();
        DataTable dtGV = new DataTable();
        //ListBox ListBox = new ListBox();

        private string MaGV,HoTen, NgaySinh, GioiTinh, DiaChi, SDT_GV, ChucVu, QuocTich, DanToc, TonGiao, Email, MaMon;
        private string imgLocation = "";
        public int str;
        // kết nối với SQL để lưu file ảnh
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-HFIR0F6;Initial Catalog=QL_GVHSTHPT;Integrated Security=True");
        SqlCommand cmd;

        // Hàm khoi tao
        public frmDanhMuc(int s)
        {
            // Lấy địa chỉ của tab tương ứng vs s
            InitializeComponent();
            this.str = s;
            tabpDanhMuc.SelectedIndex = s;

            //Load Bảng Danh Sánh GV
            dtGV = obj.SelectGV();
            dgvGiaoVien.DataSource = dtGV;

            //Che dấu GroupBox
            groupBoxThongTinCaNhan.Enabled = false;
            

            // Khi load form thì vị trí con trỏ nằm trên thanh tìm kiếm
            ActiveControl = txtSearch;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
          
           
                // mở Group để thao tác
                groupBoxThongTinCaNhan.Enabled = true;
               
                // chiển các giá trị trên Ô thông tin về Rỗng
                int n = dgvGiaoVien.Rows.Count;
                lbID.Text = "";
                txtHoTen.Text = "";
                txtNgaySinh.Text = "";
                txtGioiTinh.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtChucVu.Text = "";
                txtQuocTich.Text = "";
                txtDanToc.Text = "";
                txtTonGiao.Text = "";
                txtEmail.Text = "";
                pictGiaoVien.Image = null;
                txtMonHoc.Text = "";
               
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        // Hàm lưu ảnh
        public void SavePicture(string ID)
        {
            try
            {
                byte[] imges = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                imges = brs.ReadBytes((int)stream.Length);



                string sqlQuery = "Update GiaoVien set Pictures_GV = @imges where MaGV =N'" + ID + "'";
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add(new SqlParameter("@imges", imges));
                int N = cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(N.ToString() + "   " + "Thêm Ảnh Thành Công....!");
                pictGiaoVien.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///  Sự Kiện Click vào nút Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
            SavePicture(lbID.Text);

        }
        /// <summary>
        /// Hàm thêm ảnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictGiaoVien.ImageLocation = imgLocation;
            }
        }
        /// <summary>
        /// Hàm load ảnh
        /// </summary>
        /// <param name="ID"></param>
        public void Show_Picture(string ID)
        {
            try
            {
                string sql = "select Pictures_GV from GiaoVien where MaGV=N'" + ID + "'";
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    cmd = new SqlCommand(sql,connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if(reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);
                        if (img == null)
                            pictGiaoVien.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictGiaoVien.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This is does not extit");
                    }
                    connection.Close();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        //Hàm lưu 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            groupBoxAnhGV.Enabled = false;
            if (txtHoTen.Text == "" || txtNgaySinh.Text == "" || txtGioiTinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtChucVu.Text == "" || txtQuocTich.Text == "" || txtDanToc.Text == "" || txtTonGiao.Text == "" || txtEmail.Text == ""||pictGiaoVien==null)
            {
                MessageBox.Show("Error !", "Bạn Nhập Thiếu Thông Tin, Yêu Cầu Nhập Lại.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoTen = txtHoTen.Text.Trim();
                NgaySinh = txtNgaySinh.Text.Trim();
                GioiTinh = txtGioiTinh.Text.Trim();
                DiaChi = txtDiaChi.Text.Trim();
                SDT_GV = txtSDT.Text.Trim();
                ChucVu = txtChucVu.Text.Trim();
                QuocTich = txtQuocTich.Text.Trim();
                DanToc = txtDanToc.Text.Trim();
                TonGiao = txtTonGiao.Text.Trim();
                Email = txtEmail.Text.Trim();
                MaMon = txtMonHoc.Text.Trim();

                obj.Insert_GV(HoTen, NgaySinh, GioiTinh, DiaChi, SDT_GV, ChucVu,QuocTich,DanToc,TonGiao,Email,MaMon);
                // lưu ảnh

                //// CHưa làm được lưu 1 cách hoàn chỉnh ===> nghiên cứu lại

                if(MessageBox.Show("Mời bạn chọn Ảnh.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk )==DialogResult.OK)
                {
                    groupBoxAnhGV.Enabled = true;
                    for (int i = 0; i < dgvGiaoVien.Rows.Count - 1; i++)
                    {
                        if (HoTen == dgvGiaoVien.Rows[i].Cells[1].Value.ToString())
                        {
                            //dgvGiaoVien.CurrentCell = dgvGiaoVien.Rows[i].Cells[1];
                            dgvGiaoVien.CurrentCell = dgvGiaoVien.Rows[i].Cells[0];
                            SavePicture(dgvGiaoVien.Rows[i].Cells[0].Value.ToString());
                            //Load lại bảng

                            dtGV = obj.SelectGV();
                            dgvGiaoVien.DataSource = dtGV;
                            //Hiển thị thông báo lưu thành công
                            MessageBox.Show("Mời bạn chọn Ảnh.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }

            }
        }



        /// <summary>
        /// Sự kiện click vào bảng GV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbID.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            txtGioiTinh.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
            txtChucVu.Text = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
            txtQuocTich.Text = dgvGiaoVien.CurrentRow.Cells[8].Value.ToString();
            txtDanToc.Text = dgvGiaoVien.CurrentRow.Cells[9].Value.ToString();
            txtTonGiao.Text = dgvGiaoVien.CurrentRow.Cells[10].Value.ToString();
            txtEmail.Text = dgvGiaoVien.CurrentRow.Cells[11].Value.ToString();
          //  txtMonHoc.Text = dgvGiaoVien.CurrentRow.Cells[13].Value.ToString();


            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "1")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Ngữ Văn");
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "2")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Toán");
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "3")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(3);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "4")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(4);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "5")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(5);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "6")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(6);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "7")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(7);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "8")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(8);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "9")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(9);
            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "10")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(10);

            }
            if (dgvGiaoVien.CurrentRow.Cells[13].Value.ToString() == "11")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText(11);
            }
          
            //Che giấu GroupBox
            groupBoxThongTinCaNhan.Enabled = false;
            groupBoxAnhGV.Enabled = false;
            // Show Ảnh 
            Show_Picture(lbID.Text);
            // show ra GrouBoxThongTinNhanVien Khi click vào bảng GV
            //groupBoxThongTinCaNhan.Visible = true;

        }
        //

       

        /// <summary>
        /// Hàm thời gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmtTime_Tick(object sender, EventArgs e)
        {
            DateTime tm = DateTime.Now;
            lbTime.Text = tm.ToString("dd/MM/yyyy | hh:mm:ss");
        }



        /// <summary>
        /// Hàm tìm kiếm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    for (int i = 0; i < dgvGiaoVien.Rows.Count - 1; i++)
                    {
                        if (txtSearch.Text == dgvGiaoVien.Rows[i].Cells[1].Value.ToString())
                        {
                            dgvGiaoVien.CurrentCell = dgvGiaoVien.Rows[i].Cells[1];
                        }
                    }
                }
        }

        private void pageHoSoGV_Click(object sender, EventArgs e)
        {
            
        }

        private void pageHoSoHS_Click(object sender, EventArgs e)
        {
            
        }

        private void pageHoSoGiangDay_Click(object sender, EventArgs e)
        {
            
        }

        private void pagePhongHoc_Click(object sender, EventArgs e)
        {

        }

        private void pageMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void pageLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void tabpDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
