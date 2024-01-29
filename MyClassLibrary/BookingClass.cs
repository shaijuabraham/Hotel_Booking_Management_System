using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace MyClassLibrary
{
    public class BookingClass
    {
        private string connectString;


        public BookingClass(string connectionString)
        {
            connectString = connectionString;
        }

        public void ViewBookingInformanation(double Bookingid, Label ConfirmationNumber, Label Status, Label CheckIn, Label Checkout, Label PayementStstus, Label FullName, Label Gmail, Label PhoneNumber, 
            Label TypeofCard, Label NameontheCard, Label CardNumber, Label Cvv, Label Expiredate)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT ConfirmationNumber, Status, CheckIn, CheckOut, PaymentStatus, FirstName, " +
                                     $"LastName, Gmail, PhoneNumber, TypeOfCard, Nameonthecard, CardNumber, " +
                                     $"CvvNumber, ExpireDate FROM CustomerReservationTable WHERE ConfirmationNumber = {Bookingid}";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string ConfirmationNumberValue = reader["ConfirmationNumber"].ToString();
                                    string StatusValue = reader["Status"].ToString();
                                    string CheckInValue = reader["CheckIn"].ToString();
                                    string CheckOutValue = reader["CheckOut"].ToString();
                                    //string RoomTypeValue = reader["RoomType"].ToString();
                                    //string AdultValue = reader["Adult"].ToString();
                                    //string ChildrenValue = reader["Children"].ToString();
                                    string PaymentStatusValue = reader["PaymentStatus"].ToString();

                                    string FirstNameValue = reader["FirstName"].ToString();
                                    string LastNameValue = reader["LastName"].ToString();
                                    string FullNameValue = $"{FirstNameValue} {LastNameValue}";

                                    string GmailValue = reader["Gmail"].ToString();
                                    string PhoneNumberValue = reader["PhoneNumber"].ToString();
                                    string TypeOfCardValue = reader["TypeOfCard"].ToString();
                                    string NameOnTheCardValue = reader["Nameonthecard"].ToString();
                                    string CardNumberValue = reader["CardNumber"].ToString();
                                    string CVVNumberValue = reader["CvvNumber"].ToString();
                                    string ExpirationDateValue = reader["ExpireDate"].ToString();

                                    ConfirmationNumber.Text = "Conformanation # : " +  ConfirmationNumberValue;
                                    Status.Text = "Booking Status : " +  StatusValue;
                                    CheckIn.Text = "CheckIn : " + CheckInValue;
                                    Checkout.Text = "CheckOut : " + CheckOutValue;
                                    PayementStstus.Text = "Payement Status : " + PaymentStatusValue;
                                    FullName.Text = "Full Name : " + FullNameValue;
                                    Gmail.Text = "Gmail : " + GmailValue;
                                    PhoneNumber.Text = "PhoneNumber : " + PhoneNumberValue;
                                    TypeofCard.Text = "Payements Type : " + TypeOfCardValue;
                                    NameontheCard.Text = "Name On the Card : " + NameOnTheCardValue;
                                    CardNumber.Text = "Card Number : " +  CardNumberValue;
                                    Cvv.Text = "CVV : " + CVVNumberValue;
                                    Expiredate.Text = "Experiation Date : " + ExpirationDateValue;


                                }
                            }
                            else
                            {
                                // Display a message when no booking is found
                                MessageBox.Show("No Booking Found for the provided ID.");
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public void ViewReservedRoom(double Bookingid, ListBox listBox)
        {
            listBox.Items.Clear();
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT RoomCounter, Type, Adults, Children, Price FROM ClientRoomTable WHERE ConfirmationNumber = {Bookingid}";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string RoomCount = reader["RoomCounter"].ToString();
                                    string RoomTypeValue = reader["Type"].ToString();
                                    string AdultValue = reader["Adults"].ToString();
                                    string ChildrenValue = reader["Children"].ToString();
                                    string PriceValuse = reader["Price"].ToString();

                                    listBox.Items.Add( "Room : " + RoomCount);
                                    listBox.Items.Add(" Room Type : " +RoomTypeValue);
                                    listBox.Items.Add("Adults : " + AdultValue);
                                    listBox.Items.Add("Childrens : " + ChildrenValue);
                                    listBox.Items.Add("Room Price : $" +PriceValuse);

                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Search A Tiket 
        public void SearchByBookingIDNumber(double Bookingid, ListView datalist)
        {

            // Clear existing items in the ListView
            datalist.Items.Clear();
            datalist.Columns.Clear();

            // Add columns to the ListView
            datalist.Columns.Add("Booking Number", 160);
            datalist.Columns.Add("Status", 100);
            datalist.Columns.Add("Check-In", 200);
            datalist.Columns.Add("Check-Out", 200);
            datalist.Columns.Add("Name", 160);
            datalist.Columns.Add("Payement Status", 160);

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT ConfirmationNumber, Status, CheckIn, CheckOut, FirstName, LastName, PaymentStatus  FROM CustomerReservationTable WHERE ConfirmationNumber = {Bookingid}";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string ConfirmationNumber = reader["ConfirmationNumber"].ToString();
                                    string StatusValue = reader["Status"].ToString();
                                    string CheckInValue = reader["CheckIn"].ToString();
                                    string CheckOutValue = reader["CheckOut"].ToString();
                                    string FirstNameValue = reader["FirstName"].ToString();
                                    string LastNameValue = reader["LastName"].ToString();
                                    string FullNameValue = $"{FirstNameValue} {LastNameValue}";
                                    string PaymentStatusValue = reader["PaymentStatus"].ToString();


                                    // ListViewItem and add subitems
                                    ListViewItem listViewItem = new ListViewItem(ConfirmationNumber);
                                    listViewItem.SubItems.Add(StatusValue);
                                    listViewItem.SubItems.Add(CheckInValue);
                                    listViewItem.SubItems.Add(CheckOutValue);
                                    listViewItem.SubItems.Add(FullNameValue);
                                    listViewItem.SubItems.Add(PaymentStatusValue);


                                    // Add the ListViewItem to the ListView
                                    datalist.Items.Add(listViewItem);

                                }
                            }
                            else
                            {
                                // Display a message when no booking is found
                                MessageBox.Show("No Booking Found for the provided ID.");
                            }
                        }
                    

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Show the price based on the data

        public double SelectRoomTypePrice(string selectedCategory)
        {
            double price = 0.0; // Initialize the price to a default value

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT Price FROM HotalDataTable WHERE RoomType = '{selectedCategory}'";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Convert the value from the "Price" column to a double
                                price = Convert.ToDouble(reader["Price"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return price;
        }

        // Sent the roomtype list to the Comobobox and Show it in the Picture box

        public void SelectRoomType(string selectedCategory, PictureBox pictureBox)
        {

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT RoomImage FROM HotalDataTable WHERE RoomType = '{selectedCategory}'";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string RoomImage = reader["RoomImage"].ToString();

                                pictureBox.Load(RoomImage);
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        public void SearchBookingByPhoneNumber(double SelectedNumber, ListView listView)
        {
            // Clear existing items in the ListView
            listView.Items.Clear();
            listView.Columns.Clear();

            // Add columns to the ListView
            listView.Columns.Add("Booking Number", 160);
            listView.Columns.Add("Status", 100);
            listView.Columns.Add("Check-In", 200);
            listView.Columns.Add("Check-Out", 200);
            listView.Columns.Add("Name", 160);
            listView.Columns.Add("Payement Status", 160);


            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"SELECT ConfirmationNumber, Status, CheckIn, CheckOut, FirstName, LastName, PaymentStatus  FROM CustomerReservationTable WHERE PhoneNumber = {SelectedNumber}";
                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                        using (OleDbDataReader reader = myCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string ConfirmationNumber = reader["ConfirmationNumber"].ToString();
                                    string StatusValue = reader["Status"].ToString();
                                    string CheckInValue = reader["CheckIn"].ToString();
                                    string CheckOutValue = reader["CheckOut"].ToString();
                                    string FirstNameValue = reader["FirstName"].ToString();
                                    string LastNameValue = reader["LastName"].ToString();
                                    string FullNameValue = $"{FirstNameValue} {LastNameValue}";
                                    string PaymentStatusValue = reader["PaymentStatus"].ToString();


                                    // ListViewItem and add subitems
                                    ListViewItem listViewItem = new ListViewItem(ConfirmationNumber);
                                    listViewItem.SubItems.Add(StatusValue);
                                    listViewItem.SubItems.Add(CheckInValue);
                                    listViewItem.SubItems.Add(CheckOutValue);
                                    listViewItem.SubItems.Add(FullNameValue);
                                    listViewItem.SubItems.Add(PaymentStatusValue);


                                    // Add the ListViewItem to the ListView
                                    listView.Items.Add(listViewItem);

                                }
                            }
                            else
                            {
                                // Display message when no booking is found
                                MessageBox.Show("No Booking Found for the provided ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


    }
}
