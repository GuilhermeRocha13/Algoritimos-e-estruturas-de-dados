using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raio");
            double raio = Math.Floor(Double.Parse(Console.ReadLine())); //recebendo a variavel do raio e arredondando para baixo

            Console.WriteLine(raio); //Esse writeline é para verificar se a metodo de arredondar está funcionando

            Console.WriteLine(calculo(raio)); //Passando o parametro pra função cáculo e imprimindo o retorno


        }

        static double calculo(double raio)
        {

            double volume = (4 * 3.14 * Math.Pow(raio, 3) / 3); //formula volume

            return volume;

        }
    }
}
