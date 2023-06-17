using System;

namespace WypisywanieCyfr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba >= 100)
            {
                Console.WriteLine("Cyfry liczby:");

                WypiszCyfry(liczba);
            }
            else
            {
                Console.WriteLine("Liczba posiada mniej niż 3 cyfry.");
            }

            Console.ReadLine();
        }

        static void WypiszCyfry(int liczba)
        {
            if (liczba >= 10)
            {
                WypiszCyfry(liczba / 10);
            }

            Console.WriteLine(liczba % 10);
        }
    }
}
