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
                o.ToString();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("ERRO!" + e.Message);
                Console.WriteLine("Objeto de referência nula.");
            }
        }
    }
}
