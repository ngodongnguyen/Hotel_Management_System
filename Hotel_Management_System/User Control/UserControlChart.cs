using Hotel_Management_System;
using Hotel_Management_System.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlChart : UserControl
    {
        public UserControlChart()
        {
            InitializeComponent();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoomType frmRoomType = new frmRoomType();
            frmRoomType.ShowDialog();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            frmChooseDate frmChooseDate = new frmChooseDate();
            frmChooseDate.ShowDialog();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
           frmCountTable frmCountTable = new frmCountTable();
           frmCountTable.ShowDialog();
        }
    }
}
