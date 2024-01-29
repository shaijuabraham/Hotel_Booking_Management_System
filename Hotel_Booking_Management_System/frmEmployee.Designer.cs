
namespace Hotel_Booking_Management_System
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.btnPromotionButton = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.grpbxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingIDNumber = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckInClient = new System.Windows.Forms.Button();
            this.hotelTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBooking = new System.Windows.Forms.ListView();
            this.colConfigNumb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.cobStatus = new System.Windows.Forms.ComboBox();
            this.btnBookingClientInformanation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbxEmployeeInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPromotionButton
            // 
            this.btnPromotionButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPromotionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotionButton.ForeColor = System.Drawing.Color.White;
            this.btnPromotionButton.Location = new System.Drawing.Point(780, 149);
            this.btnPromotionButton.Name = "btnPromotionButton";
            this.btnPromotionButton.Size = new System.Drawing.Size(216, 55);
            this.btnPromotionButton.TabIndex = 0;
            this.btnPromotionButton.Text = "Hotel deals";
            this.btnPromotionButton.UseVisualStyleBackColor = false;
            this.btnPromotionButton.Click += new System.EventHandler(this.btnPromotionButton_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(12, 47);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(216, 55);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(12, 149);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(216, 55);
            this.btnCancelBooking.TabIndex = 2;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.Location = new System.Drawing.Point(780, 47);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(216, 55);
            this.btnEditBooking.TabIndex = 3;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // grpbxEmployeeInfo
            // 
            this.grpbxEmployeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpbxEmployeeInfo.Controls.Add(this.label3);
            this.grpbxEmployeeInfo.ForeColor = System.Drawing.Color.Linen;
            this.grpbxEmployeeInfo.Location = new System.Drawing.Point(670, 12);
            this.grpbxEmployeeInfo.Name = "grpbxEmployeeInfo";
            this.grpbxEmployeeInfo.Size = new System.Drawing.Size(342, 60);
            this.grpbxEmployeeInfo.TabIndex = 4;
            this.grpbxEmployeeInfo.TabStop = false;
            this.grpbxEmployeeInfo.Text = "Employee Information";
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearchBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooking.ForeColor = System.Drawing.Color.White;
            this.btnSearchBooking.Location = new System.Drawing.Point(178, 77);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.Size = new System.Drawing.Size(153, 55);
            this.btnSearchBooking.TabIndex = 5;
            this.btnSearchBooking.Text = "Search Booking";
            this.btnSearchBooking.UseVisualStyleBackColor = false;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnEditBooking);
            this.groupBox1.Controls.Add(this.btnPromotionButton);
            this.groupBox1.Controls.Add(this.btnNewBooking);
            this.groupBox1.Controls.Add(this.btnCancelBooking);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(10, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Access";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBookingIDNumber);
            this.groupBox3.Controls.Add(this.btnCheckOut);
            this.groupBox3.Controls.Add(this.btnSearchBooking);
            this.groupBox3.Controls.Add(this.btnCheckInClient);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(244, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 157);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Booking ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Booking Confermanation  Number :";
            // 
            // txtBookingIDNumber
            // 
            this.txtBookingIDNumber.Location = new System.Drawing.Point(312, 22);
            this.txtBookingIDNumber.Name = "txtBookingIDNumber";
            this.txtBookingIDNumber.Size = new System.Drawing.Size(191, 26);
            this.txtBookingIDNumber.TabIndex = 11;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(349, 77);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(154, 55);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckInClient
            // 
            this.btnCheckInClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCheckInClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInClient.ForeColor = System.Drawing.Color.White;
            this.btnCheckInClient.Location = new System.Drawing.Point(10, 77);
            this.btnCheckInClient.Name = "btnCheckInClient";
            this.btnCheckInClient.Size = new System.Drawing.Size(153, 55);
            this.btnCheckInClient.TabIndex = 6;
            this.btnCheckInClient.Text = "Check In";
            this.btnCheckInClient.UseVisualStyleBackColor = false;
            this.btnCheckInClient.Click += new System.EventHandler(this.btnCheckInClient_Click);
            // 
            // hotelTitle
            // 
            this.hotelTitle.AutoSize = true;
            this.hotelTitle.BackColor = System.Drawing.Color.Transparent;
            this.hotelTitle.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.hotelTitle.Location = new System.Drawing.Point(12, 14);
            this.hotelTitle.Name = "hotelTitle";
            this.hotelTitle.Size = new System.Drawing.Size(347, 58);
            this.hotelTitle.TabIndex = 8;
            this.hotelTitle.Text = "Hilton && Conrad";
            this.hotelTitle.Click += new System.EventHandler(this.hotelTitle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lstBooking);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cobStatus);
            this.groupBox2.Controls.Add(this.btnBookingClientInformanation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 284);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Booking List";
            // 
            // lstBooking
            // 
            this.lstBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colConfigNumb,
            this.colStatus,
            this.colName,
            this.colCheckIn,
            this.colCheckOut});
            this.lstBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooking.FullRowSelect = true;
            this.lstBooking.GridLines = true;
            this.lstBooking.HideSelection = false;
            this.lstBooking.Location = new System.Drawing.Point(12, 58);
            this.lstBooking.MultiSelect = false;
            this.lstBooking.Name = "lstBooking";
            this.lstBooking.Size = new System.Drawing.Size(970, 220);
            this.lstBooking.TabIndex = 15;
            this.lstBooking.UseCompatibleStateImageBehavior = false;
            this.lstBooking.View = System.Windows.Forms.View.Details;
            // 
            // colConfigNumb
            // 
            this.colConfigNumb.DisplayIndex = 1;
            this.colConfigNumb.Text = "Booking ID Number";
            this.colConfigNumb.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.DisplayIndex = 0;
            this.colStatus.Text = "Status";
            this.colStatus.Width = 158;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 146;
            // 
            // colCheckIn
            // 
            this.colCheckIn.Text = "CheckIn";
            this.colCheckIn.Width = 270;
            // 
            // colCheckOut
            // 
            this.colCheckOut.Text = "CheckOut";
            this.colCheckOut.Width = 377;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Booking Status";
            // 
            // cobStatus
            // 
            this.cobStatus.FormattingEnabled = true;
            this.cobStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Hold",
            "CheckedIn",
            "CheckedOut"});
            this.cobStatus.Location = new System.Drawing.Point(192, 24);
            this.cobStatus.Name = "cobStatus";
            this.cobStatus.Size = new System.Drawing.Size(166, 28);
            this.cobStatus.TabIndex = 9;
            this.cobStatus.SelectedIndexChanged += new System.EventHandler(this.cobStatus_SelectedIndexChanged);
            // 
            // btnBookingClientInformanation
            // 
            this.btnBookingClientInformanation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBookingClientInformanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingClientInformanation.ForeColor = System.Drawing.Color.White;
            this.btnBookingClientInformanation.Location = new System.Drawing.Point(767, 16);
            this.btnBookingClientInformanation.Name = "btnBookingClientInformanation";
            this.btnBookingClientInformanation.Size = new System.Drawing.Size(215, 39);
            this.btnBookingClientInformanation.TabIndex = 8;
            this.btnBookingClientInformanation.Text = "View Reservation Details";
            this.btnBookingClientInformanation.UseVisualStyleBackColor = false;
            this.btnBookingClientInformanation.Click += new System.EventHandler(this.btnBookingClientInformanation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emp: Harry Potter\r\nID: 2334552";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hotelTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxEmployeeInfo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "frmEmployee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grpbxEmployeeInfo.ResumeLayout(false);
            this.grpbxEmployeeInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPromotionButton;
        internal System.Windows.Forms.Button btnNewBooking;
        internal System.Windows.Forms.Button btnCancelBooking;
        internal System.Windows.Forms.Button btnEditBooking;
        internal System.Windows.Forms.GroupBox grpbxEmployeeInfo;
        internal System.Windows.Forms.Button btnSearchBooking;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label hotelTitle;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnCheckInClient;
        internal System.Windows.Forms.Button btnCheckOut;
        internal System.Windows.Forms.Button btnBookingClientInformanation;
        private System.Windows.Forms.ComboBox cobStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingIDNumber;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ListView lstBooking;
        internal System.Windows.Forms.ColumnHeader colStatus;
        internal System.Windows.Forms.ColumnHeader colConfigNumb;
        internal System.Windows.Forms.ColumnHeader colName;
        internal System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colCheckOut;
        private System.Windows.Forms.Label label3;
    }
}