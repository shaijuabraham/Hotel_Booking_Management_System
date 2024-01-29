
namespace Hotel_Booking_Management_System
{
    partial class frmEditBooking
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cobPayementStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookingIDNumber = new System.Windows.Forms.TextBox();
            this.btnViewBookingDetails = new System.Windows.Forms.Button();
            this.grpbxBookingInformation = new System.Windows.Forms.GroupBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Amenities = new System.Windows.Forms.ListBox();
            this.lblSpecialRequest = new System.Windows.Forms.Label();
            this.grpbxRoomInformation = new System.Windows.Forms.GroupBox();
            this.Room_Information = new System.Windows.Forms.ListBox();
            this.grpbxPaymentInformation = new System.Windows.Forms.GroupBox();
            this.txtExpericationDate = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblPayemntType = new System.Windows.Forms.Label();
            this.lblPayementStatus = new System.Windows.Forms.Label();
            this.lblCradCVVNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.grpbxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.btnDoneEditing = new System.Windows.Forms.Button();
            this.cobReservationStatus = new System.Windows.Forms.ComboBox();
            this.cobCardType = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.grpbxBookingInformation.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpbxRoomInformation.SuspendLayout();
            this.grpbxPaymentInformation.SuspendLayout();
            this.grpbxCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cobReservationStatus);
            this.groupBox2.Controls.Add(this.btnDoneEditing);
            this.groupBox2.Controls.Add(this.grpbxBookingInformation);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblBookingID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBookingIDNumber);
            this.groupBox2.Controls.Add(this.btnViewBookingDetails);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.grpbxRoomInformation);
            this.groupBox2.Controls.Add(this.grpbxPaymentInformation);
            this.groupBox2.Controls.Add(this.grpbxCustomerInformation);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 714);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Booking";
            // 
            // cobPayementStatus
            // 
            this.cobPayementStatus.FormattingEnabled = true;
            this.cobPayementStatus.Items.AddRange(new object[] {
            "Deposite",
            "Full Paid",
            "Hold",
            "On Site"});
            this.cobPayementStatus.Location = new System.Drawing.Point(213, 41);
            this.cobPayementStatus.Name = "cobPayementStatus";
            this.cobPayementStatus.Size = new System.Drawing.Size(121, 21);
            this.cobPayementStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(543, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(356, 86);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(97, 13);
            this.lblBookingID.TabIndex = 16;
            this.lblBookingID.Text = "BookingID Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter Booking Confermanation  Number :";
            // 
            // txtBookingIDNumber
            // 
            this.txtBookingIDNumber.Location = new System.Drawing.Point(332, 25);
            this.txtBookingIDNumber.Name = "txtBookingIDNumber";
            this.txtBookingIDNumber.Size = new System.Drawing.Size(191, 20);
            this.txtBookingIDNumber.TabIndex = 14;
            // 
            // btnViewBookingDetails
            // 
            this.btnViewBookingDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnViewBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookingDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewBookingDetails.Location = new System.Drawing.Point(9, 46);
            this.btnViewBookingDetails.Name = "btnViewBookingDetails";
            this.btnViewBookingDetails.Size = new System.Drawing.Size(192, 41);
            this.btnViewBookingDetails.TabIndex = 13;
            this.btnViewBookingDetails.Text = "View Booking Details";
            this.btnViewBookingDetails.UseVisualStyleBackColor = false;
            this.btnViewBookingDetails.Click += new System.EventHandler(this.btnViewBookingDetails_Click);
            // 
            // grpbxBookingInformation
            // 
            this.grpbxBookingInformation.Controls.Add(this.dtpCheckOut);
            this.grpbxBookingInformation.Controls.Add(this.dtpCheckIn);
            this.grpbxBookingInformation.Controls.Add(this.lblCheckOut);
            this.grpbxBookingInformation.Controls.Add(this.lblCheckIn);
            this.grpbxBookingInformation.Location = new System.Drawing.Point(361, 116);
            this.grpbxBookingInformation.Name = "grpbxBookingInformation";
            this.grpbxBookingInformation.Size = new System.Drawing.Size(366, 114);
            this.grpbxBookingInformation.TabIndex = 2;
            this.grpbxBookingInformation.TabStop = false;
            this.grpbxBookingInformation.Text = "Booking Information";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(6, 81);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(6, 42);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(6, 65);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(58, 13);
            this.lblCheckOut.TabIndex = 1;
            this.lblCheckOut.Text = "Check Out";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(6, 19);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 13);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Check In";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Amenities);
            this.groupBox4.Controls.Add(this.lblSpecialRequest);
            this.groupBox4.Location = new System.Drawing.Point(6, 438);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 225);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional Services";
            // 
            // Amenities
            // 
            this.Amenities.FormattingEnabled = true;
            this.Amenities.Location = new System.Drawing.Point(10, 130);
            this.Amenities.Name = "Amenities";
            this.Amenities.Size = new System.Drawing.Size(324, 82);
            this.Amenities.TabIndex = 1;
            // 
            // lblSpecialRequest
            // 
            this.lblSpecialRequest.AutoSize = true;
            this.lblSpecialRequest.Location = new System.Drawing.Point(6, 26);
            this.lblSpecialRequest.Name = "lblSpecialRequest";
            this.lblSpecialRequest.Size = new System.Drawing.Size(85, 13);
            this.lblSpecialRequest.TabIndex = 0;
            this.lblSpecialRequest.Text = "Special Request";
            // 
            // grpbxRoomInformation
            // 
            this.grpbxRoomInformation.Controls.Add(this.Room_Information);
            this.grpbxRoomInformation.Location = new System.Drawing.Point(359, 236);
            this.grpbxRoomInformation.Name = "grpbxRoomInformation";
            this.grpbxRoomInformation.Size = new System.Drawing.Size(368, 427);
            this.grpbxRoomInformation.TabIndex = 7;
            this.grpbxRoomInformation.TabStop = false;
            this.grpbxRoomInformation.Text = "Room Information";
            // 
            // Room_Information
            // 
            this.Room_Information.FormattingEnabled = true;
            this.Room_Information.Location = new System.Drawing.Point(18, 27);
            this.Room_Information.Name = "Room_Information";
            this.Room_Information.Size = new System.Drawing.Size(331, 394);
            this.Room_Information.TabIndex = 6;
            // 
            // grpbxPaymentInformation
            // 
            this.grpbxPaymentInformation.Controls.Add(this.cobCardType);
            this.grpbxPaymentInformation.Controls.Add(this.txtExpericationDate);
            this.grpbxPaymentInformation.Controls.Add(this.cobPayementStatus);
            this.grpbxPaymentInformation.Controls.Add(this.txtCardNumber);
            this.grpbxPaymentInformation.Controls.Add(this.txtCardHolderName);
            this.grpbxPaymentInformation.Controls.Add(this.txtCVV);
            this.grpbxPaymentInformation.Controls.Add(this.lblPayemntType);
            this.grpbxPaymentInformation.Controls.Add(this.lblPayementStatus);
            this.grpbxPaymentInformation.Controls.Add(this.lblCradCVVNumber);
            this.grpbxPaymentInformation.Controls.Add(this.lblExpirationDate);
            this.grpbxPaymentInformation.Controls.Add(this.lblCardNumber);
            this.grpbxPaymentInformation.Controls.Add(this.lblNameOnCard);
            this.grpbxPaymentInformation.Location = new System.Drawing.Point(6, 249);
            this.grpbxPaymentInformation.Name = "grpbxPaymentInformation";
            this.grpbxPaymentInformation.Size = new System.Drawing.Size(347, 183);
            this.grpbxPaymentInformation.TabIndex = 4;
            this.grpbxPaymentInformation.TabStop = false;
            this.grpbxPaymentInformation.Text = "Payment Information";
            // 
            // txtExpericationDate
            // 
            this.txtExpericationDate.Location = new System.Drawing.Point(9, 144);
            this.txtExpericationDate.Name = "txtExpericationDate";
            this.txtExpericationDate.Size = new System.Drawing.Size(76, 20);
            this.txtExpericationDate.TabIndex = 24;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(9, 95);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(108, 20);
            this.txtCardNumber.TabIndex = 23;
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Location = new System.Drawing.Point(8, 49);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(140, 20);
            this.txtCardHolderName.TabIndex = 22;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(135, 144);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(76, 20);
            this.txtCVV.TabIndex = 21;
            // 
            // lblPayemntType
            // 
            this.lblPayemntType.AutoSize = true;
            this.lblPayemntType.Location = new System.Drawing.Point(133, 79);
            this.lblPayemntType.Name = "lblPayemntType";
            this.lblPayemntType.Size = new System.Drawing.Size(62, 13);
            this.lblPayemntType.TabIndex = 19;
            this.lblPayemntType.Text = "Card Type :";
            // 
            // lblPayementStatus
            // 
            this.lblPayementStatus.AutoSize = true;
            this.lblPayementStatus.Location = new System.Drawing.Point(223, 25);
            this.lblPayementStatus.Name = "lblPayementStatus";
            this.lblPayementStatus.Size = new System.Drawing.Size(93, 13);
            this.lblPayementStatus.TabIndex = 18;
            this.lblPayementStatus.Text = "Payement Status :";
            // 
            // lblCradCVVNumber
            // 
            this.lblCradCVVNumber.AutoSize = true;
            this.lblCradCVVNumber.Location = new System.Drawing.Point(132, 128);
            this.lblCradCVVNumber.Name = "lblCradCVVNumber";
            this.lblCradCVVNumber.Size = new System.Drawing.Size(37, 13);
            this.lblCradCVVNumber.TabIndex = 3;
            this.lblCradCVVNumber.Text = "CVV : ";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(6, 128);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(31, 13);
            this.lblExpirationDate.TabIndex = 2;
            this.lblExpirationDate.Text = "Exp..";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(6, 79);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Location = new System.Drawing.Point(6, 25);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(94, 13);
            this.lblNameOnCard.TabIndex = 0;
            this.lblNameOnCard.Text = "Card Holder Name";
            // 
            // grpbxCustomerInformation
            // 
            this.grpbxCustomerInformation.Controls.Add(this.label7);
            this.grpbxCustomerInformation.Controls.Add(this.txtLastName);
            this.grpbxCustomerInformation.Controls.Add(this.txtEmail);
            this.grpbxCustomerInformation.Controls.Add(this.lblCustomerEmail);
            this.grpbxCustomerInformation.Controls.Add(this.txtPhoneNumber);
            this.grpbxCustomerInformation.Controls.Add(this.txtFirstName);
            this.grpbxCustomerInformation.Controls.Add(this.lblPhoneNumber);
            this.grpbxCustomerInformation.Controls.Add(this.lblCustomerFullName);
            this.grpbxCustomerInformation.Location = new System.Drawing.Point(6, 116);
            this.grpbxCustomerInformation.Name = "grpbxCustomerInformation";
            this.grpbxCustomerInformation.Size = new System.Drawing.Size(347, 127);
            this.grpbxCustomerInformation.TabIndex = 3;
            this.grpbxCustomerInformation.TabStop = false;
            this.grpbxCustomerInformation.Text = "Customer Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(138, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(112, 20);
            this.txtLastName.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(191, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(188, 78);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(46, 13);
            this.lblCustomerEmail.TabIndex = 30;
            this.lblCustomerEmail.Text = "Email ID";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(10, 94);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(112, 20);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 20);
            this.txtFirstName.TabIndex = 27;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 78);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(6, 27);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(57, 13);
            this.lblCustomerFullName.TabIndex = 0;
            this.lblCustomerFullName.Text = "First Name";
            // 
            // btnDoneEditing
            // 
            this.btnDoneEditing.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDoneEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneEditing.ForeColor = System.Drawing.Color.White;
            this.btnDoneEditing.Location = new System.Drawing.Point(244, 669);
            this.btnDoneEditing.Name = "btnDoneEditing";
            this.btnDoneEditing.Size = new System.Drawing.Size(192, 41);
            this.btnDoneEditing.TabIndex = 20;
            this.btnDoneEditing.Text = "Done";
            this.btnDoneEditing.UseVisualStyleBackColor = false;
            this.btnDoneEditing.Click += new System.EventHandler(this.btnDoneEditing_Click);
            // 
            // cobReservationStatus
            // 
            this.cobReservationStatus.FormattingEnabled = true;
            this.cobReservationStatus.Items.AddRange(new object[] {
            "Pending ",
            "Confirmed",
            "Hold",
            "CheckedIn",
            "CheckedOut"});
            this.cobReservationStatus.Location = new System.Drawing.Point(586, 83);
            this.cobReservationStatus.Name = "cobReservationStatus";
            this.cobReservationStatus.Size = new System.Drawing.Size(121, 21);
            this.cobReservationStatus.TabIndex = 21;
            // 
            // cobCardType
            // 
            this.cobCardType.FormattingEnabled = true;
            this.cobCardType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "Gift Card",
            "Other"});
            this.cobCardType.Location = new System.Drawing.Point(135, 94);
            this.cobCardType.Name = "cobCardType";
            this.cobCardType.Size = new System.Drawing.Size(121, 21);
            this.cobCardType.TabIndex = 25;
            // 
            // frmEditBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 738);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEditBooking";
            this.Text = "frmEditBooking";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpbxBookingInformation.ResumeLayout(false);
            this.grpbxBookingInformation.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpbxRoomInformation.ResumeLayout(false);
            this.grpbxPaymentInformation.ResumeLayout(false);
            this.grpbxPaymentInformation.PerformLayout();
            this.grpbxCustomerInformation.ResumeLayout(false);
            this.grpbxCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookingIDNumber;
        internal System.Windows.Forms.Button btnViewBookingDetails;
        private System.Windows.Forms.GroupBox grpbxBookingInformation;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox Amenities;
        private System.Windows.Forms.Label lblSpecialRequest;
        private System.Windows.Forms.GroupBox grpbxRoomInformation;
        private System.Windows.Forms.ListBox Room_Information;
        private System.Windows.Forms.GroupBox grpbxPaymentInformation;
        private System.Windows.Forms.TextBox txtExpericationDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblPayemntType;
        private System.Windows.Forms.Label lblPayementStatus;
        private System.Windows.Forms.Label lblCradCVVNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.GroupBox grpbxCustomerInformation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.ComboBox cobPayementStatus;
        internal System.Windows.Forms.Button btnDoneEditing;
        private System.Windows.Forms.ComboBox cobReservationStatus;
        private System.Windows.Forms.ComboBox cobCardType;
    }
}