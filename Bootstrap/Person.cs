using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap
{
    public class Person
    {
            private string ID;
            private string firstName;
            private string lastName;
            private string SSN;

            public string id
            {
                get { return this.ID; }
            }
            public string fName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string lName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public string ssn
            {
                get { return SSN; }
                set { SSN = value; }
            }

            public Person(string ID, string firstName, string lastName, string SSN)
            {
                this.ID = ID;
                this.fName = firstName;
                this.lName = lastName;
                this.ssn = SSN;
            }
      }
}