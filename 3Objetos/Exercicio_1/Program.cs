using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Quadrado q = new Quadrado();
            Trapezio tra = new Trapezio();
            Circunferencia c = new Circunferencia();
            Triangulo tri = new Triangulo();

            Console.WriteLine("Cálculos de áreas.");

            Console.WriteLine("CÁLCULO DA ÁREA DO TRIANGULO");
            Console.Write("Entre com a base: ");
            tri.b = double.Parse(Console.ReadLine());
            Console.Write("Entre com a altura: ");
            tri.h = double.Parse(Console.ReadLine());
            tri.CalcularArea();

            Console.WriteLine("CÁLCULO DA ÁREA DO Quadrado");
            Console.Write("Entre com a base: ");
            q.b = double.Parse(Console.ReadLine());
            Console.Write("Entre com a altura: ");
            q.h = double.Parse(Console.ReadLine());
            q.CalcularArea();

            Console.WriteLine("CÁLCULO DA ÁREA DA CIRCUFERÊNCIA");
            Console.Write("Entre com o raio: ");
            c.r = double.Parse(Console.ReadLine());
            c.CalcularArea();

            Console.WriteLine("CÁLCULO DA ÁREA DO TRAPÉZIO");
            Console.Write("Entre com a base maior: ");
            tra.baseMaior = double.Parse(Console.ReadLine());
            Console.Write("Entre com a base menor: ");
            tra.baseMenor = double.Parse(Console.ReadLine());
            Console.Write("Entre com a altura: ");
            tra.h = double.Parse(Console.ReadLine());
            tra.CalcularArea();
            
        }
    }
}
