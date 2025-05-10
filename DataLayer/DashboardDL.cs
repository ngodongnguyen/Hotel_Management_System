using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DashboardDL:DataProvider
    {
        public int CountClients()
        {
            string sql = "SELECT COUNT(*) FROM Client_Table";
            SqlParameter[] parameters = new SqlParameter[0];
            try
            {
                return (int)MyExecuteScalar(sql, CommandType.Text, parameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public int CountUsers()
        {
            string sql = "SELECT COUNT(*) FROM User_Table";
            SqlParameter[] parameters = new SqlParameter[0];
            try
            {
                return (int)MyExecuteScalar(sql, CommandType.Text, parameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public int CountRooms()
        {
            string sql = "SELECT COUNT(*) FROM Room_Table";
            SqlParameter[] parameters = new SqlParameter[0];
            try
            {
                return (int)MyExecuteScalar(sql, CommandType.Text, parameters);
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
