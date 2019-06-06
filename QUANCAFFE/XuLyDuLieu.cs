using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{
    class XuLyDuLieu
    {

        public static DataSet dataset = null;
        private static string chuoiKN = @"Data Source=DESKTOP-LGGQE1P\SQLEXPRESS;Initial Catalog=QUANCAFFE;Integrated Security=True";
    
        static private SqlConnection ketNoi = new SqlConnection(chuoiKN);
        static private SqlCommand TaoCommand(string sql
            , params object[] dsThamSo)
        {
            if (ketNoi.State == System.Data.ConnectionState.Closed)
                ketNoi.Open();
            var cmd = new SqlCommand(sql, ketNoi);
            //them tham so cho doi tuong cmd (tranh tan cong injection):
            for (int i = 0; i < dsThamSo.Length - 1; i += 2)
            {
                cmd.Parameters.AddWithValue
                    (dsThamSo[i].ToString(), dsThamSo[i + 1]);
            }
            return cmd;
        }
        static public int ThucThiThemXoaSua(string sql
            , params object[] dsThamSo)
        {
            var cmd = TaoCommand(sql, dsThamSo);
            var kq = cmd.ExecuteNonQuery();//tra ve so dong bi tac dong.
            ketNoi.Close();
            return kq;
        }

        public static System.Data.DataTable DocDuLieu(string sql
            , params object[] dsThamSo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = TaoCommand(sql, dsThamSo);
            DataTable t = new DataTable();
            adapter.Fill(t);
            ketNoi.Close();
            return t;
        }
        public static object ThucThiVoHuong(string sql
            , params object[] dsThamSo)
        {
            var cmd = TaoCommand(sql, dsThamSo);
            var kq = cmd.ExecuteScalar();//thuc thi cau SQL vo huong
            ketNoi.Close();
            return kq;
        }

      
    }
}
