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
        public frmChooseDate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerS.Value;
            DateTime endDate = dateTimePickerE.Value;

            // Tạo một thể hiện mới của frmTotalRevenue và truyền tham số ngày vào
            frmTotalRevenue frmTotalRevenue = new frmTotalRevenue(startDate, endDate);
            frmTotalRevenue.ShowDialog();
        }
    }
}
