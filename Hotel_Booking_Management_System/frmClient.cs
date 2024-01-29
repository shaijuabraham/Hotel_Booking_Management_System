using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace Hotel_Booking_Management_System
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumberOfTravelers_Click(object sender, EventArgs e)
        {
            frmTravelersRoomSelector frmTravelersRoom = new frmTravelersRoomSelector();
            // Assign DateTime values directly, not as strings
            frmTravelersRoom.dtpCheckin.Value = dtpCheckin.Value;
            frmTravelersRoom.dtpCheckOut.Value = dtpCheckOut.Value;
            this.Hide();  // Hide the form after all room selections are made
            frmTravelersRoom.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnSeeAllAmmenities_Click(object sender, EventArgs e)
        {
            frmPopularamenities frmPopularamenities = new frmPopularamenities();
            frmPopularamenities.ShowDialog();   
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogInPage frmLogInPage = new frmLogInPage();
            frmLogInPage.Show();
            this.Close();
        }

        private void btnPreviousBooking_Click(object sender, EventArgs e)
        {
            frmBookingHistory frmBooking = new frmBookingHistory();
            frmBooking.Show();
        }
    }
}
