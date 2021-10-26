using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("SE PAR X+5 \nSe ÍMPAR X*2");
            Console.Write("Digite um valor para iniciar:");
            int x = int.Parse(Console.ReadLine());
            string caso = "PAR";
            while (x < 1000)
            {
                if(x % 2 == 0)
                    caso = "PAR";
                else if(x % 2 != 0)
                    caso = "IMPAR";
                
                switch(caso)
                {
                    case "PAR":
                        x += 5;
                        break;
                    case "IMPAR":
                        x*=2;
                        break;
                    default:
                        Console.Write(" ");
                        break;
                }

                Console.Write(x + " ");
            }
        }
    }
}
