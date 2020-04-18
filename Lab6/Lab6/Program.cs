using System;

namespace Lab6
{
    class Program
    {
        class Example
        {
            public static void Sqr(double a, double b, string name)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                Console.WriteLine($"В методе {name}:\na = {a}\tb = {b}");
            }

            public int x;
            public int y;

            public Example(int x)
            {
                this.x = x;
                Console.WriteLine($"Example: {x}");
            }

            public static void Init(Example a)
            {
                Example var = a;
                a.x = 1;
                a.y = 1;
                var.x = 1024;
                var.y = 2048;
                Console.WriteLine($"В методе Init: {a.x}");
                Console.WriteLine($"В методе Init: {a.y}");
            }
            
        }
        static void Main(string[] args)
        {
            double a = 1.25;
            double b = 2.25;
            Console.WriteLine($"В методе Main:\na = {a}\t b = {b}");
            Example.Sqr(a,b, "Sqr");
            Example.Sqr(a*2, b*2, "Sqr^2");
            
            Console.WriteLine();
            Example parametr = new Example(0);
            Example.Init(parametr);
            // По заданию 
            /*
            Example Obj = new Example(0);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
            Example.Init(Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
            */
            

            
            
            
        }
    }
}