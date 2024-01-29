
namespace Hotel_Booking_Management_System
{
    partial class frmHotalDeals
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
            this.picAdd1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd1)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdd1
            // 
            this.picAdd1.Image = global::Hotel_Booking_Management_System.Properties.Resources.top_1544707638;
            this.picAdd1.Location = new System.Drawing.Point(0, 0);
            this.picAdd1.Name = "picAdd1";
            this.picAdd1.Size = new System.Drawing.Size(806, 289);
            this.picAdd1.TabIndex = 0;
            this.picAdd1.TabStop = false;
            // 
            // frmHotalDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 289);
            this.Controls.Add(this.picAdd1);
            this.Name = "frmHotalDeals";
            this.Text = "Today\'s Deals";
            ((System.ComponentModel.ISupportInitialize)(this.picAdd1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdd1;
    }
}