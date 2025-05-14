namespace Hotel_Management_System.User_Control
{
    partial class UserControlClient
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tpAddClient = new System.Windows.Forms.TabPage();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSearchPhone = new System.Windows.Forms.TextBox();
            this.lblSearchPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUpdateandDeleteClient = new System.Windows.Forms.TabPage();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.txbAddress1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPhone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.txbLastName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbFirstName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tpAddClient.SuspendLayout();
            this.tpSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tpUpdateandDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tpAddClient);
            this.tabControlClient.Controls.Add(this.tpSearchClient);
            this.tabControlClient.Controls.Add(this.tpUpdateandDeleteClient);
            this.tabControlClient.Location = new System.Drawing.Point(12, 15);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1068, 430);
            this.tabControlClient.TabIndex = 0;
            // 
            // tpAddClient
            // 
            this.tpAddClient.Controls.Add(this.txbAddress);
            this.tpAddClient.Controls.Add(this.lblAddress);
            this.tpAddClient.Controls.Add(this.txbPhone);
            this.tpAddClient.Controls.Add(this.lblPhone);
            this.tpAddClient.Controls.Add(this.btnAddClient);
            this.tpAddClient.Controls.Add(this.txbLastname);
            this.tpAddClient.Controls.Add(this.lblLastname);
            this.tpAddClient.Controls.Add(this.txbFirstname);
            this.tpAddClient.Controls.Add(this.lblFirstname);
            this.tpAddClient.Controls.Add(this.label4);
            this.tpAddClient.Location = new System.Drawing.Point(4, 4);
            this.tpAddClient.Name = "tpAddClient";
            this.tpAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddClient.Size = new System.Drawing.Size(1060, 396);
            this.tpAddClient.TabIndex = 0;
            this.tpAddClient.Text = "Add Client";
            this.tpAddClient.UseVisualStyleBackColor = true;
            this.tpAddClient.Leave += new System.EventHandler(this.tpAddClient_Leave);
            // 
            // txbAddress
            // 
            this.txbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbAddress.Location = new System.Drawing.Point(178, 241);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(752, 81);
            this.txbAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(179, 205);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 22);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address:";
            // 
            // txbPhone
            // 
            this.txbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhone.Location = new System.Drawing.Point(178, 157);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(332, 30);
            this.txbPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(178, 121);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(147, 22);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddClient.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(178, 338);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(137, 40);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txbLastname
            // 
            this.txbLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbLastname.Location = new System.Drawing.Point(598, 68);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(332, 30);
            this.txbLastname.TabIndex = 2;
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(594, 32);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(105, 22);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "Last name:";
            // 
            // txbFirstname
            // 
            this.txbFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFirstname.Location = new System.Drawing.Point(178, 68);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(332, 30);
            this.txbFirstname.TabIndex = 1;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(178, 32);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(104, 22);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "First name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Client: ";
            // 
            // tpSearchClient
            // 
            this.tpSearchClient.Controls.Add(this.dataGridViewClient);
            this.tpSearchClient.Controls.Add(this.txbSearchPhone);
            this.tpSearchClient.Controls.Add(this.lblSearchPhone);
            this.tpSearchClient.Controls.Add(this.label1);
            this.tpSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tpSearchClient.Name = "tpSearchClient";
            this.tpSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchClient.Size = new System.Drawing.Size(1060, 396);
            this.tpSearchClient.TabIndex = 1;
            this.tpSearchClient.Text = "Search Client";
            this.tpSearchClient.UseVisualStyleBackColor = true;
            this.tpSearchClient.Enter += new System.EventHandler(this.tpSearchClient_Enter);
            this.tpSearchClient.Leave += new System.EventHandler(this.tpSearchClient_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewClient.Location = new System.Drawing.Point(6, 168);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(1048, 216);
            this.dataGridViewClient.TabIndex = 0;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_FirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_LastName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_Phone";
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Client_Address";
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txbSearchPhone
            // 
            this.txbSearchPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSearchPhone.Location = new System.Drawing.Point(196, 91);
            this.txbSearchPhone.Name = "txbSearchPhone";
            this.txbSearchPhone.Size = new System.Drawing.Size(332, 30);
            this.txbSearchPhone.TabIndex = 1;
            this.txbSearchPhone.TextChanged += new System.EventHandler(this.txbSearchPhone_TextChanged);
            // 
            // lblSearchPhone
            // 
            this.lblSearchPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchPhone.AutoSize = true;
            this.lblSearchPhone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPhone.Location = new System.Drawing.Point(193, 55);
            this.lblSearchPhone.Name = "lblSearchPhone";
            this.lblSearchPhone.Size = new System.Drawing.Size(147, 22);
            this.lblSearchPhone.TabIndex = 0;
            this.lblSearchPhone.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Client:";
            // 
            // tpUpdateandDeleteClient
            // 
            this.tpUpdateandDeleteClient.Controls.Add(this.btnDeleteClient);
            this.tpUpdateandDeleteClient.Controls.Add(this.txbAddress1);
            this.tpUpdateandDeleteClient.Controls.Add(this.label2);
            this.tpUpdateandDeleteClient.Controls.Add(this.txbPhone1);
            this.tpUpdateandDeleteClient.Controls.Add(this.label3);
            this.tpUpdateandDeleteClient.Controls.Add(this.btnUpdateClient);
            this.tpUpdateandDeleteClient.Controls.Add(this.txbLastName1);
            this.tpUpdateandDeleteClient.Controls.Add(this.label5);
            this.tpUpdateandDeleteClient.Controls.Add(this.txbFirstName1);
            this.tpUpdateandDeleteClient.Controls.Add(this.label6);
            this.tpUpdateandDeleteClient.Controls.Add(this.label7);
            this.tpUpdateandDeleteClient.Location = new System.Drawing.Point(4, 4);
            this.tpUpdateandDeleteClient.Name = "tpUpdateandDeleteClient";
            this.tpUpdateandDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateandDeleteClient.Size = new System.Drawing.Size(1060, 396);
            this.tpUpdateandDeleteClient.TabIndex = 2;
            this.tpUpdateandDeleteClient.Text = "Update and Delete Client";
            this.tpUpdateandDeleteClient.UseVisualStyleBackColor = true;
            this.tpUpdateandDeleteClient.Leave += new System.EventHandler(this.tpUpdateandDeleteClient_Leave);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(453, 340);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(137, 40);
            this.btnDeleteClient.TabIndex = 6;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // txbAddress1
            // 
            this.txbAddress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbAddress1.Location = new System.Drawing.Point(258, 243);
            this.txbAddress1.Multiline = true;
            this.txbAddress1.Name = "txbAddress1";
            this.txbAddress1.Size = new System.Drawing.Size(752, 81);
            this.txbAddress1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // txbPhone1
            // 
            this.txbPhone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhone1.Location = new System.Drawing.Point(258, 159);
            this.txbPhone1.Name = "txbPhone1";
            this.txbPhone1.Size = new System.Drawing.Size(332, 30);
            this.txbPhone1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number:";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClient.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(258, 340);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(137, 40);
            this.btnUpdateClient.TabIndex = 5;
            this.btnUpdateClient.Text = "Update";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // txbLastName1
            // 
            this.txbLastName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbLastName1.Location = new System.Drawing.Point(678, 70);
            this.txbLastName1.Name = "txbLastName1";
            this.txbLastName1.Size = new System.Drawing.Size(332, 30);
            this.txbLastName1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last name:";
            // 
            // txbFirstName1
            // 
            this.txbFirstName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFirstName1.Location = new System.Drawing.Point(258, 70);
            this.txbFirstName1.Name = "txbFirstName1";
            this.txbFirstName1.Size = new System.Drawing.Size(332, 30);
            this.txbFirstName1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "First name:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Update and Delete Client: ";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlClient.ResumeLayout(false);
            this.tpAddClient.ResumeLayout(false);
            this.tpAddClient.PerformLayout();
            this.tpSearchClient.ResumeLayout(false);
            this.tpSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tpUpdateandDeleteClient.ResumeLayout(false);
            this.tpUpdateandDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tpAddClient;
        private System.Windows.Forms.TabPage tpSearchClient;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txbLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpUpdateandDeleteClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txbSearchPhone;
        private System.Windows.Forms.Label lblSearchPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.TextBox txbAddress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPhone1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox txbLastName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbFirstName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
