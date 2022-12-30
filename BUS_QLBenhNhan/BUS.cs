using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLBenhNhan;

namespace BUS_QLBenhNhan
{
    public class BUS
    {
        DAL dal = new DAL();
        public DataTable Show()
        {
            string sql = "SELECT *FROM BENHNHAN";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable DSach()
        {
            string sql = "SELECT *FROM Category";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void Insert(string mbn, string ht, DateTime ns, bool gt, string mbhxh, string kk)
        {
            string sql = "INSERT INTO BENHNHAN VALUES ('" + mbn + "', N'" + ht + "', '" + ns.Date.ToString("yyyy-MM-dd") + "', '" + gt + "', '" + mbhxh + "', '" + kk + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void Delete(string mbn)
        {
            string sql = "DELETE BENHNHAN WHERE MaBN='" + mbn + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void Update(string mbn, string ht, DateTime ns, bool gt, string mbhxh, string kk)
        {
            string sql = "UPDATE BENHNHAN SET HoTen='" + ht + "', NgaySinh='" + ns.Date.ToString("yyyy-MM-dd") + "', GioiTinh='" + gt + "', MaBHXH= '" + mbhxh + "', MaKhoa='" + kk + "' WHERE MaBenhNhan='" + mbn + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable Search(string mbn)
        {
            string sql = "SELECT *FROM BENHNHAN WHERE MaBN= '" + mbn + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public bool checkMaBN(string mbn)
        {
            string sql = "SELECT *FROM BENHNHAN WHERE MaBN='" + mbn + "'";
            DataTable dt = dal.getTable(sql);
            if (dt.Rows.Count == 0)
                return false;
            return true;
        }
    }
}
