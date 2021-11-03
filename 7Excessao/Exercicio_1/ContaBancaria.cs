using System;

namespace Exercicio_1
{
    public class ContaBancaria
    {
        public double Saldo;

        public double Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ValorInvalidoException(valor);
            }

            if(valor > this.Saldo)
            {
                throw new SaldoInsuficienteException(this.Saldo);
            }

            return this.Saldo - valor;
        }

        public void Depositar(double valor)
        {
            if(valor <= 0)
            {
                throw new ValorInvalidoException(valor);
            }
            this.Saldo += valor;
        }

        public void Tranferir(double valor, ContaBancaria conta)
        {
            if(valor <= 0)
            {
                throw new ValorInvalidoException(valor);
            }

            if(valor > this.Saldo)
            {
                throw new SaldoInsuficienteException(this.Saldo);
            }
            this.Saldo -= valor;
            conta.Saldo += valor;
        }
    }
}