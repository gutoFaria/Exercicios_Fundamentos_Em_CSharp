using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.Write("Digite a opção de bebida 1 , 2 ou 3:");
            int opcao = int.Parse(Console.ReadLine());
            if(opcao == 1)
            {
                Bebida b = Bebida.Refrigerante;
                Console.WriteLine("Opção escolhida:\n" + b.ToString());
            }   
            else if(opcao == 2)
            {
                Bebida b = Bebida.Suco;
                Console.WriteLine("Opção escolhida:\n" + b.ToString());
            }   
            else if(opcao == 3)
            {
                Bebida b = Bebida.Agua;
                Console.WriteLine("Opção escolhida:\n" + b.ToString());
            }
               

            
        }
        enum Bebida
        {
            Refrigerante = 1,
            Suco = 2,
            Agua = 3
        }
    }
}
