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
    public class EditBookingClass
    {
        private string connectString;
        public EditBookingClass(string connectionString)
        {
            connectString = connectionString;
        }

        public void EditBookingInformanation(double Bookingid, Label ConfirmationNumber, ComboBox ReservationStatus, Label CheckIn, Label Checkout, ComboBox PaymentStatus,
           TextBox FirstName, TextBox LastName, TextBox Gmail, TextBox PhoneNumber,
          ComboBox TypeofCard, TextBox NameontheCard, TextBox CardNumber, TextBox Cvv, TextBox Expiredate)
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
                                    string PaymentStatusValue = reader["PaymentStatus"].ToString();
                                    string FirstNameValue = reader["FirstName"].ToString();
                                    string LastNameValue = reader["LastName"].ToString();

                                    string GmailValue = reader["Gmail"].ToString();
                                    string PhoneNumberValue = reader["PhoneNumber"].ToString();
                                    string TypeOfCardValue = reader["TypeOfCard"].ToString();
                                    string NameOnTheCardValue = reader["Nameonthecard"].ToString();
                                    string CardNumberValue = reader["CardNumber"].ToString();
                                    string CVVNumberValue = reader["CvvNumber"].ToString();
                                    string ExpirationDateValue = reader["ExpireDate"].ToString();

                                    ReservationStatus.Text = StatusValue;
                                    PaymentStatus.SelectedItem = PaymentStatusValue;

                                    ConfirmationNumber.Text =ConfirmationNumberValue;
                                    CheckIn.Text = CheckInValue;
                                    Checkout.Text = CheckOutValue;
                                    FirstName.Text = FirstNameValue;
                                    LastName.Text = LastNameValue;
                                    Gmail.Text = GmailValue;
                                    PhoneNumber.Text = PhoneNumberValue;
                                    TypeofCard.SelectedItem =  TypeOfCardValue;
                                    NameontheCard.Text = NameOnTheCardValue;
                                    CardNumber.Text = CardNumberValue;
                                    Cvv.Text = CVVNumberValue;
                                    Expiredate.Text = ExpirationDateValue;

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
        public void EditData(double ConfirmationNumber, string Status, DateTime CheckIn, DateTime Checkout, string PayementStstus, string FirstName, string LastName,
        string Gmail, double PhoneNumber, string TypeofCard, string NameontheCard, double CardNumber, int Cvv, string Expiredate)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                string queryString = $"UPDATE CustomerReservationTable SET " +
                                      $"ConfirmationNumber = '{ConfirmationNumber}', " +
                                      $"Status = '{Status}', " +
                                      $"CheckIn = '{CheckIn}', " +
                                      $"CheckOut = '{Checkout}', " +
                                      $"PaymentStatus = '{PayementStstus}', " +
                                      $"FirstName = '{FirstName}', " +
                                      $"LastName = '{LastName}', " +
                                      $"Gmail = '{Gmail}', " +
                                      $"PhoneNumber = '{PhoneNumber}', " +
                                      $"TypeOfCard = '{TypeofCard}', " +
                                      $"Nameonthecard = '{NameontheCard}', " +
                                      $"CardNumber = '{CardNumber}', " +
                                      $"CvvNumber = '{Cvv}', " +
                                      $"ExpireDate = '{Expiredate}' " +
                                      $"WHERE ConfirmationNumber = {ConfirmationNumber}";

                using (OleDbCommand myCommand = new OleDbCommand(queryString, myConnection))
                {
                    try
                    {
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Chnages has been Made successfully \n PLESE REFERESH THE PAGE TO SEE THE CHANGES");
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
