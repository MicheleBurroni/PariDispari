using System;

namespace PariDispari
{
    public class PariDispariInt
    {
        public static uint LeggiIntero()
        {
            Console.Write("Inserisci un numero intero positivo che vui usare come massimo, e uno che vuoi usare come minimo! ");
            uint n1 = uint.Parse(Console.ReadLine());
            return n1;
        }
        public static void PariDispari(uint n1, uint n2)
        {
            int countPari = 0, countDispari = 0;
            uint max = Math.Max(n1, n2);
            uint min = Math.Min(n1, n2);
            for (uint i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} numeri pari;");
                    countPari++;
                }
                else
                {
                    Console.WriteLine($"{i} numeri dipari;");
                    countDispari++;
                }
            }
            Console.WriteLine($"Numeri Pari: {countPari};\n Numeri dispari: {countDispari}. ");
        }
    }
}