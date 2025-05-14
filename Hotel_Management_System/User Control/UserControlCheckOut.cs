using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlCheckOut : UserControl
    {
        private CheckOutBL checkOutBL;
        private ReservationBL reservationBL;
        private RoomBL roomBL;
        public UserControlCheckOut()
        {
            InitializeComponent();
            checkOutBL = new CheckOutBL();
            reservationBL=new ReservationBL();
            roomBL=new RoomBL();
        }
        public void GetData()
        {
            dataGridView1.DataSource = checkOutBL.DisplayCheckOut();
            AddCheckOutButtonColumn();
            AddPrintBillButtonColumn();

        }
        //public void Clear()
        //{
        //    dataGridView1.DataSource = null;
        //}
        private void UserControlCheckOut_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void AddCheckOutButtonColumn()
        {
            // Kiểm tra xem cột "CheckOut" đã tồn tại chưa
            if (dataGridView1.Columns["CheckOut"] == null)
            {
                DataGridViewButtonColumn checkOutButtonColumn = new DataGridViewButtonColumn();
                checkOutButtonColumn.Name = "CheckOut"; // Tên cột
                checkOutButtonColumn.HeaderText = "CheckOut"; // Tiêu đề cột
                checkOutButtonColumn.Text = "CheckOut"; // Văn bản trên nút
                checkOutButtonColumn.UseColumnTextForButtonValue = true; // Đảm bảo nút có giá trị là "CheckOut"

                // Thêm cột vào DataGridView
                dataGridView1.Columns.Add(checkOutButtonColumn);
            }
        }
        private void AddPrintBillButtonColumn()
        {
            if (dataGridView1.Columns["PrintBill"] == null)
            {
                DataGridViewButtonColumn printBillButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "PrintBill",
                    HeaderText = "Print Bill",
                    Text = "Print Bill",
                    UseColumnTextForButtonValue = true
                };

                dataGridView1.Columns.Add(printBillButtonColumn);
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["CheckOut"].Index && e.RowIndex >= 0)
            {
                // Lấy ID của bản ghi mà người dùng nhấn
                int reservationId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Reservation_ID"].Value); // Lấy ID của bản ghi

                // Xử lý khi nhấn nút CheckOut (gọi hàm từ business logic layer - CheckOutBL)
                checkOutBL.UpdateCheckOut(reservationId);  // Gọi phương thức xử lý CheckOut từ CheckOutBL
                roomBL.UpdateRoom(reservationId);

                // Thông báo hoặc thực hiện hành động cần thiết
                // Cập nhật lại DataGridView sau khi xử lý
                GetData();
            }
            if (e.ColumnIndex == dataGridView1.Columns["PrintBill"].Index && e.RowIndex >= 0)
            {
                int reservationId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Reservation_ID"].Value);
                DataTable invoiceData = reservationBL.GetInvoiceData(reservationId); // Lấy dữ liệu hóa đơn từ BLL
                if (invoiceData.Rows.Count > 0)
                {
                    DataRow row = invoiceData.Rows[0];
                    string fullName = row["FullName"].ToString();
                    string address = row["Client_Address"].ToString();
                    string phone = row["Client_Phone"].ToString();
                    string roomType = row["Reservation_Room_Type"].ToString();
                    string roomNumber = row["Reservation_Room_Number"].ToString();
                    DateTime checkIn = Convert.ToDateTime(row["Reservation_In"]);
                    DateTime checkOut = Convert.ToDateTime(row["Reservation_Out"]);
                    decimal totalPrice = Convert.ToDecimal(row["Total_Price"]);
                    string checkOutStatus = row["CheckOut_Status"].ToString();

                PrintBill(reservationId, fullName, address, phone, roomType, roomNumber, checkIn, checkOut, totalPrice, checkOutStatus); // Gọi hàm in bill

                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cho ID đặt phòng này.");
                }
            }
        }
        // Hàm này tạo file PDF cho hóa đơn
        private void PrintBill(int reservationId, string fullName, string address, string phone, string roomType, string roomNumber, DateTime checkIn, DateTime checkOut, decimal totalPrice, string checkOutStatus)
        {
            try
            {
                // Đường dẫn lưu file PDF
                string filePath = @"C:\Users\DELL\OneDrive\Documents" + reservationId + ".pdf"; // Lưu hóa đơn vào thư mục 

                // Tạo PDF
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Tiêu đề Hóa đơn
                        PdfFont boldFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);
                        document.Add(new Paragraph("Invoice")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFont(boldFont)
                            .SetFontSize(24));

                        // Thêm một khoảng cách giữa các phần
                        document.Add(new Paragraph("\n"));

                        // Thêm thông tin khách hàng
                        document.Add(new Paragraph("Customer Information")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(18)
                            .SetFont(boldFont));

                        // Thông tin khách hàng
                        document.Add(new Paragraph($"Customer Full Name: {fullName}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));
                        document.Add(new Paragraph($"Phone Number: {phone}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));
                        document.Add(new Paragraph($"Address: {address}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        // Khoảng cách
                        document.Add(new Paragraph("\n"));

                        // Thêm thông tin đặt phòng
                        document.Add(new Paragraph("Reservation Details")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(18)
                            .SetFont(boldFont));

                        document.Add(new Paragraph($"Room Type: {roomType}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));
                        document.Add(new Paragraph($"Room Number: {roomNumber}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));
                        document.Add(new Paragraph($"Check-in Date: {checkIn.ToShortDateString()}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));
                        document.Add(new Paragraph($"Check-out Date: {checkOut.ToShortDateString()}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        // Khoảng cách
                        document.Add(new Paragraph("\n"));

                        // Thêm thông tin tổng giá
                        document.Add(new Paragraph($"Total Price: {totalPrice} VND")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(14)
                            .SetFont(boldFont));

                        document.Add(new Paragraph($"Check-out Status: {checkOutStatus}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        // Khoảng cách
                        document.Add(new Paragraph("\n"));

                        // Lời cảm ơn
                        document.Add(new Paragraph("Thank you for your business!")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(14));

                        // Thông báo thành công
                        System.Diagnostics.Process.Start(filePath); // Mở file PDF vừa tạo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the invoice: " + ex.Message);
            }
        }
    }
}
