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
    public class frmTimKiem:SQLServer
    {
        
        public DataTable SelectTK()
        {
            string str = "Select*from GiaoVien";
            return LayDuLieuBang(str);
        }
    }
}
