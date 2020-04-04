using System;
using System.Diagnostics;

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
            Console.Write(b + "[" + a.Length + "]" + " {");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i] + ";");
            }
            Console.Write(" }\n");
        }

        public static int[,] MultMatrix(int[,] a, int[,] b)
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(0)];
            for (int i = 0; i < b.GetLength(1); i++)
            {
                for (int j = 0; j < b.GetLength(0); j++)
                {
                    r[i, j] = 0;
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i,k] * b[k,j];
                    }
                    //Console.Write(r[i, j] + "; ");
                }
            }
            return r;
        }

        public static void printMultidimensionalArray(string b, int[,] a)
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
        
        public static void createMultidimensionalArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = rnd.Next(1, 99);
                }
            }
        }
        
        public static void createArrayOfArrays(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = rnd.Next(1, 99);
                }
            }
        }
        public static void printArrayOfArrays(string b, int[][] a)
        {
            Console.WriteLine(b + ":");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"   [{i};{j}]{a[i][j], 5}");
                    
                }
                Console.WriteLine();
            }
        }

        public static void PrintAnyArr0(string b, Array a)
        {
            Console.Write($"PrintAnyArr {b}");
            if (a.Rank == 1)
            {
                Console.Write("[" + a.Length + "]" + " {");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(" " + a.GetValue(i) + ";");
                }
                Console.Write(" }\n");
            }

            if (a.Rank == 2)
            {
                Console.Write("[" + a.GetLength(0) + ";" + a.GetLength(1) + "]" + ": ");
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(" { ");
                        }
                        Console.Write(a.GetValue(i,j) + "; ");
                    }
                    Console.Write("}");
                }
                Console.WriteLine();
            }
        }
        
        public static void PrintAnyArr1(string b, Array a)
        {
            
            if (a.Rank == 1)
            {
                if (a.GetValue(0) is Array)
                {
                    int k = 0;
                    foreach (Array a1 in a)
                    {
                        PrintAnyArr1(b + k.ToString(), a1);
                        //Console.Write(k.ToString() +  a1);
                        k++;
                    }
                }
                else
                {
                    //Console.Write($"PrintAnyArr2 {b}");
                    Console.Write($"[{a.Length}]"+" { "); 
                    foreach (var a1 in a)
                    {
                        Console.Write(a1 + "; ");
                    }

                    Console.WriteLine("}");
                }
            }

            if (a.Rank == 2)
            {
                Console.Write($"PrintAnyArr2 {b}");
                Console.Write("[" + a.GetLength(0) + ";" + a.GetLength(1) + "]" + ":  { ");
                foreach (var a1 in a)
                {
                    Console.Write(a1 + "; ");
                }
                Console.WriteLine(" }");
            }
        }
        
        public static void PrintObject(string b, Object a)
        {
            Console.Write(b);
            Array arr = a as Array;
            foreach (object a1 in arr)
            {
                Console.Write(a1 + "; ");
            }
        }

        /********/
        public static void PrintArObj(string name, object[] A)
        {
            if (A.Rank == 1)
            {
                if (A.GetValue(0) is Array)
                {
                    int k = 0;
                    foreach (Array a1 in A)
                    {
                        PrintAnyArr1(name + k.ToString(), a1);
                        k++;
                    }
                }
                else
                {
                    Console.Write($"[{A.Length}]"+" { "); 
                    foreach (var a1 in A)
                    {
                        Console.Write(a1 + "; ");
                    }

                    Console.WriteLine("}");
                }
            }

            if (A.Rank == 2)
            {
                Console.Write($"PrintArObj {name}");
                Console.Write("[" + A.GetLength(0) + ";" + A.GetLength(1) + "]" + ":  { ");
                foreach (var a1 in A)
                {
                    Console.Write(a1 + "; ");
                }
                Console.WriteLine(" }");
            }
        }

        /*********/

        static void changeIndex(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, a.Length);
            }
        }
        

        static void Main()
        {
            
                        int[] A = new int[5];
                        int[] B = new int[5];

                        Arr.CreateOneDimAr(A);
                        Arr.CreateOneDimAr(B);

                        Arr.PrintAnyArr0("Массив А", a: A);
                        Console.WriteLine();
                        Arr.PrintAnyArr0("Массив В", a: B);
                        Console.WriteLine();
                        Console.Write($"PrintAnyArr2 Массив А");
                        Arr.PrintAnyArr1("Массив А", a: A);
                        Console.WriteLine();
                        Console.Write($"PrintAnyArr2 Массив В");
                        Arr.PrintAnyArr1("Массив В", a: B);
                        
                        Console.WriteLine();
                     
                        int[,] firstMatrix = new int[3,3];
                        int[,] secondMatrix = new int[3,3];
                        
                        Arr.createMultidimensionalArray(firstMatrix);
                        Arr.createMultidimensionalArray(secondMatrix);
                        
                        Arr.PrintAnyArr0("First Matrix", firstMatrix);
                        Console.WriteLine();
                        Arr.PrintAnyArr1("First Matrix", firstMatrix);
                        Console.WriteLine();
                        Arr.PrintAnyArr0("Second Matrix", secondMatrix);
                        Console.WriteLine();
                        Arr.PrintAnyArr1("Second Matrix", secondMatrix);
                        Console.WriteLine();
                        Arr.PrintAnyArr0("Mult", Arr.MultMatrix(firstMatrix, secondMatrix));
                        
                        Console.WriteLine("\n");
                    
                        int[][] arrayOfArrays = 
                        {
                            new int[1],
                            new int[2],
                            new int[3],
                            new int[4],
                            new int[5],
                            new int[6],
                            new int[7],
                            new int[8],
                            new int[9],
                            new int[10],
                        };
                        Arr.createArrayOfArrays(arrayOfArrays);
                        //Arr.printArrayOfArrays("ArrayofArrays", arrayOfArrays);
                        //Arr.PrintAnyArr0("Массив массивов: ", arrayOfArrays);
                        Arr.PrintAnyArr1("Массив массивов: ", arrayOfArrays);

                        Console.WriteLine();

                        int[] primary = new int[9] {1, 2, 3, 4, 5, 6, 7, 8, 9};
                        Arr.PrintAnyArr0("Primary ", primary);
                        int[] copy = new int[9];
                        Array.Copy(primary,copy,9);
                        Arr.PrintAnyArr0("Copy ", copy);
                       Console.WriteLine("IndexOf 2: " + Array.IndexOf(copy, 2));
                       Console.WriteLine("LastIndexOf 9: " + Array.LastIndexOf(copy, 9));
                       Array.Reverse(copy);
                       Arr.PrintAnyArr0("Reverse copy: ", copy);
                       Array.Sort(copy); 
                       Arr.PrintAnyArr0("Sort copy: ", copy);
                       Console.WriteLine("BinarySearch copy: " + Array.BinarySearch(copy, 5));
                       
                       Console.WriteLine();
                       
                       //используем firstMatrix
                       Console.WriteLine("Возвращаем к-во элементов матрицы: " + firstMatrix.Length);
                       Console.WriteLine("Возвращаем к-во элементов 1-го измерения матрицы: " + firstMatrix.GetLength(1));
                       
                       //Arr.PrintObject("Primary: ", primary);
                       
                       Console.WriteLine();
                       Arr.PrintObject("(object) Массив В ", a: B);
                       Console.WriteLine();
                       
                       
                       Console.WriteLine("\n PrintArObj:");
                       string[] str = new string[9] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
                       Arr.PrintArObj("Массив A", str);
                       Arr.PrintArObj("Массив массивов: ", arrayOfArrays);
                       //Arr.PrintArObj("First Matrix", firstMatrix);
                       
                       
                       
        }
    }
}