using System;

namespace Exercicio_2
{
    public class Aluno
    {
        public Prova prova1 = new Prova();
        public Prova prova2 = new Prova();

        public double media;

        public double CalcularMedia()
        {
            media = (prova1.CalcularNotaTotal()+prova2.CalcularNotaTotal()) /4;
            return media;
        }
    }
}