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
    public partial class UserControlClient : UserControl
    {
        private ClientBL clientBL;
        private int ID = -1;
        public UserControlClient()
        {
            InitializeComponent();
            clientBL = new ClientBL();
        }
      
        public void Clear()
        {
            txbFirstname.Clear();
            txbLastname.Clear();
            txbPhone.Clear();
            txbAddress.Clear();
            tabControlClient.SelectedTab = tpAddClient;
        }
        public void Clear1()
        {
            txbFirstName1.Clear();
            txbLastName1.Clear();
            txbPhone1.Clear();
            txbAddress1.Clear();
            ID = -1;
        }

        private void tpAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string firstname, lastname, phone, address;
            firstname = txbFirstname.Text.Trim();
            lastname = txbLastname.Text.Trim();
            phone = txbPhone.Text.Trim();
            address = txbAddress.Text.Trim();

            Client client = new Client(firstname, lastname, phone, address);

            try
            {
                if (txbFirstname.Text.Trim() == string.Empty || txbLastname.Text.Trim() == string.Empty || txbPhone.Text.Trim() == string.Empty || txbAddress.Text.Trim() == string.Empty)
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
                        bool isAdded = clientBL.AddClient(client);

                        if (isAdded)
                        {
                            MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                            MessageBox.Show("Failed to add client. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txbSearchPhone_TextChanged(object sender, EventArgs e)
        {
            string keyword = txbSearchPhone.Text.Trim();
            dataGridViewClient.DataSource = clientBL.SearchClients(keyword);
        }

        private void tpSearchClient_Enter(object sender, EventArgs e)
        {
            dataGridViewClient.DataSource = clientBL.DisplayClients();
        }

        private void tpSearchClient_Leave(object sender, EventArgs e)
        {
            txbSearchPhone.Clear();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            int clientID = ID;
            string FirstName, LastName, Phone, Address;
            FirstName = txbFirstName1.Text.Trim();
            LastName = txbLastName1.Text.Trim();
            Phone = txbPhone1.Text.Trim();
            Address = txbAddress1.Text.Trim();

            Client clientUpdate = new Client(clientID, FirstName, LastName, Phone, Address);
            try
            {
                if (txbFirstName1.Text.Trim() == string.Empty || txbLastName1.Text.Trim() == string.Empty || txbPhone1.Text.Trim() == string.Empty || txbAddress1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please select a user to update and enter all field!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra định dạng số điện thoại
                if (!System.Text.RegularExpressions.Regex.IsMatch(Phone, @"^\d+$"))
                {
                    MessageBox.Show("Please only enter number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to update this client?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    bool isUpdated = clientBL.UpdateClient(clientUpdate);

                    if (isUpdated)
                    {

                        MessageBox.Show("Client updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();

                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to update client. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Vi phạm UNIQUE constraint (User_Name đã tồn tại)
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

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells[0].Value);
                txbFirstName1.Text = row.Cells[1].Value.ToString();
                txbLastName1.Text = row.Cells[2].Value.ToString();
                txbPhone1.Text = row.Cells[3].Value.ToString();
                txbAddress1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void tpUpdateandDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            int clientID = ID;
         
            Client clientDelete = new Client(clientID);
            try
            {
                if (ID==-1)
                { 
                    MessageBox.Show("Please select a user to delete!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                else
                {
                    bool isDeleted = clientBL.DeleteClient(clientDelete);

                    if (isDeleted)
                    {
                        MessageBox.Show("Client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to delete client. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

