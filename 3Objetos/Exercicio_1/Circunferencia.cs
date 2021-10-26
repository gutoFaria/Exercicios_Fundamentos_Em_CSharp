using System;

namespace Exercicio_1
{
    public class Circunferencia
    {
        public double r;
        public double area;

        public void CalcularArea()
        {
            area = Math.PI * Math.Pow(r,2);
            Console.WriteLine("Área Circuferência: "+ Math.Round(area,2));
        }
    }
}