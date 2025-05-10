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
    public class ClientDL : DataProvider
    {
        public bool AddClient(Client client)
        {
            string sql = "INSERT INTO Client_Table(Client_FirstName,Client_LastName,Client_Phone,Client_Address) VALUES (@Client_FirstName,@Client_LastName,@Client_Phone,@Client_Address)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Client_Firstname", client.FirstName),
                new SqlParameter("@Client_Lastname", client.LastName),
                new SqlParameter("@Client_Phone", client.Phone),
                new SqlParameter("@Client_Address", client.Address),
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
        public DataTable DisplayClients()
        {
            string sql = "SELECT * FROM Client_Table";
            try
            {
                return MyExecuteQuery(sql, CommandType.Text);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable SearchClients(string keyword)
        {
            string sql = "SELECT * FROM Client_Table WHERE Client_Phone LIKE @keyword";
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

        public bool UpdateClient(Client client)
        {
            string sql = "UPDATE Client_Table SET Client_FirstName = @Client_FirstName, Client_LastName = @Client_LastName, Client_Phone = @Client_Phone, Client_Address = @Client_Address WHERE Client_ID = @Client_ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Client_ID",client.ID),
                new SqlParameter("@Client_FirstName", client.FirstName),
                new SqlParameter("@Client_LastName", client.LastName),
                new SqlParameter("@Client_Phone", client.Phone),
                new SqlParameter("@Client_Address", client.Address)
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
        public bool DeleteClient(Client client)
        {
            string sql = "DELETE FROM Client_Table WHERE Client_ID = @Client_ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Client_ID",client.ID)
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

        //Hàm này để kiểm tra xem ID khách hàng có tồn tại hay không để thực hiện đặt phòng
        public bool ClientExist(int CID)
        {
            string sql = "SELECT COUNT(*) FROM Client_Table WHERE Client_ID=@Client_ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Client_ID",CID)
            };
            try
            {
                return (int)MyExecuteScalar(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
