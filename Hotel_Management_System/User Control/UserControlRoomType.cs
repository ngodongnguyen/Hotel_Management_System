using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Đảm bảo bạn có namespace này

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlRoomType : UserControl
    {
        public UserControlRoomType()
        {
            InitializeComponent();
            InitializeChart();  // Gọi hàm khởi tạo Chart

        }
        private void InitializeChart()
        {
            // Tạo một ChartArea
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Tạo một Legend (chú giải)
            Legend legend = new Legend();
            chart1.Legends.Add(legend);

            // Tạo một Series để lưu dữ liệu
            Series series = new Series
            {
                Name = "TotalPriceSeries",
                IsVisibleInLegend = true, // Hiển thị chú giải
                ChartType = SeriesChartType.Column // Kiểu biểu đồ: Cột
            };

            // Thêm Series vào Chart
            chart1.Series.Add(series);

            // Cấu hình trục X và Y
            chart1.ChartAreas[0].AxisX.Title = "Reservation ID";
            chart1.ChartAreas[0].AxisY.Title = "Total Price";
        }

        // Hàm vẽ biểu đồ dựa trên dữ liệu
        public void DrawChart(DataTable data)
        {
            // Xóa dữ liệu cũ trong Series
            chart1.Series["TotalPriceSeries"].Points.Clear();

            // Thêm dữ liệu vào Series
            foreach (DataRow row in data.Rows)
            {
                // Thêm điểm vào biểu đồ
                chart1.Series["TotalPriceSeries"].Points.AddXY(row["Reservation_ID"], row["Total_Price"]);
            }
        }
    }
}
