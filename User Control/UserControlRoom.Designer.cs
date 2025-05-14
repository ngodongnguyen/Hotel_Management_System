namespace Hotel_Management_System.User_Control
{
    partial class UserControlRoom
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tpAddRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.txbSearchRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUpdateandDeleteRoom = new System.Windows.Forms.TabPage();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.txbPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlRoom.SuspendLayout();
            this.tpAddRoom.SuspendLayout();
            this.tpSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tpUpdateandDeleteRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tpAddRoom);
            this.tabControlRoom.Controls.Add(this.tpSearchRoom);
            this.tabControlRoom.Controls.Add(this.tpUpdateandDeleteRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(12, 15);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1068, 430);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tpAddRoom
            // 
            this.tpAddRoom.Controls.Add(this.radioButtonNo);
            this.tpAddRoom.Controls.Add(this.radioButtonYes);
            this.tpAddRoom.Controls.Add(this.labelAvailable);
            this.tpAddRoom.Controls.Add(this.comboBoxType);
            this.tpAddRoom.Controls.Add(this.btnAddRoom);
            this.tpAddRoom.Controls.Add(this.txbPhoneNumber);
            this.tpAddRoom.Controls.Add(this.lblPhone);
            this.tpAddRoom.Controls.Add(this.txbUsername);
            this.tpAddRoom.Controls.Add(this.lblType);
            this.tpAddRoom.Controls.Add(this.label4);
            this.tpAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tpAddRoom.Name = "tpAddRoom";
            this.tpAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddRoom.Size = new System.Drawing.Size(1060, 396);
            this.tpAddRoom.TabIndex = 0;
            this.tpAddRoom.Text = "Add Room";
            this.tpAddRoom.UseVisualStyleBackColor = true;
            this.tpAddRoom.Leave += new System.EventHandler(this.tpAddRoom_Leave);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(301, 219);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(56, 25);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(301, 188);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(61, 25);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // labelAvailable
            // 
            this.labelAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.Location = new System.Drawing.Point(181, 200);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(98, 22);
            this.labelAvailable.TabIndex = 0;
            this.labelAvailable.Text = "Available:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxType.Location = new System.Drawing.Point(185, 128);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(332, 29);
            this.comboBoxType.TabIndex = 1;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(185, 294);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(137, 40);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhoneNumber.Location = new System.Drawing.Point(604, 127);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(332, 30);
            this.txbPhoneNumber.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(601, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(147, 22);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUsername.Location = new System.Drawing.Point(185, 127);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(0, 30);
            this.txbUsername.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(181, 91);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(57, 22);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Room: ";
            // 
            // tpSearchRoom
            // 
            this.tpSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tpSearchRoom.Controls.Add(this.txbSearchRoom);
            this.tpSearchRoom.Controls.Add(this.label2);
            this.tpSearchRoom.Controls.Add(this.label1);
            this.tpSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tpSearchRoom.Name = "tpSearchRoom";
            this.tpSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchRoom.Size = new System.Drawing.Size(1060, 396);
            this.tpSearchRoom.TabIndex = 1;
            this.tpSearchRoom.Text = "Search Room";
            this.tpSearchRoom.UseVisualStyleBackColor = true;
            this.tpSearchRoom.Enter += new System.EventHandler(this.tpSearchRoom_Enter);
            this.tpSearchRoom.Leave += new System.EventHandler(this.tpSearchRoom_Leave);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Price,
            this.Column3,
            this.Column4});
            this.dataGridViewRoom.Location = new System.Drawing.Point(6, 165);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1048, 216);
            this.dataGridViewRoom.TabIndex = 0;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // txbSearchRoom
            // 
            this.txbSearchRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSearchRoom.Location = new System.Drawing.Point(196, 88);
            this.txbSearchRoom.Name = "txbSearchRoom";
            this.txbSearchRoom.Size = new System.Drawing.Size(332, 30);
            this.txbSearchRoom.TabIndex = 1;
            this.txbSearchRoom.TextChanged += new System.EventHandler(this.txbSearchRoom_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Number:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Room:";
            // 
            // tpUpdateandDeleteRoom
            // 
            this.tpUpdateandDeleteRoom.Controls.Add(this.btnDeleteRoom);
            this.tpUpdateandDeleteRoom.Controls.Add(this.radioButtonNo1);
            this.tpUpdateandDeleteRoom.Controls.Add(this.radioButtonYes1);
            this.tpUpdateandDeleteRoom.Controls.Add(this.label3);
            this.tpUpdateandDeleteRoom.Controls.Add(this.comboBoxType1);
            this.tpUpdateandDeleteRoom.Controls.Add(this.btnUpdateRoom);
            this.tpUpdateandDeleteRoom.Controls.Add(this.txbPhoneNumber1);
            this.tpUpdateandDeleteRoom.Controls.Add(this.label5);
            this.tpUpdateandDeleteRoom.Controls.Add(this.textBox2);
            this.tpUpdateandDeleteRoom.Controls.Add(this.label6);
            this.tpUpdateandDeleteRoom.Controls.Add(this.label7);
            this.tpUpdateandDeleteRoom.Location = new System.Drawing.Point(4, 4);
            this.tpUpdateandDeleteRoom.Name = "tpUpdateandDeleteRoom";
            this.tpUpdateandDeleteRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateandDeleteRoom.Size = new System.Drawing.Size(1060, 396);
            this.tpUpdateandDeleteRoom.TabIndex = 2;
            this.tpUpdateandDeleteRoom.Text = "Update and Delete Room";
            this.tpUpdateandDeleteRoom.UseVisualStyleBackColor = true;
            this.tpUpdateandDeleteRoom.Leave += new System.EventHandler(this.tpUpdateandDeleteRoom_Leave);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoom.FlatAppearance.BorderSize = 0;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.Location = new System.Drawing.Point(388, 291);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(137, 40);
            this.btnDeleteRoom.TabIndex = 6;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(309, 227);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(56, 25);
            this.radioButtonNo1.TabIndex = 4;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "No";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(309, 196);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(61, 25);
            this.radioButtonYes1.TabIndex = 3;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Yes";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available:";
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Location = new System.Drawing.Point(193, 136);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(332, 29);
            this.comboBoxType1.TabIndex = 1;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRoom.FlatAppearance.BorderSize = 0;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(193, 291);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(137, 40);
            this.btnUpdateRoom.TabIndex = 5;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // txbPhoneNumber1
            // 
            this.txbPhoneNumber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhoneNumber1.Location = new System.Drawing.Point(612, 135);
            this.txbPhoneNumber1.Name = "txbPhoneNumber1";
            this.txbPhoneNumber1.Size = new System.Drawing.Size(332, 30);
            this.txbPhoneNumber1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(193, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 30);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(18, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Update and Delete Room: ";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_Number";
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Type";
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Room_Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_Available";
            this.Column4.HeaderText = "Available";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlRoom.ResumeLayout(false);
            this.tpAddRoom.ResumeLayout(false);
            this.tpAddRoom.PerformLayout();
            this.tpSearchRoom.ResumeLayout(false);
            this.tpSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tpUpdateandDeleteRoom.ResumeLayout(false);
            this.tpUpdateandDeleteRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tpAddRoom;
        private System.Windows.Forms.TabPage tpSearchRoom;
        private System.Windows.Forms.TabPage tpUpdateandDeleteRoom;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.TextBox txbSearchRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.TextBox txbPhoneNumber1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
