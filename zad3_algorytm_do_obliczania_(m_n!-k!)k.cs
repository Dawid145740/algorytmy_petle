using System;

namespace ObliczanieWyrazenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            do
            {
                Console.Write("Podaj liczbę n (większą lub równą 5): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 5);

            do
            {
                Console.Write("Podaj liczbę k (większą lub równą 5): ");
                k = Convert.ToInt32(Console.ReadLine());
            } while (k < 5);

            if (n < k)
            {
                Console.WriteLine("Błąd: n musi być większe lub równe k.");
                Console.ReadLine();
                return;
            }

            long wynik = ObliczWyrazenie(n, k);

            Console.WriteLine("Wynik: " + wynik);
            Console.ReadLine();
        }

        static long ObliczSilnie(int liczba)
        {
            long wynik = 1;
            for (int i = 1; i <= liczba; i++)
            {
                wynik *= i;
            }
            return wynik;
        }

        static long ObliczWyrazenie(int n, int k)
        {
            long silniaN = ObliczSilnie(n);
            long silniaK = ObliczSilnie(k);

            long wynik = (silniaN - silniaK) / silniaK;

            return wynik;
        }
    }
}
