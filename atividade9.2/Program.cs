using System;

namespace atividade9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result;

            Console.WriteLine("Digite o limete");
            n = int.Parse(Console.ReadLine());

            for (int contador = 0; contador <= n; contador++)
            {
                if (contador++ % 2 != 0) ;
                

                    Console.WriteLine("O contador está em: " + contador);
                
            }
        }
    }
}
