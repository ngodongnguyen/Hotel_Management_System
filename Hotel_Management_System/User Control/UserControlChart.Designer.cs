namespace Hotel_Management_System.User_Control
{
    partial class UserControlChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlRoomType = new Hotel_Management_System.User_Control.UserControlRoomType();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoom
            // 
            this.btnRoom.AutoSize = true;
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(300, 32);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(178, 42);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Room Type";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(529, 32);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(178, 42);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(32, 32);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(222, 42);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Total Revenue";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCount);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.userControlRoomType);
            this.panel1.Location = new System.Drawing.Point(63, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 100);
            this.panel1.TabIndex = 4;
            // 
            // userControlRoomType
            // 
            this.userControlRoomType.BackColor = System.Drawing.Color.Linen;
            this.userControlRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoomType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRoomType.Location = new System.Drawing.Point(0, 0);
            this.userControlRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlRoomType.Name = "userControlRoomType";
            this.userControlRoomType.Size = new System.Drawing.Size(723, 100);
            this.userControlRoomType.TabIndex = 0;
            this.userControlRoomType.Visible = false;
            // 
            // UserControlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlChart";
            this.Size = new System.Drawing.Size(828, 282);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Panel panel1;
        private User_Control.UserControlRoomType userControlRoomType;

    }
}
