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

namespace DAL
{
    public class SQLServer
    {
        public string Server { get; set; }
        public string Database { get; set; }

        public string strConnectString = "";// chuỗi kết nối dến CSDL của máy chủ
        public SqlConnection myConnectSQL;// Đối tượng dùng để kết nối đến máy chủ

        public SQLServer()
        {
            strConnectString = "Server = " + Variable.TenMayChu + ";" +
                "Database = " + Variable.TenCSDL + ";" +
                "Integrated Security = true;" +
                "Connection Timeout = 30";

            // Tạo đối tượng kết nối đến CSDL

            myConnectSQL = new SqlConnection();
            myConnectSQL.ConnectionString = strConnectString;

        }

        // Mở kết nối
        public bool Open_KetNoiCSDL()
        {
            try
            {
                if (myConnectSQL.State == System.Data.ConnectionState.Closed)// kiểm tra nếu đóng thì mở 
                {
                    myConnectSQL.Open();
             

                }
                return true;
            }
            catch(SqlException ex)
            {
                return false;
            }
        }

        // Đóng kết nối

        public bool Close_KetNoiCSDL()
        {
            try
            {
                if (myConnectSQL.State == System.Data.ConnectionState.Open)
                    myConnectSQL.Close();
                return true;
            }
            catch(SqlException ex)
            {
                return false;
            }
        }

        // Câu lệnh Select
        public DataTable LayDuLieuBang(string strQuery)
        {
            try
            {
                Open_KetNoiCSDL();// Mở Kết nối
                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandText = strQuery;
                myCommand.Connection = myConnectSQL;

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = myCommand;
                dataAdapter.Fill(dataTable);// đổ dữ liệu

                return dataTable;

            }
            catch(SqlException ex)
            {
                return null;
            }
        }
       

    }
}
