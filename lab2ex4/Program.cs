using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va determina daca un numar este sau nu palindrom.
                        Console.WriteLine("Introduceti un numar ");
            int n = int.Parse(Console.ReadLine());
            int dublura, palindrom;
            palindrom = n % 10;
            dublura = n / 10;
            while(dublura!=0)
            {
                palindrom = (palindrom * 10) + (dublura % 10);
                dublura = dublura / 10;
            }
            if (n == palindrom)
            {
                Console.WriteLine("Numarul introdus este un palindrom");
            }
            else
            {
                Console.WriteLine("Numarul introdus nu este un palindrom");
            }
        }
    }
}
