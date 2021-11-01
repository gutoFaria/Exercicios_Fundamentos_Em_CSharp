using System;

namespace Exercicio_1
{
    public class FiguraComplexa : Figura
    {
        public Quadrado[] quadrado = new Quadrado[2];
        public Retangulo[] retangulo = new Retangulo[2];
        public double area { get; set; }

        public override double CalcularArea()
        {
            this.area = quadrado[0].area + quadrado[1].area + retangulo[0].area + retangulo[1].area;
            return this.area;
        }
    }
}