using System;

namespace KartaPracy3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //z.1
            /*
            for (int i = 1; i < 31; i++) {
                Console.WriteLine(i + " listopada");
            }
            */
            //z.2
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i+=2)
            {
                Console.WriteLine(i*i);
            }
            */
            //z.3
            /*
            for (int i = 1000; i < 10000; i++) {
                if (i % 379 == 0) {
                    Console.WriteLine(i);
                }
            }
            */
            //z.4
            /*
            for (int i = 100; i < 1000; i++)
            {
                if (i % 5 == 0 && i % 6 == 0 || i % 11 == 0) {
                    Console.WriteLine(i);
                }
            }
            */
            //z.5
            /*
            int suma = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                suma += a;
            }
            Console.WriteLine(suma);
            */
            //z.6
            /*
            int suma = 0;
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                if (k % 2 == 0) {
                    suma += k;
                }
            }
            Console.WriteLine(suma);
            */
            //z.7
            /*
            int suma = 0;
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                if (i > 10 && i < 100 && i % 2 != 0) {
                    suma += m;
                }
            }
            Console.WriteLine(suma);
            */
            //z.8
            /*
            int L = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            double value = 0;
            int time = L * 12;
            for (int i = 0; i < time; i++) {
                if (i % 12 == 0) {
                    value += W * 0.06;
                }
            }
            Console.WriteLine(value);
            */
            //z.9
            /*
            int suma = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i % 100 == 21) {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
            */
            //z.10
            /*
            for (int i = 1; i <= 1000; i++) {
                double s = Math.Sqrt(i);
                if (s == (int)s) {
                    Console.WriteLine(i);
                }
            }
            */
        }
    }
}
