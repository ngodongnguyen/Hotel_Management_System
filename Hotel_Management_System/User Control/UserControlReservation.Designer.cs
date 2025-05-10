namespace Hotel_Management_System.User_Control
{
    partial class UserControlReservation
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
            this.tpSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSearchClientID = new System.Windows.Forms.TextBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddReservation = new System.Windows.Forms.TabPage();
            this.lblOut = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.lblIn = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tpUpdateandCancelReservation = new System.Windows.Forms.TabPage();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNumber1 = new System.Windows.Forms.ComboBox();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.txbClientID1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tpAddReservation.SuspendLayout();
            this.tabControlReservation.SuspendLayout();
            this.tpUpdateandCancelReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpSearchReservation
            // 
            this.tpSearchReservation.Controls.Add(this.dataGridViewReservation);
            this.tpSearchReservation.Controls.Add(this.txbSearchClientID);
            this.tpSearchReservation.Controls.Add(this.labelClientID);
            this.tpSearchReservation.Controls.Add(this.label1);
            this.tpSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tpSearchReservation.Name = "tpSearchReservation";
            this.tpSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchReservation.Size = new System.Drawing.Size(1060, 396);
            this.tpSearchReservation.TabIndex = 1;
            this.tpSearchReservation.Text = "Search Reservation";
            this.tpSearchReservation.UseVisualStyleBackColor = true;
            this.tpSearchReservation.Enter += new System.EventHandler(this.tpSearchReservation_Enter);
            this.tpSearchReservation.Leave += new System.EventHandler(this.tpSearchReservation_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewReservation.Location = new System.Drawing.Point(6, 164);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.RowTemplate.Height = 24;
            this.dataGridViewReservation.Size = new System.Drawing.Size(1048, 216);
            this.dataGridViewReservation.TabIndex = 0;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Reservation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Reservation_Room_Type";
            this.Column2.HeaderText = "Room Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Reservation_Room_Number";
            this.Column3.HeaderText = "Room Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Reservation_Client_ID";
            this.Column4.HeaderText = "Client ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Reservation_In";
            this.Column5.HeaderText = "Check In";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Reservation_Out";
            this.Column6.HeaderText = "Check Out";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txbSearchClientID
            // 
            this.txbSearchClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSearchClientID.Location = new System.Drawing.Point(196, 87);
            this.txbSearchClientID.Name = "txbSearchClientID";
            this.txbSearchClientID.Size = new System.Drawing.Size(332, 30);
            this.txbSearchClientID.TabIndex = 1;
            this.txbSearchClientID.TextChanged += new System.EventHandler(this.txbSearchClientID_TextChanged);
            // 
            // labelClientID
            // 
            this.labelClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClientID.AutoSize = true;
            this.labelClientID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientID.Location = new System.Drawing.Point(193, 51);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(88, 22);
            this.labelClientID.TabIndex = 0;
            this.labelClientID.Text = "Client ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Reservation:";
            // 
            // tpAddReservation
            // 
            this.tpAddReservation.Controls.Add(this.lblOut);
            this.tpAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tpAddReservation.Controls.Add(this.lblIn);
            this.tpAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tpAddReservation.Controls.Add(this.comboBoxNumber);
            this.tpAddReservation.Controls.Add(this.comboBoxType);
            this.tpAddReservation.Controls.Add(this.txbClientID);
            this.tpAddReservation.Controls.Add(this.lblClientID);
            this.tpAddReservation.Controls.Add(this.btnAddReservation);
            this.tpAddReservation.Controls.Add(this.lblRoomNumber);
            this.tpAddReservation.Controls.Add(this.lblRoomType);
            this.tpAddReservation.Controls.Add(this.label4);
            this.tpAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tpAddReservation.Name = "tpAddReservation";
            this.tpAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddReservation.Size = new System.Drawing.Size(1060, 396);
            this.tpAddReservation.TabIndex = 0;
            this.tpAddReservation.Text = "Add Reservation";
            this.tpAddReservation.UseVisualStyleBackColor = true;
            this.tpAddReservation.Leave += new System.EventHandler(this.tpAddReservation_Leave);
            // 
            // lblOut
            // 
            this.lblOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(599, 213);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(110, 22);
            this.lblOut.TabIndex = 0;
            this.lblOut.Text = "Check Out:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(599, 248);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(332, 30);
            this.dateTimePickerOut.TabIndex = 5;
            // 
            // lblIn
            // 
            this.lblIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(179, 213);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(95, 22);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "Check In:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(179, 248);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(332, 30);
            this.dateTimePickerIn.TabIndex = 4;
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Items.AddRange(new object[] {
            ""});
            this.comboBoxNumber.Location = new System.Drawing.Point(599, 78);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(332, 29);
            this.comboBoxNumber.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(179, 78);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(332, 29);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.TextChanged += new System.EventHandler(this.comboBoxType_TextChanged);
            // 
            // txbClientID
            // 
            this.txbClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbClientID.Location = new System.Drawing.Point(179, 159);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(332, 30);
            this.txbClientID.TabIndex = 3;
            // 
            // lblClientID
            // 
            this.lblClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(179, 123);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(88, 22);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "Client ID:";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddReservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.FlatAppearance.BorderSize = 0;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(179, 325);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(137, 40);
            this.btnAddReservation.TabIndex = 6;
            this.btnAddReservation.Text = "Add";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(595, 42);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(142, 22);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(179, 42);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(113, 22);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Reservation: ";
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservation.Controls.Add(this.tpAddReservation);
            this.tabControlReservation.Controls.Add(this.tpSearchReservation);
            this.tabControlReservation.Controls.Add(this.tpUpdateandCancelReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(12, 15);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1068, 430);
            this.tabControlReservation.TabIndex = 0;
            // 
            // tpUpdateandCancelReservation
            // 
            this.tpUpdateandCancelReservation.Controls.Add(this.btnCancelReservation);
            this.tpUpdateandCancelReservation.Controls.Add(this.label2);
            this.tpUpdateandCancelReservation.Controls.Add(this.dateTimePickerOut1);
            this.tpUpdateandCancelReservation.Controls.Add(this.label3);
            this.tpUpdateandCancelReservation.Controls.Add(this.dateTimePickerIn1);
            this.tpUpdateandCancelReservation.Controls.Add(this.comboBoxNumber1);
            this.tpUpdateandCancelReservation.Controls.Add(this.comboBoxType1);
            this.tpUpdateandCancelReservation.Controls.Add(this.txbClientID1);
            this.tpUpdateandCancelReservation.Controls.Add(this.label5);
            this.tpUpdateandCancelReservation.Controls.Add(this.btnUpdateReservation);
            this.tpUpdateandCancelReservation.Controls.Add(this.label6);
            this.tpUpdateandCancelReservation.Controls.Add(this.label7);
            this.tpUpdateandCancelReservation.Controls.Add(this.label8);
            this.tpUpdateandCancelReservation.Location = new System.Drawing.Point(4, 4);
            this.tpUpdateandCancelReservation.Name = "tpUpdateandCancelReservation";
            this.tpUpdateandCancelReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateandCancelReservation.Size = new System.Drawing.Size(1060, 396);
            this.tpUpdateandCancelReservation.TabIndex = 2;
            this.tpUpdateandCancelReservation.Text = "Update and Cancel Reservation";
            this.tpUpdateandCancelReservation.UseVisualStyleBackColor = true;
            this.tpUpdateandCancelReservation.Leave += new System.EventHandler(this.tpUpdateandCancelReservation_Leave);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.FlatAppearance.BorderSize = 0;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.Location = new System.Drawing.Point(374, 327);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(137, 40);
            this.btnCancelReservation.TabIndex = 7;
            this.btnCancelReservation.Text = "Cancel";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check Out:";
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Location = new System.Drawing.Point(599, 250);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(332, 30);
            this.dateTimePickerOut1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Check In:";
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Location = new System.Drawing.Point(179, 250);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(332, 30);
            this.dateTimePickerIn1.TabIndex = 4;
            // 
            // comboBoxNumber1
            // 
            this.comboBoxNumber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNumber1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNumber1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNumber1.FormattingEnabled = true;
            this.comboBoxNumber1.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxNumber1.Location = new System.Drawing.Point(599, 80);
            this.comboBoxNumber1.Name = "comboBoxNumber1";
            this.comboBoxNumber1.Size = new System.Drawing.Size(332, 29);
            this.comboBoxNumber1.TabIndex = 2;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType1.Location = new System.Drawing.Point(179, 80);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(332, 29);
            this.comboBoxType1.TabIndex = 1;
            this.comboBoxType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxType1_SelectedIndexChanged);
            // 
            // txbClientID1
            // 
            this.txbClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbClientID1.Location = new System.Drawing.Point(179, 161);
            this.txbClientID1.Name = "txbClientID1";
            this.txbClientID1.Size = new System.Drawing.Size(332, 30);
            this.txbClientID1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Client ID:";
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateReservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateReservation.FlatAppearance.BorderSize = 0;
            this.btnUpdateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReservation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservation.Location = new System.Drawing.Point(179, 327);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(137, 40);
            this.btnUpdateReservation.TabIndex = 6;
            this.btnUpdateReservation.Text = "Update";
            this.btnUpdateReservation.UseVisualStyleBackColor = false;
            this.btnUpdateReservation.Click += new System.EventHandler(this.btnUpdateReservation_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Room Number:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Update and Cancel Reservation: ";
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.tabControlReservation);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tpSearchReservation.ResumeLayout(false);
            this.tpSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tpAddReservation.ResumeLayout(false);
            this.tpAddReservation.PerformLayout();
            this.tabControlReservation.ResumeLayout(false);
            this.tpUpdateandCancelReservation.ResumeLayout(false);
            this.tpUpdateandCancelReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpSearchReservation;
        private System.Windows.Forms.TabPage tpAddReservation;
        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tpUpdateandCancelReservation;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txbClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox txbSearchClientID;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxNumber1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox txbClientID1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
