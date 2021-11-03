using System;

namespace Exercicio_1
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public DateTime Validade { get; set; }

        public Produto(string nome,double peso,DateTime validade)
        {
            this.Nome = nome;
            this.Peso = peso;
            this.Validade = validade;
        }

        public void Imprimir(int t)
        {
            Console.WriteLine("");
            Console.WriteLine("{0}) {1,12} {2:000000.00} {3}",t, this.Nome, this.Peso, this.Validade.ToString("dd-MM-yyyy"));
        }
    }
}