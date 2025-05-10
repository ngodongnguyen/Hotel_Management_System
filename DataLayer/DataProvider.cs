using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public class DataProvider
    {
        private SqlConnection cn;
        //public DataProvider()
        //{
        //    string cnStr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        //    cn = new SqlConnection(cnStr);
        //}
        public DataProvider() {
            string cnStr = @"Data Source=NGUYEN;Initial Catalog=Hotel_Management_System;Integrated Security=True;";
            cn = new SqlConnection(cnStr);
        }

        private void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void Disconnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public object MyExecuteScalar(string sql, CommandType type, SqlParameter[] parameters)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                cmd.Parameters.AddRange(parameters);
                return (cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        // Phương thức thực thi câu lệnh SQL không trả về giá trị (INSERT, UPDATE, DELETE)
        public int MyExecuteNonQuery(string sql, CommandType type, SqlParameter[] parameters)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                // Thêm tham số vào câu lệnh SQL
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();  // Trả về số bản ghi bị ảnh hưởng
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable MyExecuteQuery(string sql, CommandType type, SqlParameter[] parameters = null)
        {
            try
            {
                Connect();
                using (var cmd = new SqlCommand(sql, cn) { CommandType = type })
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public SqlDataReader MyExecuteReader(string sql, CommandType type, SqlParameter[] parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                // CommandBehavior.CloseConnection để tự đóng kết nối sau khi đọc xong
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            // Không cần gọi Disconnect() ở đây vì nó sẽ tự động đóng sau khi reader bị đóng.
        }


    }
}
