using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int x = 0;
            int[] escolhas = new int[6];
            int[] mega = new int[6];

            Console.WriteLine("Digite os números de 1 a 60 para o sorteio:");
            while (x<6)
            {
                escolhas[x] = int.Parse(Console.ReadLine());
                x++;
            }

            Random r = new Random();
            int i =0;
            int c =0;
            while (i < 6 )
            {
                c=0;
                int a = r.Next(1,60);
                for (int j = 0; j < 6; j++)
                {
                    if(mega[j] != a)
                    {
                        c++;
                    }

                    if(c == 6)
                    {
                        mega[i] = a;
                        i++;
                    }
                }
                
            }

            int cont = 0;
            for (int a = 0; a < 6; a++)
            {
                Console.WriteLine("Sua escolha: "+escolhas[a]+"\t Sorteio: "+mega[a]);
                for (int z = 0; z < 6; z++)
                {
                    if(escolhas[a] == mega[z])
                    cont++;
                } 
            }

            Console.WriteLine("Acertos: " + cont);
        }
    }
}
