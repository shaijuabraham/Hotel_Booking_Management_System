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
    public partial class frmBookingHistory : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";
        public frmBookingHistory()
        {
            InitializeComponent();
        }

        private void btnViewBookingDetails_Click(object sender, EventArgs e)
        {
            BookingClass bookingClass = new BookingClass(connectString);
            double phoneNumber = double.Parse(txtBookingIDNumber.Text);
            bookingClass.SearchBookingByPhoneNumber(phoneNumber, lstBooking);

        }
    }
}
