using System;

namespace Exercicio_1
{
    public class Quadrado
    {
        public double b;
        public double h;
        public double area;

        public void CalcularArea()
        {
            area = (b * h);
            Console.WriteLine("Área Quadrado:"+ area);
        }
    }
}