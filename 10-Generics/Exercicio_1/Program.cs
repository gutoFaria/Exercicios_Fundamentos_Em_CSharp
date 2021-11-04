using System;
using System.Text;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Lista<int> l = new Lista<int>();

            // l.Adicionar(10);
            // l.Adicionar(20);
            // l.Adicionar(30);

            // int e1 = l.Ler(0);
            // int e2 = l.Ler(1);
            // int e3 = l.Ler(2);

            // Console.WriteLine(e1 + " " + e2 +" "+ e3);

            // Creator<StringBuilder> c1 = new Creator<StringBuilder>();
            // StringBuilder sb = c1.Create();

            // Creator<int> c2 = new Creator<int>();
            // int s = c2.Create();

            ServiceFactory<MyClass> teste = new ServiceFactory<MyClass>();

            MyClass s = teste.NewInstance();
        }

        public class ServiceFactory<T> where T : class,IService , new()
        {
            public T NewInstance()
            {
                T obj = new T();
                obj.Execute();
                return obj;
            }
        }

        public interface IService
        {
            void Execute();
        }

        public class MyClass : IService
        {
            public void Execute()
            {
                Console.WriteLine("Executado");
            }
        }
    }
}
