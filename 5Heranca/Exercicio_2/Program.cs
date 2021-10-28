using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Porta p = new Porta(2,0.40,false);
            Porta pClone = (Porta)p.Clone();

            Porta p1 = new Porta(1.8,0.40,true);
            Porta p1Clone = (Porta)p1.Clone();
        }
    }
}
