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
    public partial class frmCancelBooking : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";
        EmployeeDataBase employeeData;
        public frmCancelBooking()
        {
            InitializeComponent();
        }
        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            employeeData = new EmployeeDataBase(connectString);  
            employeeData.CancelBookingView(lstBooking);

        }

        private void btnViewBookingDetails_Click(object sender, EventArgs e)
        {
            employeeData = new EmployeeDataBase(connectString);
            double ConfirmationNumber = double.Parse(txtBookingIDNumber.Text);
            string Name = txtName.Text;
            string Reason = cobCancelReason.SelectedItem.ToString();
            employeeData.CancelBooking(ConfirmationNumber, Name, Reason);
            employeeData.CancelBookingView(lstBooking);

        }
    }
}
