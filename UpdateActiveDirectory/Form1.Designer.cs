namespace UpdateActiveDirectory
{
    partial class Form1
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatasourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblADUpdateError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkOtherTelephone = new System.Windows.Forms.CheckBox();
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.chkDescription = new System.Windows.Forms.CheckBox();
            this.chkLastname = new System.Windows.Forms.CheckBox();
            this.chkInitials = new System.Windows.Forms.CheckBox();
            this.chkFirstName = new System.Windows.Forms.CheckBox();
            this.chkDisplayName = new System.Windows.Forms.CheckBox();
            this.ChkAdTelephone = new System.Windows.Forms.CheckBox();
            this.GrpResults = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdateCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorCnt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDataSourceError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.txtDBUsrName = new System.Windows.Forms.TextBox();
            this.txtDBServerName = new System.Windows.Forms.TextBox();
            this.txtDBDatabase = new System.Windows.Forms.TextBox();
            this.lblTblName = new System.Windows.Forms.Label();
            this.txtTablename = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAuthError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsrName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GrpResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.prepareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // prepareToolStripMenuItem
            // 
            this.prepareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDatasourceToolStripMenuItem});
            this.prepareToolStripMenuItem.Name = "prepareToolStripMenuItem";
            this.prepareToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.prepareToolStripMenuItem.Text = "Prepare";
            // 
            // createDatasourceToolStripMenuItem
            // 
            this.createDatasourceToolStripMenuItem.Name = "createDatasourceToolStripMenuItem";
            this.createDatasourceToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createDatasourceToolStripMenuItem.Text = "Create Datasource";
            this.createDatasourceToolStripMenuItem.Click += new System.EventHandler(this.createDatasourceToolStripMenuItem_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(636, 420);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblADUpdateError);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chkEmail);
            this.groupBox3.Controls.Add(this.chkOtherTelephone);
            this.groupBox3.Controls.Add(this.chkOffice);
            this.groupBox3.Controls.Add(this.chkDescription);
            this.groupBox3.Controls.Add(this.chkLastname);
            this.groupBox3.Controls.Add(this.chkInitials);
            this.groupBox3.Controls.Add(this.chkFirstName);
            this.groupBox3.Controls.Add(this.chkDisplayName);
            this.groupBox3.Controls.Add(this.ChkAdTelephone);
            this.groupBox3.Location = new System.Drawing.Point(395, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 387);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active Directory Options";
            // 
            // lblADUpdateError
            // 
            this.lblADUpdateError.AutoSize = true;
            this.lblADUpdateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADUpdateError.ForeColor = System.Drawing.Color.Red;
            this.lblADUpdateError.Location = new System.Drawing.Point(23, 361);
            this.lblADUpdateError.Name = "lblADUpdateError";
            this.lblADUpdateError.Size = new System.Drawing.Size(48, 13);
            this.lblADUpdateError.TabIndex = 12;
            this.lblADUpdateError.Text = "label11";
            this.lblADUpdateError.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "sAMAccountName is used as the primary search parameter, \r\nplease ensure this is a" +
    "vailable in the source data.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select the items that you would like to update in active\r\ndirectory, make sure th" +
    "at these are available in the \r\nreference data\r\n";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(23, 275);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 9;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkOtherTelephone
            // 
            this.chkOtherTelephone.AutoSize = true;
            this.chkOtherTelephone.Location = new System.Drawing.Point(23, 251);
            this.chkOtherTelephone.Name = "chkOtherTelephone";
            this.chkOtherTelephone.Size = new System.Drawing.Size(146, 17);
            this.chkOtherTelephone.TabIndex = 8;
            this.chkOtherTelephone.Text = "Other Telephone Number";
            this.chkOtherTelephone.UseVisualStyleBackColor = true;
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.Location = new System.Drawing.Point(23, 204);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(54, 17);
            this.chkOffice.TabIndex = 7;
            this.chkOffice.Text = "Office";
            this.chkOffice.UseVisualStyleBackColor = true;
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Location = new System.Drawing.Point(23, 180);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(79, 17);
            this.chkDescription.TabIndex = 6;
            this.chkDescription.Text = "Description";
            this.chkDescription.UseVisualStyleBackColor = true;
            // 
            // chkLastname
            // 
            this.chkLastname.AutoSize = true;
            this.chkLastname.Location = new System.Drawing.Point(23, 133);
            this.chkLastname.Name = "chkLastname";
            this.chkLastname.Size = new System.Drawing.Size(77, 17);
            this.chkLastname.TabIndex = 5;
            this.chkLastname.Text = "Last Name";
            this.chkLastname.UseVisualStyleBackColor = true;
            // 
            // chkInitials
            // 
            this.chkInitials.AutoSize = true;
            this.chkInitials.Location = new System.Drawing.Point(23, 109);
            this.chkInitials.Name = "chkInitials";
            this.chkInitials.Size = new System.Drawing.Size(55, 17);
            this.chkInitials.TabIndex = 4;
            this.chkInitials.Text = "Initials";
            this.chkInitials.UseVisualStyleBackColor = true;
            // 
            // chkFirstName
            // 
            this.chkFirstName.AutoSize = true;
            this.chkFirstName.Location = new System.Drawing.Point(23, 85);
            this.chkFirstName.Name = "chkFirstName";
            this.chkFirstName.Size = new System.Drawing.Size(71, 17);
            this.chkFirstName.TabIndex = 3;
            this.chkFirstName.Text = "Firstname";
            this.chkFirstName.UseVisualStyleBackColor = true;
            // 
            // chkDisplayName
            // 
            this.chkDisplayName.AutoSize = true;
            this.chkDisplayName.Location = new System.Drawing.Point(23, 156);
            this.chkDisplayName.Name = "chkDisplayName";
            this.chkDisplayName.Size = new System.Drawing.Size(91, 17);
            this.chkDisplayName.TabIndex = 1;
            this.chkDisplayName.Text = "Display Name";
            this.chkDisplayName.UseVisualStyleBackColor = true;
            // 
            // ChkAdTelephone
            // 
            this.ChkAdTelephone.AutoSize = true;
            this.ChkAdTelephone.Location = new System.Drawing.Point(23, 227);
            this.ChkAdTelephone.Name = "ChkAdTelephone";
            this.ChkAdTelephone.Size = new System.Drawing.Size(117, 17);
            this.ChkAdTelephone.TabIndex = 0;
            this.ChkAdTelephone.Text = "Telephone Number";
            this.ChkAdTelephone.UseVisualStyleBackColor = true;
            // 
            // GrpResults
            // 
            this.GrpResults.Controls.Add(this.label11);
            this.GrpResults.Controls.Add(this.label2);
            this.GrpResults.Controls.Add(this.lblUpdateCnt);
            this.GrpResults.Controls.Add(this.label1);
            this.GrpResults.Controls.Add(this.lblErrorCnt);
            this.GrpResults.Location = new System.Drawing.Point(12, 361);
            this.GrpResults.Name = "GrpResults";
            this.GrpResults.Size = new System.Drawing.Size(373, 79);
            this.GrpResults.TabIndex = 14;
            this.GrpResults.TabStop = false;
            this.GrpResults.Text = "Results";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 39);
            this.label11.TabIndex = 6;
            this.label11.Text = "The application may appear to become \r\nunresponsive if there is many entries, \r\np" +
    "lease be patient.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Updates";
            // 
            // lblUpdateCnt
            // 
            this.lblUpdateCnt.AutoSize = true;
            this.lblUpdateCnt.Location = new System.Drawing.Point(235, 51);
            this.lblUpdateCnt.Name = "lblUpdateCnt";
            this.lblUpdateCnt.Size = new System.Drawing.Size(13, 13);
            this.lblUpdateCnt.TabIndex = 2;
            this.lblUpdateCnt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Errors";
            // 
            // lblErrorCnt
            // 
            this.lblErrorCnt.AutoSize = true;
            this.lblErrorCnt.Location = new System.Drawing.Point(317, 51);
            this.lblErrorCnt.Name = "lblErrorCnt";
            this.lblErrorCnt.Size = new System.Drawing.Size(13, 13);
            this.lblErrorCnt.TabIndex = 3;
            this.lblErrorCnt.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDataSourceError);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDBPassword);
            this.groupBox2.Controls.Add(this.txtDBUsrName);
            this.groupBox2.Controls.Add(this.txtDBServerName);
            this.groupBox2.Controls.Add(this.txtDBDatabase);
            this.groupBox2.Controls.Add(this.lblTblName);
            this.groupBox2.Controls.Add(this.txtTablename);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 192);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSource";
            // 
            // lblDataSourceError
            // 
            this.lblDataSourceError.AutoSize = true;
            this.lblDataSourceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSourceError.ForeColor = System.Drawing.Color.Red;
            this.lblDataSourceError.Location = new System.Drawing.Point(33, 168);
            this.lblDataSourceError.Name = "lblDataSourceError";
            this.lblDataSourceError.Size = new System.Drawing.Size(48, 13);
            this.lblDataSourceError.TabIndex = 12;
            this.lblDataSourceError.Text = "label11";
            this.lblDataSourceError.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(316, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Enter the details of the datasource where the data you would like \r\nto update Act" +
    "ive Directory with is held.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Server Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(133, 127);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(100, 20);
            this.txtDBPassword.TabIndex = 8;
            // 
            // txtDBUsrName
            // 
            this.txtDBUsrName.Location = new System.Drawing.Point(27, 127);
            this.txtDBUsrName.Name = "txtDBUsrName";
            this.txtDBUsrName.Size = new System.Drawing.Size(100, 20);
            this.txtDBUsrName.TabIndex = 7;
            // 
            // txtDBServerName
            // 
            this.txtDBServerName.Location = new System.Drawing.Point(27, 75);
            this.txtDBServerName.Name = "txtDBServerName";
            this.txtDBServerName.Size = new System.Drawing.Size(100, 20);
            this.txtDBServerName.TabIndex = 4;
            // 
            // txtDBDatabase
            // 
            this.txtDBDatabase.Location = new System.Drawing.Point(133, 75);
            this.txtDBDatabase.Name = "txtDBDatabase";
            this.txtDBDatabase.Size = new System.Drawing.Size(100, 20);
            this.txtDBDatabase.TabIndex = 5;
            // 
            // lblTblName
            // 
            this.lblTblName.AutoSize = true;
            this.lblTblName.Location = new System.Drawing.Point(236, 59);
            this.lblTblName.Name = "lblTblName";
            this.lblTblName.Size = new System.Drawing.Size(65, 13);
            this.lblTblName.TabIndex = 2;
            this.lblTblName.Text = "Table Name";
            // 
            // txtTablename
            // 
            this.txtTablename.Location = new System.Drawing.Point(239, 75);
            this.txtTablename.Name = "txtTablename";
            this.txtTablename.Size = new System.Drawing.Size(100, 20);
            this.txtTablename.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAuthError);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblDomain);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUsrName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsrName);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 126);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // lblAuthError
            // 
            this.lblAuthError.AutoSize = true;
            this.lblAuthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthError.ForeColor = System.Drawing.Color.Red;
            this.lblAuthError.Location = new System.Drawing.Point(30, 103);
            this.lblAuthError.Name = "lblAuthError";
            this.lblAuthError.Size = new System.Drawing.Size(48, 13);
            this.lblAuthError.TabIndex = 7;
            this.lblAuthError.Text = "label11";
            this.lblAuthError.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Enter the details of a user with WRITE access to Active Directory";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(30, 54);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(43, 13);
            this.lblDomain.TabIndex = 5;
            this.lblDomain.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(30, 71);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(100, 20);
            this.txtDomain.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(244, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsrName
            // 
            this.lblUsrName.AutoSize = true;
            this.lblUsrName.Location = new System.Drawing.Point(136, 54);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(55, 13);
            this.lblUsrName.TabIndex = 2;
            this.lblUsrName.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(242, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsrName
            // 
            this.txtUsrName.Location = new System.Drawing.Point(136, 71);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(100, 20);
            this.txtUsrName.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(555, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 22);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 458);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AD Telephone Number Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GrpResults.ResumeLayout(false);
            this.GrpResults.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblADUpdateError;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkOtherTelephone;
        private System.Windows.Forms.CheckBox chkOffice;
        private System.Windows.Forms.CheckBox chkDescription;
        private System.Windows.Forms.CheckBox chkLastname;
        private System.Windows.Forms.CheckBox chkInitials;
        private System.Windows.Forms.CheckBox chkFirstName;
        private System.Windows.Forms.CheckBox chkDisplayName;
        private System.Windows.Forms.CheckBox ChkAdTelephone;
        private System.Windows.Forms.GroupBox GrpResults;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdateCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorCnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDataSourceError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.TextBox txtDBUsrName;
        private System.Windows.Forms.TextBox txtDBServerName;
        private System.Windows.Forms.TextBox txtDBDatabase;
        private System.Windows.Forms.Label lblTblName;
        private System.Windows.Forms.TextBox txtTablename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAuthError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem prepareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatasourceToolStripMenuItem;
    }
}

