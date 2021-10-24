using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("1-IMPRIMINDO TODOS OS NÚMEROS DE 1 A 10");
             Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("2-IMPRIMIR A SOMA DOS NÚMEROS DE 1 A 100 PULANDO DE 2 EM 2 (1,3,5,7 ...)");

            int soma = 0;
            for (int i = 1; i <=100; i++)
            {
                //condição de impar
                if(i % 2 !=0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"SOMA: {soma}");

            Console.WriteLine("");

            Console.WriteLine("3-COMEÇANDO EM 0,IMPRIMA OS NÚMEROS SEGUINTES,ENQUANTO A SOMA DOS NÚMEROS JÁ IMPRESSOS FOR MENOR QUE 100. ");
             Console.WriteLine("");
            int soma2 = 0;
            int s = 0;
            do
            {
                Console.Write(s + " ");
                s++;
                soma2 +=s;  
            } while (soma2 < 100);

            Console.WriteLine("");

            Console.WriteLine("4-IMPRIMIR A TABUADA DE 9 ATÉ O DÉCIMO VALOR.");
            Console.WriteLine("");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(9 + " x "+ i +" = "+ (9*i));
            }
            Console.WriteLine("");
        }
    }
}
