using System;

namespace Exercicio_1
{
    public class Excessoes
    {
        
    }

    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException(double valor)
        {
            Console.WriteLine("R$ "+Math.Round(valor,2)+" é um valor inválido.");
        }

        public ValorInvalidoException(string message) : base(message)
        {
        }

        public ValorInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(double valor)
        {
            Console.WriteLine("R$ "+ Math.Round(valor,2)+" saldo insuficiente");
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}