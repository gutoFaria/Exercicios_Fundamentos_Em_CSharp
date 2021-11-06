using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Soma de valores de colunas de uma MATRIZ");

            int[,] mat = new int[3,4];

            Console.WriteLine("Preencha as posições da matriz 3x4");

            int cont = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o {0}° valor:",cont+1);
                    mat[i,j] = int.Parse(Console.ReadLine());
                    cont++;
                }
            }

            cont = 0;
            Console.WriteLine("\nIMPRIMINDO A MATRIZ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("{0}° valor: {1}",cont+1,mat[i,j]);
                    cont++;
                }
            }

            //4 variável para guuardar a soma das colunas e um vetor para guardar o resultado dessas somas
            int soma1 = 0;
            int soma2 = 0;
            int soma3 = 0;
            int soma4 = 0;
            int[] resultado = new int[4];

            Console.WriteLine("\nFAZENDO A SOMA DAS COLUNAS");
            Console.WriteLine("\nIMPRIMINDO A MATRIZ");
            cont =0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        soma1 += mat[i,j];
                        resultado[j] = soma1;
                    }

                    if (j == 1)
                    {
                        soma2 += mat[i,j];
                        resultado[j] = soma2;
                    }

                    if (j == 2)
                    {
                        soma3 += mat[i,j];
                        resultado[j] = soma3;
                    }

                    if (j == 3)
                    {
                        soma4 += mat[i,j];
                        resultado[j] = soma4;
                    }
                }
            }

            Console.WriteLine("\nIMPRIMINDO AS SOMAS DAS COLUNAS");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}° Soma = {1}",i+1,resultado[i]);
            }

        }
    }
}
