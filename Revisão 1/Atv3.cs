using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numero = new int [10];

            Random sorteio = new Random(1);

            int vltotal = 0;

            for(int i = 0; i < numero.Length; i++){
               
               numero[i] = sorteio.Next(1,10);
               
               vltotal += numero[i];
               Console.WriteLine(numero[i]);
            }
           Console.WriteLine(vltotal);
              
        }

     
        
    }

}

//caralho = raio
