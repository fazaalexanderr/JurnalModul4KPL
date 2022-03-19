using System;

namespace modul4_1302204062
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(12f, 34f, 56f));
        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T A, T B, T C)
        {
            dynamic tempA = A;
            dynamic tempB = B;
            dynamic tempC = C;
            return tempA + tempB + tempC;
        }
    }
}