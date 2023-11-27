using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUI
{
    internal class Person
    {
        public Person(string firstName, string lastName, string url)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.url = url;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return "First Name: " + firstName + " Last Name: " + lastName + " URL: " + url;
        }
    }
}