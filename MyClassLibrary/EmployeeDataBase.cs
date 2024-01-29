using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class EmployeeDataBase
    {
        private string connectString;
        public EmployeeDataBase(string connectionString)
        {
            connectString = connectionString;
        }
        // Add the Client reservation to the data base
        public void InsertData(string RoomType, int Adult, int Children, string Price, int RoomCounter, double ConfirmanationNumber)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = "INSERT INTO ClientRoomTable (Type, Adults, Children, Price, RoomCounter, ConfirmationNumber) " +
                                    "VALUES (@Type, @Adults, @Children, @Price, @RoomCounter, @ConfirmationNumber)";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                       // Use parameters to avoid SQL injection
                        myCommand.Parameters.AddWithValue("@Type", RoomType);
                        myCommand.Parameters.AddWithValue("@Adults", Adult);
                        myCommand.Parameters.AddWithValue("@Children", Children);
                        myCommand.Parameters.AddWithValue("@Price", Price);
                        myCommand.Parameters.AddWithValue("@RoomCounter", RoomCounter);
                        myCommand.Parameters.AddWithValue("@ConfirmationNumber", ConfirmanationNumber);

                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    } 
                }
            }
        }

        public void InsertCustomerData(double ConfirmationNumber, string BookingStatus, string CheckIn, string Checkout, string FirstName, string LastName,
            string Gmail, double PhoneNumber, string TypeofCard, string NameontheCard, double CardNumber, int Cvv, string Expiredate, string PayementStatus, string SpecialRequest)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = "INSERT INTO CustomerReservationTable (ConfirmationNumber, Status, CheckIn, CheckOut, FirstName, LastName, Gmail, PhoneNumber, TypeOfCard, Nameonthecard, CardNumber, CvvNumber, ExpireDate, PaymentStatus, SpecialRequest)" +
                  " VALUES (@ConfirmationNumber, @Status, @CheckIn, @CheckOut, @FirstName, @LastName, @Gmail, @PhoneNumber, @TypeOfCard, @Nameonthecard, @CardNumber, @CvvNumber, @ExpireDate, @PaymentStatus, @SpecialRequest)";


                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();

                       // Use parameters to avoid SQL injection
                        myCommand.Parameters.AddWithValue("@ConfirmationNumber", ConfirmationNumber);
                        myCommand.Parameters.AddWithValue("@Status", BookingStatus);
                        myCommand.Parameters.AddWithValue("@CheckIn", CheckIn);
                        myCommand.Parameters.AddWithValue("@CheckOut", Checkout);
                        myCommand.Parameters.AddWithValue("@FirstName", FirstName);
                        myCommand.Parameters.AddWithValue("@LastName", LastName);
                        myCommand.Parameters.AddWithValue("@Gmail", Gmail);
                        myCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        myCommand.Parameters.AddWithValue("@TypeOfCard", TypeofCard);
                        myCommand.Parameters.AddWithValue("@Nameonthecard", NameontheCard);
                        myCommand.Parameters.AddWithValue("@CardNumber", CardNumber);
                        myCommand.Parameters.AddWithValue("@CvvNumber", Cvv);
                        myCommand.Parameters.AddWithValue("@ExpireDate", Expiredate);
                        myCommand.Parameters.AddWithValue("@PaymentStatus", PayementStatus);
                        myCommand.Parameters.AddWithValue("@SpecialRequest", SpecialRequest);

                        myCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        //..........................................................................................
        public void SearchBookingByStatus(string SelectedCategory, ListView listView)
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
                string queryString = $"SELECT ConfirmationNumber, Status, CheckIn, CheckOut, FirstName, LastName, PaymentStatus FROM CustomerReservationTable WHERE Status = '{SelectedCategory}'";
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

        public void CheckIn(double ConfirmationNumber)
        {
            string PaymentStatus = "Full Paid";
            string Status = "CheckedIn";
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"UPDATE CustomerReservationTable SET " +
                                    $"PaymentStatus = '{PaymentStatus}', " +
                                    $"Status = '{Status}' " +
                                    $"WHERE ConfirmationNumber = {ConfirmationNumber}";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(" CheckIn has been Made successfully \n PLESE REFERESH THE PAGE TO SEE THE CHANGES");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public void CheckOut(double ConfirmationNumber)
        {
            string PaymentStatus = "No Balance Due";
            string Status = "CheckedOut";
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"UPDATE CustomerReservationTable SET " +
                                    $"PaymentStatus = '{PaymentStatus}', " +
                                    $"Status = '{Status}' " +
                                    $"WHERE ConfirmationNumber = {ConfirmationNumber}";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show(" CheckOut has been Made successfully \n PLESE REFERESH THE PAGE TO SEE THE CHANGES");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void CancelBooking(double ConfirmationNumber, string Name, string Reason)
        {

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString0 = $"INSERT INTO CancelledBookingTable (ConfirmationNumber, CancalledBy, Reason) " +
                                      $"VALUES ({ConfirmationNumber}, '{Name}', '{Reason}')";

                string queryString1 = $"DELETE FROM CustomerReservationTable WHERE ConfirmationNumber = {ConfirmationNumber}";
                string queryString2 = $"DELETE FROM ClientRoomTable WHERE ConfirmationNumber = {ConfirmationNumber}";


                try
                {
                    myConnection.Open();

                    using (OleDbCommand myCommand0 = new OleDbCommand(queryString0, myConnection))
                    {
                        myCommand0.ExecuteNonQuery();
                    }

                    using (OleDbCommand myCommand1 = new OleDbCommand(queryString1, myConnection))
                    {
                        myCommand1.ExecuteNonQuery();
                    }

                    using (OleDbCommand myCommand2 = new OleDbCommand(queryString2, myConnection))
                    {
                        myCommand2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Booking Canceled successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void CancelBookingView(ListView listView)
        {
            // Clear existing items in the ListView
            listView.Items.Clear();
            listView.Columns.Clear();

            // Add columns to the ListView
            listView.Columns.Add("Booking Number", 160);
            listView.Columns.Add("Cancelled By", 100);
            listView.Columns.Add("Reason", 200);

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
               
                string queryString3 = $"SELECT ConfirmationNumber, CancalledBy, Reason FROM CancelledBookingTable";


                try
                {
                    myConnection.Open();

                    // Execute the SELECT statement to retrieve the updated data
                    using (OleDbCommand myCommand3 = new OleDbCommand(queryString3, myConnection))
                    using (OleDbDataReader reader = myCommand3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ConfirmationNumberValue = reader["ConfirmationNumber"].ToString();
                            string CancelledByValue = reader["CancalledBy"].ToString();
                            string ReasonValue = reader["Reason"].ToString();

                            // Create a ListViewItem and add subitems
                            ListViewItem listViewItem = new ListViewItem(ConfirmationNumberValue);
                            listViewItem.SubItems.Add(CancelledByValue);
                            listViewItem.SubItems.Add(ReasonValue);

                            // Add the ListViewItem to the ListView
                            listView.Items.Add(listViewItem);
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
