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
            this.btnTopCustomer = new System.Windows.Forms.Button();
            this.btnTopSpenders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoom
            // 
            this.btnRoom.AutoSize = true;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(486, 112);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(178, 44);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Room Type";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(734, 112);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(178, 44);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(200, 112);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(222, 44);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Total Revenue";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTopSpenders);
            this.panel1.Controls.Add(this.btnTopCustomer);
            this.panel1.Controls.Add(this.btnCount);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 430);
            this.panel1.TabIndex = 4;
            // 
            // btnTopCustomer
            // 
            this.btnTopCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopCustomer.Location = new System.Drawing.Point(302, 245);
            this.btnTopCustomer.Name = "btnTopCustomer";
            this.btnTopCustomer.Size = new System.Drawing.Size(215, 44);
            this.btnTopCustomer.TabIndex = 4;
            this.btnTopCustomer.Text = "Top Customer";
            this.btnTopCustomer.UseVisualStyleBackColor = true;
            this.btnTopCustomer.Click += new System.EventHandler(this.btnTopCustomer_Click);
            // 
            // btnTopSpenders
            // 
            this.btnTopSpenders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSpenders.Location = new System.Drawing.Point(614, 245);
            this.btnTopSpenders.Name = "btnTopSpenders";
            this.btnTopSpenders.Size = new System.Drawing.Size(213, 44);
            this.btnTopSpenders.TabIndex = 5;
            this.btnTopSpenders.Text = "Top Spenders";
            this.btnTopSpenders.UseVisualStyleBackColor = true;
            this.btnTopSpenders.Click += new System.EventHandler(this.btnTopSpenders_Click);
            // 
            // UserControlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlChart";
            this.Size = new System.Drawing.Size(1102, 462);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTopCustomer;
        private System.Windows.Forms.Button btnTopSpenders;
    }
}
