using System;
using System.Collections.Generic;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            float n = 0;
            float p = 0;
            Console.Write("Digite o número de notas que será Calculado a média:");
            int numeroNotas = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite -1 para sair ou 0 para continuar:");
                escolha = int.Parse(Console.ReadLine());
                if(escolha == -1)
                    break;
                Console.Write("Digite sua nota: ");
                n = float.Parse(Console.ReadLine());
                Console.Write("Digite o peso da nota: ");
                p = float.Parse(Console.ReadLine()); 

            } while (escolha != -1);

           
        }
    }
}
