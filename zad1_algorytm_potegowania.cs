using System;

namespace Potegowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj podstawę potęgi: ");
            int podstawa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj wykładnik potęgi: ");
            int wykladnik = Convert.ToInt32(Console.ReadLine());

            int wynik = Poteguj(podstawa, wykladnik);
            Console.WriteLine("Wynik: " + wynik);

            Console.ReadLine();
        }

        static int Poteguj(int podstawa, int wykladnik)
        {
            int wynik = 1;
            for (int i = 0; i < wykladnik; i++)
            {
                wynik *= podstawa;
            }
            return wynik;
        }
    }
}
