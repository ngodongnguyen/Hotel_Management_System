using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class CheckOutDL:DataProvider
    {
        public DataTable DisplayCheckOut()
        {
            string sql = "select * from CheckOut";
            try
            {
                return MyExecuteQuery(sql, CommandType.Text);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public bool AddCheckOut(CheckOut checkOut)
        {
            string sql = "INSERT INTO CheckOut(Reservation_ID, Total_Price, CheckOut_Status) " +
                         "VALUES (@Reservation_ID, @Price, @CheckOut_Status)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Reservation_ID", checkOut.Reservation_ID),
        new SqlParameter("@Price", checkOut.Total_Price),
        new SqlParameter("@CheckOut_Status", checkOut.CheckOut_Status)
            };

            try
            {
                // Thực thi câu lệnh SQL
                int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);

                // Nếu có ít nhất một bản ghi được thêm vào, trả về true
                return result > 0;
            }
            catch (SqlException)
            {
                // Xử lý lỗi nếu có lỗi trong quá trình thực thi câu lệnh SQL
                throw;
            }
        }
        public bool UpdateCheckOut(int reservationId)
        {
            string sql = "UPDATE CheckOut SET CheckOut_Status = @CheckOut_Status WHERE Reservation_ID = @Reservation_ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@CheckOut_Status", "Completed"),  // Set trạng thái là "Completed"
        new SqlParameter("@Reservation_ID", reservationId)   // Tham số Reservation_ID để tìm bản ghi cần cập nhật
            };

            try
            {
                // Thực thi câu lệnh SQL
                int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);

                // Nếu có ít nhất một bản ghi được cập nhật, trả về true
                return result > 0;
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi nếu có lỗi trong quá trình thực thi câu lệnh SQL
                throw new Exception("Error updating CheckOut status", ex);
            }
        }


    }
}
