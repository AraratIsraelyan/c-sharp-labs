using System;

namespace Lab4_6_2
{
    class Program
    {
        private static Random rnd = new Random();
            
        public static void createArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = rnd.Next(1, 9);
                }
            }
        }
        
        public static void printArray(string b, int[,] a)
        {
            Console.Write("\n" +  b  + "[" + a.GetLength(0) + ";" + a.GetLength(1) + "]" + ":");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write(" { ");
                    }
                    Console.Write(a[i, j] + "; ");
                }
                Console.Write("}");
            }
        }

        public static int srav(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public static int[,] сумма(int[,] a, int[,] b)
        {
            int x = srav(a.GetLength(0), b.GetLength(0));
            int y = srav(a.GetLength(1), b.GetLength(1));
            
            int[,] s = new int[x,y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    s[i, j] = a[i, j] + b[i, j];
                }
            }
            
            return s;
        }
        
        public static int[,] вычитание(int[,] a, int[,] b)
        {
            int x = srav(a.GetLength(0), b.GetLength(0));
            int y = srav(a.GetLength(1), b.GetLength(1));
            
            int[,] s = new int[x,y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    s[i, j] = a[i, j] - b[i, j];
                }
            }
            
            return s;
        }
        
        public static int[,] произведение(int[,] a, int b)
        {
            int[,] s = new int[a.GetLength(0),a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s[i, j] = a[i, j] * b ;
                }
            }
            
            return s;
        }
        
        public static int[,] деление(int[,] a, int b)
        {
            int[,] s = new int[a.GetLength(0),a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s[i, j] = a[i, j] / b ;
                }
            }
            
            return s;
        }
        
        
        static void Main()
        {
            Console.WriteLine($"Введите размерность массива: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            
            int[,] mas1 = new int[rnd.Next(2,6),rnd.Next(2,6)];
            int[,] mas2 = new int[rnd.Next(2,6),rnd.Next(2,6)];
            
            createArray(mas1); 
            createArray(mas2);
            
            printArray("1 MaccuB: ",mas1);
            printArray("2 MaccuB: ", mas2);

            int[,] r1 = сумма(mas1, mas2);
            printArray("Cymma maccuBoB: ", r1);
            
            int[,] r2 = вычитание(mas1, mas2);
            printArray("Pa3HocTb maccuBoB: ", r2);
            
            int[,] r3 = произведение(mas1, 3);
            printArray("Умножение на число: ", r3);
            
            int[,] r4 = деление(mas2, 3);
            printArray("Деление на число: ", r4);
            
            Console.WriteLine();
            Console.WriteLine("Введите индексы элементов");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x >= mas1.GetLength(0) || y >= mas1.GetLength(1))
            {
                Console.WriteLine("Bblxod 3a llpedel maccuBa");
            }
            else
            {
                Console.WriteLine($"3Ha4eHue MaccuBa B T04KE [{x};{y}] = {mas1[x,y]}");
            }

        }
    }
}