
namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFilePathNameHT = new System.Windows.Forms.Label();
            this.txtFilePathNameHT = new System.Windows.Forms.TextBox();
            this.btnConfirmFileExistsHT = new System.Windows.Forms.Button();
            this.btnExitHT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtbxHT = new System.Windows.Forms.RichTextBox();
            this.btnReloadRecordsHT = new System.Windows.Forms.Button();
            this.lblMemberIdHT = new System.Windows.Forms.Label();
            this.btnDeleteHT = new System.Windows.Forms.Button();
            this.lblFirstNameHT = new System.Windows.Forms.Label();
            this.txtFirstNameHT = new System.Windows.Forms.TextBox();
            this.lblTotalCostOfAllClassesHT = new System.Windows.Forms.Label();
            this.txtTotalCostofAllClassesHT = new System.Windows.Forms.TextBox();
            this.lblLastNameHT = new System.Windows.Forms.Label();
            this.txtLastNameHT = new System.Windows.Forms.TextBox();
            this.lblAmountOutstandingHT = new System.Windows.Forms.Label();
            this.lblDateRegisteredHT = new System.Windows.Forms.Label();
            this.txtAmountOutstandingHT = new System.Windows.Forms.TextBox();
            this.txtDateRegisteredHT = new System.Windows.Forms.TextBox();
            this.lblNumberOfClasses = new System.Windows.Forms.Label();
            this.txtNumberOfClassesHT = new System.Windows.Forms.TextBox();
            this.lblTotalCostPerClassHT = new System.Windows.Forms.Label();
            this.txtTotalCostPerClassHT = new System.Windows.Forms.TextBox();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.txtTotalPaidHT = new System.Windows.Forms.TextBox();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.btnSaveHT = new System.Windows.Forms.Button();
            this.MessagesHT = new System.Windows.Forms.GroupBox();
            this.lblErrorMIHT = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMemberIdHT = new System.Windows.Forms.TextBox();
            this.lblerrorfn = new System.Windows.Forms.Label();
            this.lblerrorln = new System.Windows.Forms.Label();
            this.lblerrordr = new System.Windows.Forms.Label();
            this.lblerrornoc = new System.Windows.Forms.Label();
            this.lbltcpc = new System.Windows.Forms.Label();
            this.lbltp = new System.Windows.Forms.Label();
            this.lblerrordel = new System.Windows.Forms.Label();
            this.MessagesHT.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilePathNameHT
            // 
            this.lblFilePathNameHT.AutoSize = true;
            this.lblFilePathNameHT.Location = new System.Drawing.Point(1, 9);
            this.lblFilePathNameHT.Name = "lblFilePathNameHT";
            this.lblFilePathNameHT.Size = new System.Drawing.Size(110, 15);
            this.lblFilePathNameHT.TabIndex = 0;
            this.lblFilePathNameHT.Text = "File Path and Name\r\n";
            // 
            // txtFilePathNameHT
            // 
            this.txtFilePathNameHT.Location = new System.Drawing.Point(117, 6);
            this.txtFilePathNameHT.Name = "txtFilePathNameHT";
            this.txtFilePathNameHT.Size = new System.Drawing.Size(414, 23);
            this.txtFilePathNameHT.TabIndex = 1;
            this.txtFilePathNameHT.TextChanged += new System.EventHandler(this.txtFilePathNameHT_TextChanged);
            // 
            // btnConfirmFileExistsHT
            // 
            this.btnConfirmFileExistsHT.Location = new System.Drawing.Point(537, 6);
            this.btnConfirmFileExistsHT.Name = "btnConfirmFileExistsHT";
            this.btnConfirmFileExistsHT.Size = new System.Drawing.Size(254, 23);
            this.btnConfirmFileExistsHT.TabIndex = 2;
            this.btnConfirmFileExistsHT.Text = "Confirm File Exists";
            this.btnConfirmFileExistsHT.UseVisualStyleBackColor = true;
            this.btnConfirmFileExistsHT.Click += new System.EventHandler(this.btnConfirmFileExistsHT_Click);
            // 
            // btnExitHT
            // 
            this.btnExitHT.Location = new System.Drawing.Point(984, 5);
            this.btnExitHT.Name = "btnExitHT";
            this.btnExitHT.Size = new System.Drawing.Size(162, 53);
            this.btnExitHT.TabIndex = 4;
            this.btnExitHT.Text = "Exit";
            this.btnExitHT.UseVisualStyleBackColor = true;
            this.btnExitHT.Click += new System.EventHandler(this.btnExitHT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Records From Text File";
            // 
            // richTxtbxHT
            // 
            this.richTxtbxHT.Location = new System.Drawing.Point(1, 64);
            this.richTxtbxHT.Name = "richTxtbxHT";
            this.richTxtbxHT.ReadOnly = true;
            this.richTxtbxHT.Size = new System.Drawing.Size(1145, 117);
            this.richTxtbxHT.TabIndex = 6;
            this.richTxtbxHT.Text = "";
            // 
            // btnReloadRecordsHT
            // 
            this.btnReloadRecordsHT.Enabled = false;
            this.btnReloadRecordsHT.Location = new System.Drawing.Point(797, 5);
            this.btnReloadRecordsHT.Name = "btnReloadRecordsHT";
            this.btnReloadRecordsHT.Size = new System.Drawing.Size(181, 53);
            this.btnReloadRecordsHT.TabIndex = 7;
            this.btnReloadRecordsHT.Text = "Reload Records";
            this.btnReloadRecordsHT.UseVisualStyleBackColor = true;
            this.btnReloadRecordsHT.Click += new System.EventHandler(this.btnReloadRecordsHT_Click);
            // 
            // lblMemberIdHT
            // 
            this.lblMemberIdHT.AutoSize = true;
            this.lblMemberIdHT.Location = new System.Drawing.Point(41, 191);
            this.lblMemberIdHT.Name = "lblMemberIdHT";
            this.lblMemberIdHT.Size = new System.Drawing.Size(66, 15);
            this.lblMemberIdHT.TabIndex = 8;
            this.lblMemberIdHT.Text = "Member ID";
            // 
            // btnDeleteHT
            // 
            this.btnDeleteHT.Enabled = false;
            this.btnDeleteHT.Location = new System.Drawing.Point(632, 187);
            this.btnDeleteHT.Name = "btnDeleteHT";
            this.btnDeleteHT.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHT.TabIndex = 10;
            this.btnDeleteHT.Text = "Delete";
            this.btnDeleteHT.UseVisualStyleBackColor = true;
            this.btnDeleteHT.Click += new System.EventHandler(this.btnDeleteHT_Click);
            // 
            // lblFirstNameHT
            // 
            this.lblFirstNameHT.AutoSize = true;
            this.lblFirstNameHT.Location = new System.Drawing.Point(41, 222);
            this.lblFirstNameHT.Name = "lblFirstNameHT";
            this.lblFirstNameHT.Size = new System.Drawing.Size(64, 15);
            this.lblFirstNameHT.TabIndex = 11;
            this.lblFirstNameHT.Text = "First Name";
            // 
            // txtFirstNameHT
            // 
            this.txtFirstNameHT.Location = new System.Drawing.Point(113, 219);
            this.txtFirstNameHT.Name = "txtFirstNameHT";
            this.txtFirstNameHT.Size = new System.Drawing.Size(223, 23);
            this.txtFirstNameHT.TabIndex = 12;
            this.txtFirstNameHT.TextChanged += new System.EventHandler(this.txtFirstNameHT_TextChanged);
            // 
            // lblTotalCostOfAllClassesHT
            // 
            this.lblTotalCostOfAllClassesHT.AutoSize = true;
            this.lblTotalCostOfAllClassesHT.Location = new System.Drawing.Point(338, 225);
            this.lblTotalCostOfAllClassesHT.Name = "lblTotalCostOfAllClassesHT";
            this.lblTotalCostOfAllClassesHT.Size = new System.Drawing.Size(129, 15);
            this.lblTotalCostOfAllClassesHT.TabIndex = 13;
            this.lblTotalCostOfAllClassesHT.Text = "Total Cost of all Classes";
            // 
            // txtTotalCostofAllClassesHT
            // 
            this.txtTotalCostofAllClassesHT.Location = new System.Drawing.Point(473, 222);
            this.txtTotalCostofAllClassesHT.Name = "txtTotalCostofAllClassesHT";
            this.txtTotalCostofAllClassesHT.Size = new System.Drawing.Size(234, 23);
            this.txtTotalCostofAllClassesHT.TabIndex = 14;
            this.txtTotalCostofAllClassesHT.TextChanged += new System.EventHandler(this.txtTotalCostofAllClassesHT_TextChanged);
            // 
            // lblLastNameHT
            // 
            this.lblLastNameHT.AutoSize = true;
            this.lblLastNameHT.Location = new System.Drawing.Point(41, 256);
            this.lblLastNameHT.Name = "lblLastNameHT";
            this.lblLastNameHT.Size = new System.Drawing.Size(63, 15);
            this.lblLastNameHT.TabIndex = 15;
            this.lblLastNameHT.Text = "Last Name";
            // 
            // txtLastNameHT
            // 
            this.txtLastNameHT.Location = new System.Drawing.Point(113, 253);
            this.txtLastNameHT.Name = "txtLastNameHT";
            this.txtLastNameHT.Size = new System.Drawing.Size(223, 23);
            this.txtLastNameHT.TabIndex = 16;
            this.txtLastNameHT.TextChanged += new System.EventHandler(this.txtLastNameHT_TextChanged);
            // 
            // lblAmountOutstandingHT
            // 
            this.lblAmountOutstandingHT.AutoSize = true;
            this.lblAmountOutstandingHT.Location = new System.Drawing.Point(347, 256);
            this.lblAmountOutstandingHT.Name = "lblAmountOutstandingHT";
            this.lblAmountOutstandingHT.Size = new System.Drawing.Size(120, 15);
            this.lblAmountOutstandingHT.TabIndex = 17;
            this.lblAmountOutstandingHT.Text = "Amount Outstanding";
            // 
            // lblDateRegisteredHT
            // 
            this.lblDateRegisteredHT.AutoSize = true;
            this.lblDateRegisteredHT.Location = new System.Drawing.Point(22, 289);
            this.lblDateRegisteredHT.Name = "lblDateRegisteredHT";
            this.lblDateRegisteredHT.Size = new System.Drawing.Size(89, 15);
            this.lblDateRegisteredHT.TabIndex = 19;
            this.lblDateRegisteredHT.Text = "Date Registered";
            // 
            // txtAmountOutstandingHT
            // 
            this.txtAmountOutstandingHT.Location = new System.Drawing.Point(473, 256);
            this.txtAmountOutstandingHT.Name = "txtAmountOutstandingHT";
            this.txtAmountOutstandingHT.Size = new System.Drawing.Size(234, 23);
            this.txtAmountOutstandingHT.TabIndex = 20;
            // 
            // txtDateRegisteredHT
            // 
            this.txtDateRegisteredHT.Location = new System.Drawing.Point(113, 289);
            this.txtDateRegisteredHT.Name = "txtDateRegisteredHT";
            this.txtDateRegisteredHT.Size = new System.Drawing.Size(223, 23);
            this.txtDateRegisteredHT.TabIndex = 21;
            this.txtDateRegisteredHT.TextChanged += new System.EventHandler(this.txtDateRegisteredHT_TextChanged);
            // 
            // lblNumberOfClasses
            // 
            this.lblNumberOfClasses.AutoSize = true;
            this.lblNumberOfClasses.Location = new System.Drawing.Point(2, 326);
            this.lblNumberOfClasses.Name = "lblNumberOfClasses";
            this.lblNumberOfClasses.Size = new System.Drawing.Size(106, 15);
            this.lblNumberOfClasses.TabIndex = 22;
            this.lblNumberOfClasses.Text = "Number of Classes";
            // 
            // txtNumberOfClassesHT
            // 
            this.txtNumberOfClassesHT.Location = new System.Drawing.Point(113, 326);
            this.txtNumberOfClassesHT.Name = "txtNumberOfClassesHT";
            this.txtNumberOfClassesHT.Size = new System.Drawing.Size(223, 23);
            this.txtNumberOfClassesHT.TabIndex = 23;
            this.txtNumberOfClassesHT.TextChanged += new System.EventHandler(this.txtNumberOfClassesHT_TextChanged);
            // 
            // lblTotalCostPerClassHT
            // 
            this.lblTotalCostPerClassHT.AutoSize = true;
            this.lblTotalCostPerClassHT.Location = new System.Drawing.Point(2, 363);
            this.lblTotalCostPerClassHT.Name = "lblTotalCostPerClassHT";
            this.lblTotalCostPerClassHT.Size = new System.Drawing.Size(109, 15);
            this.lblTotalCostPerClassHT.TabIndex = 24;
            this.lblTotalCostPerClassHT.Text = "Total Cost Per Class";
            // 
            // txtTotalCostPerClassHT
            // 
            this.txtTotalCostPerClassHT.Location = new System.Drawing.Point(113, 360);
            this.txtTotalCostPerClassHT.Name = "txtTotalCostPerClassHT";
            this.txtTotalCostPerClassHT.Size = new System.Drawing.Size(223, 23);
            this.txtTotalCostPerClassHT.TabIndex = 25;
            this.txtTotalCostPerClassHT.TextChanged += new System.EventHandler(this.txtTotalCostPerClassHT_TextChanged);
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Location = new System.Drawing.Point(46, 397);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(58, 15);
            this.lblTotalPaid.TabIndex = 26;
            this.lblTotalPaid.Text = "Total Paid";
            // 
            // txtTotalPaidHT
            // 
            this.txtTotalPaidHT.Location = new System.Drawing.Point(113, 394);
            this.txtTotalPaidHT.Name = "txtTotalPaidHT";
            this.txtTotalPaidHT.Size = new System.Drawing.Size(223, 23);
            this.txtTotalPaidHT.TabIndex = 27;
            this.txtTotalPaidHT.TextChanged += new System.EventHandler(this.txtTotalPaidHT_TextChanged);
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Enabled = false;
            this.btnEmptyFile.Location = new System.Drawing.Point(113, 441);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(594, 23);
            this.btnEmptyFile.TabIndex = 28;
            this.btnEmptyFile.Text = "Empty File";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
            // 
            // btnSaveHT
            // 
            this.btnSaveHT.Enabled = false;
            this.btnSaveHT.Location = new System.Drawing.Point(399, 326);
            this.btnSaveHT.Name = "btnSaveHT";
            this.btnSaveHT.Size = new System.Drawing.Size(308, 52);
            this.btnSaveHT.TabIndex = 29;
            this.btnSaveHT.Text = "Save (Add/Update)";
            this.btnSaveHT.UseVisualStyleBackColor = true;
            this.btnSaveHT.Click += new System.EventHandler(this.btnSaveHT_Click);
            // 
            // MessagesHT
            // 
            this.MessagesHT.Controls.Add(this.lblerrordel);
            this.MessagesHT.Controls.Add(this.lbltp);
            this.MessagesHT.Controls.Add(this.lbltcpc);
            this.MessagesHT.Controls.Add(this.lblerrornoc);
            this.MessagesHT.Controls.Add(this.lblerrordr);
            this.MessagesHT.Controls.Add(this.lblerrorln);
            this.MessagesHT.Controls.Add(this.lblerrorfn);
            this.MessagesHT.Controls.Add(this.lblErrorMIHT);
            this.MessagesHT.Location = new System.Drawing.Point(751, 209);
            this.MessagesHT.Name = "MessagesHT";
            this.MessagesHT.Size = new System.Drawing.Size(395, 235);
            this.MessagesHT.TabIndex = 30;
            this.MessagesHT.TabStop = false;
            this.MessagesHT.Text = "Messages (Label)";
            // 
            // lblErrorMIHT
            // 
            this.lblErrorMIHT.AutoSize = true;
            this.lblErrorMIHT.Location = new System.Drawing.Point(7, 21);
            this.lblErrorMIHT.Name = "lblErrorMIHT";
            this.lblErrorMIHT.Size = new System.Drawing.Size(38, 15);
            this.lblErrorMIHT.TabIndex = 4;
            this.lblErrorMIHT.Text = "label1";
            this.lblErrorMIHT.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Member ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "First Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Date Registered";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(632, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Total Cost Per Class";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(769, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Total Cost of all Classes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(494, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 39;
            this.label16.Text = "Number of Classes";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(926, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "Total Paid";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1011, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 15);
            this.label20.TabIndex = 41;
            this.label20.Text = "Amount Outstanding";
            // 
            // txtMemberIdHT
            // 
            this.txtMemberIdHT.Location = new System.Drawing.Point(113, 188);
            this.txtMemberIdHT.Name = "txtMemberIdHT";
            this.txtMemberIdHT.Size = new System.Drawing.Size(223, 23);
            this.txtMemberIdHT.TabIndex = 42;
            this.txtMemberIdHT.Click += new System.EventHandler(this.txtMemberIdHT_Click);
            this.txtMemberIdHT.TextChanged += new System.EventHandler(this.txtMemberIdHT_TextChanged);
            // 
            // lblerrorfn
            // 
            this.lblerrorfn.AutoSize = true;
            this.lblerrorfn.Location = new System.Drawing.Point(7, 44);
            this.lblerrorfn.Name = "lblerrorfn";
            this.lblerrorfn.Size = new System.Drawing.Size(38, 15);
            this.lblerrorfn.TabIndex = 5;
            this.lblerrorfn.Text = "label1";
            this.lblerrorfn.Visible = false;
            // 
            // lblerrorln
            // 
            this.lblerrorln.AutoSize = true;
            this.lblerrorln.Location = new System.Drawing.Point(7, 71);
            this.lblerrorln.Name = "lblerrorln";
            this.lblerrorln.Size = new System.Drawing.Size(38, 15);
            this.lblerrorln.TabIndex = 6;
            this.lblerrorln.Text = "label1";
            this.lblerrorln.Visible = false;
            // 
            // lblerrordr
            // 
            this.lblerrordr.AutoSize = true;
            this.lblerrordr.Location = new System.Drawing.Point(7, 100);
            this.lblerrordr.Name = "lblerrordr";
            this.lblerrordr.Size = new System.Drawing.Size(38, 15);
            this.lblerrordr.TabIndex = 7;
            this.lblerrordr.Text = "label1";
            this.lblerrordr.Visible = false;
            // 
            // lblerrornoc
            // 
            this.lblerrornoc.AutoSize = true;
            this.lblerrornoc.Location = new System.Drawing.Point(7, 124);
            this.lblerrornoc.Name = "lblerrornoc";
            this.lblerrornoc.Size = new System.Drawing.Size(38, 15);
            this.lblerrornoc.TabIndex = 8;
            this.lblerrornoc.Text = "label1";
            this.lblerrornoc.Visible = false;
            // 
            // lbltcpc
            // 
            this.lbltcpc.AutoSize = true;
            this.lbltcpc.Location = new System.Drawing.Point(7, 153);
            this.lbltcpc.Name = "lbltcpc";
            this.lbltcpc.Size = new System.Drawing.Size(38, 15);
            this.lbltcpc.TabIndex = 9;
            this.lbltcpc.Text = "label1";
            this.lbltcpc.Visible = false;
            // 
            // lbltp
            // 
            this.lbltp.AutoSize = true;
            this.lbltp.Location = new System.Drawing.Point(7, 185);
            this.lbltp.Name = "lbltp";
            this.lbltp.Size = new System.Drawing.Size(38, 15);
            this.lbltp.TabIndex = 10;
            this.lbltp.Text = "label1";
            this.lbltp.Visible = false;
            // 
            // lblerrordel
            // 
            this.lblerrordel.AutoSize = true;
            this.lblerrordel.Location = new System.Drawing.Point(7, 214);
            this.lblerrordel.Name = "lblerrordel";
            this.lblerrordel.Size = new System.Drawing.Size(38, 15);
            this.lblerrordel.TabIndex = 11;
            this.lblerrordel.Text = "label1";
            this.lblerrordel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 476);
            this.Controls.Add(this.txtMemberIdHT);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MessagesHT);
            this.Controls.Add(this.btnSaveHT);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.txtTotalPaidHT);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.txtTotalCostPerClassHT);
            this.Controls.Add(this.lblTotalCostPerClassHT);
            this.Controls.Add(this.txtNumberOfClassesHT);
            this.Controls.Add(this.lblNumberOfClasses);
            this.Controls.Add(this.txtDateRegisteredHT);
            this.Controls.Add(this.txtAmountOutstandingHT);
            this.Controls.Add(this.lblDateRegisteredHT);
            this.Controls.Add(this.lblAmountOutstandingHT);
            this.Controls.Add(this.txtLastNameHT);
            this.Controls.Add(this.lblLastNameHT);
            this.Controls.Add(this.txtTotalCostofAllClassesHT);
            this.Controls.Add(this.lblTotalCostOfAllClassesHT);
            this.Controls.Add(this.txtFirstNameHT);
            this.Controls.Add(this.lblFirstNameHT);
            this.Controls.Add(this.btnDeleteHT);
            this.Controls.Add(this.lblMemberIdHT);
            this.Controls.Add(this.btnReloadRecordsHT);
            this.Controls.Add(this.richTxtbxHT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitHT);
            this.Controls.Add(this.btnConfirmFileExistsHT);
            this.Controls.Add(this.txtFilePathNameHT);
            this.Controls.Add(this.lblFilePathNameHT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MessagesHT.ResumeLayout(false);
            this.MessagesHT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePathNameHT;
        private System.Windows.Forms.TextBox txtFilePathNameHT;
        private System.Windows.Forms.Button btnConfirmFileExistsHT;
        private System.Windows.Forms.Button btnExitHT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtbxHT;
        private System.Windows.Forms.Button btnReloadRecordsHT;
        private System.Windows.Forms.Label lblMemberIdHT;
        private System.Windows.Forms.Button btnDeleteHT;
        private System.Windows.Forms.Label lblFirstNameHT;
        private System.Windows.Forms.TextBox txtFirstNameHT;
        private System.Windows.Forms.Label lblTotalCostOfAllClassesHT;
        private System.Windows.Forms.TextBox txtTotalCostofAllClassesHT;
        private System.Windows.Forms.Label lblLastNameHT;
        private System.Windows.Forms.TextBox txtLastNameHT;
        private System.Windows.Forms.Label lblAmountOutstandingHT;
        private System.Windows.Forms.Label lblDateRegisteredHT;
        private System.Windows.Forms.TextBox txtAmountOutstandingHT;
        private System.Windows.Forms.TextBox txtDateRegisteredHT;
        private System.Windows.Forms.Label lblNumberOfClasses;
        private System.Windows.Forms.TextBox txtNumberOfClassesHT;
        private System.Windows.Forms.Label lblTotalCostPerClassHT;
        private System.Windows.Forms.TextBox txtTotalCostPerClassHT;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.TextBox txtTotalPaidHT;
        private System.Windows.Forms.Button btnEmptyFile;
        private System.Windows.Forms.Button btnSaveHT;
        private System.Windows.Forms.GroupBox MessagesHT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblErrorMIHT;
        private System.Windows.Forms.TextBox txtMemberIdHT;
        private System.Windows.Forms.Label lbltp;
        private System.Windows.Forms.Label lbltcpc;
        private System.Windows.Forms.Label lblerrornoc;
        private System.Windows.Forms.Label lblerrordr;
        private System.Windows.Forms.Label lblerrorln;
        private System.Windows.Forms.Label lblerrorfn;
        private System.Windows.Forms.Label lblerrordel;
    }
}

