using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bank_obiektowka
{
    internal class Program
    {
        class Person { 
            public string Name { 
                get { return Name; } 
                set { this.Name = value; } 
            }
            public string lastName { 
                get { return lastName; } 
                set { this.lastName = value; } 
            }
            public int Phone { 
                get { return Phone; } 
                set { this.Phone = value; } 
            }
            public string Email { 
                get { return Email; } 
                set { this.Email = value; } 
            }
            public void getInfo(string name, string lastName, int phone, string email) {
                Name = name;
                this.lastName = lastName;
                Phone = phone;
                Email = email;
            }
        }
        class Adress {
            public string City { 
                get { return City; } 
                set { this.City = value; } 
            }
            public string Street { 
                get { return Street; } 
                set { this.Street = value; } 
            }
            public string Voivodeship { 
                get { return Voivodeship; } 
                set { this.Voivodeship = value; } 
            }
            public int postalCode { 
                get { return postalCode; } 
                set { this.postalCode = value; } 
            }
        }
        class Customer : Person {
            private int idCustomer;
            private int Balance;
            private Adress Adress;
            
            public void openAccount() {
                Console.WriteLine("Konto otwarte");
            }
            public void closeAccount() {
                Console.WriteLine("Konto zamknięte");
            }
            public void borrowLoan() {
                Console.WriteLine("Pożyczka wzięta");
            }
            private Transaction transaction;
        }
        class Employee : Person {
            private int idWorker;
            private Adress Adress;
            public void CreateCusAccount() {
                Console.WriteLine("Stworzono konto");
            }
            public void CloseCusAccount(){
                Console.WriteLine("Zamknięto konto");
            }
        }
        class Transaction {
            public string Type {
                get {
                    if (Type == "deposit")
                    {
                        return "Pieniądze wpłacone";
                    }
                    else if (Type == "withdraw")
                    {
                        return "Pieniądze wypłacone";
                    }
                    else if (Type == "transfer")
                    {
                        return "Pieniądze przeniesione";
                    }
                    else {
                        return "Nie takiego typu transakcji";
                    }
                }
                set { this.Type = value; }
            }
            public DateTime date;
        }
        class Account {
            private int idAccount;
            private int balance;
            public int checkBalance() {
                return this.balance;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
