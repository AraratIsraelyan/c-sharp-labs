using System;
using System.Runtime.CompilerServices;

namespace Part_3___task_1
{
    class Program
    {
        class List
        {
            public int number;

            public List(int a)
            {
                this.number = a;
            }
            public override string ToString() {
                return $"[{number}]";
            }
        }

        class listItems
        {
            public int houseNumber;
            
            public override string ToString() {
                return $"[{houseNumber}]";
            }
        }
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}