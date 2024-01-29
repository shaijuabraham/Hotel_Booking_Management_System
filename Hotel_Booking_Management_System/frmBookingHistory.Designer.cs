
namespace Hotel_Booking_Management_System
{
    partial class frmBookingHistory
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
            this.txtBookingIDNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewBookingDetails = new System.Windows.Forms.Button();
            this.lstBooking = new System.Windows.Forms.ListView();
            this.colConfigNumb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtBookingIDNumber
            // 
            this.txtBookingIDNumber.Location = new System.Drawing.Point(483, 30);
            this.txtBookingIDNumber.Name = "txtBookingIDNumber";
            this.txtBookingIDNumber.Size = new System.Drawing.Size(236, 20);
            this.txtBookingIDNumber.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(249, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Booking Phone Number :";
            // 
            // btnViewBookingDetails
            // 
            this.btnViewBookingDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnViewBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookingDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewBookingDetails.Location = new System.Drawing.Point(466, 72);
            this.btnViewBookingDetails.Name = "btnViewBookingDetails";
            this.btnViewBookingDetails.Size = new System.Drawing.Size(192, 43);
            this.btnViewBookingDetails.TabIndex = 21;
            this.btnViewBookingDetails.Text = "Search Booking";
            this.btnViewBookingDetails.UseVisualStyleBackColor = false;
            this.btnViewBookingDetails.Click += new System.EventHandler(this.btnViewBookingDetails_Click);
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
            this.lstBooking.Location = new System.Drawing.Point(-1, 121);
            this.lstBooking.MultiSelect = false;
            this.lstBooking.Name = "lstBooking";
            this.lstBooking.Size = new System.Drawing.Size(1084, 220);
            this.lstBooking.TabIndex = 22;
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
            // frmBookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 352);
            this.Controls.Add(this.lstBooking);
            this.Controls.Add(this.btnViewBookingDetails);
            this.Controls.Add(this.txtBookingIDNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmBookingHistory";
            this.Text = "frmBookingHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookingIDNumber;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnViewBookingDetails;
        internal System.Windows.Forms.ListView lstBooking;
        internal System.Windows.Forms.ColumnHeader colConfigNumb;
        internal System.Windows.Forms.ColumnHeader colStatus;
        internal System.Windows.Forms.ColumnHeader colName;
        internal System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colCheckOut;
    }
}