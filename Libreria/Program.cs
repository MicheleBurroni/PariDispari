using System;
using PariDispari;

namespace EsercizioPariDispari
{
    public class Program
    {
        static void Main(string[] args)
        {
            uint n1 = PariDispariInt.LeggiIntero();
            uint n2 = PariDispariInt.LeggiIntero();
            PariDispariInt.PariDispari(n1, n2);
        }

    }
}
