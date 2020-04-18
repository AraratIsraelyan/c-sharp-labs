using System;

namespace Z5
{
    class Program
    {
        public static double Avarge1(int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av/arr.Length);
        }
        
        public static double Avarge2(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                
                av += elem;
            return (av/arr.Length);
        }
        
        public static double Avarge3(ref int a, params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av/arr.Length);
        }

        public static void Avarge4(params char[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 'F';
            }

            Console.Write("Char[] a: {");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "; ");
            }

            Console.WriteLine("}");
        }

        public static void TypeOfObject(Object a)
        {
            Console.WriteLine(a.GetType());
        }
        
        
        static void Main(string[] args)
        {
            int[] a = new int[] {1,2,3,4};
            Console.WriteLine($"Avarge1: {Avarge1(a)}");

            short sh1 = 1, sh2 = 12; 
            byte bt = 107;
            Console.WriteLine("Avarge2: " + Avarge2(sh1,sh2,bt));
            
            int b0 = 10, b1 = 20, b2 = 30, b3 = 40, b4 = 50;
            Console.WriteLine("Avarge3: " + Avarge3(ref b0, b1, b2, b3, b4));

            char[] message = {'S', 'T', 'A', 'Y', ' ', 'H', 'O', 'M', 'E', '!'};
            Avarge4(message);
            
            TypeOfObject(message);
        }
    }
}