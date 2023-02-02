using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Func(666));
        }

        static double Func(double caralho)
        {

            double volume = (4 * 3.14 * Math.Pow(caralho, 3) / 3);


            return volume;

        }
    }
}