using System;

namespace Exercicio_2
{
    public class Carta
    {
        public string Tipo { get; set; }
        public string Naipe { get; set; }

        public Carta(){}

        public Carta(string tipo,string naipe)
        {
            this.Tipo = tipo;
            this.Naipe = naipe;
        }

        public void ImprimirCarta()
        {
            Console.Write("TIPO: "+this.Tipo + "\tNAIPE: "+ this.Naipe);
            Console.WriteLine("");
        }
    }
}