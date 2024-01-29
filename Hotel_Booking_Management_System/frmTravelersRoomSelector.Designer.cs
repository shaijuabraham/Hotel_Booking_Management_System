
namespace Hotel_Booking_Management_System
{
    partial class frmTravelersRoomSelector
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
            this.lblRoomNumberCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.npdAdult = new System.Windows.Forms.NumericUpDown();
            this.npdChildren = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cobRoomType = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.pibRoomType = new System.Windows.Forms.PictureBox();
            this.btnAddanotherRoom = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.npdAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdChildren)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibRoomType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomNumberCount
            // 
            this.lblRoomNumberCount.AutoSize = true;
            this.lblRoomNumberCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumberCount.Location = new System.Drawing.Point(22, 25);
            this.lblRoomNumberCount.Name = "lblRoomNumberCount";
            this.lblRoomNumberCount.Size = new System.Drawing.Size(92, 17);
            this.lblRoomNumberCount.TabIndex = 0;
            this.lblRoomNumberCount.Text = "Room No. 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Adults";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Children\r\n        (Age 0-17)";
            // 
            // npdAdult
            // 
            this.npdAdult.Location = new System.Drawing.Point(210, 124);
            this.npdAdult.Name = "npdAdult";
            this.npdAdult.Size = new System.Drawing.Size(113, 20);
            this.npdAdult.TabIndex = 5;
            // 
            // npdChildren
            // 
            this.npdChildren.Location = new System.Drawing.Point(210, 178);
            this.npdChildren.Name = "npdChildren";
            this.npdChildren.Size = new System.Drawing.Size(113, 20);
            this.npdChildren.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobRoomType);
            this.groupBox1.Controls.Add(this.npdChildren);
            this.groupBox1.Controls.Add(this.npdAdult);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblRoomNumberCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 227);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type of Room";
            // 
            // cobRoomType
            // 
            this.cobRoomType.FormattingEnabled = true;
            this.cobRoomType.Items.AddRange(new object[] {
            "Deluxe Room, 1 King Bed City View",
            "Deluxe Room, 2 Queen Beds City View",
            "Suite, 1 King Bed",
            "Deluxe Room, 2 Queen Beds"});
            this.cobRoomType.Location = new System.Drawing.Point(135, 64);
            this.cobRoomType.Name = "cobRoomType";
            this.cobRoomType.Size = new System.Drawing.Size(246, 21);
            this.cobRoomType.TabIndex = 8;
            this.cobRoomType.SelectedIndexChanged += new System.EventHandler(this.cobRoomType_SelectedIndexChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(12, 407);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(387, 44);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pibRoomType
            // 
            this.pibRoomType.Location = new System.Drawing.Point(406, 99);
            this.pibRoomType.Name = "pibRoomType";
            this.pibRoomType.Size = new System.Drawing.Size(352, 355);
            this.pibRoomType.TabIndex = 11;
            this.pibRoomType.TabStop = false;
            // 
            // btnAddanotherRoom
            // 
            this.btnAddanotherRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddanotherRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddanotherRoom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddanotherRoom.Location = new System.Drawing.Point(207, 332);
            this.btnAddanotherRoom.Name = "btnAddanotherRoom";
            this.btnAddanotherRoom.Size = new System.Drawing.Size(192, 40);
            this.btnAddanotherRoom.TabIndex = 12;
            this.btnAddanotherRoom.Text = "Add another room";
            this.btnAddanotherRoom.UseVisualStyleBackColor = false;
            this.btnAddanotherRoom.Click += new System.EventHandler(this.btnAddanotherRoom_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(406, 54);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(262, 36);
            this.dtpCheckOut.TabIndex = 19;
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Location = new System.Drawing.Point(23, 56);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(312, 36);
            this.dtpCheckin.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Check-out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Check-in";
            // 
            // frmTravelersRoomSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 486);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddanotherRoom);
            this.Controls.Add(this.pibRoomType);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTravelersRoomSelector";
            this.Text = "Select Number of Travelers & Rooms";
            this.Load += new System.EventHandler(this.frmTravelersRoomSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npdAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdChildren)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibRoomType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblRoomNumberCount;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.NumericUpDown npdAdult;
        internal System.Windows.Forms.NumericUpDown npdChildren;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnDone;
        internal System.Windows.Forms.PictureBox pibRoomType;
        internal System.Windows.Forms.ComboBox cobRoomType;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnAddanotherRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtpCheckOut;
        public System.Windows.Forms.DateTimePicker dtpCheckin;
    }
}