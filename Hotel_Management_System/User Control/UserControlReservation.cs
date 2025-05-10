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
    public partial class UserControlReservation : UserControl
    {
        private ReservationBL reservationBL;
        private CheckOutBL checkOutBL;
        private RoomBL roomBL;
        private ClientBL clientBL;
        private string No = "";
        private int RID = -1;
        
        public UserControlReservation()
        {
            InitializeComponent();
            reservationBL = new ReservationBL();
            roomBL = new RoomBL();
            clientBL = new ClientBL();
            checkOutBL = new CheckOutBL();
        }
        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNumber.SelectedIndex = -1;
            txbClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tpAddReservation;
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {

            comboBoxType.SelectedIndex = 0;
            comboBoxNumber.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
            comboBoxNumber1.SelectedIndex = 0;

        }

        private void tpAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNumber1.SelectedIndex = 0;
            txbClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = -1;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {

            if (comboBoxType.SelectedIndex == -1 || comboBoxNumber.SelectedIndex == -1 || txbClientID.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int ClientID;
            if (!int.TryParse(txbClientID.Text.Trim(), out ClientID))
            {
                MessageBox.Show("Client ID must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!clientBL.ClientExist(ClientID))
            {
                MessageBox.Show("Client ID does not exist!. Please check.", "ID Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string R_Type = comboBoxType.SelectedItem?.ToString() ?? "";

            // Chuyển giá trị từ ComboBox sang int cho 'R_Number'
            int R_Number = int.Parse(comboBoxNumber.SelectedItem.ToString());

            DateTime In = dateTimePickerIn.Value;
            DateTime Out = dateTimePickerOut.Value;

            Reservation reservation = new Reservation(R_Type, R_Number, ClientID, In, Out);

            try
            {

                bool isAdded = reservationBL.AddReservation(reservation);

                if (isAdded)
                {
                    Reservation_Room reservation_Room = reservationBL.GetPrice(R_Number);
                    CheckOut checkOut = new CheckOut(R_Number, reservation_Room.Price, "Đang sử dụng");
                    checkOutBL.AddCheckOut(checkOut);
                    
                    //CheckOut checkOut = new CheckOut(R_Number,)

                    roomBL.UpdateReservationRoom(comboBoxNumber.SelectedItem.ToString(), "No");
                    MessageBox.Show("Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                    MessageBox.Show("Failed to add reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpSearchReservation_Enter(object sender, EventArgs e)
        {
            dataGridViewReservation.DataSource = reservationBL.DisplayReservation();
        }

        private void tpSearchReservation_Leave(object sender, EventArgs e)
        {
            txbSearchClientID.Clear();
        }

        private void txbSearchClientID_TextChanged(object sender, EventArgs e)
        {
            string keyword = txbSearchClientID.Text.Trim();
            dataGridViewReservation.DataSource = reservationBL.SearchReservation(keyword);
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = Convert.ToInt32(row.Cells[0].Value);
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                txbClientID1.Text = row.Cells[3].Value.ToString();
                if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime checkIn))
                {
                    dateTimePickerIn.Value = checkIn;
                }
                else
                {
                    dateTimePickerIn.Value = DateTime.Now;
                }

                if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime checkOut))
                {
                    dateTimePickerOut1.Value = checkOut;
                }
                else
                {
                    dateTimePickerOut1.Value = DateTime.Now;
                }

            }
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {

            if (comboBoxType1.SelectedIndex == -1 || comboBoxNumber1.SelectedIndex == -1 || txbClientID1.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int ClientID;
            if (!int.TryParse(txbClientID1.Text.Trim(), out ClientID))
            {
                MessageBox.Show("Client ID must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!clientBL.ClientExist(ClientID))
            {
                MessageBox.Show("Client ID does not exist!. Please check.", "ID Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string R_Type = comboBoxType1.SelectedItem?.ToString() ?? "";

            // Chuyển giá trị từ ComboBox sang int cho 'R_Number'
            int R_Number = int.Parse(comboBoxNumber1.SelectedItem.ToString());
            int ID= RID;
            DateTime In = dateTimePickerIn1.Value;
            DateTime Out = dateTimePickerOut1.Value;

            Reservation reservation = new Reservation(ID,R_Type, R_Number, ClientID, In, Out);
            try
            {
                var result = MessageBox.Show("Are you sure you want to update this room?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                bool isUpdated = reservationBL.UpdateReservation(reservation);
                if (isUpdated)
                {
                    // Nếu thay đổi phòng, cập nhật lại trạng thái phòng cũ và phòng mới
                    if (No != R_Number.ToString())
                    {
                        roomBL.UpdateReservationRoom(No, "Yes"); // Đưa phòng cũ về trạng thái "Yes"
                        roomBL.UpdateReservationRoom(comboBoxNumber1.SelectedItem.ToString(), "No"); // Đưa phòng mới về trạng thái "No"
                    }
                    MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                    MessageBox.Show("Failed to update reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (SqlException ex)
            {
              
                MessageBox.Show("SQL Error:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            int ReservationID = RID;
            Reservation reservation = new Reservation(ReservationID);
            try
            {
                if (RID == -1)
                {
                    MessageBox.Show("Please select a reservation to cancel!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                else
                {
                    bool isCanceled = reservationBL.CancelReservation(reservation);

                    if (isCanceled)
                    {
                        roomBL.UpdateReservationRoom(No, "Yes");
                        MessageBox.Show("Reservation canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to cancel reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpUpdateandCancelReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType1.SelectedIndex <= 0) return;

            comboBoxNumber1.Items.Clear();
            comboBoxNumber1.Items.Add("Please select ...");
            string type = comboBoxType1.SelectedItem.ToString();
            List<string> reader = roomBL.RoomNumbers(type);
            foreach (var number in reader)
            {
                comboBoxNumber1.Items.Add(number);
            }
            comboBoxNumber1.SelectedIndex = 0;
        }

        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex <= 0) return;

            comboBoxNumber.Items.Clear();
            comboBoxNumber.Items.Add("Please select ...");
            string type = comboBoxType.SelectedItem.ToString();
            List<string> reader = roomBL.RoomNumbers(type);
            foreach (var number in reader)
            {
                comboBoxNumber.Items.Add(number);
            }
            comboBoxNumber.SelectedIndex = 0;
        }
    }
}
