using System;

namespace Exercicio_7
{
    class Program
    {
        
        static bool verificaDiaEMes(int dia,int mes)
        {
            if(dia < 1 || dia > 31)
                return false;
            if(mes < 1 || mes > 12)
                return false;
            
            if(dia > 28 && mes == 2)
                return false;
            
            if(dia == 31 && (mes != 1 || mes != 3 || mes != 5 || mes != 7 || mes != 8 || mes != 10 || mes != 12))
                return false;
            
            return true;
        }

        static bool verificaAno(int ano)
        {
            if(ano >= 1900 && ano <= 2999 )
                return true;
            
            return false;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("VERIFICAR DATA");
            Console.Write("Digite o número de dias:");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o número do mês :");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o número do ano:");
            int ano = int.Parse(Console.ReadLine());

            bool a = verificaDiaEMes( dia, mes);
            bool b = verificaAno( ano);

            if(a && b)
                Console.WriteLine("Data Válida!");
            else
                Console.WriteLine("Data Inválida");
           
        }
    }
}
