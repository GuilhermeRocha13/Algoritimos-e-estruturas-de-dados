
using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numero = new int [10];

            Random sorteio = new Random(); //criando sorteio e vetor

            for(int i = 0; i < numero.Length; i++){
               
               numero[i] = sorteio.Next(1,10);
                                                    //preenchendo vetor
               Console.WriteLine(numero[i]);
            }

            double vltotal = 0;

            for(int i = 0; i < numero.Length; i++){
                 
                 vltotal += numero[i]; //somando todas posições do vetor 

            }

            Console.WriteLine(vltotal);

            double media = vltotal / numero.Length; //calculando a media 
            Console.WriteLine(media);
              
        }

     
        
    }

}
