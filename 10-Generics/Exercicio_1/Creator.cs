using System;

namespace Exercicio_1
{
    public class Creator<T> where T : class, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}