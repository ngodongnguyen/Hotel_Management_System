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
            LoadRoomTypes();
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
            comboBoxNumber.SelectedIndex = -1;
            comboBoxType1.SelectedIndex = 0;
            comboBoxNumber1.SelectedIndex = -1;

        }

        private void tpAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = -1;
            comboBoxNumber1.SelectedIndex = -1;
            txbClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = -1;
        }
        private void LoadRoomTypes()
        {
            comboBoxType.Items.Clear();
            comboBoxType.Items.Add("Please select ...");
            comboBoxType.SelectedIndex = 0;

            List<RoomTypeAndPrice> roomTypes = roomBL.RoomTypes();

            foreach (RoomTypeAndPrice item in roomTypes)
            {
                comboBoxType.Items.Add(item); // sẽ hiện thị đẹp nhờ ToString override
            }


            comboBoxType1.Items.Clear();
            comboBoxType1.Items.Add("Please select ...");
            comboBoxType1.SelectedIndex = 0;

            List<RoomTypeAndPrice> roomTypes1 = roomBL.RoomTypes();

            foreach (RoomTypeAndPrice item in roomTypes1)
            {
                comboBoxType1.Items.Add(item); // sẽ hiện thị đẹp nhờ ToString override
            }

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
            var selectedRoom = (RoomTypeAndPrice)comboBoxType.SelectedItem;
            decimal R_Price = selectedRoom?.Price ?? 0m;
            string R_Type = selectedRoom?.Type ?? "";// Trả về chuỗi trống nếu selectedRoom là null
            // Chuyển giá trị từ ComboBox sang int cho 'R_Number'
            int R_Number = int.Parse(comboBoxNumber.SelectedItem.ToString());

            DateTime In = dateTimePickerIn.Value;
            DateTime Out = dateTimePickerOut.Value;
            if (In >= Out)
            {
                MessageBox.Show("Check-In date must be before Check-Out date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reservation reservation = new Reservation(R_Type, R_Price, R_Number, ClientID, In, Out);

            try
            {

                bool isAdded = reservationBL.AddReservation(reservation);

                if (isAdded)
                {
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
            var selectedRoom = (RoomTypeAndPrice)comboBoxType1.SelectedItem;
            decimal R_Price = selectedRoom?.Price ?? 0m;
            string R_Type = selectedRoom?.Type ?? "";// Trả về chuỗi trống nếu selectedRoom là null
            // Chuyển giá trị từ ComboBox sang int cho 'R_Number'
            int R_Number = int.Parse(comboBoxNumber1.SelectedItem.ToString());
            int ID = RID;
            DateTime In = dateTimePickerIn1.Value;
            DateTime Out = dateTimePickerOut1.Value;
            if (In >= Out)
            {
                MessageBox.Show("Check-In date must be before Check-Out date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reservation reservation = new Reservation(ID, R_Type, R_Price, R_Number, ClientID, In, Out);
            try
            {
                var result = MessageBox.Show("Are you sure you want to update this reservation?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if (comboBoxType1.SelectedItem is RoomTypeAndPrice selectedType)
            {
                string type = selectedType.Type;
                decimal price = selectedType.Price;

                List<string> roomNumbers = roomBL.RoomNumbers(type, price); // Gọi đúng hàm đã sửa

                comboBoxNumber1.Items.Clear();

                foreach (var number in roomNumbers)
                {
                    comboBoxNumber1.Items.Add(number);
                }
                comboBoxNumber1.SelectedIndex = -1;
            }
        }

        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem is RoomTypeAndPrice selectedType)
            {
                string type = selectedType.Type;
                decimal price = selectedType.Price;

                List<string> roomNumbers = roomBL.RoomNumbers(type, price); // Gọi đúng hàm đã sửa

                comboBoxNumber.Items.Clear();


                foreach (var number in roomNumbers)
                {
                    comboBoxNumber.Items.Add(number);
                }

                comboBoxNumber.SelectedIndex = -1;
            }
        }
        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];

                // Lấy thông tin từ dòng
                RID = Convert.ToInt32(row.Cells[0].Value);
                string r_Type = row.Cells[1].Value.ToString();
                decimal r_Price = Convert.ToDecimal(row.Cells[2].Value);
                No = row.Cells[3].Value.ToString();
                txbClientID1.Text = row.Cells[4].Value.ToString();

                // Lấy và gán ngày CheckIn
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime checkIn))
                    dateTimePickerIn1.Value = checkIn;
                else
                    dateTimePickerIn1.Value = DateTime.Now;

                // Lấy và gán ngày CheckOut
                if (DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime checkOut))
                    dateTimePickerOut1.Value = checkOut;
                else
                    dateTimePickerOut1.Value = DateTime.Now;
                // Nạp lại danh sách loại phòng (RoomTypeAndPrice)
                comboBoxType1.Items.Clear();
                var types = roomBL.RoomTypes();
                RoomTypeAndPrice selectedType = null;

                foreach (var type in types)
                {
                    comboBoxType1.Items.Add(type);
                    if (type.Type == r_Type && type.Price == r_Price)
                    {
                        selectedType = type;
                    }
                }

                // Chọn loại phòng phù hợp
                if (selectedType != null)
                {
                    comboBoxType1.SelectedItem = selectedType;
                }
            }
        }
    }
}

