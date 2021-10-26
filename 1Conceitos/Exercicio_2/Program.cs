using System;
using System.Collections.Generic;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //variáveis peso e nota
            float nota = 0;
            float peso = 0;
            //somatorios da media
            float somaPesoENota = 0;
            float somaPesos = 0;
            //media ponderada
            float media = 0;
            do
            {
                Console.Write("Digite -1 para sair \nOu a nota do aluno: ");
                nota = float.Parse(Console.ReadLine());
                //uma condição para sair do loop
                if(nota == -1)
                    break;
                Console.Write("Digite o peso da nota do aluno: ");
                peso=float.Parse(Console.ReadLine());


                //somatorios
                somaPesoENota += (peso * nota);
                somaPesos += peso;
                

            } while (nota != -1);

            // media ponderada
            media = somaPesoENota / somaPesos;

            Console.WriteLine("A média das notas é igual a: " +Math.Round(media,2));
        }
    }
}
