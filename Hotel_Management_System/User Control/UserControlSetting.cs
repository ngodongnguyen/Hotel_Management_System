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
using System.Security.Principal;

namespace Hotel_Management_System.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        private LoginBL loginBL;
        private int ID = -1;
        public UserControlSetting()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }
        public void Clear()
        {
            txbUsername.Clear();
            txbPassword.Clear();
            tabControlUser.SelectedTab = tpAddUser;
        }

        public void Clear1()
        {
            txbUsername1.Clear();
            txbPassword1.Clear();
            ID = -1;
        }

        private void tpAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tpSearchUser_Enter(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = loginBL.DisplayUsers();
        }

        private void tpSearchUser_Leave(object sender, EventArgs e)
        {
            txbSearchUsername.Clear();
        }

        private void tpUpdateandDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txbUsername.Text.Trim();
            pass = txbPassword.Text.Trim();

            Account account = new Account(user, pass);

            try
            {
                if (txbUsername.Text.Trim() == string.Empty || txbPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter all field!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    bool isAdded = loginBL.AddUser(account);

                    if (isAdded)
                    {
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Vi phạm UNIQUE constraint (User_Name đã tồn tại)
                {
                    MessageBox.Show("Password already exists. Please choose a different one.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void txbSearchUsername_TextChanged_1(object sender, EventArgs e)
        {

            string keyword = txbSearchUsername.Text.Trim();
            dataGridViewUser.DataSource = loginBL.SearchUsers(keyword);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int userId = ID; // ID lấy từ cell click
            string user1 = txbUsername1.Text.Trim();
            string pass1 = txbPassword1.Text.Trim();

            Account account = new Account(userId, user1, pass1);
            try
            {
                if (txbUsername1.Text.Trim() == string.Empty || txbPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please select a user to update!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to update this user?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    bool isUpdated = loginBL.UpdateUser(account);
                    if (isUpdated)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Vi phạm UNIQUE constraint (User_Name đã tồn tại)
                {
                    MessageBox.Show("Password already exists. Please choose a different one.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void btnDelete_Click(object sender, EventArgs e)
        {

            int userId = ID; // ID lấy từ cell click
          

            Account accountDelete = new Account(userId);
            try
            {
                if (ID==-1)
                {
                    MessageBox.Show("Please select a user to delete!", "Field is empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    bool isDeleted = loginBL.DeleteUser(accountDelete);
                    if (isDeleted)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                    else
                    {
                        // Trường hợp thất bại nhưng không có lỗi, bạn có thể xử lý thêm tùy yêu cầu
                        MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = Convert.ToInt32(row.Cells[0].Value);
                txbUsername1.Text = row.Cells[1].Value.ToString();
                txbPassword1.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
