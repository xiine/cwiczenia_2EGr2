using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kurtiak321
{
    internal class Program
    {
        class Sortowanie {
            private List<int> Lista;
            public List<int> sortuj() {
                return new List<int>(); 
            }
            public void wyswietl(List<int> lista) {
                foreach (var item in lista)
                {
                    Console.Write(item + " ");
                }
            }
        }
        class Babelkowe  : Sortowanie
        {
            public List<int> sortuj(List<int> lista) {
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    for (int j = 0; j < lista.Count - 1; j++)
                    {
                        if (lista[j] > lista[j+1]) {
                            int tmp = lista[j];
                            lista[j] = lista[j + 1];
                            lista[j + 1] = tmp;
                        }
                    }
                }
                return lista;
            }
        }
        class Debilne : Sortowanie {
            public List<int> sortuj(List<int> lista) {
                lista.Sort();
                return lista;
            }
            public void wyswietl(List<int> lista)
            {
                foreach (var item in lista)
                {
                    Console.Write(item + " ");
                }
            }
        }

        class pWstawianie : Sortowanie {
            public List<int> sortuj(List<int> lista) {
                int p, x;
                for (int i = 1; i < lista.Count; i++)
                {
                    p = lista[i];
                    x = i - 1;
                    while (x >= 0 && lista[x] > p) {
                        lista[x + 1] = lista[x];
                        x--;
                    }
                    lista[x + 1] = p;
                }
                return lista;
            }
            
        }
        static void Main(string[] args)
        {
            List<int> L = new List<int>() { 5, 7, 2, 1, 4, 3 };
            Console.WriteLine("Sortowanie bąbelkowe");
            Babelkowe babelkowe1 = new Babelkowe();
            babelkowe1.wyswietl(L);
            Console.WriteLine();
            List<int> W = babelkowe1.sortuj(L);
            babelkowe1.wyswietl(W);
            Console.WriteLine();
            Console.WriteLine("Sortowanie debilne");
            Debilne debilne = new Debilne();
            debilne.wyswietl(L);
            Console.WriteLine();
            debilne.sortuj(L);
            debilne.wyswietl(L);
            Console.WriteLine();
            Console.WriteLine("Sortowanie przez wstawianie");
            pWstawianie wstawianie1 = new pWstawianie();
            wstawianie1.wyswietl(L);
            Console.WriteLine();
            List<int> P = wstawianie1.sortuj(L);
            wstawianie1.wyswietl(P);
            Console.ReadKey();
        }
    }
}
