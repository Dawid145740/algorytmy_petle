using System;

namespace KontoOszczednosciowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj kwotę początkową wpłacaną na konto oszczędnościowe: ");
            decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Podaj oprocentowanie konta w skali roku: ");
            decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Podaj liczbę miesięcy oszczędzania: ");
            int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

            decimal podatekBelki = 0.19m; // Stawka podatku Belki (19%)
            decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;

            decimal kwotaKoncowa = ObliczKwoteKoncowa(kwotaPoczatkowa, oprocentowanieMiesieczne, liczbaMiesiecy);
            decimal kwotaZysku = kwotaKoncowa - kwotaPoczatkowa;
            decimal podatekBelkiNaliczony = kwotaZysku * podatekBelki;

            decimal kwotaKoncowaPoPodatku = kwotaZysku - podatekBelkiNaliczony;

            Console.WriteLine("Kwota końcowa: " + kwotaKoncowaPoPodatku);
            Console.ReadLine();
        }

        static decimal ObliczKwoteKoncowa(decimal kwotaPoczatkowa, decimal oprocentowanieMiesieczne, int liczbaMiesiecy)
        {
            decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + oprocentowanieMiesieczne), liczbaMiesiecy);
            return kwotaKoncowa;
        }
    }
}
