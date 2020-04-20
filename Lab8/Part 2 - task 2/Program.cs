using System;

namespace Part_2___task_2
{
    class Program
    {
        class BigClass : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
            
        }
        class SmallClass : IComparable
        {
            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        //По умолчанию методы (что тот, что другой) не реализованы, предполагая, что
        //я реализую их сам в дальнейшем
    }
}