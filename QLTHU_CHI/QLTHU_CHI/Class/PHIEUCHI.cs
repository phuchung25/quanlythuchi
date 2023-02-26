using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHU_CHI.Class
{
     class PHIEUCHI
    {
        Connect conn = new Connect();
        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.PHIEUCHI WHERE maphieuchi=" + id, conn.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable layKH(SqlCommand command)
        {

            command.Connection = conn.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
