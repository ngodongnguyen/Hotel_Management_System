using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices.ComTypes;


namespace Hotel_Management_System.Chart
{
    public partial class frmFrequentCustomer : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private ReservationBL reservationBL;
        public frmFrequentCustomer(DateTime sDate, DateTime eDate)
        {
            InitializeComponent();
            reservationBL= new ReservationBL();
            startDate = sDate;
            endDate = eDate;
            LoadChart();
        }
        private void LoadChart()
        {
            // Lấy dữ liệu khách hàng đặt phòng nhiều nhất trong khoảng thời gian
            DataTable data = reservationBL.GetMostFrequentCustomer(startDate, endDate);

            // Xóa dữ liệu cũ trong Series
            chart1.Series.Clear();

            // Tạo một Series mới để vẽ biểu đồ cột
            Series series = new Series
            {
                Name = "MostFrequentCustomer",
                IsVisibleInLegend = true, // Hiển thị chú giải
                ChartType = SeriesChartType.Column, // Kiểu biểu đồ cột
                BorderWidth = 1,
                BorderColor = Color.Black
            };

            // Thêm dữ liệu vào Series
            foreach (DataRow row in data.Rows)
            {
                // Thêm thông tin về khách hàng và số lần đặt phòng vào biểu đồ
                string CID = row["Client_ID"].ToString(); // Hoặc bạn có thể thay thế Customer_ID bằng tên khách hàng nếu có
                int reservationCount = Convert.ToInt32(row["ReservationCount"]);
                series.Points.AddXY(CID, reservationCount);
            }

            // Thêm Series vào Chart
            chart1.Series.Add(series);

            // Thiết lập các cài đặt cho biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Client ID";  // Hoặc có thể là "Customer Name"
            chart1.ChartAreas[0].AxisY.Title = "Number of Reservations";
            chart1.ChartAreas[0].AxisX.Interval = 1; // Giới hạn khoảng cách giữa các cột nếu cần
        }
    }
}
