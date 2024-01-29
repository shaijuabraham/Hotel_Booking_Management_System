
namespace Hotel_Booking_Management_System
{
    partial class frmViewBooking
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
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.grpbxBookingInformation = new System.Windows.Forms.GroupBox();
            this.grpbxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.grpbxPaymentInformation = new System.Windows.Forms.GroupBox();
            this.lblPayemntType = new System.Windows.Forms.Label();
            this.lblPayementStatus = new System.Windows.Forms.Label();
            this.lblCradCVVNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Amenities = new System.Windows.Forms.ListBox();
            this.lblSpecialRequest = new System.Windows.Forms.Label();
            this.libRoomInformation = new System.Windows.Forms.ListBox();
            this.grpbxRoomInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingIDNumber = new System.Windows.Forms.TextBox();
            this.btnViewBookingDetails = new System.Windows.Forms.Button();
            this.grpbxBookingInformation.SuspendLayout();
            this.grpbxCustomerInformation.SuspendLayout();
            this.grpbxPaymentInformation.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpbxRoomInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(6, 27);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 13);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(6, 57);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(58, 13);
            this.lblCheckOut.TabIndex = 1;
            this.lblCheckOut.Text = "Check Out";
            // 
            // grpbxBookingInformation
            // 
            this.grpbxBookingInformation.Controls.Add(this.lblCheckOut);
            this.grpbxBookingInformation.Controls.Add(this.lblCheckIn);
            this.grpbxBookingInformation.Location = new System.Drawing.Point(6, 116);
            this.grpbxBookingInformation.Name = "grpbxBookingInformation";
            this.grpbxBookingInformation.Size = new System.Drawing.Size(347, 83);
            this.grpbxBookingInformation.TabIndex = 2;
            this.grpbxBookingInformation.TabStop = false;
            this.grpbxBookingInformation.Text = "Booking Information";
            // 
            // grpbxCustomerInformation
            // 
            this.grpbxCustomerInformation.Controls.Add(this.lblPhoneNumber);
            this.grpbxCustomerInformation.Controls.Add(this.lblCustomerEmail);
            this.grpbxCustomerInformation.Controls.Add(this.lblCustomerFullName);
            this.grpbxCustomerInformation.Location = new System.Drawing.Point(5, 205);
            this.grpbxCustomerInformation.Name = "grpbxCustomerInformation";
            this.grpbxCustomerInformation.Size = new System.Drawing.Size(347, 79);
            this.grpbxCustomerInformation.TabIndex = 3;
            this.grpbxCustomerInformation.TabStop = false;
            this.grpbxCustomerInformation.Text = "Customer Information";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 54);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(67, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "2158881626";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(150, 39);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(103, 13);
            this.lblCustomerEmail.TabIndex = 1;
            this.lblCustomerEmail.Text = "johndoe@gmail.com";
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(6, 27);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(53, 13);
            this.lblCustomerFullName.TabIndex = 0;
            this.lblCustomerFullName.Text = "John Doe";
            // 
            // grpbxPaymentInformation
            // 
            this.grpbxPaymentInformation.Controls.Add(this.lblPayemntType);
            this.grpbxPaymentInformation.Controls.Add(this.lblPayementStatus);
            this.grpbxPaymentInformation.Controls.Add(this.lblCradCVVNumber);
            this.grpbxPaymentInformation.Controls.Add(this.lblExpirationDate);
            this.grpbxPaymentInformation.Controls.Add(this.lblCardNumber);
            this.grpbxPaymentInformation.Controls.Add(this.lblNameOnCard);
            this.grpbxPaymentInformation.Location = new System.Drawing.Point(6, 290);
            this.grpbxPaymentInformation.Name = "grpbxPaymentInformation";
            this.grpbxPaymentInformation.Size = new System.Drawing.Size(347, 109);
            this.grpbxPaymentInformation.TabIndex = 4;
            this.grpbxPaymentInformation.TabStop = false;
            this.grpbxPaymentInformation.Text = "Payment Information";
            // 
            // lblPayemntType
            // 
            this.lblPayemntType.AutoSize = true;
            this.lblPayemntType.Location = new System.Drawing.Point(186, 49);
            this.lblPayemntType.Name = "lblPayemntType";
            this.lblPayemntType.Size = new System.Drawing.Size(37, 13);
            this.lblPayemntType.TabIndex = 19;
            this.lblPayemntType.Text = "Status";
            // 
            // lblPayementStatus
            // 
            this.lblPayementStatus.AutoSize = true;
            this.lblPayementStatus.Location = new System.Drawing.Point(186, 25);
            this.lblPayementStatus.Name = "lblPayementStatus";
            this.lblPayementStatus.Size = new System.Drawing.Size(37, 13);
            this.lblPayementStatus.TabIndex = 18;
            this.lblPayementStatus.Text = "Status";
            // 
            // lblCradCVVNumber
            // 
            this.lblCradCVVNumber.AutoSize = true;
            this.lblCradCVVNumber.Location = new System.Drawing.Point(186, 76);
            this.lblCradCVVNumber.Name = "lblCradCVVNumber";
            this.lblCradCVVNumber.Size = new System.Drawing.Size(25, 13);
            this.lblCradCVVNumber.TabIndex = 3;
            this.lblCradCVVNumber.Text = "896";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(6, 76);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(64, 13);
            this.lblExpirationDate.TabIndex = 2;
            this.lblExpirationDate.Text = "March 2025";
            this.lblExpirationDate.Click += new System.EventHandler(this.lblExpirationDate_Click);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(5, 49);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(67, 13);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "9001002981";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Location = new System.Drawing.Point(6, 25);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(78, 13);
            this.lblNameOnCard.TabIndex = 0;
            this.lblNameOnCard.Text = "John York Doe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Amenities);
            this.groupBox4.Controls.Add(this.lblSpecialRequest);
            this.groupBox4.Location = new System.Drawing.Point(6, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 169);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Additional Services";
            // 
            // Amenities
            // 
            this.Amenities.FormattingEnabled = true;
            this.Amenities.Location = new System.Drawing.Point(9, 81);
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
            // libRoomInformation
            // 
            this.libRoomInformation.FormattingEnabled = true;
            this.libRoomInformation.Location = new System.Drawing.Point(18, 27);
            this.libRoomInformation.Name = "libRoomInformation";
            this.libRoomInformation.Size = new System.Drawing.Size(331, 394);
            this.libRoomInformation.TabIndex = 6;
            // 
            // grpbxRoomInformation
            // 
            this.grpbxRoomInformation.Controls.Add(this.libRoomInformation);
            this.grpbxRoomInformation.Location = new System.Drawing.Point(359, 116);
            this.grpbxRoomInformation.Name = "grpbxRoomInformation";
            this.grpbxRoomInformation.Size = new System.Drawing.Size(368, 440);
            this.grpbxRoomInformation.TabIndex = 7;
            this.grpbxRoomInformation.TabStop = false;
            this.grpbxRoomInformation.Text = "Room Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblBookingID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBookingIDNumber);
            this.groupBox1.Controls.Add(this.btnViewBookingDetails);
            this.groupBox1.Controls.Add(this.grpbxBookingInformation);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grpbxRoomInformation);
            this.groupBox1.Controls.Add(this.grpbxPaymentInformation);
            this.groupBox1.Controls.Add(this.grpbxCustomerInformation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 580);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Booking";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(580, 86);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Booking Confermanation  Number :";
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
            this.btnViewBookingDetails.Location = new System.Drawing.Point(15, 58);
            this.btnViewBookingDetails.Name = "btnViewBookingDetails";
            this.btnViewBookingDetails.Size = new System.Drawing.Size(192, 41);
            this.btnViewBookingDetails.TabIndex = 13;
            this.btnViewBookingDetails.Text = "View Booking Details";
            this.btnViewBookingDetails.UseVisualStyleBackColor = false;
            this.btnViewBookingDetails.Click += new System.EventHandler(this.btnViewBookingDetails_Click);
            // 
            // frmViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 604);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViewBooking";
            this.Text = "frmViewBooking";
            this.Load += new System.EventHandler(this.frmViewBooking_Load);
            this.grpbxBookingInformation.ResumeLayout(false);
            this.grpbxBookingInformation.PerformLayout();
            this.grpbxCustomerInformation.ResumeLayout(false);
            this.grpbxCustomerInformation.PerformLayout();
            this.grpbxPaymentInformation.ResumeLayout(false);
            this.grpbxPaymentInformation.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpbxRoomInformation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.GroupBox grpbxBookingInformation;
        private System.Windows.Forms.GroupBox grpbxCustomerInformation;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.GroupBox grpbxPaymentInformation;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSpecialRequest;
        private System.Windows.Forms.ListBox libRoomInformation;
        private System.Windows.Forms.Label lblCradCVVNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ListBox Amenities;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox grpbxRoomInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingIDNumber;
        internal System.Windows.Forms.Button btnViewBookingDetails;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPayementStatus;
        private System.Windows.Forms.Label lblPayemntType;
    }
}