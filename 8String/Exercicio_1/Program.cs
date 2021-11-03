using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Processar(null));
			Console.WriteLine(Processar("bb"));
			Console.WriteLine(Processar("palavra"));
        }

        private static String Processar(string s)
		{
			if (s == null)
				return null;

			if (s.Length <= 3)
			{
				s = s.ToUpper();
				return s;
			}

            if (s.Length > 3)
			{
				s = s.ToUpper();
                s = "???" + s.Substring(3);
				return s;
			}

			
			return s;
        }
    }
}
