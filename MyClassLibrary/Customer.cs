using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Customer
    {
        private string customerFirstName;
        private string customerLastName;
        private string customerStreetAddress;
        private string customerCityName;
        private string customerStateName;
        private double customerZipCode;
        private double customerPhoneNumber;


        public Customer(string customerFirstName, string customerLastName, string customerStreetAddress, string customerCityName, string customerStateName, double customerZipCode, double customerPhoneNumber)
        {
            customerFirstName = this.customerFirstName;
            customerLastName = this.customerLastName;
            customerStreetAddress = this.customerStreetAddress;
            customerCityName = this.customerCityName;
            customerStateName = this.customerStateName;
            customerZipCode = this.customerZipCode;
            customerPhoneNumber = this.customerPhoneNumber;

        }

        public string CustomerFirstName
        {
            get { return customerFirstName; }
            set { customerFirstName = value; }
        }

        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }

        public string CustomerStreetAddress
        {
            get { return customerStreetAddress; }
            set { customerStreetAddress = value; }
        }

        public string CustomerCityName
        {
            get { return customerCityName; }
            set { customerCityName = value; }
        }

        public string CustomerStateName
        {
            get { return customerStateName; }
            set { customerStateName = value; }
        }

        public double CustomerZipCode
        {
            get { return customerZipCode; }
            set
            {
                if (value > 0)
                {
                    customerZipCode = value;
                }
                else
                {
                    // throw an exception or handle it in another way
                    throw new ArgumentException("Plese Enter a Vaild Zip Code.");
                }
            }
        }

        public double CustomerPhoneNumber
        {
            get { return customerPhoneNumber; }
            set
            {
                if (value > 0)
                {
                    customerPhoneNumber = value;
                }
                else
                {
                    // throw an exception or handle it in another way
                    throw new ArgumentException("Plese Enter a Vaild Phone Number.");
                }
            }
        }






    }



}