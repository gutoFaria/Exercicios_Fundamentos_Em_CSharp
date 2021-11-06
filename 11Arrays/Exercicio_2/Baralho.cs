using System;

namespace Exercicio_2
{
    public class Baralho : Exception
    {
        public Carta[] cartas = new Carta[52];
        
        public Baralho(){ Console.WriteLine("Criando Baralho!");}//construtor padrão

        public void Distribuir(int q)
        {
            if(q <= 0)
            {
                throw new ArgumentOutOfRangeException("Digite um valor válido!");
            }

            if (q>52)
            {
                throw new ArgumentOutOfRangeException("Valor superior ao número de quartas");
            }

            Carta[] c = new Carta[q];

            for (int i = 0; i < q; i++)
            {
                c[i] = this.cartas[i];
                this.cartas[i] = null;
            }

            Console.WriteLine("\nCARTAS DISTRIBUIDAS:\n");
            for (int i = 0; i < q; i++)
            {
                c[i].ImprimirCarta();
            }

            Console.WriteLine("\nCARTAS RESTANTE NO BARALHO\n");
            for (int i = 0; i < 52; i++)
            {
                if(this.cartas[i] != null)
                {
                    this.cartas[i].ImprimirCarta();
                }
            }


        }

        //para embaralhar criar outro vetor
        public void Embaralhar()
        {
            Console.WriteLine("Embaralhando...");
            //para embaralhar e aparecer a numeração 0 no random 
            //foi necessário modificar o for de 52 a 51
            //foi necessário mudar o random com um valor a mais nesse caso 52
            //dessa forma seria gerado numeros entres 0 até 51 o que corresponde o valores dentro do vetor cartas
            Random r = new Random();
            int i =0;
            int c =0;
            int[] mega = new int[52];
            while (i < 52 )
            {
                c=0;
                int a = r.Next(0,52);
                for (int j = 0; j < 51; j++)
                {
                    if(mega[j] != a)
                    {
                        c++;
                    }

                    if(c == 51)
                    {
                        mega[i] = a;
                        this.cartas[i] = this.cartas[a];
                        i++;
                    }
                }
            }
            
            // int w =1;
            // foreach (int m in mega)
            // {
            //     Console.WriteLine("{0}° Sorteio: {1}",w,m);
            //     w++;
            // }
        }

        public void MostrarCartas()
        {
            for (int i = 0; i < this.cartas.Length; i++)
            {
                this.cartas[i].ImprimirCarta();
            }
        }
        
    }
}