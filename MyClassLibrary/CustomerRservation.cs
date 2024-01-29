using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class CustomerReservation
    {
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int numberOfAdults;
        private int numberOfChildrens;
        private string reservationNotes;
        private string selectedRoomType;
        private double roomPrice;
        private double confirmationNumber;
        private Random random = new Random();


        public CustomerReservation()
        {

        }

        public CustomerReservation(DateTime checkInDate, DateTime checkOutDate, double bookingIDNumber, int numberOfAdults, int numberOfChildrens, string reservationNotes, string selectedRoomType)
        {
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.numberOfAdults = numberOfAdults;
            this.numberOfChildrens = numberOfChildrens;
            this.reservationNotes = reservationNotes;
            this.selectedRoomType = selectedRoomType;
        }
        public CustomerReservation(int numberOfAdults, int numberOfChildrens, string selectedRoomType,double roomPrice, double confirmationNumber)
        {

            this.numberOfAdults = numberOfAdults;
            this.numberOfChildrens = numberOfChildrens;
            this.selectedRoomType = selectedRoomType;
            this.roomPrice = roomPrice;
            this.confirmationNumber = confirmationNumber;
        }

        public double ConfirmationNumber
        {
            get { return confirmationNumber; }
            set { confirmationNumber = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        public double RoomTypePrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }
        public int NumberOfAdults
        {
            get { return numberOfAdults; }
            set { numberOfAdults = value; }
        }

        public int NumberOfChildrens
        {
            get { return numberOfChildrens; }
            set { numberOfChildrens = value; }
        }

        public string ReservationNotes
        {
            get { return reservationNotes; }
            set { reservationNotes = value; }
        }

        public string SelectedRoomType
        {
            get { return selectedRoomType; }
            set { selectedRoomType = value; }
        }


          public  double GenerateConfirmationNumber()
        {
            int randomNumber = random.Next(10000, 100000); // Generate a random 5-digit number
            return randomNumber;
        }
    }
}