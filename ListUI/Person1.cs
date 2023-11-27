using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUI
{
    internal class Person1
    {
        public Person1(string firstName, string lastName, string url)
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
            return firstName + "," + lastName + "," + url;
        }
    }
}