using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] vendas = new int[12, 4];

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("vendas do mês " + (i + 1) + ":");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Semana " + (j + 1) + ": ");
                    vendas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[] totaisMensais = new int[12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    totaisMensais[i] += vendas[i, j];
                }
                Console.WriteLine("vendido no mês " + (i + 1) + ": " + totaisMensais[i]);
            }

            // Calcular total vendido no ano
            int totalAnual = 0;
            for (int i = 0; i < 12; i++)
            {
                totalAnual += totaisMensais[i];
            }
            Console.WriteLine(" vendido no ano: " + totalAnual);

            // Encontrar a melhor semana para vender carros
            int[] totaisSemanais = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    totaisSemanais[i] += vendas[j, i];
                }
            }

            int melhorSemana = 0;
            for (int i = 1; i < 4; i++)
            {
                if (totaisSemanais[i] > totaisSemanais[melhorSemana])
                {
                    melhorSemana = i;
                }
            }

            Console.WriteLine("A melhor semana é a " + (melhorSemana + 1));
        }
    }
}
