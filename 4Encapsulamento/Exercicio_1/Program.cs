using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Lampada lamp = new Lampada();
            lamp.Imprimir();
            lamp.Desligar();
            lamp.Imprimir();
        }
    }
}
