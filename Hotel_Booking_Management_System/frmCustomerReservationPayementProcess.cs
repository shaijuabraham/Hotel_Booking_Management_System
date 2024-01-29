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
    public partial class frmCustomerReservationPayementProcess : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";
        public frmCustomerReservationPayementProcess()
        {
            InitializeComponent();
           // this.reservations = reservations;
        }


        private void frmCustomerReservationPayementProcess_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompleteBooking_Click_1(object sender, EventArgs e)
        {

            EmployeeDataBase employeeData = new EmployeeDataBase(connectString);
            frmCustomerReservationPayementProcess frmCustomerReservationPayement = new frmCustomerReservationPayementProcess();
            double bookingNumber = double.Parse(lblShowBookingNumber.Text);
            // Boooking..........................................
            string Bookingstatus; ;
            string PayementStatus;
            try
            {
                string checkin = lblCheckIn.Text;
                string checkout = lblCheckOut.Text;
                //Customer infromanation............................
                string FirstName = txtFirstName.Text;
                string LastName = txtFirstName.Text;
                string Gmail = txtEmail.Text;
                double PhoneNumber = double.Parse(txtPhoneNumber.Text);
                // Payements Informanation...........................
                string TypeOfCard = cobPayementType.SelectedItem.ToString();
                string ExpMonth = cobExpMonth.SelectedItem.ToString();
                string ExpeYear = cobExpYear.SelectedItem.ToString();

                string Nameonthecard = txtCardName.Text;
                double CardNumber = double.Parse(txtCardNumber.Text);
                int CvvNumber = int.Parse(txtCvv.Text);
                string ExpMonandYear = ExpMonth + "/" + ExpeYear;

                string SpecialReq = rtbSpecialRequest.Text;


                if (rdbDeposite.Checked)
                {
                    PayementStatus = "Deposite";
                    Bookingstatus = "Pending";
                    employeeData.InsertCustomerData(bookingNumber, Bookingstatus, checkin, checkout, FirstName, LastName,
                    Gmail, PhoneNumber, TypeOfCard, Nameonthecard, CardNumber, CvvNumber, ExpMonandYear, PayementStatus, SpecialReq);

                }
                else if (rdbFullPayement.Checked)
                {
                    PayementStatus = "Full Paid";
                    Bookingstatus = "Confirmed";

                    employeeData.InsertCustomerData(bookingNumber, Bookingstatus, checkin, checkout, FirstName, LastName,
                    Gmail, PhoneNumber, TypeOfCard, Nameonthecard, CardNumber, CvvNumber, ExpMonandYear, PayementStatus, SpecialReq);
                }
                frmCompteBooking frmCompte = new frmCompteBooking(bookingNumber);
                frmCompte.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}
