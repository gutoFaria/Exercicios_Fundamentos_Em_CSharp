using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma t = new Turma();

            //Acrescentando notas as provas aluno 1
            t.aluno1.prova1.nota1 = 4;
            t.aluno1.prova1.nota2 = 2.5;
            //segunda prova
            t.aluno1.prova2.nota1 = 1;
            t.aluno1.prova2.nota2 = 7;
            Console.WriteLine("Nota total aluno 1: "+ (t.aluno1.prova1.CalcularNotaTotal()+t.aluno1.prova2.CalcularNotaTotal()));
            Console.WriteLine("Média do Aluno 1: "+ t.aluno1.CalcularMedia());

            //Acrescentando notas as provas aluno 2
            t.aluno2.prova1.nota1 = 6.5;
            t.aluno2.prova1.nota2 = 3.5;
            //segunda prova
            t.aluno2.prova2.nota1 = 0;
            t.aluno2.prova2.nota2 = 3;
            Console.WriteLine("Nota total aluno 2: "+ (t.aluno2.prova1.CalcularNotaTotal()+t.aluno2.prova2.CalcularNotaTotal()));
            Console.WriteLine("Média do Aluno 2: "+ t.aluno2.CalcularMedia());
            //Acrescentando notas as provas aluno 3
            t.aluno3.prova1.nota1 = 5;
            t.aluno3.prova1.nota2 = 4;
            //segunda prova
            t.aluno3.prova2.nota1 = 6;
            t.aluno3.prova2.nota2 = 1.5;
            Console.WriteLine("Nota total aluno 3: "+ (t.aluno3.prova1.CalcularNotaTotal()+t.aluno3.prova2.CalcularNotaTotal()));
            Console.WriteLine("Média do Aluno 3: "+ t.aluno3.CalcularMedia());

            Console.WriteLine("\nMedia Total: "+ t.CalcularMedia());
            
        }
    }
}
