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

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlCheckOut : UserControl
    {
        private CheckOutBL checkOutBL;
        public UserControlCheckOut()
        {
            InitializeComponent();
            checkOutBL = new CheckOutBL();
        }
        public void GetData()
        {
            dataGridView1.DataSource = checkOutBL.DisplayCheckOut();
            AddCheckOutButtonColumn();

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

                // Thông báo hoặc thực hiện hành động cần thiết
                // Cập nhật lại DataGridView sau khi xử lý
                GetData();
            }
        }
    }
}
