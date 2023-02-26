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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLTHU_CHI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect mydb = new Connect();
            if (radioButtonAdmin.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM QUANLY WHERE username = @User AND password = @Pass", mydb.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = txttk.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtmk.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    HomeQuanLy admin = new HomeQuanLy();
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonNV.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE username = @User AND password = @Pass", mydb.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = txttk.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtmk.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {

                    int userid = Convert.ToInt16(table.Rows[0][0].ToString()); //mã số nhân viên
                    GLOBALS.setGlobalUserId(userid);
                    //

                    DateTime giovao = DateTime.Now;

                    //
                    Home_nv menu = new Home_nv();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Chọn quyền đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
