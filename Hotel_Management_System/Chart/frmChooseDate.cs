using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Chart
{
    public partial class frmChooseDate : Form
    {
        public string FormType { get; set; }

        public frmChooseDate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerS.Value;
            DateTime endDate = dateTimePickerE.Value;

            if (FormType == "Room")
            {
                // Nếu là Room, mở form RoomType
                frmRoomType frmRoomType = new frmRoomType(startDate,endDate);
                frmRoomType.ShowDialog();
            }
            else if (FormType == "Total")
            {
                // Nếu là Total, mở form TotalRevenue
                frmTotalRevenue frmTotalRevenue = new frmTotalRevenue(startDate, endDate);
                frmTotalRevenue.ShowDialog();
                
            }
            else if (FormType == "TopC")
            {
                // Nếu là TopC, mở form FrequentCustomer
                frmFrequentCustomer frmFrequentCustomer=new frmFrequentCustomer(startDate, endDate);
                frmFrequentCustomer.ShowDialog();
                
            }
            else if (FormType == "TopSpend")
            {
                frmTopSpenders frmTopSpenders=new frmTopSpenders(startDate, endDate);
                frmTopSpenders.ShowDialog();
            }
        }
    }
}
