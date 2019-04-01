using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QL_HSGVTHPT
{
    public partial class frmDanhMuc : Form
    {
        frmDM_GiaoVien obj = new frmDM_GiaoVien();
        DataTable dtGV = new DataTable();
        DataTable dtHS = new DataTable();

        private string TrungGian="";
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
            dtHS = obj.Diem_HS("1");
            chartDiemHK_HS.DataSource = dtHS;
            chartDiemHK_HS.ChartAreas["ChartArea1"].AxisX.Title = "Điểm";
            chartDiemHK_HS.ChartAreas["ChartArea1"].AxisX.Title = "Học Kỳ";

            chartDiemHK_HS.Series["Ngữ Văn"].XValueMember = 

            //Load Bảng Danh Sánh GV
            dtGV = obj.SelectGV();
            dgvGiaoVien.DataSource = dtGV;

            // Load Diểm Học Sinh


            //Che dấu GroupBox
            groupBoxAnhGV.Enabled = false;
            groupBoxThongTinCaNhan.Enabled = false;

            // Khi load form thì vị trí con trỏ nằm trên thanh tìm kiếm
            ActiveControl = txtSearch;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
        //int n = dgvGiaoVien.Rows.Count -1;
        // mở Group để thao tác
            groupBoxThongTinCaNhan.Enabled = true;
        //Tăng ID lên 1
        //   lbID.Text = Convert.ToString(n+1);
        // chiển các giá trị trên Ô thông tin về Rỗng
                lbID.Text = null;
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
            if(lbID.Text==""||lbID.Text=="ID")
            {
                MessageBox.Show("Bạn Chưa Chọn Giáo Viên Nào để Sửa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                groupBoxAnhGV.Enabled = true;
                groupBoxThongTinCaNhan.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lbID.Text == "" || lbID.Text == "ID")
            {
                MessageBox.Show("Bạn Chưa Chọn Giáo Viên Nào để Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không ??", "*Chú Ý:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj.Delete_GiaoVien(lbID.Text);
                    MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadTable();
                }
            }
        }

        /// <summary>
        /// Hàm chuyển chữ thường sang chữ HOA
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ChuanHoa(string str)
        {
            str = str.ToUpper();
            return str;
        }
        /// <summary>
        /// Hàm Lưu Ảnh
        /// </summary>
        /// <param name="ID"></param>
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
                MessageBox.Show("Bạn Thêm Được: " + N.ToString()+" Ảnh");
                pictGiaoVien.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // lưu xong load lại bảng
            dtGV = obj.SelectGV();
            dgvGiaoVien.DataSource = dtGV;
        }
        /// <summary>
        /// Hàm load Lại bảng
        /// </summary>
        public void LoadTable()
        {
            //Load lại bảng
            dtGV = obj.SelectGV();
            dgvGiaoVien.DataSource = dtGV;
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
                // tạo điều kiện mà rỗng thì k hiển thị đc
                if (obj.Check_Image(lbID.Text)==true)
                {
                    if (MessageBox.Show("Không Có Ảnh, Mời Bạn Thêm Ảnh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)==DialogResult.OK)
                    {
                        groupBoxAnhGV.Enabled = true;
                    }
                }
                else
                {
                    string sql = "select Pictures_GV from GiaoVien where MaGV=N'" + ID + "'";
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        cmd = new SqlCommand(sql, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
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
                            MessageBox.Show("Đối Tượng Được chọn Rỗng","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                        connection.Close();
                    }
                }
                dgvGiaoVien.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Hàm lưu 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // sét điều kiện nếu có ID thì là thực hiện sửa, nếu ID= Rỗng thì là thêm
            if (lbID.Text == "")
            {
                //Đóng group ảnh
                groupBoxAnhGV.Enabled = false;
                if (txtHoTen.Text == "" || txtNgaySinh.Text == "" || txtGioiTinh.Text == "" || txtQuocTich.Text == "" || txtDanToc.Text == "" || txtTonGiao.Text == "" || txtChucVu.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Error !", "Bạn Nhập Thiếu Thông Tin, Yêu Cầu Nhập Lại.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HoTen = ChuanHoa(txtHoTen.Text);
                    NgaySinh = txtNgaySinh.Text;
                    GioiTinh = txtGioiTinh.Text;
                    DiaChi = txtDiaChi.Text;
                    SDT_GV = txtSDT.Text;
                    ChucVu = txtChucVu.Text;
                    QuocTich = txtQuocTich.Text;
                    DanToc = txtDanToc.Text;
                    TonGiao = txtTonGiao.Text;
                    Email = txtEmail.Text;
                    MaMon = txtMonHoc.Text;

                    // kiểm tra điều kiện, nếu tên đã có trong hệ thống thì k cho nhập
                    if (obj.Check_Name(HoTen, NgaySinh, GioiTinh) == false)
                    {
                        obj.Insert_GV(HoTen, NgaySinh, GioiTinh, DiaChi, SDT_GV, ChucVu, QuocTich, DanToc, TonGiao, Email, MaMon);
                        //Load lại bảng
                        LoadTable();
                        //Load vị trí ID giáo Viên lên label
                        for (int i = 0; i < dgvGiaoVien.Rows.Count - 1; i++)
                        {
                            if (txtHoTen.Text == dgvGiaoVien.Rows[i].Cells[1].Value.ToString() || txtNgaySinh.Text == dgvGiaoVien.Rows[i].Cells[2].Value.ToString() || txtGioiTinh.Text == dgvGiaoVien.Rows[i].Cells[3].Value.ToString())
                            {
                                dgvGiaoVien.CurrentCell = dgvGiaoVien.Rows[i].Cells[1];
                                TrungGian = dgvGiaoVien.Rows[i].Cells[0].Value.ToString();
                            }
                        }
                        if (MessageBox.Show("Chúc Mừng Bạn Đã Lưu Thành Công,Tiếp Theo Mời bạn chọn Ảnh!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            // mở ảnh, đóng phần nhập thông tin
                            groupBoxAnhGV.Enabled = true;
                            groupBoxThongTinCaNhan.Enabled = false;
                            // lấy ID để lưu ảnh
                            lbID.Text = TrungGian;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi : Tên Đã Tồn Tại Trong Hệ Thống, Yêu Cầu Nhập Lại.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ActiveControl = txtHoTen;
                    }
                }
            }
            else
            {
                MaGV = lbID.Text;
                HoTen = ChuanHoa(txtHoTen.Text);
                NgaySinh = txtNgaySinh.Text;
                GioiTinh = txtGioiTinh.Text;
                DiaChi = txtDiaChi.Text;
                SDT_GV = txtSDT.Text;
                ChucVu = txtChucVu.Text;
                QuocTich = txtQuocTich.Text;
                DanToc = txtDanToc.Text;
                TonGiao = txtTonGiao.Text;
                Email = txtEmail.Text;
                //MaMon = txtMonHoc.Text;
                if(txtMonHoc.Text == "Ngữ Văn")
                {
                    MaMon = "1";
                }
                if (txtMonHoc.Text == "Toán")
                {
                    MaMon = "2";
                }
                if (txtMonHoc.Text == "Giáo Dục Công Dân")
                {
                    MaMon = "3";
                }
                if (txtMonHoc.Text == "Lịch Sử")
                {
                    MaMon = "4";
                }
                if (txtMonHoc.Text == "Địa Lý")
                {
                    MaMon = "5";
                }
                if (txtMonHoc.Text == "Hóa Học")
                {
                    MaMon = "7";
                }
                if (txtMonHoc.Text == "Sinh Học")
                {
                    MaMon = "8";
                }
                if (txtMonHoc.Text == "Công Nghệ")
                {
                    MaMon = "9";
                }
                if (txtMonHoc.Text == "Tin Học")
                {
                    MaMon = "10";
                }
                if (txtMonHoc.Text == "Giáo Dục Thể Chất")
                {
                    MaMon = "11";
                }
                if (txtMonHoc.Text == "Tiếng Anh")
                {
                    MaMon = "12";
                }
                if (txtMonHoc.Text == "Vật Lý")
                {
                    MaMon = "6";
                }

                obj.Update_TT_GiaoVien(MaGV,HoTen, NgaySinh, GioiTinh, DiaChi, SDT_GV, ChucVu, QuocTich, DanToc, TonGiao, Email, MaMon);
                SavePicture(lbID.Text);
                LoadTable();
                if (MessageBox.Show("Chúc Mừng: Bạn đã Update thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    groupBoxAnhGV.Enabled = false;
                    groupBoxThongTinCaNhan.Enabled = false;
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
          //  txtMonHoc.Text = dgvGiaoVien.CurrentRow.Cells[12].Value.ToString();


            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "1")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Ngữ Văn");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "2")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Toán");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "3")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Giáo Dục Công Dân");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "4")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Lịch Sử");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "5")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Địa Lý");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "6")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Vật Lý");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "7")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Hóa Học");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "8")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Sinh Học");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "9")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Công Nghệ");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "10")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Tin Học");

            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "11")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Giáo Dục Thể Chất");
            }
            if (dgvGiaoVien.CurrentRow.Cells[12].Value.ToString() == "11")
            {
                txtMonHoc.Text = txtMonHoc.GetItemText("Tiếng Anh");
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
                        if (ChuanHoa(txtSearch.Text) == dgvGiaoVien.Rows[i].Cells[1].Value.ToString())
                        {
                            dgvGiaoVien.CurrentCell = dgvGiaoVien.Rows[i].Cells[1];
                        }
                        else
                        {
                            MessageBox.Show("Không Tìm Thấy: '"+txtSearch.Text+"' Trong Hệ Thống.","Thông Báo :", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
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
