using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Quadrado q1 = new Quadrado();
            q1.Lado =3;
            double areaQ1 = q1.CalcularArea();
            Console.Write("Área do primeiro quadrado:"+areaQ1);
            Console.WriteLine("");

            Quadrado q2 = new Quadrado();
            q2.Lado = 10;
            double areaQ2 = q2.CalcularArea();
            Console.Write("Área do segundo quadrado:"+areaQ2);
            Console.WriteLine("");

            //Retangulos
            Retangulo r1 =new Retangulo();
            r1.Base = 2;
            r1.Altura = 7;
            double areaR1 = r1.CalcularArea();
            Console.Write("Área do primeiro retângulo:"+areaR1);
            Console.WriteLine("");
            
            Retangulo r2 = new Retangulo();
            r2.Base = 5;
            r2.Altura = 3;
            double areaR2 = r2.CalcularArea();
            Console.Write("Área do segundo retângulo:"+areaR2);
            Console.WriteLine("");

            FiguraComplexa fc = new FiguraComplexa();
            fc.quadrado[0] = q1;
            fc.quadrado[1] = q2;
            fc.retangulo[0] = r1;
            fc.retangulo[1] = r2;

            double areaFC = fc.CalcularArea();
            Console.Write("Área da figura complexa:"+areaFC);
            Console.WriteLine("");
        }
    }
}
