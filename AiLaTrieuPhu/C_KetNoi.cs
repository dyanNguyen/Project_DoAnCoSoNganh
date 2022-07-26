using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace AiLaTrieuPhu
{
    class C_KetNoi
    {
        private static SqlConnection con;

        public static void ketNoi()
        {
            string chuoiKetNoi = @"Data Source=LAPTOP-HLV1F66B\SQLEXPRESS;Initial Catalog=CauHoi;Integrated Security=True";
            con = new SqlConnection(chuoiKetNoi);
            con.Open();
        }

        public static void dongKetNoi()
        {
            string chuoiKetNoi = @"Data Source=LAPTOP-HLV1F66B\SQLEXPRESS;Initial Catalog=CauHoi;Integrated Security=True";
            con = new SqlConnection(chuoiKetNoi);
            //đóng kết nối
            con.Close();
            //giải phóng bộ nhớ
            con.Dispose();
            con = null;
        }
        
        /// <summary>
        /// lấy dữ liệu từ một ô
        /// </summary>
        /// <param name="sql">câu lệnh truy vấn</param>
        /// <param name="cot">tên cột cần lấy dữ liệu</param>
        /// <param name="i">vị trí dòng cần lấy dữ liệu</param>
        /// <returns>trả về dữ liệu kiểu string</returns>
        public static string layDuLieu(string sql, string cot, int i)
        {
            //tạo câu lệnh truy vấn
            SqlCommand cm = new SqlCommand(sql, con);

            //lưu dữ liệu sau khi truy vấn vào data
            SqlDataAdapter data = new SqlDataAdapter(cm);
            
            DataTable tbl = new DataTable();
            //đổ dữ liệu từ data vào bảng tbl
            data.Fill(tbl);

            //trả về dữ liệu tại dòng thứ i trong cột cot
            return tbl.Rows[i][cot].ToString();

        }


    }
}
