using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TransferObject;
using BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Hotel_Management_System
{
    public partial class FormLogin : Form
    {
        private LoginBL loginBL;
        public FormLogin()
        {
            InitializeComponent();
            loginBL= new LoginBL();
        }

        bool UserLogin(Account account)
        {
            try
            {
                return loginBL.Login(account);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; //Đăng nhập thất bại
            }

        }

        private void pictureBox_Minimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox_Minimize, "Minimize"); //hien thi chu minimize khi re chuot vao
        }

        private void pictureBox_Close_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox_Close, "Close");
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox_Show_Click(object sender, EventArgs e)
        {
            pictureBox_Show.Hide();
            tbPassword.UseSystemPasswordChar = false;
            pictureBox_Hide.Show();
        }

        private void pictureBox_Hide_Click(object sender, EventArgs e)
        {
            pictureBox_Hide.Hide();
            tbPassword.UseSystemPasswordChar = true;
            pictureBox_Show.Show();
        }

        private void pictureBox_Show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox_Show, "Show Password");
        }

        private void pictureBox_Hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox_Hide, "Hide Password");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = tbUsername.Text.Trim();
            pass = tbPassword.Text.Trim();

            Account account = new Account(user, pass);
            if (tbUsername.Text.Trim() == string.Empty || tbPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please enter all field!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (UserLogin(account) == true)
                {
                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.Username = tbUsername.Text;
                    tbUsername.Clear();
                    tbPassword.Clear();
                    formDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Clear();
                    tbUsername.Clear();
                    tbUsername.Focus();
                }
            }
        }
    }
}
