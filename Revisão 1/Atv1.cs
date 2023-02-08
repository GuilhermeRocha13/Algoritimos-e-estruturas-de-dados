using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Func(666)); //passando um valor para a função e imprimindo o retoron
        }

        static double Func(double parm1)
        {

            double volume = (4 * 3.14 * Math.Pow(parm1, 3) / 3); //formula volume


            return volume;

        }
    }
}
