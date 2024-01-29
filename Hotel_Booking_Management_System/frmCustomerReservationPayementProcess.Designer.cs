
namespace Hotel_Booking_Management_System
{
    partial class frmCustomerReservationPayementProcess
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rtbSpecialRequest = new System.Windows.Forms.RichTextBox();
            this.lbl = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.rdbDeposite = new System.Windows.Forms.RadioButton();
            this.rdbFullPayement = new System.Windows.Forms.RadioButton();
            this.lblShowBookingNumber = new System.Windows.Forms.Label();
            this.lblPayementType = new System.Windows.Forms.Label();
            this.cobPayementType = new System.Windows.Forms.ComboBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.libReservationList = new System.Windows.Forms.ListBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cobExpYear = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cobExpMonth = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnCompleteBooking = new System.Windows.Forms.Button();
            this.libTotal = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lbl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.btnCompleteBooking);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 850);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.libTotal);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.rtbSpecialRequest);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 557);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 232);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Service";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Car Rental",
            "SPA",
            "Laundry"});
            this.checkedListBox1.Location = new System.Drawing.Point(9, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(328, 84);
            this.checkedListBox1.TabIndex = 1;
            // 
            // rtbSpecialRequest
            // 
            this.rtbSpecialRequest.Location = new System.Drawing.Point(6, 142);
            this.rtbSpecialRequest.Name = "rtbSpecialRequest";
            this.rtbSpecialRequest.Size = new System.Drawing.Size(331, 67);
            this.rtbSpecialRequest.TabIndex = 0;
            this.rtbSpecialRequest.Text = "Please enter here if you needs any special request........";
            // 
            // lbl
            // 
            this.lbl.Controls.Add(this.groupBox2);
            this.lbl.Controls.Add(this.rdbDeposite);
            this.lbl.Controls.Add(this.rdbFullPayement);
            this.lbl.Controls.Add(this.lblShowBookingNumber);
            this.lbl.Controls.Add(this.lblPayementType);
            this.lbl.Controls.Add(this.cobPayementType);
            this.lbl.Controls.Add(this.txtCvv);
            this.lbl.Controls.Add(this.libReservationList);
            this.lbl.Controls.Add(this.txtPhoneNumber);
            this.lbl.Controls.Add(this.cobExpYear);
            this.lbl.Controls.Add(this.txtZipCode);
            this.lbl.Controls.Add(this.txtCardName);
            this.lbl.Controls.Add(this.txtEmail);
            this.lbl.Controls.Add(this.cobExpMonth);
            this.lbl.Controls.Add(this.txtLastName);
            this.lbl.Controls.Add(this.txtCardNumber);
            this.lbl.Controls.Add(this.comboBox1);
            this.lbl.Controls.Add(this.txtFirstName);
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(8, 19);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(742, 532);
            this.lbl.TabIndex = 28;
            this.lbl.TabStop = false;
            this.lbl.Text = "Booking Informanation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCheckIn);
            this.groupBox2.Controls.Add(this.lblCheckOut);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 75);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation Dates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "CheckOut: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "CheckIn:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(16, 49);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(94, 19);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "reservation";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(373, 49);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(94, 19);
            this.lblCheckOut.TabIndex = 17;
            this.lblCheckOut.Text = "reservation";
            // 
            // rdbDeposite
            // 
            this.rdbDeposite.AutoSize = true;
            this.rdbDeposite.Location = new System.Drawing.Point(141, 246);
            this.rdbDeposite.Name = "rdbDeposite";
            this.rdbDeposite.Size = new System.Drawing.Size(90, 21);
            this.rdbDeposite.TabIndex = 34;
            this.rdbDeposite.TabStop = true;
            this.rdbDeposite.Text = "Deposite";
            this.rdbDeposite.UseVisualStyleBackColor = true;
            // 
            // rdbFullPayement
            // 
            this.rdbFullPayement.AutoSize = true;
            this.rdbFullPayement.Location = new System.Drawing.Point(12, 246);
            this.rdbFullPayement.Name = "rdbFullPayement";
            this.rdbFullPayement.Size = new System.Drawing.Size(83, 21);
            this.rdbFullPayement.TabIndex = 33;
            this.rdbFullPayement.TabStop = true;
            this.rdbFullPayement.Text = "Pay Full";
            this.rdbFullPayement.UseVisualStyleBackColor = true;
            // 
            // lblShowBookingNumber
            // 
            this.lblShowBookingNumber.AutoSize = true;
            this.lblShowBookingNumber.Location = new System.Drawing.Point(6, 593);
            this.lblShowBookingNumber.Name = "lblShowBookingNumber";
            this.lblShowBookingNumber.Size = new System.Drawing.Size(52, 17);
            this.lblShowBookingNumber.TabIndex = 32;
            this.lblShowBookingNumber.Text = "label2";
            // 
            // lblPayementType
            // 
            this.lblPayementType.AutoSize = true;
            this.lblPayementType.Location = new System.Drawing.Point(10, 283);
            this.lblPayementType.Name = "lblPayementType";
            this.lblPayementType.Size = new System.Drawing.Size(119, 17);
            this.lblPayementType.TabIndex = 31;
            this.lblPayementType.Text = "Payement Type";
            // 
            // cobPayementType
            // 
            this.cobPayementType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cobPayementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobPayementType.FormattingEnabled = true;
            this.cobPayementType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "Apple Wallet",
            "Credit Card",
            "other"});
            this.cobPayementType.Location = new System.Drawing.Point(141, 279);
            this.cobPayementType.Name = "cobPayementType";
            this.cobPayementType.Size = new System.Drawing.Size(114, 26);
            this.cobPayementType.TabIndex = 30;
            // 
            // txtCvv
            // 
            this.txtCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvv.Location = new System.Drawing.Point(15, 431);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(55, 24);
            this.txtCvv.TabIndex = 29;
            this.txtCvv.Text = "098";
            // 
            // libReservationList
            // 
            this.libReservationList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libReservationList.FormattingEnabled = true;
            this.libReservationList.ItemHeight = 15;
            this.libReservationList.Location = new System.Drawing.Point(364, 114);
            this.libReservationList.Name = "libReservationList";
            this.libReservationList.Size = new System.Drawing.Size(360, 409);
            this.libReservationList.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(105, 202);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 24);
            this.txtPhoneNumber.TabIndex = 21;
            this.txtPhoneNumber.Text = "9763214723";
            // 
            // cobExpYear
            // 
            this.cobExpYear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cobExpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobExpYear.FormattingEnabled = true;
            this.cobExpYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046"});
            this.cobExpYear.Location = new System.Drawing.Point(107, 389);
            this.cobExpYear.Name = "cobExpYear";
            this.cobExpYear.Size = new System.Drawing.Size(86, 26);
            this.cobExpYear.TabIndex = 28;
            this.cobExpYear.Text = "Year";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(15, 470);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(89, 24);
            this.txtZipCode.TabIndex = 26;
            this.txtZipCode.Text = "17921";
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Location = new System.Drawing.Point(13, 311);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(343, 24);
            this.txtCardName.TabIndex = 23;
            this.txtCardName.Text = "Name on the Card";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 24);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Text = "accountuser@gmail.com";
            // 
            // cobExpMonth
            // 
            this.cobExpMonth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cobExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobExpMonth.FormattingEnabled = true;
            this.cobExpMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cobExpMonth.Location = new System.Drawing.Point(15, 389);
            this.cobExpMonth.Name = "cobExpMonth";
            this.cobExpMonth.Size = new System.Drawing.Size(86, 26);
            this.cobExpMonth.TabIndex = 27;
            this.cobExpMonth.Text = "Month";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(213, 120);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 24);
            this.txtLastName.TabIndex = 19;
            this.txtLastName.Text = "John";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(13, 350);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(242, 24);
            this.txtCardNumber.TabIndex = 25;
            this.txtCardNumber.Text = "98765432345678";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 26);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "USA+1";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(12, 120);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 24);
            this.txtFirstName.TabIndex = 18;
            this.txtFirstName.Text = "Kona";
            // 
            // btnCompleteBooking
            // 
            this.btnCompleteBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleteBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnCompleteBooking.Location = new System.Drawing.Point(239, 795);
            this.btnCompleteBooking.Name = "btnCompleteBooking";
            this.btnCompleteBooking.Size = new System.Drawing.Size(232, 44);
            this.btnCompleteBooking.TabIndex = 16;
            this.btnCompleteBooking.Text = "Complete Booking";
            this.btnCompleteBooking.UseVisualStyleBackColor = false;
            this.btnCompleteBooking.Click += new System.EventHandler(this.btnCompleteBooking_Click_1);
            // 
            // libTotal
            // 
            this.libTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libTotal.FormattingEnabled = true;
            this.libTotal.ItemHeight = 15;
            this.libTotal.Location = new System.Drawing.Point(364, 18);
            this.libTotal.Name = "libTotal";
            this.libTotal.Size = new System.Drawing.Size(378, 199);
            this.libTotal.TabIndex = 31;
            // 
            // frmCustomerReservationPayementProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 870);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmCustomerReservationPayementProcess";
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.frmCustomerReservationPayementProcess_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.lbl.ResumeLayout(false);
            this.lbl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbSpecialRequest;
        private System.Windows.Forms.GroupBox lbl;
        private System.Windows.Forms.RadioButton rdbDeposite;
        private System.Windows.Forms.RadioButton rdbFullPayement;
        public System.Windows.Forms.Label lblShowBookingNumber;
        private System.Windows.Forms.Label lblPayementType;
        private System.Windows.Forms.ComboBox cobPayementType;
        private System.Windows.Forms.TextBox txtCvv;
        internal System.Windows.Forms.ListBox libReservationList;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cobExpYear;
        internal System.Windows.Forms.Label lblCheckIn;
        internal System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cobExpMonth;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Button btnCompleteBooking;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        internal System.Windows.Forms.ListBox libTotal;
    }
}