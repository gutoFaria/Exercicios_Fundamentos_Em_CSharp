using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ajustar hora do relogio");
            Console.Write("Informe as horas no formato de dois número exemplo(07 ou 12): ");
            int hora = int.Parse(Console.ReadLine());
            Console.Write("Informe os minutos entre 0 e 60: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.Write("Informe os segundos entre 0 e 60: ");
            int segundos = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora Informada: " + hora +":"+minutos+":"+segundos);

            Relogio r = new Relogio();
            r.AcertaRelogio(hora,minutos,segundos);
            
        }
    }

    class Relogio
    {
        Ponteiro ponteiroSegundo = new Ponteiro();
        Ponteiro ponteiroMinuto = new Ponteiro();
        Ponteiro ponteiroHora = new Ponteiro();

        Ponteiro horaAtual = new Ponteiro();

        public void AcertaRelogio(int hora,int minuto,int segundo)
        {
           hora = int.Parse(LerHora());
           ponteiroHora.posicao = hora;
           minuto = int.Parse(LerMinuto());
           ponteiroMinuto.posicao = minuto;
           segundo = int.Parse(LerSegundo());
           ponteiroSegundo.posicao = segundo;

           horaAtual.PrintPonteiro(ponteiroHora.posicao,ponteiroMinuto.posicao,ponteiroSegundo.posicao);
        }

        public string  LerHora()
        {
            return DateTime.Now.ToString("HH");
        }

        public string LerMinuto()
        {
            return DateTime.Now.ToString("mm");
        }

        public string LerSegundo()
        {
            return DateTime.Now.ToString("ss");
        }
    }

    class Ponteiro
    {
        public int posicao;

        public void PrintPonteiro(int hora ,int minuto,int segundo)
        {
            Console.WriteLine("Hora Atual: "+hora+":"+minuto+":"+segundo);
        }
    }
}
