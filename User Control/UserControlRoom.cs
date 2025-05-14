using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        private RoomBL roomBL;
        private string Available = "";
        private int Number = -1;
        public UserControlRoom()
        {
            InitializeComponent();
            roomBL = new RoomBL();
            LoadRoomTypes();
        }


        public void Clear()
        {
            comboBoxType.SelectedIndex = -1;
            txbPhoneNumber.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlRoom.SelectedTab = tpAddRoom;
        }
        public void LoadRoomTypes()
        {
            List <RoomTypeAndPrice> list =new List<RoomTypeAndPrice>
                {
                new RoomTypeAndPrice("Single", 800000),
                new RoomTypeAndPrice("Double", 1500000),
                new RoomTypeAndPrice("Family", 3800000),
                new RoomTypeAndPrice("Suite", 4700000)
                }; 
            comboBoxType.DataSource= list;
            comboBoxType.DisplayMember = "ToString";

            comboBoxType1.DataSource = list;
            comboBoxType1.DisplayMember = "ToString";
        }


        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            string type, phone, available;
            // Lấy giá trị từ ComboBox
            var selectedRoom = (RoomTypeAndPrice)comboBoxType.SelectedItem;
            decimal price = selectedRoom?.Price ?? 0m;
            type = selectedRoom?.Type??"";// Trả về chuỗi trống nếu selectedRoom là null
            phone = txbPhoneNumber.Text.Trim();
            available = radioButtonYes.Checked ? "Yes" : radioButtonNo.Checked ? "No" : "";

            Room room = new Room(type,price, phone, available);

            try
            {
                if (comboBoxType.SelectedIndex == -1 || txbPhoneNumber.Text.Trim() == string.Empty || available == "")
                    MessageBox.Show("Please enter all field!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // Kiểm tra định dạng số điện thoại
                    if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
                    {
                        MessageBox.Show("Please only enter number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        bool isAdded = roomBL.AddRoom(room);

                        if (isAdded)
                        {
                            MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                            MessageBox.Show("Failed to add room. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Vi phạm UNIQUE constraint (Phone đã tồn tại)
                {
                    MessageBox.Show("Phone already exists. Please choose a different one.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("SQL Error:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tpSearchRoom_Enter(object sender, EventArgs e)
        {
            dataGridViewRoom.DataSource = roomBL.DisplayRoom();

        }

        private void tpSearchRoom_Leave(object sender, EventArgs e)
        {
            txbSearchRoom.Clear();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                Number = Convert.ToInt32(row.Cells[0].Value);
                string roomType = row.Cells[1].Value.ToString();
                decimal roomPrice = Convert.ToDecimal(row.Cells[2].Value);
                txbPhoneNumber1.Text = row.Cells[3].Value.ToString();
                Available = row.Cells[4].Value.ToString();
                if (Available == "Yes")
                    radioButtonYes1.Checked = true;
                if (Available == "No")
                    radioButtonNo1.Checked = true;
                // Tìm đối tượng trong comboBox khớp với cả Type và Price
                foreach (RoomTypeAndPrice item in comboBoxType1.Items)
                {
                    if (item.Type == roomType && item.Price == roomPrice)
                    {
                        comboBoxType1.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void txbSearchRoom_TextChanged(object sender, EventArgs e)
        {
            string keyword = txbSearchRoom.Text.Trim();
            dataGridViewRoom.DataSource = roomBL.SearchRoom(keyword);
        }
      
        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            int RoomNumber = Number;
            string type, phone, available;
            // Lấy giá trị từ ComboBox
            var selectedRoom = (RoomTypeAndPrice)comboBoxType1.SelectedItem;
            decimal price = selectedRoom?.Price ?? 0m;
            type = selectedRoom?.Type ?? "";// Trả về chuỗi trống nếu selectedRoom là null
            phone = txbPhoneNumber1.Text.Trim();
            available = radioButtonYes1.Checked ? "Yes" : radioButtonNo1.Checked ? "No" : "";

            Room room = new Room(RoomNumber, type, price, phone, available);
            try
            {
                if (comboBoxType1.SelectedIndex == -1 || txbPhoneNumber1.Text.Trim() == string.Empty || available == "")
                {
                    MessageBox.Show("Please select a user to update and enter all field!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra định dạng số điện thoại
                if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
                {
                    MessageBox.Show("Please only enter number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to update this room?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    bool isUpdated = roomBL.UpdateRoom(room);

                    if (isUpdated)
                    {

                        MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();

                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to update room. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Vi phạm UNIQUE constraint 
                {
                    MessageBox.Show("Phone already exists. Please choose a different one.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("SQL Error:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear1()
        {
            comboBoxType1.SelectedIndex = -1;
            txbPhoneNumber1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            Number = -1;
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int Roonumber = Number;

            Room room = new Room(Roonumber);
            try
            {
                if (Number == -1)
                {
                    MessageBox.Show("Please select a room to delete!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                else
                {
                    bool isDeleted = roomBL.DeleteRoom(room);

                    if (isDeleted)
                    {
                        MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to delete room. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpUpdateandDeleteRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}
