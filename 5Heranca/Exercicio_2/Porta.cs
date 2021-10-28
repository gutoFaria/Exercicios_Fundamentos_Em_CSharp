using System;

namespace Exercicio_2
{
    public class Porta : ICloneable
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public bool Aberta { get; set; }

        public Porta(double altura,double largura,bool aberta)
        {
            this.Aberta = aberta;
            this.Altura = altura;
            this.Largura = largura;

            Imprimir();
            Abrir(this.Aberta);
            
        }
        private void Abrir(bool aberta)
        {
            if(aberta)
                Console.WriteLine("Porta Aberta");
            else
                Fechar();
        }

        private void Fechar()
        {
            Console.WriteLine("Porta Fechada");
        }

        public object Clone()
        {
            return new Porta(this.Altura,this.Largura,this.Aberta);
        }

        private void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("Largura da Porta: "+this.Largura);
            Console.WriteLine("Altura da Porta:" + this.Altura);
        }
    }
}