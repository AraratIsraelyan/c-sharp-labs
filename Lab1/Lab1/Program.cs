using System;
using System.Globalization;

namespace Lab1


     {
    class Zadanie1
    {
        enum gradus : int //перечисления (набор логически связанных констант
        {
            min = 0,
            krit = 72,
            max = 100,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            
            //  2-1
            int i=10;	                    //объявление и инициализация целочисленной переменной i
            Console.WriteLine(i);		    //просмотр значения переменной
            i=100;		                    //изменение значение переменной
            Console.WriteLine(i);
            
            //  2-2
            int j;	                        //объявление и инициализация целочисленной переменной j
            j = 10;                         
            Console.WriteLine(j);		    //просмотр значения переменной
            
            //  2-3
            const int k=10;	            //объявление целочисленной константы j
            Console.WriteLine(k);		//просмотр значения константы
            //k=100;		            //ошибка
            Console.WriteLine(k);
            
            //  2-3
            Console.WriteLine("минимальная температура=" + (int) gradus.min);
            Console.WriteLine("критическая температура=" + (int) gradus.krit);
            Console.WriteLine("максимальная температура=" + (int) gradus.max);
            //  Console.WriteLine("x={0} y={1}, x, y");        // дополнительно
            
            //  2-4
            /*
            Console.WriteLine("C Format (денежный):{0,44:C} \t{0:C2}", 12345.678); 
            Console.WriteLine("D Format (целочисленный):{0,31:D} \t{0:D6}", 123);
            Console.WriteLine("E Format (экспоненциальное представление чисел):{0,18:E} \t{0:E8}", 12345.6789);
            Console.WriteLine("G Format (общий формат / с фиксированной точкой):{0,14:G} \t{0:G10}", 12345.6789);
            Console.WriteLine("N Format (стандартное форматирование):{0,25:N}\t{0:N5}", 12345.6789);
            Console.WriteLine("X Format (шестнадцатиричный):{0,27:X} ", 1234);
            Console.WriteLine("P Format (процентный):{0,39:P} ", 0.9);
            */
            
            // Задание 2-5
            //Ввод данных с клавиатуры
            Console.Write("Введите строку:");
            string s = Console.ReadLine();
            Console.WriteLine("Вы ввели: {0} ", s);
            
            //  Задание 1
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            //int a = Console.ReadLine();
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            
            int c = a + b;
            Console.WriteLine("Сумма чисел а и b равна {0} + {1} = {2}",a, b, c);
            
            // Задание 2
            Console.Write("Введите l: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = l + m + n;
            Console.WriteLine("Сумма чисел а, b, c равна {0} + {1} + {2} = {3}", l, m, n, sum);
            String summ = Convert.ToString(s);
            //Console.WriteLine(s);
            string reverse = string.Empty;
            for (int ii = summ.Length - 1; ii > -1; ii--)
                reverse += summ[ii];
            //Console.WriteLine(reverse);
            Console.WriteLine("Сумма чисел а, b, c в обратном порядке равна {0} + {1} + {2} = {3}", l, m, n, reverse);
            
            // Задание 3
            Console.Write("Введите a: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            int c1 = int.Parse(Console.ReadLine());
            int s1 = a1 + b1 + c1;
            Console.WriteLine("Сумма чисел а, b, c равна {0} + {1} + {2} = {3}", a1, b1, c1, s1);
            
            // Задание 4
            Console.Write("Введите вещественное число a : ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число b : ");
            double b2 = double.Parse(Console.ReadLine());
            double p = a2 * b2;
            Console.WriteLine("Произведение чисел а, b равна {0:#.#} + {1:#.#} = {2:#.#}", a2, b2, p);
            
            // Задание 5
            Console.Write("Введите вещественное число a : ");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число b : ");
            double b3 = double.Parse(Console.ReadLine());
            double s3 = a3 / b3;
            Console.WriteLine("Результат деления чисел а, b, c равна {0} / {1} = {2:#.##}", a3, b3, s3);
            
            // Задание 6
            Console.Write("Введите вещественное число a : ");
            double a4 = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число b : ");
            double b4 = double.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число c : ");
            double c4 = double.Parse(Console.ReadLine());
            double s4 = a4 / b4;
            Console.WriteLine("( {0:#.##} + {1:#.##} ) + {2:#.##} = {0:#.##} + ( {1:#.##}  + {2:#.##} )", a4, b4, c4);
            
        }
    }
}
