using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Raio");
             double raio = Double.Parse(Console.ReadLine());

            Console.WriteLine(Func(raio));
           
        }

        static double Func(double caralho)
        {

            double volume = (4 * 3.14 * Math.Pow(caralho, 3) / 3);


            return Math.Floor(volume);

        }
    }
}
