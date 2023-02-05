using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja o fatorial de qual número?");
            int numero = int.Parse(Console.ReadLine());

            int resultado = fatorial(numero);

            Console.WriteLine(resultado);
        }

        static int fatorial(int caralho)
        {
            int resultado = 1;

            for (int i = 1; i <= caralho; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
    }
}
