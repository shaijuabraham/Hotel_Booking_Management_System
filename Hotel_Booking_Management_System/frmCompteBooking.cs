using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking_Management_System
{
    public partial class frmCompteBooking : Form
    {
        private double ConfirmanationNumber;

        public frmCompteBooking(double value)
        {
            InitializeComponent();
            ConfirmanationNumber = value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClient frmClient = new frmClient();
            frmClient.Show();
        }

        private void frmCompteBooking_Load(object sender, EventArgs e)
        {

           lblShowBookingNumber.Text = "Thank you for choosing Hiltion && Canrad! Your reservation is confirmed!\n" +
                                        "     We look forward to providing you with a wonderful stay.\n" +
                                        "If you have any special requests or need further assistance, feel free to contact us.\n" +
                                        "                     Safe travels and see you soon!\n"
                                       +"Your Confirmanation Number is :" + ConfirmanationNumber.ToString();

        }

        private void lblShowBookingNumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
