using System;

namespace Exercicio_1
{
    public class Triangulo
    {
        public double b;
        public double h;
        public double area;

        public void CalcularArea()
        {
            area = (b * h) / 2;
            Console.WriteLine("Área Triangulo: "+ area);
        }
    }
}