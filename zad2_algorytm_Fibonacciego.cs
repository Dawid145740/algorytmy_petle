using System;

namespace CiagFibonacciego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ciąg Fibonacciego:");
            for (int i = 0; i < n; i++)
            {
                int wynik = Fibonacci(i);
                Console.WriteLine(wynik);
            }

            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int a = 0;
            int b = 1;
            int wynik = 0;

            for (int i = 2; i <= n; i++)
            {
                wynik = a + b;
                a = b;
                b = wynik;
            }

            return wynik;
        }
    }
}