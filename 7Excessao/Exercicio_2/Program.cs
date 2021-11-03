using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            try
            {
                object o = null;
                o.toString();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("ERRO!" + e.Message);
                Console.WriteLine("Objeto de referência nula.");
            }
        }
    }
}
