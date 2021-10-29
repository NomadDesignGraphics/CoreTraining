
using System;

namespace Destek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            topla topla = new topla();
            int[] veri1 = new int[] { 1, 2, 3, 4, 5, 6};
            int[] veri2 = new int[] { 7, 8, 9, 10, 11, 12};

            Console.WriteLine("veri1: " + topla.toplam(veri1));
            Console.WriteLine("veri2: " + topla.toplam(veri2));
            Console.Read();
        }
    }
}
