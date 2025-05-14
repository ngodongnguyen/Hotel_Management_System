using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class RoomDL:DataProvider
    {
        public bool AddRoom(Room room)
        {
            string sql = "INSERT INTO Room_Table(Room_Type, Room_Phone, Room_Available,Price) VALUES (@Room_Type, @Room_Phone, @Room_Available,@Price)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Room_Type", room.Type),
                new SqlParameter("@Room_Phone", room.Phone),
                new SqlParameter("@Room_Available", room.Available),
                new SqlParameter("@Price", room.Price)

            };
            try
            {
                // Thực thi câu lệnh SQL
                int result = MyExecuteNonQuery(sql, CommandType.Text, parameters);

                // Nếu có ít nhất một bản ghi được thêm vào, trả về true
                return result > 0;
            }
            catch (SqlException )
            {
                // Xử lý lỗi nếu có lỗi trong quá trình thực thi câu lệnh SQL
                throw ;
            }
        }
        public DataTable DisplayRoom()
        {
            string sql = "SELECT * FROM Room_Table";
            try
            {
                return MyExecuteQuery(sql, CommandType.Text);
            }
            catch (SqlException)
            {
                throw ;
            }
        }
        public DataTable SearchRoom(string keyword)
        {
            string sql = "SELECT * FROM Room_Table WHERE Room_Number LIKE @keyword";
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

        public bool UpdateRoom(Room room)
        {
            string sql = "UPDATE Room_Table SET Room_Type = @Room_Type, Room_Phone = @Room_Phone, Room_Available = @Room_Available,Price=@Price WHERE Room_Number = @Room_Number";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Room_Number", room.Number),
            new SqlParameter("@Room_Type", room.Type),
            new SqlParameter("@Room_Phone", room.Phone),
            new SqlParameter("@Room_Available", room.Available),
            new SqlParameter("@Price", room.Price)

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
        public bool DeleteRoom(Room room)
        {
            string sql = "DELETE FROM Room_Table WHERE Room_Number = @Room_Number";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Room_Number",room.Number)
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

        public bool UpdateReservationRoom(string roomNumber,string roomAvailable)
        {
            string sql= "UPDATE Room_Table SET Room_Available = @Room_Available WHERE Room_Number = @Room_Number";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@Room_Available",roomAvailable),
                new SqlParameter("@Room_Number",roomNumber)
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
        public bool UpdateRoom(int Reservation_ID)
        {
            string sql = "UPDATE Room_Table\r\nSET Room_Available = 'Yes'\r\nFROM Room_Table r\r\nJOIN Reservation_Table res ON r.Room_Number = res.Reservation_Room_Number\r\nwhere res.Reservation_ID=@Reservation_ID";
            SqlParameter[] parameters = new SqlParameter[]
{
                new SqlParameter("@Reservation_ID",Reservation_ID)
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
        public List<string> RoomTypes()
        {
            List<string> types = new List<string>();
            string sql = "SELECT DISTINCT Room_Type FROM Room_Table";
            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

            while (reader.Read())
            {
                types.Add(reader[0].ToString());
            }
            reader.Close();
            return types;
        }
        public List<string> RoomNumbers(string type)
        {
            List<string> numbers = new List<string>();
            string sql = "SELECT Room_Number FROM Room_Table WHERE Room_Type = @Room_Type AND Room_Available = 'Yes'";
            SqlParameter[] param = {
            new SqlParameter("@Room_Type", type)
        };

            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, param);

            while (reader.Read())
            {
                numbers.Add(reader[0].ToString());
            }

            reader.Close();
            return numbers;
        }


    }
}
