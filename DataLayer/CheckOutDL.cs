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
            string Total = "SELECT r.Reservation_In, r.Reservation_Out, rm.Price " +
                           "FROM Reservation_Table r " +
                           "JOIN Room_Table rm ON r.Reservation_Room_Number = rm.Room_Number " +
                           "WHERE r.Reservation_ID = @resId";

            SqlParameter param = new SqlParameter("@resId", reservationId);
            DataTable result = MyExecuteQuery(Total, CommandType.Text, new SqlParameter[] { param });

            if (result.Rows.Count > 0)
            {
                DateTime checkIn = Convert.ToDateTime(result.Rows[0]["Reservation_In"]);
                DateTime checkOut = Convert.ToDateTime(result.Rows[0]["Reservation_Out"]);
                decimal pricePerDay = Convert.ToDecimal(result.Rows[0]["Price"]);

                int numDays = (checkOut - checkIn).Days;
                if (numDays <= 0) numDays = 1;

                decimal totalPrice = pricePerDay * numDays;

                string sql = "UPDATE CheckOut SET CheckOut_Status = @CheckOut_Status, Total_Price = @total WHERE Reservation_ID = @Reservation_ID";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CheckOut_Status", "Completed"),
            new SqlParameter("@total", totalPrice),
            new SqlParameter("@Reservation_ID", reservationId)
                };

                try
                {
                    int result1 = MyExecuteNonQuery(sql, CommandType.Text, parameters);
                    return result1 > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error updating CheckOut status", ex);
                }
            }

            return false;
        }


    }
}
