using System;

namespace Z3
{
    class Program
    {
        public static void Method(double a, out int sign, out bool isInteger, out double abs, out double sqr)
        {
            sign = Math.Sign(a);
            isInteger = a % 1 == 0 ? true : false;
            abs = Math.Abs(a);
            sqr = a * a;
            
        }
        
        static void Main()
        {
            double a = 42;
            double b = -12.67;

            double c, d;
            int i;
            bool tf;
            
            Method(a, out i, out tf, out c, out d);
            Console.WriteLine($"Число: {a}\nЗнак числа {i}; Целое: {tf}, Модуль числа: {c}, Квадрат числа: {d}");
            Method(b, out i, out tf, out c, out d);
            Console.WriteLine($"Число: {b}\nЗнак числа {i}; Целое: {tf}, Модуль числа: {c}, Квадрат числа: {d}");
        }
    }
}