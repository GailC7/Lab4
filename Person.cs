using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //properties
    internal class Person : IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Address Address { get; init; }

        //constructor
        public Person(string fName, string lName, Address addy)
        {
            FirstName = fName;
            LastName = lName;
            Address = addy;

        }

        //ToSTring
        public override string ToString()
        {
            return 
        }

    }




}
