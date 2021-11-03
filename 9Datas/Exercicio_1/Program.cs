using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            DateTime data1 = new DateTime(2020,04,10);
            DateTime data2 = new DateTime(2022,01,01);
            DateTime data3 = new DateTime(2017,11,12);

            Produto p1 = new Produto("Feijão",2.5,data1);

            Produto p2 = new Produto("Café",1.0,data2);

            Produto p3 = new Produto("Beterraba",0.9,data3);

            p1.Imprimir(1);
            p2.Imprimir(2);
            p3.Imprimir(3);
        }
    }
}
