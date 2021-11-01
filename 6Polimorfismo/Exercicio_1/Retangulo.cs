using System;

namespace Exercicio_1
{
    public class Retangulo : Figura
    {
         public double Base { get; set; }
        public double Altura {get; set;}
        public double area { get; set; }

        public override double CalcularArea()
        {
            this.area = this.Base*this.Altura;
            return this.area;
        }
    }
}