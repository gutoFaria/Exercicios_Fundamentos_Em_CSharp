using System;

namespace Exercicio_1
{
    public class Trapezio
    {
        public double baseMaior;
        public double baseMenor;
        public double h;
        public double area;

        public void CalcularArea()
        {
            area = ((baseMaior + baseMenor) /2 ) * h;
            Console.WriteLine("Área Trapezio: "+ area);
        }
    }
}