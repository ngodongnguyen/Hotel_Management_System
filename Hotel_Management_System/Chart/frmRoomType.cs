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
    public partial class frmRoomType : Form
    {
        private ReservationBL reservationBL;
        private DateTime startDate;
        private DateTime endDate;
        public frmRoomType(DateTime sDate, DateTime eDate)
        {
            reservationBL = new ReservationBL();
            InitializeComponent();
            startDate = sDate;
            endDate = eDate;
            LoadChart();
        }
        private void LoadChart()
        {
            // Lấy dữ liệu từ BusinessLogicLayer
            DataTable data = reservationBL.GetRoomType(startDate,endDate);

            // Xóa dữ liệu cũ trong Series
            chart1.Series.Clear();

            // Tạo một Series mới để vẽ biểu đồ tròn
            Series series = new Series
            {
                Name = "RoomTypeSeries",
                IsVisibleInLegend = true, // Hiển thị chú giải
                ChartType = SeriesChartType.Pie, // Kiểu biểu đồ tròn
                BorderWidth = 1,
                BorderColor = Color.Black
            };

            // Thêm dữ liệu vào Series
            foreach (DataRow row in data.Rows)
            {
                series.Points.AddXY(row["Reservation_Room_Type"].ToString(), row["SoLuong"]);
            }

            // Thêm Series vào Chart
            chart1.Series.Add(series);

            // Thiết lập các cài đặt cho biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Room Type";
            chart1.ChartAreas[0].AxisY.Title = "Count";
        }
    }
}

