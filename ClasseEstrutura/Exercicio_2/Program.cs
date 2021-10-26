using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Fracao f = new Fracao();
            f.numerador = 7;
            f.denominador = 5;

            Console.WriteLine("Multiplicação de fração.");
            Console.WriteLine("7/5 x 2/3");
            f.multiplicaFracao(2,3);
        }
    }

    public struct Fracao
    {
        public float numerador;
        public float denominador;

        public void multiplicaFracao(float n, float d)
        {
            numerador *= n;
            denominador *=d;

            Console.WriteLine("Igual="+numerador+"/"+denominador);
        }

    }
}
