using System;
namespace Exercicio_2
{
    public class Data
    {
        private int dia ;
        private int mes ;
        private int ano ;
        private int hora ;
        private int minuto ;
        private int segundo ;
        Data(int dia , int mes ,int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data(int dia,int mes,int ano,int hora,int minuto,int segundo) : this(dia, mes, ano)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo; 
        }

        public void Imprimir()
        {
            Console.Write("Data: ");
            Console.Write(this.dia+"/"+this.mes+"/"+this.ano);
            Console.WriteLine("");
            Console.Write("Hora: "+this.hora+":"+this.minuto+":"+this.segundo);
        }

    }
}