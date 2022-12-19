using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pracownik {
        private string imie;
        private string nazwisko;
        private Pracownik przelozony;
        private string pesel;
        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public Pracownik(string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        public void pokazSzczegoly() {
            Console.WriteLine($"{this.imie} {this.nazwisko} {this.pesel} {this.przelozony}");
        }
    }
    class Wypozyczenie {
        private int id;
        private int nrReferencyjny;
        private Pracownik opiekun;
        private Auto auto;
        private Klient klient;
        public Wypozyczenie() { }
        public Wypozyczenie(int id) {
            this.id = id;
        }
        public Auto wydajAuto() {
            return auto;
        }
    }
    class Auto {
        private string marka;
        private string model;
        private string rocznik;
        private Producent producent;
        private Dealer dealer;
        public Auto(string marka, string model, string rocznik, Producent producent, Dealer dealer)
        {
            this.marka = marka;
            this.model = model;
            this.rocznik = rocznik;
            this.dealer = dealer;
            this.producent = producent;
        }
        public void pokazSzczegoly() {
            Console.WriteLine($"{this.marka} {this.model} {this.rocznik} {this.dealer} {this.producent}");
        }
        public static int zlecNaprawe() {
            return 10;
        }
    }
    class Producent {
        private string nazwa;
        private int kod;
        private int koncesja;
    }
    class Klient {
        private string login;
        private string pass;
        private int id;
        private List<Wypozyczenie> wypozyczenie;
        public static void sprawdzHistorie(int id) {
            wypozyczenie(id); 
        }
    }
    class Dealer {
        private string nazwa;
        private string miasto;
        public List<Producent> producenci = new List<Producent>();
        private bool strategicznyPartner;
        public Dealer(string nazwa, string miasto) {
            this.nazwa = nazwa;
            this.miasto = miasto;
        }
        public Dealer(bool strategicznyPartner) {
            this.strategicznyPartner = strategicznyPartner;
        }
        public void dodajDoListyProducentow(Producent producent) {
            producenci.Add(producent);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Pracownik pracownik = new Pracownik("Borys","Kurtiak","234225234");
            Dealer dealer = new Dealer("cos", "soc");
            Producent producent = new Producent();
            Auto auto = new Auto("Honda","idk","2022",producent,dealer);
            auto.pokazSzczegoly();

        }
    }
}
