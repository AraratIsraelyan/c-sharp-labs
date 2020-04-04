using System;

namespace lab3
{
    class Arr
    {
        private static Random rnd = new Random();

        public static void CreateOneDimAr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = rnd.Next(1, 99);
        }

        public static void PrintArr1(string b, int[] a)
        {
            //b = "Название массива";
            Console.Write(b);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 99);
                Console.Write(" " + a[i] + ";");
            }
            Console.WriteLine();
        }
        
        static void Main()
        {
            // Задание 1
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            
            Arr.CreateOneDimAr(A);
            Arr.CreateOneDimAr(B);
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            Arr.PrintArr1("Массив А:",a:A);
            Arr.PrintArr1("Массив В:",a:B);
            Arr.PrintArr1("Массив С:",a:C);







            Console.WriteLine("\nHello World!");
        }
    }
}