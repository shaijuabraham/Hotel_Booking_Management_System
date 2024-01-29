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
    public partial class frmEditBooking : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";

        public frmEditBooking()
        {
            InitializeComponent();
        }

        private void grpbxPaymentInformation_Enter(object sender, EventArgs e)
        {

        }

        private void btnViewBookingDetails_Click(object sender, EventArgs e)
        {
            EditBookingClass employeeDataBase = new EditBookingClass(connectString);
            if (!string.IsNullOrWhiteSpace(txtBookingIDNumber.Text))
            {
                double Bookingid = double.Parse(txtBookingIDNumber.Text);

                employeeDataBase.EditBookingInformanation(Bookingid, lblBookingID, cobReservationStatus, lblCheckIn, lblCheckOut,
                    cobPayementStatus, txtFirstName, txtLastName, txtEmail, txtPhoneNumber,
              cobCardType, txtCardHolderName, txtCardNumber, txtCVV, txtExpericationDate);
            }
            else
                MessageBox.Show("Please Enter the Booking ID Number");


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoneEditing_Click(object sender, EventArgs e)
        {
            EditBookingClass employeeDataBase = new EditBookingClass(connectString);

            if (!string.IsNullOrWhiteSpace(txtBookingIDNumber.Text))
            {
                double confirmationNumber = double.Parse(lblBookingID.Text);
                string Reservationstatus = cobReservationStatus.SelectedItem.ToString();
                DateTime checkIn = DateTime.Parse(dtpCheckIn.Text);
                DateTime checkOut = DateTime.Parse(dtpCheckOut.Text);
                string paymentStatus = cobPayementStatus.SelectedItem.ToString();
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string gmail = txtEmail.Text;
                double phoneNumber = double.Parse(txtPhoneNumber.Text);
                string typeOfCard = cobCardType.SelectedItem.ToString();
                string nameOnTheCard = txtCardHolderName.Text;
                double cardNumber = double.Parse(txtCardNumber.Text);
                int cvv = int.Parse(txtCVV.Text);
                string expireDate = txtExpericationDate.Text;

                employeeDataBase.EditData(confirmationNumber, Reservationstatus, checkIn, checkOut, paymentStatus, firstName, lastName,
                gmail, phoneNumber, typeOfCard, nameOnTheCard, cardNumber, cvv, expireDate);
            }    

        }
    }
}
       