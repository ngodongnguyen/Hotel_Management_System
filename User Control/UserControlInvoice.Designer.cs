namespace Hotel_Management_System.User_Control
{
    partial class UserControlInvoice
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
            this.tabControlInvoice = new System.Windows.Forms.TabControl();
            this.tpAddInvoice = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.listViewReservationRoom = new System.Windows.Forms.ListView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblReservationRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpListInvoice = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSearchClientID = new System.Windows.Forms.TextBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPayment = new System.Windows.Forms.TabPage();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.textBoxTotal1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerPayDate = new System.Windows.Forms.DateTimePicker();
            this.tpPaymentHistory = new System.Windows.Forms.TabPage();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlInvoice.SuspendLayout();
            this.tpAddInvoice.SuspendLayout();
            this.tpListInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlInvoice
            // 
            this.tabControlInvoice.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlInvoice.Controls.Add(this.tpAddInvoice);
            this.tabControlInvoice.Controls.Add(this.tpListInvoice);
            this.tabControlInvoice.Controls.Add(this.tpPayment);
            this.tabControlInvoice.Controls.Add(this.tpPaymentHistory);
            this.tabControlInvoice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlInvoice.Location = new System.Drawing.Point(12, 15);
            this.tabControlInvoice.Name = "tabControlInvoice";
            this.tabControlInvoice.SelectedIndex = 0;
            this.tabControlInvoice.Size = new System.Drawing.Size(1068, 430);
            this.tabControlInvoice.TabIndex = 0;
            // 
            // tpAddInvoice
            // 
            this.tpAddInvoice.Controls.Add(this.label1);
            this.tpAddInvoice.Controls.Add(this.dateTimePicker1);
            this.tpAddInvoice.Controls.Add(this.btnFind);
            this.tpAddInvoice.Controls.Add(this.txtCID);
            this.tpAddInvoice.Controls.Add(this.listViewReservationRoom);
            this.tpAddInvoice.Controls.Add(this.txtTotal);
            this.tpAddInvoice.Controls.Add(this.lblTotal);
            this.tpAddInvoice.Controls.Add(this.btnAddInvoice);
            this.tpAddInvoice.Controls.Add(this.lblClientID);
            this.tpAddInvoice.Controls.Add(this.lblReservationRoom);
            this.tpAddInvoice.Controls.Add(this.label4);
            this.tpAddInvoice.Location = new System.Drawing.Point(4, 4);
            this.tpAddInvoice.Name = "tpAddInvoice";
            this.tpAddInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddInvoice.Size = new System.Drawing.Size(1060, 396);
            this.tpAddInvoice.TabIndex = 0;
            this.tpAddInvoice.Text = "Add Invoice";
            this.tpAddInvoice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Of Invoice:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(692, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(324, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Linen;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Location = new System.Drawing.Point(494, 89);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 42);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find\r\n";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(216, 97);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(251, 30);
            this.txtCID.TabIndex = 1;
            // 
            // listViewReservationRoom
            // 
            this.listViewReservationRoom.CheckBoxes = true;
            this.listViewReservationRoom.HideSelection = false;
            this.listViewReservationRoom.Location = new System.Drawing.Point(36, 198);
            this.listViewReservationRoom.Name = "listViewReservationRoom";
            this.listViewReservationRoom.Size = new System.Drawing.Size(632, 153);
            this.listViewReservationRoom.TabIndex = 3;
            this.listViewReservationRoom.UseCompatibleStateImageBehavior = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Location = new System.Drawing.Point(757, 240);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(259, 30);
            this.txtTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(694, 248);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 22);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInvoice.FlatAppearance.BorderSize = 0;
            this.btnAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInvoice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.Location = new System.Drawing.Point(698, 311);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(127, 40);
            this.btnAddInvoice.TabIndex = 5;
            this.btnAddInvoice.Text = "Add";
            this.btnAddInvoice.UseVisualStyleBackColor = false;
            // 
            // lblClientID
            // 
            this.lblClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(212, 63);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(88, 22);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblReservationRoom
            // 
            this.lblReservationRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReservationRoom.AutoSize = true;
            this.lblReservationRoom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationRoom.Location = new System.Drawing.Point(41, 164);
            this.lblReservationRoom.Name = "lblReservationRoom";
            this.lblReservationRoom.Size = new System.Drawing.Size(173, 22);
            this.lblReservationRoom.TabIndex = 0;
            this.lblReservationRoom.Text = "Reservation Room:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Invoice: ";
            // 
            // tpListInvoice
            // 
            this.tpListInvoice.Controls.Add(this.button2);
            this.tpListInvoice.Controls.Add(this.btnUpdateInvoice);
            this.tpListInvoice.Controls.Add(this.label5);
            this.tpListInvoice.Controls.Add(this.dateTimePicker2);
            this.tpListInvoice.Controls.Add(this.comboBox2);
            this.tpListInvoice.Controls.Add(this.label6);
            this.tpListInvoice.Controls.Add(this.textBoxTotal);
            this.tpListInvoice.Controls.Add(this.label7);
            this.tpListInvoice.Controls.Add(this.dataGridViewReservation);
            this.tpListInvoice.Controls.Add(this.txbSearchClientID);
            this.tpListInvoice.Controls.Add(this.labelClientID);
            this.tpListInvoice.Controls.Add(this.label2);
            this.tpListInvoice.Location = new System.Drawing.Point(4, 4);
            this.tpListInvoice.Name = "tpListInvoice";
            this.tpListInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tpListInvoice.Size = new System.Drawing.Size(1060, 396);
            this.tpListInvoice.TabIndex = 1;
            this.tpListInvoice.Text = "List Invoice";
            this.tpListInvoice.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(886, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateInvoice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInvoice.Location = new System.Drawing.Point(730, 321);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(101, 53);
            this.btnUpdateInvoice.TabIndex = 4;
            this.btnUpdateInvoice.Text = "Update";
            this.btnUpdateInvoice.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(722, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Of Invoice:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(726, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(324, 30);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(797, 245);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 29);
            this.comboBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(726, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTotal.Location = new System.Drawing.Point(789, 168);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(198, 30);
            this.textBoxTotal.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(726, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total:";
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
            this.Column5});
            this.dataGridViewReservation.Location = new System.Drawing.Point(12, 168);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.RowTemplate.Height = 24;
            this.dataGridViewReservation.Size = new System.Drawing.Size(698, 200);
            this.dataGridViewReservation.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Invoice_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Invoice_Client_ID";
            this.Column2.HeaderText = "ClientID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Invoice_Date";
            this.Column3.HeaderText = "Invoice Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Invoice_Total";
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Invoice_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txbSearchClientID
            // 
            this.txbSearchClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSearchClientID.Location = new System.Drawing.Point(217, 91);
            this.txbSearchClientID.Name = "txbSearchClientID";
            this.txbSearchClientID.Size = new System.Drawing.Size(257, 30);
            this.txbSearchClientID.TabIndex = 1;
            // 
            // labelClientID
            // 
            this.labelClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClientID.AutoSize = true;
            this.labelClientID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientID.Location = new System.Drawing.Point(214, 55);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(88, 22);
            this.labelClientID.TabIndex = 0;
            this.labelClientID.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "List Invoice:";
            // 
            // tpPayment
            // 
            this.tpPayment.Controls.Add(this.dateTimePickerPayDate);
            this.tpPayment.Controls.Add(this.label9);
            this.tpPayment.Controls.Add(this.txtChange);
            this.tpPayment.Controls.Add(this.label14);
            this.tpPayment.Controls.Add(this.txtPA);
            this.tpPayment.Controls.Add(this.label13);
            this.tpPayment.Controls.Add(this.label8);
            this.tpPayment.Controls.Add(this.comboBoxMethod);
            this.tpPayment.Controls.Add(this.btnPay);
            this.tpPayment.Controls.Add(this.textBoxTotal1);
            this.tpPayment.Controls.Add(this.label10);
            this.tpPayment.Controls.Add(this.dataGridView1);
            this.tpPayment.Controls.Add(this.txtInvoiceID);
            this.tpPayment.Controls.Add(this.label11);
            this.tpPayment.Controls.Add(this.label12);
            this.tpPayment.Location = new System.Drawing.Point(4, 4);
            this.tpPayment.Name = "tpPayment";
            this.tpPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tpPayment.Size = new System.Drawing.Size(1060, 396);
            this.tpPayment.TabIndex = 2;
            this.tpPayment.Text = "Payment";
            this.tpPayment.UseVisualStyleBackColor = true;
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChange.Location = new System.Drawing.Point(749, 198);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(240, 30);
            this.txtChange.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(660, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Change:";
            // 
            // txtPA
            // 
            this.txtPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPA.Location = new System.Drawing.Point(831, 137);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(202, 30);
            this.txtPA.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(660, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Payment amount:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Method:";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(749, 90);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(121, 29);
            this.comboBoxMethod.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(664, 325);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(135, 48);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // textBoxTotal1
            // 
            this.textBoxTotal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTotal1.Location = new System.Drawing.Point(723, 20);
            this.textBoxTotal1.Name = "textBoxTotal1";
            this.textBoxTotal1.ReadOnly = true;
            this.textBoxTotal1.Size = new System.Drawing.Size(240, 30);
            this.textBoxTotal1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(660, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(14, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceID.Location = new System.Drawing.Point(85, 96);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(257, 30);
            this.txtInvoiceID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Invoice ID:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(10, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Payment:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Payment Date:";
            // 
            // dateTimePickerPayDate
            // 
            this.dateTimePickerPayDate.Location = new System.Drawing.Point(664, 281);
            this.dateTimePickerPayDate.Name = "dateTimePickerPayDate";
            this.dateTimePickerPayDate.Size = new System.Drawing.Size(316, 30);
            this.dateTimePickerPayDate.TabIndex = 4;
            // 
            // tpPaymentHistory
            // 
            this.tpPaymentHistory.Controls.Add(this.dateTimePicker3);
            this.tpPaymentHistory.Controls.Add(this.label15);
            this.tpPaymentHistory.Controls.Add(this.label18);
            this.tpPaymentHistory.Controls.Add(this.comboBox1);
            this.tpPaymentHistory.Controls.Add(this.button3);
            this.tpPaymentHistory.Controls.Add(this.dataGridView2);
            this.tpPaymentHistory.Controls.Add(this.textBox3);
            this.tpPaymentHistory.Controls.Add(this.label20);
            this.tpPaymentHistory.Controls.Add(this.label21);
            this.tpPaymentHistory.Location = new System.Drawing.Point(4, 4);
            this.tpPaymentHistory.Name = "tpPaymentHistory";
            this.tpPaymentHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaymentHistory.Size = new System.Drawing.Size(1060, 396);
            this.tpPaymentHistory.TabIndex = 3;
            this.tpPaymentHistory.Text = "Payment History";
            this.tpPaymentHistory.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(704, 57);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(316, 30);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(700, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Payment Date:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(703, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 22);
            this.label18.TabIndex = 0;
            this.label18.Text = "Method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(792, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(919, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column8,
            this.Column6,
            this.dataGridViewTextBoxColumn7,
            this.Column7});
            this.dataGridView2.Location = new System.Drawing.Point(40, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(980, 200);
            this.dataGridView2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(151, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 30);
            this.textBox3.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(148, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 22);
            this.label20.TabIndex = 0;
            this.label20.Text = "Invoice ID:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(41, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 22);
            this.label21.TabIndex = 0;
            this.label21.Text = "Payment:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Invoice_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Invoice_Client_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Invoice_Total";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Invoice_Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Payment_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Payment_Invoice_ID";
            this.Column8.HeaderText = "Invoice ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Payment_Method";
            this.Column6.HeaderText = "Method";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Payment_Paid";
            this.dataGridViewTextBoxColumn7.HeaderText = "Paid";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Payment_Date";
            this.Column7.HeaderText = "Payment Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UserControlInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.tabControlInvoice);
            this.Name = "UserControlInvoice";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlInvoice.ResumeLayout(false);
            this.tpAddInvoice.ResumeLayout(false);
            this.tpAddInvoice.PerformLayout();
            this.tpListInvoice.ResumeLayout(false);
            this.tpListInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tpPayment.ResumeLayout(false);
            this.tpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpPaymentHistory.ResumeLayout(false);
            this.tpPaymentHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInvoice;
        private System.Windows.Forms.TabPage tpAddInvoice;
        private System.Windows.Forms.TabPage tpListInvoice;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblReservationRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox txbSearchClientID;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewReservationRoom;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tpPayment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox textBoxTotal1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.DateTimePicker dateTimePickerPayDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tpPaymentHistory;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}
