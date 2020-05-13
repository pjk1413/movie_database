namespace Final_Project_2
{
    partial class memberForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMemberStatus = new System.Windows.Forms.GroupBox();
            this.rdInactive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.gbPrefContact = new System.Windows.Forms.GroupBox();
            this.rdTwitter = new System.Windows.Forms.RadioButton();
            this.rdPhone = new System.Windows.Forms.RadioButton();
            this.rdFacebook = new System.Windows.Forms.RadioButton();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberNumber = new System.Windows.Forms.TextBox();
            this.txtJoinDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxMemberData = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPicture = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbMemberStatus.SuspendLayout();
            this.gbPrefContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMemberData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gbMemberStatus
            // 
            this.gbMemberStatus.Controls.Add(this.rdInactive);
            this.gbMemberStatus.Controls.Add(this.rdActive);
            this.gbMemberStatus.Location = new System.Drawing.Point(12, 31);
            this.gbMemberStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMemberStatus.Name = "gbMemberStatus";
            this.gbMemberStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMemberStatus.Size = new System.Drawing.Size(180, 74);
            this.gbMemberStatus.TabIndex = 1;
            this.gbMemberStatus.TabStop = false;
            this.gbMemberStatus.Text = "Member Status";
            // 
            // rdInactive
            // 
            this.rdInactive.AutoSize = true;
            this.rdInactive.Location = new System.Drawing.Point(97, 34);
            this.rdInactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdInactive.Name = "rdInactive";
            this.rdInactive.Size = new System.Drawing.Size(77, 21);
            this.rdInactive.TabIndex = 1;
            this.rdInactive.TabStop = true;
            this.rdInactive.Text = "Inactive";
            this.rdInactive.UseVisualStyleBackColor = true;
            this.rdInactive.CheckedChanged += new System.EventHandler(this.rdInactive_CheckedChanged);
            this.rdInactive.Click += new System.EventHandler(this.rdInactive_Click);
            // 
            // rdActive
            // 
            this.rdActive.AutoSize = true;
            this.rdActive.Location = new System.Drawing.Point(5, 34);
            this.rdActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(67, 21);
            this.rdActive.TabIndex = 0;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Active";
            this.rdActive.UseVisualStyleBackColor = true;
            this.rdActive.Click += new System.EventHandler(this.rdActive_Click);
            // 
            // gbPrefContact
            // 
            this.gbPrefContact.Controls.Add(this.rdTwitter);
            this.gbPrefContact.Controls.Add(this.rdPhone);
            this.gbPrefContact.Controls.Add(this.rdFacebook);
            this.gbPrefContact.Controls.Add(this.rdEmail);
            this.gbPrefContact.Location = new System.Drawing.Point(249, 31);
            this.gbPrefContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPrefContact.Name = "gbPrefContact";
            this.gbPrefContact.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPrefContact.Size = new System.Drawing.Size(379, 74);
            this.gbPrefContact.TabIndex = 2;
            this.gbPrefContact.TabStop = false;
            this.gbPrefContact.Text = "Preferred Contact Method";
            // 
            // rdTwitter
            // 
            this.rdTwitter.AutoSize = true;
            this.rdTwitter.Location = new System.Drawing.Point(296, 34);
            this.rdTwitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTwitter.Name = "rdTwitter";
            this.rdTwitter.Size = new System.Drawing.Size(71, 21);
            this.rdTwitter.TabIndex = 36;
            this.rdTwitter.TabStop = true;
            this.rdTwitter.Text = "Twitter";
            this.rdTwitter.UseVisualStyleBackColor = true;
            // 
            // rdPhone
            // 
            this.rdPhone.AutoSize = true;
            this.rdPhone.Location = new System.Drawing.Point(209, 34);
            this.rdPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPhone.Name = "rdPhone";
            this.rdPhone.Size = new System.Drawing.Size(70, 21);
            this.rdPhone.TabIndex = 36;
            this.rdPhone.TabStop = true;
            this.rdPhone.Text = "Phone";
            this.rdPhone.UseVisualStyleBackColor = true;
            // 
            // rdFacebook
            // 
            this.rdFacebook.AutoSize = true;
            this.rdFacebook.Location = new System.Drawing.Point(100, 34);
            this.rdFacebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdFacebook.Name = "rdFacebook";
            this.rdFacebook.Size = new System.Drawing.Size(91, 21);
            this.rdFacebook.TabIndex = 36;
            this.rdFacebook.TabStop = true;
            this.rdFacebook.Text = "Facebook";
            this.rdFacebook.UseVisualStyleBackColor = true;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.Location = new System.Drawing.Point(16, 34);
            this.rdEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(63, 21);
            this.rdEmail.TabIndex = 36;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(763, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 238);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(792, 274);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(193, 39);
            this.btnUploadImage.TabIndex = 4;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member Number";
            // 
            // txtMemberNumber
            // 
            this.txtMemberNumber.Location = new System.Drawing.Point(141, 17);
            this.txtMemberNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberNumber.Name = "txtMemberNumber";
            this.txtMemberNumber.Size = new System.Drawing.Size(112, 22);
            this.txtMemberNumber.TabIndex = 6;
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.Location = new System.Drawing.Point(141, 47);
            this.txtJoinDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(112, 22);
            this.txtJoinDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Join Date";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 87);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 22);
            this.txtFirstName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 119);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(112, 22);
            this.txtLastName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 153);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(244, 22);
            this.txtAddress.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(141, 186);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(112, 22);
            this.txtCity.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(320, 186);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(112, 22);
            this.txtState.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "State";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(520, 186);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(112, 22);
            this.txtZipCode.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Zipcode";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(141, 220);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(112, 22);
            this.txtPhoneNumber.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 220);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 22);
            this.txtEmail.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Email";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(83, 256);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(171, 22);
            this.txtLogin.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(348, 252);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 22);
            this.txtPassword.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 416);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 133);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 555);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 57);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(181, 555);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(161, 57);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 555);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 57);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(516, 555);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 57);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(683, 555);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 57);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(849, 555);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 57);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxMemberData
            // 
            this.groupBoxMemberData.Controls.Add(this.label1);
            this.groupBoxMemberData.Controls.Add(this.txtMemberNumber);
            this.groupBoxMemberData.Controls.Add(this.label2);
            this.groupBoxMemberData.Controls.Add(this.txtJoinDate);
            this.groupBoxMemberData.Controls.Add(this.label3);
            this.groupBoxMemberData.Controls.Add(this.txtFirstName);
            this.groupBoxMemberData.Controls.Add(this.label4);
            this.groupBoxMemberData.Controls.Add(this.txtLastName);
            this.groupBoxMemberData.Controls.Add(this.txtPassword);
            this.groupBoxMemberData.Controls.Add(this.label5);
            this.groupBoxMemberData.Controls.Add(this.label12);
            this.groupBoxMemberData.Controls.Add(this.txtAddress);
            this.groupBoxMemberData.Controls.Add(this.txtLogin);
            this.groupBoxMemberData.Controls.Add(this.label6);
            this.groupBoxMemberData.Controls.Add(this.label11);
            this.groupBoxMemberData.Controls.Add(this.txtCity);
            this.groupBoxMemberData.Controls.Add(this.txtEmail);
            this.groupBoxMemberData.Controls.Add(this.label7);
            this.groupBoxMemberData.Controls.Add(this.label10);
            this.groupBoxMemberData.Controls.Add(this.txtState);
            this.groupBoxMemberData.Controls.Add(this.txtPhoneNumber);
            this.groupBoxMemberData.Controls.Add(this.label8);
            this.groupBoxMemberData.Controls.Add(this.label9);
            this.groupBoxMemberData.Controls.Add(this.txtZipCode);
            this.groupBoxMemberData.Location = new System.Drawing.Point(12, 111);
            this.groupBoxMemberData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMemberData.Name = "groupBoxMemberData";
            this.groupBoxMemberData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMemberData.Size = new System.Drawing.Size(665, 299);
            this.groupBoxMemberData.TabIndex = 36;
            this.groupBoxMemberData.TabStop = false;
            this.groupBoxMemberData.Text = "Member Data";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoEllipsis = true;
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(788, 331);
            this.lblPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPicture.MaximumSize = new System.Drawing.Size(267, 0);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(0, 17);
            this.lblPicture.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(684, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Currently Selected: ";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(811, 393);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(0, 17);
            this.lblSelected.TabIndex = 39;
            // 
            // memberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 618);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.groupBoxMemberData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbPrefContact);
            this.Controls.Add(this.gbMemberStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "memberForm";
            this.Text = "Member Form";
            this.Load += new System.EventHandler(this.memberForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMemberStatus.ResumeLayout(false);
            this.gbMemberStatus.PerformLayout();
            this.gbPrefContact.ResumeLayout(false);
            this.gbPrefContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMemberData.ResumeLayout(false);
            this.groupBoxMemberData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMemberStatus;
        private System.Windows.Forms.RadioButton rdInactive;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.GroupBox gbPrefContact;
        private System.Windows.Forms.RadioButton rdTwitter;
        private System.Windows.Forms.RadioButton rdPhone;
        private System.Windows.Forms.RadioButton rdFacebook;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberNumber;
        private System.Windows.Forms.TextBox txtJoinDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxMemberData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSelected;
    }
}

