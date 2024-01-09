using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QuanLiBanVeMayBay
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();

        private void DoanhThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }
        private void btnTimTatCa_Click(object sender, EventArgs e)
        {
            dt.Connect();

            DataSet data = new DataSet();
            string query = "Select MAPHIEU 'Mã phiếu', MAKH 'Mã khách hàng', MACHUYENBAY 'Mã chuyến bay', MATUYENBAY 'Mã tuyến bay', MAHANGVE 'Mã hạng vé', SOGHEDAT 'Số ghế đặt', NGAYDAT 'Ngày đặt', GIATIEN 'Giá tiền'  "
                        + " from DATCHO ";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewDoanhThu.DataSource = data.Tables[0];
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dt.Connect();
            DateTime selectedDate = dateTimeTruoc.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            DateTime selectedDate1 = dateTimeSau.Value;
            string formattedDate1 = selectedDate.ToString("yyyy-MM-dd");
            DataSet data = new DataSet();
            string query = " Select MAPHIEU 'Mã phiếu', MAKH 'Mã khách hàng', MACHUYENBAY 'Mã chuyến bay', MATUYENBAY 'Mã tuyến bay', MAHANGVE 'Mã hạng vé', SOGHEDAT 'Số ghế đặt', NGAYDAT 'Ngày đặt', GIATIEN 'Giá tiền' "
                        + "from DATCHO "
                         + " where "
                                + "NGAYDAT between '" + formattedDate + "' and '" + formattedDate1 + "' ";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewDoanhThu.DataSource = data.Tables[0];
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewDoanhThu.Rows)
            {
                if (row.Cells[dataGridViewDoanhThu.Columns.Count - 1].Value != null)
                {
                    decimal value;
                    if (decimal.TryParse(row.Cells[dataGridViewDoanhThu.Columns.Count - 1].Value.ToString(), out value))
                    {
                        total += value;
                    }
                }
            }
            txtTongTien.Text = total.ToString();
        }

       
        class ExportToExcel

        {
            public void Export(DataTable dt, string sheetName, string title)
            {
                double total = 0;

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

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã phiếu";

                cl1.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã khách hàng";

                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Mã chuyến bay";

                cl3.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Mã Tuyến Bay";

                cl4.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Mã hạng vé";

                cl5.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Số ghế đặt";

                cl6.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Ngày đặt";

                cl7.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                cl8.Value2 = "Giá tiền";

                cl8.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < dt.Rows.Count; r++)

                {

                    DataRow dr = dt.Rows[r];

                    for (int c = 0; c < dt.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                        if (c == dt.Columns.Count - 1) // Kiểm tra cột cuối
                        {
                            total += Convert.ToDouble(dr[c]); // Tính tổng
                        }
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

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                

                // Lấy số hàng dữ liệu trong DataTable
                int rowCount = dt.Rows.Count;

                // Gán giá trị "1" cho ô dưới bảng
                Microsoft.Office.Interop.Excel.Range totalCell = oSheet.Cells[rowStart + rowCount, columnEnd];
                totalCell.Value2 = "Tổng doanh thu: "+total.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            DataTable dt = (DataTable) dataGridViewDoanhThu.DataSource;
            excel.Export(dt, "Doanh thu", "BÁO CÁO DOANH THU");
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
