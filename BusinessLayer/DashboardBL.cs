using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class DashboardBL
    {
        private DashboardDL dashboardDL;
        public DashboardBL()
        {
            dashboardDL = new DashboardDL();    
        }
        public int CountClients()
        {
            return dashboardDL.CountClients();
        }
        public int CountUsers()
        {
            return dashboardDL.CountUsers();
        }
        public int CountRooms()
        {
            return dashboardDL.CountRooms();
        }
    }
}
