using System;
using System.Xml.Linq;

namespace MMABooksBusinessClasses
{
    public class Customer
    {
        // there are several warnings in this file related to nullable properties and return values.
        // you can ignore them
        public Customer() { }

        public Customer(int id, string name, string address, string city, string state, string zipcode)
        {
            CustomerID = id;
            Name = name;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;
        }
        /*
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                if (value > 0)
                    customerID = value;
                else
                    throw new ArgumentOutOfRangeException("Customer ID must be a positive integer");
            }
        }
        */
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                if (value > 0)
                    customerID = value;
                else
                    throw new ArgumentOutOfRangeException("Customer ID must be a positive integer");
            }

        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Trim().Length > 0 && value.Length <= 100)
                    name = value;
                else
                    throw new ArgumentOutOfRangeException("Must be at least one characer, and no more than 100.");
            }


        }

        public string Address {
            get
            {
                return address;
            }

            set
            {
                if (value.Trim().Length > 0 && value.Length <= 100)
                    address = value;
                else
                    throw new ArgumentOutOfRangeException("Must be at least one characer, and no more than 100.");
            }
        }

        public string City {
            get
            {
                return city;
            }

            set
            {
                if (value.Trim().Length > 0 && value.Length <= 100)
                    city = value;
                else
                    throw new ArgumentOutOfRangeException("Must be at least one characer, and no more than 100.");
            }
        }

        public string State {
            get
            {
                return state;
            }

            set
            {
                if (value.Trim().Length > 0 && value.Length <= 35)
                    state = value;
                else
                    throw new ArgumentOutOfRangeException("Must be at least one characer, and no more than 35.");
            }
        }

        public string ZipCode {
            get
            {
                return zipcode;
            }

            set
            {
                if (value.Trim().Length > 0 && value.Length <= 11)
                    zipcode = value;
                else
                    throw new ArgumentOutOfRangeException("Must be at least one characer, and no more than 11.");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
    

