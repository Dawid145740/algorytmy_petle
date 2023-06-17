using System;

namespace OdwracanieKolejnosciCyfr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int odwroconaLiczba = OdwrocKolejnoscCyfr(liczba);

            Console.WriteLine("Odwrocona liczba: " + odwroconaLiczba);
            Console.ReadLine();
        }

        static int OdwrocKolejnoscCyfr(int liczba)
        {
            if (liczba < 10)
            {
                return liczba;
            }
            else
            {
                int ostatniaCyfra = liczba % 10;
                int pozostaleCyfry = liczba / 10;
                int odwroconaPozostaleCyfry = OdwrocKolejnoscCyfr(pozostaleCyfry);

                int iloscCyfr = LiczIloscCyfr(pozostaleCyfry);

                return ostatniaCyfra * (int)Math.Pow(10, iloscCyfr) + odwroconaPozostaleCyfry;
            }
        }

        static int LiczIloscCyfr(int liczba)
        {
            if (liczba < 10)
            {
                return 1;
            }
            else
            {
                return 1 + LiczIloscCyfr(liczba / 10);
            }
        }
    }
}
