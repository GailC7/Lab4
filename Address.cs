using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Address
    {
        //properties
        public string StreetAddress { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string PostalCode { get; init; }

        //constructor
        public Address(string streetAddress, string city, string state, string postalCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        //ToString
        public override string ToString()
        {
            return this.StreetAddress + " | " + this.City 
                    + " | " + this.State + " | " + this.PostalCode;
        }
    }
}
