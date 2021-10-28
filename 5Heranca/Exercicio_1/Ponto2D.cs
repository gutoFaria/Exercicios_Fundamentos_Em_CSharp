using System;

namespace Exercicio_1
{
    public class Ponto2D
    {
        public double x ;
        public double y ;

        public Ponto2D(double x,double y)
        {
            this.x = x;
            this.y =y;
        }

        public void Imprimir()
        {
            Console.WriteLine("Coordenadas dos pontos x e y");
            Console.Write("x = " + this.x + ", y = "+this.y);
        }
    }
}