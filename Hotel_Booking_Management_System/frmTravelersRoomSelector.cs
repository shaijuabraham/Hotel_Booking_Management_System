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
    public partial class frmTravelersRoomSelector : Form
    {
        string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../HotalDataBase.accdb;";
        private List<CustomerReservation> reservations = new List<CustomerReservation>();
        // Declared a variable to store the last used confirmation number
        public double lastConfirmationNumber = 0;

        public frmTravelersRoomSelector()
        {
            InitializeComponent();
        }
        private void frmTravelersRoomSelector_Load(object sender, EventArgs e)
        {

        }


        private void cobRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookingClass bookingClass = new BookingClass(connectString);
            string selectedCategory = cobRoomType.SelectedItem.ToString();
            bookingClass.SelectRoomType(selectedCategory, pibRoomType); 
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            frmCustomerReservationPayementProcess frmCustomerReservationPayement = new frmCustomerReservationPayementProcess();
            BookingClass bookingClass = new BookingClass(connectString);
            EmployeeDataBase employeeData = new EmployeeDataBase(connectString);
            CustomerReservation customerReservation1 = new CustomerReservation();

            DateTime checkin = dtpCheckin.Value;
            DateTime checkout = dtpCheckOut.Value;

            // Calculate the time span between the two dates
            TimeSpan difference = checkout - checkin;

            // Get the difference in days
            int daysDifference = difference.Days;

            int adults = (int)npdAdult.Value;

            if (cobRoomType.SelectedItem != null)
            {
                // Retrieve values from frmClient form
                string roomType = cobRoomType.SelectedItem.ToString();
                    if (roomType == null)
                    {
                        MessageBox.Show("Please select your room.");
                    }
                    if (adults == 0)
                    {
                        MessageBox.Show("To book a room, you must be 18 years old or older and specify the number of adults");

                    }
                else
                {
                    int children = (int)npdChildren.Value;
                    double confirmationNumber;

                    if (lastConfirmationNumber == 0)
                    {
                        // Generate a new confirmation number if it's the first click
                        confirmationNumber = customerReservation1.GenerateConfirmationNumber();
                        lastConfirmationNumber = confirmationNumber; // Store the generated number
                    }
                    else
                    {
                        // Reuse the stored confirmation number for subsequent clicks
                        confirmationNumber = lastConfirmationNumber;
                    }
                    // Set properties of the CustomerReservation object
                    CustomerReservation customerReservation = new CustomerReservation
                    {
                        CheckInDate = checkin,
                        CheckOutDate = checkout,
                        SelectedRoomType = roomType,
                        NumberOfAdults = adults,
                        NumberOfChildrens = children,
                        RoomTypePrice = bookingClass.SelectRoomTypePrice(roomType),
                        ConfirmationNumber = confirmationNumber

                    };

                    // Add the current reservation to the reservations collection
                    reservations.Add(customerReservation);

                    // Display reservation details in the frmCustomerReservationPayementProcess form
                    frmCustomerReservationPayement.lblCheckIn.Text = $"{checkin}";
                    frmCustomerReservationPayement.lblCheckOut.Text = $"{checkout}";



                    int roomCounter = 1; // Counter for room numbers
                    double totalRoomPrice = 0;
                    foreach (CustomerReservation reservation in reservations)
                    {
                        employeeData.InsertData(reservation.SelectedRoomType, reservation.NumberOfAdults,
                                     reservation.NumberOfChildrens, reservation.RoomTypePrice.ToString(), int.Parse(roomCounter.ToString()), reservation.ConfirmationNumber);

                        // frmCustomerReservationPayement.lblShowBookingNumber.Text = 
                        frmCustomerReservationPayement.libReservationList.Items.Add($"Room {roomCounter}");
                        frmCustomerReservationPayement.libReservationList.Items.Add($"Type: {reservation.SelectedRoomType}");
                        frmCustomerReservationPayement.libReservationList.Items.Add($"Adults: {reservation.NumberOfAdults}");
                        frmCustomerReservationPayement.libReservationList.Items.Add($"Children: {reservation.NumberOfChildrens}");
                        frmCustomerReservationPayement.libReservationList.Items.Add($"Price: {reservation.RoomTypePrice}");
                        frmCustomerReservationPayement.libReservationList.Items.Add("");
                        totalRoomPrice += reservation.RoomTypePrice;
                        roomCounter++; // Increment room counter for the next iteration
                    }
                    // Calculate the total price after applying a 10% tax
                    double totalWithTax = totalRoomPrice * 1.10; // 10% tax is added
                   // Calculate the total price after applying a 10% tax
                    double totalTax = totalWithTax - totalRoomPrice; // 10% tax is added

                    frmCustomerReservationPayement.lblShowBookingNumber.Text = $"{confirmationNumber}";
                    // Display the total room price in the libTotal control
                    frmCustomerReservationPayement.libTotal.Items.Clear();
                    frmCustomerReservationPayement.libTotal.Items.Add($"Total Room Price: ${totalRoomPrice}");
                    frmCustomerReservationPayement.libTotal.Items.Add($"10% Tax: ${totalTax}");
                    frmCustomerReservationPayement.libTotal.Items.Add($"Total Amount: ${totalWithTax * daysDifference } For {daysDifference} Days ");



                    frmCustomerReservationPayement.Show();
                    this.Hide();  // Hide the form after all room selections are made
                }
            }
        }

        private void btnAddanotherRoom_Click(object sender, EventArgs e)
        {
            frmCustomerReservationPayementProcess frmCustomerReservationPayement = new frmCustomerReservationPayementProcess();
            BookingClass bookingClass = new BookingClass(connectString);
            CustomerReservation customerReservation = new CustomerReservation();    


            if (cobRoomType.SelectedItem != null)
            {
                string roomType = cobRoomType.SelectedItem.ToString();
                if (roomType == null)
                {
                    MessageBox.Show("Please select your room.");
                }
                int adults = (int)npdAdult.Value;
                if (adults == 0)
                {
                    MessageBox.Show("To book a room, you must be 18 years old or older and specify the number of adults");
                }
                int children = (int)npdChildren.Value;
                double confirmationNumber;

                if (lastConfirmationNumber == 0)
                {
                    // Generate a new confirmation number if it's the first click
                    confirmationNumber = customerReservation.GenerateConfirmationNumber();
                    lastConfirmationNumber = confirmationNumber; // Store the generated number
                }
                else
                {
                    // Reuse the stored confirmation number for subsequent clicks
                    confirmationNumber = lastConfirmationNumber;
                }

                CustomerReservation newReservation = new CustomerReservation
                {
                    SelectedRoomType = roomType,
                    NumberOfAdults = adults,
                    NumberOfChildrens = children,
                    RoomTypePrice = bookingClass.SelectRoomTypePrice(roomType),
                    ConfirmationNumber = confirmationNumber

                };

                reservations.Add(newReservation);

                cobRoomType.SelectedItem = "";
                npdAdult.Value = 0;
                npdChildren.Value = 0;
            }
        }
    }
}
