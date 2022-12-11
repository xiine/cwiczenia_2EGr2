using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6KP
{
    class Account {
        private string emailAddress;
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
    }
    class Address_Book{
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private Contact contact;
        public Contact Contact { get { return contact; } set { contact = value; } }
    }
    class Contact
    {
        private string emailAddress;
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
        private string faxNumber;
        public string FaxNumber { get { return faxNumber; } set { faxNumber = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string primaryContactMethod;
        public string PrimaryContactMethod { get { return primaryContactMethod; } set { primaryContactMethod = value; } }
    }
    class Contact_Group {
        private string name;
        public string Name { get { return name; } set { name = value; } }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
