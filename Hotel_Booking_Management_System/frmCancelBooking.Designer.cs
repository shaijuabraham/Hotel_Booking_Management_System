
namespace Hotel_Booking_Management_System
{
    partial class frmCancelBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingIDNumber = new System.Windows.Forms.TextBox();
            this.btnViewBookingDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobCancelReason = new System.Windows.Forms.ComboBox();
            this.lstBooking = new System.Windows.Forms.ListView();
            this.colConfigNumb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Booking Confirmation Number :";
            // 
            // txtBookingIDNumber
            // 
            this.txtBookingIDNumber.Location = new System.Drawing.Point(300, 27);
            this.txtBookingIDNumber.Name = "txtBookingIDNumber";
            this.txtBookingIDNumber.Size = new System.Drawing.Size(191, 20);
            this.txtBookingIDNumber.TabIndex = 17;
            // 
            // btnViewBookingDetails
            // 
            this.btnViewBookingDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnViewBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookingDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewBookingDetails.Location = new System.Drawing.Point(160, 139);
            this.btnViewBookingDetails.Name = "btnViewBookingDetails";
            this.btnViewBookingDetails.Size = new System.Drawing.Size(192, 43);
            this.btnViewBookingDetails.TabIndex = 16;
            this.btnViewBookingDetails.Text = "Cancel Booking";
            this.btnViewBookingDetails.UseVisualStyleBackColor = false;
            this.btnViewBookingDetails.Click += new System.EventHandler(this.btnViewBookingDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cobCancelReason);
            this.groupBox1.Controls.Add(this.txtBookingIDNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnViewBookingDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 197);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Booking";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Reservation Cancelled by : ";
            // 
            // cobCancelReason
            // 
            this.cobCancelReason.FormattingEnabled = true;
            this.cobCancelReason.Items.AddRange(new object[] {
            "Change of plans",
            "Emergency situations",
            "Health issues",
            "Travel restrictions",
            "Financial constraints",
            "Accommodation issues",
            "Work commitments",
            "Weather conditions",
            "Family matters",
            "Transportation issues",
            "Double booking",
            "Policy changes",
            "Unsatisfactory services",
            "Personal reasons",
            "COVID-19 concerns"});
            this.cobCancelReason.Location = new System.Drawing.Point(6, 100);
            this.cobCancelReason.Name = "cobCancelReason";
            this.cobCancelReason.Size = new System.Drawing.Size(548, 21);
            this.cobCancelReason.TabIndex = 19;
            this.cobCancelReason.Text = "Reason for Cancel Reservation";
            // 
            // lstBooking
            // 
            this.lstBooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colConfigNumb,
            this.colName,
            this.colReason});
            this.lstBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooking.FullRowSelect = true;
            this.lstBooking.GridLines = true;
            this.lstBooking.HideSelection = false;
            this.lstBooking.Location = new System.Drawing.Point(12, 215);
            this.lstBooking.MultiSelect = false;
            this.lstBooking.Name = "lstBooking";
            this.lstBooking.Size = new System.Drawing.Size(560, 177);
            this.lstBooking.TabIndex = 20;
            this.lstBooking.UseCompatibleStateImageBehavior = false;
            this.lstBooking.View = System.Windows.Forms.View.Details;
            // 
            // colConfigNumb
            // 
            this.colConfigNumb.Text = "Booking ID Number";
            this.colConfigNumb.Width = 130;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 146;
            // 
            // colReason
            // 
            this.colReason.Text = "Reason";
            this.colReason.Width = 377;
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 399);
            this.Controls.Add(this.lstBooking);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCancelBooking";
            this.Text = "frmCancelBooking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingIDNumber;
        internal System.Windows.Forms.Button btnViewBookingDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobCancelReason;
        private System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ListView lstBooking;
        internal System.Windows.Forms.ColumnHeader colConfigNumb;
        internal System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colReason;
    }
}