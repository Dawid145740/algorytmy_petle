using System;

namespace SprawdzanieSilni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int n = SprawdzSilnie(x);

            if (n != -1)
            {
                Console.WriteLine(x + " jest silnią liczby " + n);
            }
            else
            {
                Console.WriteLine(x + " nie jest silnią żadnej liczby.");
            }

            Console.ReadLine();
        }

        static int SprawdzSilnie(int x)
        {
            int n = 0;
            int silnia = 1;

            while (silnia <= x)
            {
                if (silnia == x)
                {
                    return n;
                }

                n++;
                silnia *= (n + 1);
            }

            return -1;
        }
    }
}
