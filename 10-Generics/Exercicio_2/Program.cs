using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Exemplos de teste de Generics \n O programa não tem significado \n apenas testa os conceitos de Generics");
            Ponto<int> p1 = new Ponto<int>();
            p1.X = 3;
            p1.Y = 4;
            p1.Z = 5;

            Triangulo<int> t1 = new Triangulo<int>();
            t1.P1 = p1;

            Console.WriteLine("x = "+p1.X+" y = "+p1.Y+" z = "+p1.Z);
            t1.Imprimir();
        }

        struct Ponto<T>
        {
            public T X;
            public T Y;
            public T Z;
        }

        struct Triangulo<T>
        {
            public Ponto<T> P1;
            public Ponto<T> P2;
            public Ponto<T> P3;

            public void Imprimir()
            {
                Console.WriteLine("x = "+P1.X+" y = "+P1.Y+" z = "+P1.Z);
            }
        }
    }
}
