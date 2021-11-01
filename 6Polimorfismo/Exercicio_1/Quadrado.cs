namespace Exercicio_1
{
    public class Quadrado : Figura
    {
        public double Lado { get; set; }
        public double area { get; set; }
        public override double CalcularArea()
        {
            this.area = this.Lado*this.Lado;
            return this.area;
        }
    }
}