using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBenhNhan
{
    public class DAL
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=QuanSuper;Initial Catalog=QuanLyBenhNhan;Integrated Security=True");
        }
        public DataTable getTable(string strsql)
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void ExcuteNonQuery(string strsql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand com = new SqlCommand(strsql, conn);
            com.ExecuteNonQuery();
            com.Dispose();
            com.Clone();
        }
    }
}
