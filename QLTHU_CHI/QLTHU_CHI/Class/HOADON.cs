using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace QLTHU_CHI.Class
{
     class HOADON
    {
        Connect conn = new Connect();
        public string tongtien(int maphieuthu)
        {
            string count = "";
            SqlCommand command = new SqlCommand("SELECT sotien FROM dbo.PHIEUTHU WHERE maphieuthu=" + maphieuthu, conn.getConnection);
            conn.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count = reader[0].ToString();
                }
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            conn.closeConnection();
            return count;
        }
        public string tongtien1(int maphieuchi)
        {
            string count = "";
            SqlCommand command = new SqlCommand("SELECT sotien FROM dbo.PHIEUCHI WHERE maphieuchi=" + maphieuchi, conn.getConnection);
            conn.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count = reader[0].ToString();
                }
            }
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            conn.closeConnection();
            return count;
        }
    }
}
