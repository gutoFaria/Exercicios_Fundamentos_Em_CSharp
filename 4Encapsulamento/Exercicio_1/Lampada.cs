using System;

namespace Exercicio_1
{
    public class Lampada
    {
        private bool ligada = true;

        public void Ligar()
        {
            this.ligada = true;
        }

        public void Desligar()
        {
            this.ligada = false;
        }

        public void Imprimir()
        {
            if(this.ligada)
                Console.WriteLine("Lâmpada ligada.");
            else
                Console.WriteLine("Lâmpada desligada.");
        }
    }
}