using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siłownia
{
    class Information{
        public string Name;
        public string lastName;
        public int ID;
        public string Adress;
        public string Country;
        public string Email;
        public int Phone;
        public string securityQuestion;
        public string securityAnswer;
    }
    class Customer : Information {
        private DateTime joinDate;
        public bool isMember;
        private string memberPassword;
        private DateTime subscriptionDate;
    }
    class Employee : Information {
        private DateTime joinDate;
        public string position;
        public string trainerType;
        private string employeePassword;
        private string employeeStatus;
        public void Emoplyee() { }

    }
    class Training {
        private int ID;
        public string trainingName;
        public string trainPart;
    }
    class Equipment {
        private int ID;
        public string equipmentName;
        public string equipmentType;
        public string equipmentStatus;
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
        }
    }
}
