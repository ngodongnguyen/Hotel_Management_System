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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.AxHost;

namespace Hotel_Management_System.Chart
{
    public partial class frmTotalRevenue : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private ReservationBL reservationBL;
        public frmTotalRevenue(DateTime sDate, DateTime eDate)
        {
            InitializeComponent();
            reservationBL = new ReservationBL();
            startDate = sDate;
            endDate = eDate;
            LoadChart();
        }
        private void LoadChart()
        {
            DataTable data = reservationBL.GetTotalRevenue(startDate,endDate);

            // Xóa dữ liệu cũ trong Series
            chart1.Series.Clear();

            // Tạo một Series mới để vẽ biểu đồ tròn
            Series series = new Series
            {
                Name = "TotalRevenue",
                IsVisibleInLegend = true, // Hiển thị chú giải
                ChartType = SeriesChartType.Column, // Kiểu biểu đồ tròn
                BorderWidth = 1,
                BorderColor = Color.Black
            };

            // Thêm dữ liệu vào Series
            foreach (DataRow row in data.Rows)
            {
                // Thêm ngày và tổng doanh thu vào biểu đồ
                series.Points.AddXY(row["CheckOutDate"], row["TotalRevenue"]);
            }

            // Thêm Series vào Chart
            chart1.Series.Add(series);

            // Thiết lập các cài đặt cho biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Total Revenue";
        }
    }
}
