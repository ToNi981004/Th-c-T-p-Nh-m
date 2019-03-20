using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class frmDM_GiaoVien:SQLServer
    {
        private string str;
        public DataTable SelectGV()
        {
            str = "Select* from GiaoVien";
            return LayDuLieuBang(str);
        }
        public DataTable Insert_GV(string HoTen, string NgaySinh, string GioiTinh, string DiaChi, string SDT_GV, string ChucVu, string QuocTich,string DanToc, string TonGiao, string Email, string MaMon)
        {
            str = "Insert Into GiaoVien(HoTen, NgaySinh, GioiTinh, DiaChi, SDT_GV, ChucVu, QuocTich, DanToc, TonGiao, Email, MaMon) Values(N'"+HoTen+"', N'"+NgaySinh+"', N'"+GioiTinh+"', N'"+DiaChi+"', N'"+SDT_GV+"', N'"+ChucVu+"', N'"+QuocTich+"', N'"+DanToc+"', N'"+TonGiao+"', N'"+Email+"', N'"+MaMon+"')";
            return LayDuLieuBang(str);

        }

    }
}
