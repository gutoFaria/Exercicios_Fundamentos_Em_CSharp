using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ContaBancaria c1 = new ContaBancaria();
            ContaBancaria c2 = new ContaBancaria();

            //definir a o saldo das contas
            c1.Saldo = 500;
            c2.Saldo = 65;

            Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
            Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));

            //fazer depositos nas contas utilizando os blocos try catch com valores corretos
            Console.WriteLine("");
            Console.WriteLine("Depositos");
            Console.WriteLine("");
            try
            {
                c1.Depositar(100);
                c2.Depositar(50);
                Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
                Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));

            }
            catch (ValorInvalidoException e)
            {
                Console.WriteLine("ERROR! ");
            }

            //fazer depositos nas contas utilizando os blocos try catch com valores inválidos

            try
            {
                //c1.Depositar(0);
                c2.Depositar(-5);
                Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
                Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));
            }
            catch (ValorInvalidoException e)
            {
                Console.WriteLine("ERROR! ");
            }

            Console.WriteLine("");
            Console.WriteLine("SAQUES");
            Console.WriteLine("");
            //sacar com valores corretos utilizando try e catch

            try
            {
                c1.Sacar(200);
                c2.Depositar(20);
                Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
                Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));

            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("ERROR! ");
            }

            //fazer sques com valores acima da conta

            try
            {
                c1.Sacar(700);
                c2.Sacar(150);
                Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
                Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("ERROR! ");
            }

            Console.WriteLine("");
            Console.WriteLine("TRANSFERÊNCIA");
            Console.WriteLine("");

            try
            {
                c1.Tranferir(200,c2);
                Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
                Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));

            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("ERROR! ");
            }

            //fazer sques com valores acima da conta

            try
            {
                c1.Tranferir(800,c2);
                Console.WriteLine("Saldo da 1° conta:R$ "+Math.Round(c1.Saldo,2));
                Console.WriteLine("Saldo da 2° conta:R$ "+Math.Round(c2.Saldo,2));
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("ERROR! ");
            }

        }
    }
}
