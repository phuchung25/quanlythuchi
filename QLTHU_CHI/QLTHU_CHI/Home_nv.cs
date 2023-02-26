using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTHU_CHI.Class;

namespace QLTHU_CHI
{
    public partial class Home_nv : Form
    {
        
        
        public Home_nv()
        {
            InitializeComponent();
        }
        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            phieuthu pt = new phieuthu();
            pt.Show();
            
        }
        string laytennv(int msnv)
        {
            Connect mydb = new Connect();
            msnv = GLOBALS.GlobalUserId;
            string tennv = "";
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.NHANVIEN WHERE msnv=" + msnv, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tennv = reader["hoten"].ToString();
            }
            reader.Close();
            return tennv;
        }

        private void Home_nv_Load(object sender, EventArgs e)
        {

        }

        private void chiNgânSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phieuchi pc = new phieuchi();
            pc.Show();
        }
    }
}
