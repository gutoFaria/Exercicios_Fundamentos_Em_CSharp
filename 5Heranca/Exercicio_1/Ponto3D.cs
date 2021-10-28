using System;
namespace Exercicio_1
{
    public class Ponto3D : Ponto2D
    {
        public double z { get; set; }
        public Ponto3D(double x , double y , double z) : base(x,y)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Imprimir3D()
        {
            Console.WriteLine("Coordenadas dos pontos x , y e z");
            Console.Write("x = " + this.x + ", y = "+this.y + ", z = " +this.z);
        }
    }
}