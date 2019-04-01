using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

using DAL;
namespace BLL
{
   public  class frmDagNhap:SQLServer
    {
     private string str="";
     public bool KiemTra_MK(string TenDN,string MatKhauDN,string ChucVu)
        {
            str = "Select*from GiaoVien where HoTen = N'" +TenDN + "' AND MatKhauDN = N'" +MatKhauDN + "' AND ChucVu = N'" +ChucVu + "'";
            return sql_KiemTra(str);
        }
    }
}
