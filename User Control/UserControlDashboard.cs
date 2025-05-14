using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private DashboardBL dashboardBL;
        public UserControlDashboard()
        {
            InitializeComponent();
            dashboardBL = new DashboardBL();
        }
        public void User()
        {
            labelUserCount.Text = dashboardBL.CountUsers().ToString();
        }
        public void Client()
        {
            labelClientCount.Text = dashboardBL.CountClients().ToString();
        }
        public void Room()
        {
            labelRoomCount.Text = dashboardBL.CountRooms().ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }
    }
}
