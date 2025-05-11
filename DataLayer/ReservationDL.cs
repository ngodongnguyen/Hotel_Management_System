using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using System.Security.Cryptography;

namespace DataLayer
{
    public class ReservationDL:DataProvider
    {
        public bool AddReservation(Reservation reservation)
        {
            string sql = "INSERT INTO Reservation_Table OUTPUT INSERTED.Reservation_ID VALUES (@ReservationRoomType, @ReservationRoomNumber, @ReservationClientID, @ReservationIn, @ReservationOut);";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@ReservationRoomType", reservation.R_Type),
                new SqlParameter("@ReservationRoomNumber",reservation.R_Number),
                new SqlParameter("@ReservationClientID", reservation.ClientID),
                new SqlParameter("@ReservationIn",reservation.In),
                new SqlParameter("@ReservationOut",reservation.Out)
           };
            try
            {
                // Thực thi câu lệnh SQL
                reservation.ID = (int)MyExecuteScalar(sql, CommandType.Text, parameters);

                // Nếu có ít nhất một bản ghi được thêm vào, trả về true
                return reservation.ID > 0;
            }
            catch (SqlException)
            {
                // Xử lý lỗi nếu có lỗi trong quá trình thực thi câu lệnh SQL
                throw;
            }
        }
        public DataTable DisplayReservation()
        {
            string sql = "SELECT * FROM Reservation_Table";
            try
            {
                return MyExecuteQuery(sql, CommandType.Text);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable CountOrder()
        {
            string sql = "SELECT \r\n    YEAR(r.Reservation_Out) AS Year,\r\n    MONTH(r.Reservation_Out) AS Month,\r\n    COUNT(r.Reservation_Room_Type) AS RoomCount\r\nFROM \r\n    Reservation_Table AS r\r\nJOIN \r\n    CheckOut AS c ON r.Reservation_ID = c.Reservation_ID\r\nWHERE \r\n    c.CheckOut_Status = 'Completed'\r\nGROUP BY \r\n    YEAR(r.Reservation_Out), MONTH(r.Reservation_Out)\r\nORDER BY \r\n    Year, Month;";
            try
            {
                return MyExecuteQuery(sql, CommandType.Text);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public Reservation_Room GetPrice(int reservationId)
        {
            string sql = "SELECT r.Reservation_ID, t.Price " +
                         "FROM Reservation_Table AS r " +
                         "JOIN Room_Table AS t ON r.Reservation_Room_Number = t.Room_Number " +
                         "WHERE r.Reservation_Room_Number = @Reservation_Room_Number"; // Điều kiện có thể thay đổi theo yêu cầu

            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@Reservation_Room_Number",reservationId)
                };

                DataTable dt = MyExecuteQuery(sql, CommandType.Text,parameter);

                if (dt.Rows.Count > 0)
                {
                    // Lấy dữ liệu từ DataTable và chuyển thành đối tượng Reservation_Room
                    int resId = Convert.ToInt32(dt.Rows[0]["Reservation_ID"]);
                    decimal price = Convert.ToDecimal(dt.Rows[0]["Price"]);

                    // Khởi tạo đối tượng Reservation_Room với tham số
                    Reservation_Room reservationRoom = new Reservation_Room(resId, price);
                    return reservationRoom;  // Trả về đối tượng Reservation_Room
                }
                return null;  // Trả về null nếu không có kết quả
            }
            catch (SqlException)
            {
                throw;  // Xử lý ngoại lệ
            }
        }
        public DataTable GetTotalRevenue(DateTime sdate, DateTime edate)
        {
            string sql = "SELECT \r\n    CAST(r.Reservation_Out AS DATE) AS CheckOutDate, \r\n    SUM(c.Total_Price) AS TotalRevenue\r\nFROM \r\n    Reservation_Table AS r\r\nJOIN \r\n    CheckOut AS c ON r.Reservation_ID = c.Reservation_ID\r\nWHERE \r\n    c.CheckOut_Status = 'Completed' \r\n    AND r.Reservation_In BETWEEN @startdate AND @endate\r\nGROUP BY \r\n    CAST(r.Reservation_Out AS DATE)\r\nORDER BY \r\n    CheckOutDate;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@startdate",sdate),
                new SqlParameter("@endate",edate)
            };
            try
            {
                return MyExecuteQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable SearchReservation(string keyword)
        {
            string sql = "SELECT * FROM Reservation_Table WHERE Reservation_Client_ID LIKE @keyword";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@keyword", "%" + keyword + "%")
            };

            try
            {
                return MyExecuteQuery(sql, CommandType.Text, parameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public bool UpdateReservation(Reservation reservation)
        {
            string sql = "UPDATE Reservation_Table SET Reservation_Room_Type = @ReservationRoomType, Reservation_Room_Number = @ReservationRoomNumber, Reservation_Client_ID = @ReservationClientID, Reservation_In = @ReservationIn, Reservation_Out = @ReservationOut WHERE Reservation_ID = @ReservationID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ReservationID", reservation.ID),
            new SqlParameter("@ReservationRoomType", reservation.R_Type),
            new SqlParameter("@ReservationRoomNumber", reservation.R_Number),
            new SqlParameter("@ReservationClientID", reservation.ClientID),
            new SqlParameter("@ReservationIn", reservation.In),
            new SqlParameter("@ReservationOut", reservation.Out)
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
                throw;
            }
        }
        public bool CancelReservation(Reservation reservation)
        {
            string sql = "DELETE FROM Reservation_Table WHERE Reservation_ID = @ReservationID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ReservationID",reservation.ID)
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
                throw;
            }
        }
        public DataTable GetCheckOutData()
        {
            string sql = "select * from CheckOut, Reservation_Table  where CheckOut.Reservation_ID=Reservation_Table.Reservation_ID";
            // Giả sử bạn đã có phương thức MyExecuteQuery để lấy dữ liệu từ cơ sở dữ liệu
            return MyExecuteQuery(sql, CommandType.Text);  // Trả về DataTable
        }
        public DataTable GetRoomType()
        {
            string sql = "select Reservation_Room_Type,count(Reservation_Room_Type) as SoLuong from CheckOut, Reservation_Table  where CheckOut.Reservation_ID=Reservation_Table.Reservation_ID and CheckOut_Status='Completed' group by Reservation_Room_Type";
            return MyExecuteQuery(sql, CommandType.Text);  // Trả về DataTable
        }

    }
}
