using DevExpress.XtraPrinting.Native;
using QLTHU_CHI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using Word = Microsoft.Office.Interop.Word;
using Size = System.Drawing.Size;
using System.IO;

namespace QLTHU_CHI
{
    public partial class phieuchi : Form
    {
        PHIEUCHI pc = new PHIEUCHI();
        HOADON hd = new HOADON();
        int maphieuchi;
        public int them = 0;
        string nguoinhantien = "";
        string tenNV = "";
        string str = @"Data Source=HUNG\SQLEXPRESS;Initial Catalog=QLYTHUCHI;Persist Security Info=True;User ID=sa;Password=123456";
        SqlConnection conn;
        public phieuchi()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {

            SqlCommand command = new SqlCommand("select maphieuchi AS'Mã phiếu chi', nguoinhantien AS'Người Nhận',ngaynhan AS'Ngày nhận tiền', diachi AS 'Địa chỉ', sdt AS 'Số điện thoại', email AS 'Email', sotien AS 'Số tiền', lydo as 'Lý do', msnv as 'Mã nhân viên', ketoantruong as 'Kế toán trưởng', giamdoc as 'Giám đốc' from PHIEUCHI", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            tablePhieuchi.DataSource = tb;
            tb.Columns.Add("STT");
            adapter.Fill(tb);
            for (int i = 0; i < tb.Rows.Count; i++)
                tb.Rows[i]["STT"] = i ;
            tablePhieuchi.Columns["STT"].DisplayIndex = 0;
            tablePhieuchi.Refresh();

        }

        public void timkiem()
        {
          
            if (radioButtonMachi.Checked)
            {
                if ((txttk.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("select maphieuchi AS'Mã Phiếu Chi', nguoinhantien AS'Người nhận',ngaynhan AS'Ngày nhận tiền', diachi AS 'Địa chỉ', sdt AS 'Số điện thoại', email AS 'Email', sotien AS 'Số tiền', lydo as 'Lý do', msnv as 'Mã nhân viên', ketoantruong as 'Kế toán trưởng', giamdoc as 'Giám đốc' from PHIEUCHI", conn);
                    tablePhieuchi.DataSource = pc.layKH(command);
                }
                else
                {

                    try
                    {
                        int id = int.Parse(txttk.Text);
                        SqlCommand command = new SqlCommand("SELECT maphieuchi AS'Mã Phiếu Chi', nguoinhantien AS'Người nhận',ngaynhan AS'Ngày nhận tiền', diachi AS 'Địa chỉ', sdt AS 'Số điện thoại', email AS 'Email', sotien AS 'Số tiền', lydo as 'Lý do', msnv as 'Mã nhân viên', ketoantruong as 'Kế toán trưởng', giamdoc as 'Giám đốc' FROM PHIEUCHI WHERE maphieuchi = " + id);
                        tablePhieuchi.DataSource = pc.layKH(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if ((txttk.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT maphieuchi AS'Mã Phiếu Chi', nguoinhantien AS'Người nhận',ngaynhan AS'Ngày nhận tiền', diachi AS 'Địa chỉ', sdt AS 'Số điện thoại', email AS 'Email', sotien AS 'Số tiền', lydo as 'Lý do', msnv as 'Mã nhân viên', ketoantruong as 'Kế toán trưởng', giamdoc as 'Giám đốc' FROM PHIEUCHI");
                    tablePhieuchi.DataSource = pc.layKH(command);
                }
                else
                {
                    string ten = txttk.Text;
                    SqlCommand command = new SqlCommand("SELECT maphieuchi AS'Mã Phiếu Chi', nguoinhantien AS'Người nhận',ngaynhan AS'Ngày nhận tiền', diachi AS 'Địa chỉ', sdt AS 'Số điện thoại', email AS 'Email', sotien AS 'Số tiền', lydo as 'Lý do', msnv as 'Mã nhân viên', ketoantruong as 'Kế toán trưởng', giamdoc as 'Giám đốc' FROM PHIEUCHI WHERE nguoinhantien LIKE '%" + ten + "%'");
                    tablePhieuchi.DataSource = pc.layKH(command);
                }

            }
        }

        string layten()
        {
            Connect mydb = new Connect();
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.PHIEUCHI WHERE nguoinhantien" + nguoinhantien, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            reader.Read();
            nguoinhantien = reader["nguoinoptien"].ToString();
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return nguoinhantien;

        }
        string layten2()
        {
            Connect mydb = new Connect();

            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.NHANVIEN WHERE msnv=" + GLOBALS.GlobalUserId, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            reader.Read();
            tenNV = reader["hoten"].ToString();
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return tenNV;

        }
        bool verif()
        {
            if ((txtMachi.Text.Trim() == "") || (txtnguoinhan.Text.Trim() == "") || (txtlydo.Text.Trim() == "") || (txtgiamdoc.Text.Trim() == "") || (txtemail.Text.Trim() == "") || (txtdiachi.Text.Trim() == "") || (cbnhanvien.Text.Trim() == "") || (dtNgaychi.Text.Trim() == "") || (txtSotien.Text.Trim() == "") || (txtketoantruong.Text.Trim() == "") || (txtsdt.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void reset()
        {
            txtlydo.Text = "";
            txtMachi.Text = "";
            txtnguoinhan.Text = "";
            txtSotien.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            dtNgaychi.Text = "";
            txtketoantruong.Text = "";
            cbnhanvien.Text = "";
            txtgiamdoc.Text = "";
        }
        public void luudon()
        {
            if (verif() == false)
            {
                MessageBox.Show("Nhập thông tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lưu phiếu thu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO PHIEUCHI values('" + txtMachi.Text + "',N'" + txtnguoinhan.Text + "','" + dtNgaychi.Text + "','" + txtdiachi.Text + "' , '" + txtsdt.Text + "', '" + txtemail.Text + "', '" + txtSotien.Text + "',N'" + txtlydo.Text + "','" + cbnhanvien.Text + "',N'" + txtketoantruong.Text + "',N'" + txtgiamdoc.Text + "')";
                command.ExecuteNonQuery();
                reset();
                Loaddata();
            }
        }
        public void duocnhap(bool val)
        {
            txtMachi.Enabled = val;
            txtlydo.Enabled = val;
            txtnguoinhan.Enabled = val;
            txtSotien.Enabled = val;
            txtsdt.Enabled = val;
            txtemail.Enabled = val;
            txtdiachi.Enabled = val;
            dtNgaychi.Enabled = val;
            txtketoantruong.Enabled = val;
            cbnhanvien.Enabled = val;
            txtgiamdoc.Enabled = val;
        }
        public void matudongPC()
        {
            Connect conn = new Connect();
            DataTable dt = new DataTable();
            dt = conn.laybang("Select TOP 1 Cast(a.maphieuchi as int) From PHIEUCHI a Order by Cast(a.maphieuchi as int) DESC");
            DataRow r = dt.Rows[0];
            string ma_moi = ((Convert.ToInt32(r[0].ToString())) + 1).ToString();

            if (ma_moi.Length == 1)
            {
                txtMachi.Text = "00000" + ma_moi;
            }
            if (ma_moi.Length == 2)
            {
                txtMachi.Text = "0000" + ma_moi;
            }
            if (ma_moi.Length == 3)
            {
                txtMachi.Text = "000" + ma_moi;
            }
            if (ma_moi.Length == 4)
            {
                txtMachi.Text = "00" + ma_moi;
            }
        }
        public void xuatword()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(tablePhieuchi, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;


                ///////   ĐÂY LÀ SAVE BÌNH THƯỜNG CHƯA CĂN CHỈNH

                /*Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
               for (int r = 0; r <= RowCount - 1; r++)
               {
                   oTemp = "";
                   for (int c = 0; c < ColumnCount - 1; c++)
                   {
                       oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                   }
                   var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                   oPara1.Range.Text = oTemp;
                   oPara1.Range.InsertParagraphAfter();
                   byte[] imgbyte = (byte[])dataGridViewPrint.Rows[r].Cells[7].Value;
                   MemoryStream ms = new MemoryStream(imgbyte);
                   //Image sparePicture = Image.FromStream(ms);
                   Image finalPic = (Image)new Bitmap(Image.FromStream(ms), new System.Drawing.Size(50, 50));
                   Clipboard.SetDataObject(finalPic);
                   var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                   oPara2.Range.Paste();
                   oPara2.Range.InsertParagraphAfter();
                   //oTemp += "\n";
               }
               //save the file
               oDoc.SaveAs2(filename);*/
                //////////////////////////////////////////////////////////////////////////////////////


                //////        ĐÂY LÀ SAVE CÓ CHIA CỘT THẲNG HÀNG       

                Object[,] dataArray = new object[RowCount + 1, ColumnCount + 1];
                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        dataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page origiantion
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;

                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + dataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                       Type.Missing, Type.Missing, ref ApplyBorders,
                                       Type.Missing, Type.Missing, Type.Missing,
                                       Type.Missing, Type.Missing, Type.Missing,
                                       Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows.Height = 30;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 10;

                //tổng tiền
                oTemp = "\n\t\t\t**************************Tổng thành tiền: " + hd.tongtien1(GLOBALS.GlobalUserId) + " VND**************************";
                Object oMissing = System.Reflection.Missing.Value;
                var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = oTemp;
                oPara1.Range.InsertParagraphAfter();
                //in nhân viên
                tenNV = layten2();
                string ten = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t Nhân viên: " + tenNV + "";
                Object oMissing3 = System.Reflection.Missing.Value;
                var oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing3);
                oPara3.Range.Text = ten;
                oPara3.Range.InsertParagraphAfter();

                //in ngay o cuối
                string ngay = "";
                ngay = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + DateTime.Now + "";
                Object oMissing2 = System.Reflection.Missing.Value;
                var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing2);
                oPara2.Range.Text = ngay;
                oPara2.Range.InsertParagraphAfter();
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table sytle
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 3");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text

                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Font.Size = 20;
                    headerRange.Font.Name = "Times New Roman";
                    headerRange.Bold = 1;
                    headerRange.Text = "Phiếu Chi Tiền\n" + "HÓA ĐƠN THANH TOÁN\n" + "\nMã phiếu chi: " + maphieuchi + " Người nhận: " + nguoinhantien + "\n";

                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    //hóa đơn
                }
                //tổng tiền
                //save file
                oDoc.SaveAs(filename);
            }
        }
        public void inphieu()
        {
            XuatExcel excel = new XuatExcel();
            DataTable dt = (DataTable)tablePhieuchi.DataSource;
            excel.Export1(dt, "phieu chi", "PHIẾU CHI TIỀN");
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.xlsx";
            savefile.Filter = "XLSX files(*.xlsx)|*.xlsx";

            //if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            //{
            //    Export_Data_To_Word(dtphieuthu, savefile.FileName);
            //    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //if (savefile.ShowDialog() == DialogResult.OK)
            //{
            //    ToExcel(dtphieuthu, savefile.FileName);
            //}
        }
        public void update()
        {
            MessageBox.Show("Update thông tin thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "update PHIEUCHI set nguoinhantien=N'" + txtnguoinhan.Text + "',ngaynhan='" + dtNgaychi.Text + "',diachi=N'" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "',email=N'" + txtemail.Text + "',sotien='" + txtSotien.Text + "',lydo=N'" + txtlydo.Text + "',msnv='" + cbnhanvien.Text + "',ketoantruong=N'" + txtketoantruong.Text + "',giamdoc=N'" + txtgiamdoc.Text + "'  where maphieuchi='" + txtMachi.Text + "'";
            command.ExecuteNonQuery();
            reset();
            Loaddata();
        }
        public void xoa()
        {
            MessageBox.Show("Xóa thông tin thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from PHIEUCHI where maphieuchi='" + txtMachi.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            them = 1;
            matudongPC();
        }

        private void phieuchi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLYTHUCHIDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLYTHUCHIDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qLYTHUCHIDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLYTHUCHIDataSet.NHANVIEN);
            conn = new SqlConnection(str);
            conn.Open();
            Loaddata();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablePhieuchi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tablePhieuchi.CurrentRow.Index;
            txtMachi.Text = tablePhieuchi.Rows[i].Cells[0].Value.ToString();
            txtnguoinhan.Text = tablePhieuchi.Rows[i].Cells[1].Value.ToString();
            dtNgaychi.Text = tablePhieuchi.Rows[i].Cells[2].Value.ToString();
            txtdiachi.Text = tablePhieuchi.Rows[i].Cells[3].Value.ToString();
            txtsdt.Text = tablePhieuchi.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = tablePhieuchi.Rows[i].Cells[5].Value.ToString();
            txtSotien.Text = tablePhieuchi.Rows[i].Cells[6].Value.ToString();
            txtlydo.Text = tablePhieuchi.Rows[i].Cells[7].Value.ToString();
            cbnhanvien.Text = tablePhieuchi.Rows[i].Cells[8].Value.ToString();
            txtketoantruong.Text = tablePhieuchi.Rows[i].Cells[9].Value.ToString();
            txtgiamdoc.Text = tablePhieuchi.Rows[i].Cells[10].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            luudon();
            reset();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            xuatword();
        }

        private void btnSaveprint_Click(object sender, EventArgs e)
        {
            inphieu();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            xoa();
            reset();
        }

        private void btSeach_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void txtMachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Không nhập đừng các ký tự a-z chỉ nhận các chữ số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtSotien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Không nhập đừng các ký tự a-z chỉ nhận các chữ số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Không nhập đừng các ký tự a-z chỉ nhận các chữ số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
