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
    public partial class frmEmployee : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";

        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {

            frmClient frmCliens = new frmClient();

            frmCliens.ShowDialog();
        }

        private void hotelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            BookingClass bookingClass = new BookingClass(connectString);

            if (double.TryParse(txtBookingIDNumber.Text, out double bookingIdNumber))
            {
                    bookingClass.SearchByBookingIDNumber(bookingIdNumber, lstBooking);
            }
            else
            {
                MessageBox.Show("Invalid Booking ID Number");
            }

        }

        private void btnBookingClientInformanation_Click(object sender, EventArgs e)
        {
            frmViewBooking frmView = new frmViewBooking();
            frmView.ShowDialog();
        }

        private void cobStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDataBase employee = new EmployeeDataBase(connectString);

            // Get the selected category from the combo box
            string selectedCategory = cobStatus.SelectedItem.ToString();

            employee.SearchBookingByStatus(selectedCategory, lstBooking);
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            frmEditBooking frmEdit = new frmEditBooking();
            frmEdit.ShowDialog();
        }

        private void btnCheckInClient_Click(object sender, EventArgs e)
        {
            EmployeeDataBase employeeDataBase = new EmployeeDataBase(connectString);

            if (double.TryParse(txtBookingIDNumber.Text, out double bookingIdNumber))
            {
                employeeDataBase.CheckIn(bookingIdNumber);
            }
            else
            {
                MessageBox.Show("Invalid Booking ID Number");
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            EmployeeDataBase employeeDataBase = new EmployeeDataBase(connectString);

            if (double.TryParse(txtBookingIDNumber.Text, out double bookingIdNumber))
            {
                employeeDataBase.CheckOut(bookingIdNumber);
            }
            else
            {
                MessageBox.Show("Invalid Booking ID Number");
            }

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            frmCancelBooking frmCancelBooking = new frmCancelBooking();
            frmCancelBooking.ShowDialog();
        }

        private void btnPromotionButton_Click(object sender, EventArgs e)
        {
            frmHotalDeals frmHotalAds = new frmHotalDeals();
            frmHotalAds.ShowDialog();
        }
    }
}
