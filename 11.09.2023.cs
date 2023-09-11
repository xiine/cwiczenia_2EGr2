using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kurwiok3
{
    static class User {
        public static Register Regis(Register register)
        {
            return register;
        }
        
    }
    class Register {
        public string Name { get; set; }
        public string Password { get; set; }
        canRegister CR;
        addToDatabase ATD;
        addToNewsletter ATN;
        addToRegisterCO2Production ATRCO2P;
        public void registerrr(string Name, string Password) {
            if (this.Name != Name || this.Password != Password){
                CR.CanRegister();
                ATD.AddToDatabase();
                ATN.AddToNewletter();
                ATRCO2P.AddToRegisterCO2Production();
                Console.WriteLine("Logged in");
                
            }
            else {
                Console.WriteLine("Hasło lub login są niepoprawne");
            }
        }
    }
    class canRegister {
        public bool CanRegister() {
            return true;
        }
    }
    class addToDatabase {
        public void AddToDatabase() {
            Console.WriteLine("Added to database");
        }
    }
    class addToNewsletter {
        public void AddToNewletter() {
            Console.WriteLine("Added to newslettera");
        }
    }
    class addToRegisterCO2Production {
        public void AddToRegisterCO2Production() {
            Console.WriteLine("Added");
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            User.regis;
        }
    }
}
