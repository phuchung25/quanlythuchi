using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHU_CHI.Class
{
     class XuatExcel
    {
        public void Export(DataTable dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel 
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook  
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu 
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Courier New";
            head.Font.Size = "16";
            head.Interior.ColorIndex = 6;
            head.Font.Color = 15;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột  
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A2", "A2");
            cl1.Value2 = "Mã Phiếu Thu";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");
            cl2.Value2 = "Tên Người Nộp";
            cl2.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");
            cl3.Value2 = "Ngày Nộp Tiền";
            cl3.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");
            cl4.Value2 = "Địa Chỉ";
            cl4.ColumnWidth = 7.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");
            cl5.Value2 = "SĐT";
            cl5.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");
            cl6.Value2 = "Email";
            cl6.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G2", "G2");
            cl7.Value2 = "Số Tiền";
            cl7.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H2", "H2");
            cl8.Value2 = "Lý Do";
            cl8.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I2", "I2");
            cl9.Value2 = "Mã Nhân Viên";
            cl9.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J2", "J2");
            cl10.Value2 = "Kế Toán Trưởng";
            cl10.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K2", "K2");
            cl11.Value2 = "Giám Đốc";
            cl11.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A2", "K2");
            rowHead.Font.Bold = true;
            // Kẻ viền 
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền 
            rowHead.Interior.ColorIndex = 4;
            rowHead.Font.Color = 5;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable, 
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng 
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu 
            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;
            // Ô bắt đầu điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập 
            range.Value2 = arr;
            // Kẻ viền 
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }
        public void Export1(DataTable dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel 
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook  
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu 
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Courier New";
            head.Font.Size = "16";
            head.Interior.ColorIndex = 6;
            head.Font.Color = 15;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột  
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A2", "A2");
            cl1.Value2 = "Mã Phiếu Chi";
            cl1.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B2", "B2");
            cl2.Value2 = "Tên Người Nhận";
            cl2.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C2", "C2");
            cl3.Value2 = "Ngày Nhận Tiền";
            cl3.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D2", "D2");
            cl4.Value2 = "Địa Chỉ";
            cl4.ColumnWidth = 7.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E2", "E2");
            cl5.Value2 = "SĐT";
            cl5.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F2", "F2");
            cl6.Value2 = "Email";
            cl6.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G2", "G2");
            cl7.Value2 = "Số Tiền";
            cl7.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H2", "H2");
            cl8.Value2 = "Lý Do";
            cl8.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I2", "I2");
            cl9.Value2 = "Mã Nhân Viên";
            cl9.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J2", "J2");
            cl10.Value2 = "Kế Toán Trưởng";
            cl10.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K2", "K2");
            cl11.Value2 = "Giám Đốc";
            cl11.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A2", "K2");
            rowHead.Font.Bold = true;
            // Kẻ viền 
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền 
            rowHead.Interior.ColorIndex = 4;
            rowHead.Font.Color = 5;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable, 
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng 
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu 
            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;
            // Ô bắt đầu điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập 
            range.Value2 = arr;
            // Kẻ viền 
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }
    }
}
