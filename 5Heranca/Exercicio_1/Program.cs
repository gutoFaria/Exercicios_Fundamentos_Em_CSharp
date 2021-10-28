using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Ponto2D ponto2d = new Ponto2D(5,7);
            ponto2d.Imprimir();

            Console.WriteLine("");

            Ponto3D ponto3d = new Ponto3D(4,2,10);
            ponto3d.Imprimir3D();
        }
    }
}
