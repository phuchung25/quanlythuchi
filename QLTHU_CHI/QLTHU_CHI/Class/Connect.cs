using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLTHU_CHI.Class
{

     class Connect
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HUNG\SQLEXPRESS;Initial Catalog=QLYTHUCHI;Persist Security Info=True;User ID=sa;Password=123456");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public void kn_csdl()
        {
            string chuoikn = "Data Source=HUNG\\SQLEXPRESS;Initial Catalog=QLYTHUCHI;Persist Security Info=True;User ID=sa;Password=123456";//chuỗi kết nối
            conn.ConnectionString = chuoikn;
            conn.Open();//mở kết nối
        }

        // open the connection
        public void openConnection()
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((conn.State == ConnectionState.Open))
            {
                conn.Close();
            }

        }
        public DataTable bangdulieu = new DataTable();
        public DataTable laybang(string caulenh)
        {
            try
            {
                kn_csdl();
                SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, conn);
                DataSet ds = new DataSet();

                Adapter.Fill(bangdulieu);
            }
            catch (System.Exception)
            {
                bangdulieu = null;
            }
            finally
            {
                closeConnection();
            }

            return bangdulieu;
        }
    }
}
