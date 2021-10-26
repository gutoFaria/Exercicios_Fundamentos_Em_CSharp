using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15 PRIMEIROS NÚMEROS DA SÉRIE FIBONACCI");
            int n1 = 1;
            int n2 = 1;
            int soma = 0;
            Console.Write($"{n1} {n2}");
            for (int i = 0; i < 13; i++)
            {
                soma = n1 + n2;
                Console.Write(" " + soma);
                n1 = n2;
                n2 = soma;
            }
        }
    }
}
