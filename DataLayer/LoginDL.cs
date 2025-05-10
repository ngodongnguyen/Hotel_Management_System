using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class LoginDL : DataProvider
    {
        public bool Login(Account account)
        {
            string sql = "SELECT COUNT(User_Name) FROM User_Table WHERE User_Name = @User_Name AND User_Password = @User_Password";
            // Tạo các tham số cho câu truy vấn
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@User_Name", account.Username),
                 new SqlParameter("@User_Password",  account.Password)
            };

            try
            {
                // Thực thi câu truy vấn với tham số
                return (int)MyExecuteScalar(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public bool AddUser(Account account)
        {
            string sql = "INSERT INTO User_Table(User_Name,User_Password) VALUES (@User_Name, @User_Password)";
            // Tạo tham số và gán giá trị cho chúng
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@User_Name", account.Username),
                new SqlParameter("@User_Password", account.Password), // Nên mã hóa mật khẩu trước khi lưu vào cơ sở dữ liệu
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
        public DataTable DisplayUsers()
        {
            string sql = "SELECT * FROM User_Table";
            try
            {
                return MyExecuteQuery(sql, CommandType.Text);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public DataTable SearchUsers(string keyword)
        {
            string sql = "SELECT * FROM User_Table WHERE User_Name LIKE @keyword ";
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

        public bool UpdateUser(Account account)
        {
            string sql = "UPDATE  User_Table SET User_Name=@User_Name, User_Password=@User_Password WHERE User_ID=@User_ID";
            // Tạo tham số và gán giá trị cho chúng
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@User_Name", account.Username),
                new SqlParameter("@User_Password", account.Password),
                new SqlParameter("@User_ID",account.ID)
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


        public bool DeleteUser(Account account)
        {
            string sql = "Delete FROM User_Table WHERE User_ID=@User_ID";
            // Tạo tham số và gán giá trị cho chúng
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@User_ID", account.ID),
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
    }
}
