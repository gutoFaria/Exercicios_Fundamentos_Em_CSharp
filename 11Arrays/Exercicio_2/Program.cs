using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] tipos = {"ÁS","DOIS","TRÊS","QUATRO","CINCO","SEIS","SETE","OITO","NOVE","DEZ","DAMA","VALETE","REI"};
            string[] naipe = {"COPAS","ESPADAS","OUROS","PAUS"};

            //construtor produz o baralho
            Baralho b = new Baralho();

            

            int contTipo = 0;
            int contNaipe = 0;
            for (int i = 0; i < 52; i++)
            {
                Carta c = new Carta(tipos[contTipo],naipe[contNaipe]);
                b.cartas[i] = c;
                contTipo++;

                if(contTipo > 12)
                {
                    contTipo = 0;
                    contNaipe++;
                }
            }
            //mostrar o baralho criado
            b.MostrarCartas();
            //Embaralhar o baralho
            b.Embaralhar();

            //quantidade de carta para distribuir

            Console.Write("Digite a quantidade de cartas que será distribuida:");
            int q = int.Parse(Console.ReadLine());
            try
            {
                b.Distribuir(q);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ERRO! " + e.Message);
            }
           
            
        }
    }
}
