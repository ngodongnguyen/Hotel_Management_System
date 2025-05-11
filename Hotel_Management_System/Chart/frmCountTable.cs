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

namespace Hotel_Management_System.Chart
{
    public partial class frmCountTable : Form
    {
        private ReservationBL reservationBL;
        public frmCountTable()
        {
            reservationBL = new ReservationBL();
            InitializeComponent();
            LoadChart();
        }
        private void LoadChart()
        {
            // Lấy dữ liệu số lượng phòng theo tháng từ phương thức GetRoomCountByMonth
            DataTable data = reservationBL.CountOrder();

            // Xóa dữ liệu cũ trong Series
            chart1.Series.Clear();

            // Tạo một Series mới để vẽ biểu đồ đường
            Series series = new Series
            {
                Name = "RoomCount",
                IsVisibleInLegend = true, // Hiển thị chú giải
                ChartType = SeriesChartType.Line, // Kiểu biểu đồ đường
                BorderWidth = 3, // Độ rộng đường
                BorderColor = Color.Blue,
                Color = Color.Orange // Đặt màu cho Series (để hiển thị màu trong legend)

            };

            // Thêm dữ liệu vào Series
            foreach (DataRow row in data.Rows)
            {
                // Thêm tháng và số lượng phòng vào biểu đồ
                string monthYear = $"{row["Month"]}/{row["Year"]}";
                series.Points.AddXY(monthYear, row["RoomCount"]);
            }

            // Thêm Series vào Chart
            chart1.Series.Add(series);

            // Thiết lập các cài đặt cho biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Room Count";

        }


    }
}
