using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("CÁLCULO DO FATORIAL DE 10");
            int n = 1;
            
            for (int i = 10; i > 0; i--)
            {
                n*=i;
            }
            Console.WriteLine("Fatorial de 10 é : " + n);
        }
    }
}
