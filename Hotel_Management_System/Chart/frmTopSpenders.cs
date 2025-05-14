using BusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel_Management_System.Chart
{
    public partial class frmTopSpenders : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private ReservationBL reservationBL;

        public frmTopSpenders(DateTime sDate, DateTime eDate)
        {
            InitializeComponent();
            reservationBL = new ReservationBL();
            startDate = sDate;
            endDate = eDate;
            LoadChart();
        }

        private void LoadChart()
        {
            // Gọi hàm lấy top khách hàng chi tiêu nhiều nhất
            DataTable data = reservationBL.GetTopSpenders(startDate, endDate);

            // Xóa dữ liệu cũ
            chart1.Series.Clear();

            // Tạo Series mới
            Series series = new Series
            {
                Name = "TopSpenders",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column,
                BorderWidth = 1,
                BorderColor = Color.Black
            };

            // Thêm dữ liệu theo Client_ID
            foreach (DataRow row in data.Rows)
            {
                int clientId = Convert.ToInt32(row["Client_ID"]);
                decimal totalSpent = Convert.ToDecimal(row["TotalSpent"]);
                series.Points.AddXY(clientId, totalSpent);
            }

            // Thêm series vào chart
            chart1.Series.Add(series);

            // Cấu hình biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Client ID";
            chart1.ChartAreas[0].AxisY.Title = "Total Spent";
           
        }
    }
}
