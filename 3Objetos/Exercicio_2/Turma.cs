using System;
using System.Collections.Generic;

namespace Exercicio_2
{
    public class Turma
    {
        public Aluno aluno1 = new Aluno();
        public Aluno aluno2 = new Aluno();
        public Aluno aluno3 = new Aluno();

        public double CalcularMedia()
        {
            double media = aluno1.media+aluno2.media+aluno3.media;
            return media;
        }
    }
}