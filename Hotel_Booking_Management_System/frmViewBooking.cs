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
    public partial class frmViewBooking : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";

        public frmViewBooking()
        {
            InitializeComponent();
        }

        private void btnViewBookingDetails_Click(object sender, EventArgs e)
        {
            BookingClass bookingClass = new BookingClass(connectString);


            // Check if the BookingID is a valid number
            if (!double.TryParse(txtBookingIDNumber.Text, out double Bookingid))
            {
                MessageBox.Show("Invalid Booking ID.");
                return; // Exit the method if the BookingID is not valid
            }

            bookingClass.ViewBookingInformanation(Bookingid, lblBookingID, lblStatus, 
                lblCheckIn, lblCheckOut, lblPayementStatus, lblCustomerFullName, lblCustomerEmail, lblPhoneNumber,
            lblPayemntType, lblNameOnCard, lblCardNumber, lblCradCVVNumber, lblExpirationDate);

            bookingClass.ViewReservedRoom(Bookingid, libRoomInformation);
        }

        private void lblExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void frmViewBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
