using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite 5 números");
            int[] numeros = new int[5];

            //pegando os valores
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}° número:",i+1);
                numeros[i]=int.Parse(Console.ReadLine());
            }
           
           Console.WriteLine("A MÉDIA DOS VALORES DIGITADOS");
           double soma = 0;
           for (int i = 0; i < 5; i++)
           {
               soma +=numeros[i];
           }

           double media = soma/5;

           Console.Write("MÉDIA = {0}",media);

           //encontrando o maior valor presente no array numeros
           int maior = numeros[0]; // variável de recebimento de maior

           for (int i = 0; i < 5; i++)
           {
               if(maior < numeros[i])
                    maior = numeros[i];
           }

           Console.Write("\nMAIOR NÚMERO DO VETOR: {0}",maior);

           //encontrar o menor valor no vetor
           int menor = numeros[0];
            for (int i = 0; i < 5; i++)
           {
               if(menor > numeros[i])
                    menor = numeros[i];
           }
           Console.Write("\nMENOR NÚMERO DO VETOR: {0}",menor);

           //ordenar vator de forma decrecente com o método Reverse
           Array.Reverse(numeros);

            Console.WriteLine("\nVETOR INVERTIDO");
           for (int i = 0; i < 5; i++)
           {
               Console.Write("{0} ",numeros[i]);
           }

        }
    }
}
