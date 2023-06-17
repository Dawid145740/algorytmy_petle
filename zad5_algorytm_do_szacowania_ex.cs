using System;

namespace SzeregTaylora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wartość x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj liczbę wyrazów do uwzględnienia w szeregu Taylora: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double wynik = ObliczWartoscFunkcji(x, n);

            Console.WriteLine("Wynik: " + wynik);
            Console.ReadLine();
        }

        static double ObliczSilnie(int liczba)
        {
            if (liczba == 0)
                return 1;

            double wynik = 1;
            for (int i = 1; i <= liczba; i++)
            {
                wynik *= i;
            }
            return wynik;
        }

        static double ObliczWartoscFunkcji(double x, int n)
        {
            double wynik = 0;
            for (int i = 0; i <= n; i++)
            {
                double wyraz = Math.Pow(x, i) / ObliczSilnie(i);
                wynik += wyraz;
            }
            return wynik;
        }
    }
}