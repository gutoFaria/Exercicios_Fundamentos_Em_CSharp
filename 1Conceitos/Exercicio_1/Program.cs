using System;

namespace Exercicio_1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.Clear();// Iniciando o programa limpando o terminal
            Console.WriteLine("CALCULO DA MÉDIA PONDERADA 3 DE NOTAS ");

            //PEGANDO AS NOTAS E PESOS
            Console.Write("Digite a primeira nota do aluno:");
            float a1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o peso da primeira nota:");
            float p1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno:");
            float a2 = float.Parse(Console.ReadLine());
            Console.Write("Digite o peso da segunda nota:");
            float p2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno:");
            float a3 = float.Parse(Console.ReadLine());
            Console.Write("Digite o peso da terceira nota:");
            float p3 = float.Parse(Console.ReadLine());

           //calculo da média ponderada
            float mediaPonderada = ((a1 * p1) + (a2 * p2) + (a3 * p3))/(p1+p2+p3);
            Console.WriteLine("");
            //utilizando o comando Math.Round para exibir apenas duas casas decimais
            Console.WriteLine("A média ponderada das 3 notas é: " + Math.Round(mediaPonderada,2));  
        }
    }
}
