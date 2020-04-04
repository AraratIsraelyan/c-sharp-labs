using System;
using System.Diagnostics;

namespace Lab2_1
{
    internal class Program
    {
        public static void Main()
        {
            //ЗАДАНИЕ К6
             // for (int i = 6; i <= 10; i++, Console.WriteLine())
             // {
             //     for (int j = 10; j >= i; j--)
             //         Console.Write(" " + i);
             // }
            
            //ЗАДАНИЕ К5

          //   int a = 1;
          //   int b = 99;
          // Console.WriteLine("Диапазон значений: " +"(" + a + ";" + b+ ")");
          //
          //   Console.Write("while ");
          //   while (a < b)
          //   {
          //       if (a % 2 == 0)
          //           Console.Write("{0} ", a);
          //       a++;
          //   }
          //   Console.WriteLine();
          //   
          //   a = 1;
          //   b = 99;
          //   Console.Write("do while ");
          //   do
          //   {
          //       if (a % 2 == 0)
          //           Console.Write("{0} ", a);
          //       a++;
          //   }
          //   while (a < b);
          //   Console.WriteLine();
          //   
          //   a = 1;
          //   b = 99;
          //   Console.Write("for ");
          //   for (int i = a; i < b; i++)
          //   {
          //       if (i % 2 == 0)
          //           Console.Write("{0} ", i);
          //   }
          
            // Задание К4
           
            
            // int g=0;
            // Console.WriteLine("УСТАНОВКА ДАТЫ");
            // Console.Write("Введите день:");
            // int d = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Введите месяц:");
            // int m = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Введите год:");
            // int y = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Дата " + d + ":" + m + ":" + y);
            // Console.Write("Введите кол-во прошедших месяцев: ");
            // int k = Convert.ToInt32(Console.ReadLine());
            // g = (k + m) / 12;
            // m = (k + m) % 12;
            // //Console.WriteLine(g);
            // switch (m)
            // {
            //     case 0: Console.WriteLine("Месяц - декабрь, дата: {0}:12:{1}", d, y - g); break;
            //     case 1: Console.WriteLine("Месяц - январь, дата: {0}:01:{1}", d, y - g); break;
            //     case 2: Console.WriteLine("Месяц - февраль, дата: {0}:02:{1}", d, y - g); break;
            //     case 3: Console.WriteLine("Месяц - март, дата: {0}:03:{1}", d, y - g); break;
            //     case 4: Console.WriteLine("Месяц - апрель, дата: {0}:04:{1}", d, y - g); break;
            //     case 5: Console.WriteLine("Месяц - май, дата: {0}:05:{1}", d, y - g); break;
            //     case 6: Console.WriteLine("Месяц - июнь, дата: {0}:06:{1}", d, y - g); break;
            //     case 7: Console.WriteLine("Месяц - июль, дата: {0}:07:{1}", d, y - g); break;
            //     case 8: Console.WriteLine("Месяц - август, дата: {0}:08:{1}", d, y - g); break;
            //     case 9: Console.WriteLine("Месяц - сентябрь, дата: {0}:09:{1}", d, y - g); break;
            //     case 10: Console.WriteLine("Месяц - октябрь, дата: {0}:10:{1}", d, y - g); break;
            //     case 11: Console.WriteLine("Месяц - ноябрь, дата: {0}:11:{1}", d, y - g); break;
            //     default:
            //         Console.WriteLine("error"); break;
            // }
            
            
            
            
            
            // //Задание К3
            
            // Console.Write("Введите х: ");
            // float x = float.Parse(Console.ReadLine());
            // Console.Write("Введите y: ");
            // float y = float.Parse(Console.ReadLine());
            // if ((x > 40 || x < -40) || (y > 40 || y < -40))
            // {
            //     Console.WriteLine("Точка {0};{1} лежит внутри заштрихованной области", x , y);
            // }
            // else if ((x < 40 & x > -40) & (y < 40 & y > -40))
            // {
            //     Console.WriteLine("Точка {0};{1} лежит вне заштрихованной области", x , y);
            // }
            // else Console.WriteLine("Точка {0};{1} лежит на заштрихованной области", x , y);
            
            
            //Задание К2
            
            // Console.Write("Введите число: a= "); float a = float.Parse(Console.ReadLine());
            // if (a % 2 == 0 )
            // {
            //     Console.WriteLine("Чётное");
            // }
            // else {Console.WriteLine("Нечётное");}

            
            //Задание К1  //181,5
            
            // Console.Write("Введите площадь полной поверхности куба: S= "); double S = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ребро куба равно " + Math.Sqrt(S/6));
           
            
            
            //Задача Д-2.4
            
            // Console.Write("Введите длину прямоугольника: "); int a = int.Parse(Console.ReadLine());
            // Console.Write("Введите ширину прямоугольника: "); int b = int.Parse(Console.ReadLine());
            // int s = a * b;
            // int x1;
            // int n;
            // Console.WriteLine("Выберите, каким способом выполнить поиска количества квадратов: \n 1) наименьшая площадь" +
            //               "\n 2) наибольшая площадь  "); int z = int.Parse(Console.ReadLine());
            // switch (z)
            // {
            //     case 1:
            //         Console.Write("Введите наименьшую площадь: ");
            //         x1 = int.Parse(Console.ReadLine());
            //         while (x1 > s)
            //         {
            //             Console.Write("ОШИБКА! Введите наименьшую площадь: ");
            //             x1 = int.Parse(Console.ReadLine());
            //         }
            //
            //         Console.WriteLine("Наименьшая площадь: " + x1);
            //         Console.WriteLine("Количество квадратов: " + (n = s / x1) );
            //         break; 
            //     case 2:
            //         Console.Write("Введите наибольшую площадь: ");
            //         x1 = int.Parse(Console.ReadLine());
            //         while (x1 >= s)
            //         {
            //             Console.Write("ОШИБКА! Введите наибольшую площадь: ");
            //             x1 = int.Parse(Console.ReadLine());
            //         } 
            //         Console.WriteLine("Наибольшая площадь: " + x1);
            //         Console.WriteLine("Количество квадратов: " + (n = s / x1) );
            //         break;
            // }
            
            
            // Задача Д-2.3
            
            // int k;
            // for (int i = 1; i < 10; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         for (int y = 0; y < 10; y++)
            //         {
            //             if ((i * 100 + j * 10 + y) == (Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(y, 3)))
            //             {
            //                 k = i * 100 + j * 10 + y;
            //                 Console.Write(k + "; ");
            //             }
            //         }
            //     }
            // }
            
            // Задача Д-2.3  2Й СПОСОБ
            
            // for (int i = 100; i < 1000; i++)
            //              {
            //                  int a = i / 100;
            //                  int b = i % 100 / 10;
            //                  int c = i % 10;
            //                  
            //                  if (i == (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3)))
            //                  {
            //                      Console.Write(i + "; ");
            //                  }
            //              }
            
            
            // Задача Д-2.2
            
            // Console.Write("Введите день: "); int d = int.Parse(Console.ReadLine());
            // Console.Write("Введите месяц: "); int m = int.Parse(Console.ReadLine());
            // Console.Write("Введите год: "); int y = int.Parse(Console.ReadLine());
            // int days = m * 30 + d;
            // Console.WriteLine("1) С начала года прошло " + days + " дней");
            // Console.WriteLine("2) До конца года " + (365 - days) + " дней");
            //
            // if ((d - 1) == 0)
            // {
            //     if (m == 1)
            //     {
            //         Console.WriteLine("3) Дата предыдущего дня 29.12." + (y - 1));
            //     }
            //     else Console.WriteLine("3) Дата предыдущего дня 29." + (m - 1) + "." + y );
            // }
            // else 
            //     Console.WriteLine("3) Дата предыдущего дня " + (d - 1) + "." + m + "." + y);
            //
            // if (d  == 30)
            // {
            //     if (m == 12)
            //     {
            //         Console.WriteLine("4) Дата следующего дня 01.01." + (y + 1));
            //     }
            //     else Console.WriteLine("4) Дата следующего дня 01." +  (m+1) + "." + y);
            // }
            // else 
            //     Console.WriteLine("4) Дата следующего дня " + (d + 1) + "." + m + "." + y);
            
            
            //Задача Д-2.1

            Console.Write("Введите размер шахматной доски в клетках: "); int n = int.Parse(Console.ReadLine());
            int black = 0;
            Console.Write("Введите номер ячейки k1 по горизонтали: "); int k = int.Parse(Console.ReadLine());
            Console.Write("Введите номер ячейки m1 по вертикали: "); int m = int.Parse(Console.ReadLine());
            Console.Write("Введите номер ячейки k2 по горизонтали: "); int k2 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер ячейки m2 по вертикали: "); int m2 = int.Parse(Console.ReadLine());
            int kb = 0;
            int k1b = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if ((i % 2 == 0))
                {
                    for (int j = 2; j <= n; j+=2)
                    {
                        black++;
                        //Console.Write(" " + i + ";" + j + " | ");
                        if (i == k & j == m)
                        {
                            kb = 1;
                        }
                        if (i == k2 & j == m2)
                        {
                            k1b = 1;
                        }
                        
                    }
                }
                else
                {
                    for (int j = 1; j <= n; j+=2)
                    {
                        black++;
                        //Console.Write(" " + i + ";" + j + " | ");
                        if (i == k & j == m)
                        {
                            kb = 1;
                        }
                        if (i == k2 & j == m2)
                        {
                            k1b = 1;
                        }
                    }
                    
                }
                
            } 
            
            
            
            Console.WriteLine("1) Количество чёрных ячеек доски равно " + black );
            
            if (kb == 1)
            {
                Console.WriteLine("2) Цвет ячейки " + k + ";" + m + " чёрный" );
            }
            else Console.WriteLine("2) Цвет ячейки " + k + ";" + m + " белый" );
            
            if (k1b == kb)
            {
                Console.WriteLine("3) Ячейки " + k + ";" + m + " " + k2 + ";" + m2 +  " одинакового цвета" );
            }
            else Console.WriteLine("3) Ячейки " + k + ";" + m + " " + k2 + ";" + m2 + " разного цвета" );
            
            if ((k + 1 == k2 & m + 1 == m2) || (k - 1 == k2 & m - 1 == m2) || (k - 1 == k2 & m + 1 == m2) ||
                (k + 1 == k2 & m - 1 == m2))
            {
                Console.WriteLine("4) a) Фигуру бьёт пешка");
            }
            
            if (k == k2 || m == m2)
            {
                Console.WriteLine("4) в) Фигуру бьёт ладья");
            }
            
            if ((k + 2 == k2 & m + 1 == m2) || (k + 2 == k2 & m + 1 == m2) || 
                (k - 2 == k2 & m - 1 == m2) || (k - 2 == k2 & m + 1 == m2) || 
                (k - 1 == k2 & m + 2 == m2) || (k + 1 == k2 & m + 2 == m2) ||
                (k + 1 == k2 & m - 2 == m2) || (k - 1 == k2 & m - 2 == m2))
            {
                Console.WriteLine("4) e) Фигуру бьёт конь");
            }
            
            if (((k + m) % 2 == (k2 + m2) % 2) && (Math.Abs(k + m) == Math.Abs(k2 + m2)))
            {
                Console.WriteLine("4) b) Фигуру бьёт слон");
            }
            
            if ((((k + m) % 2 == (k2 + m2) % 2) && (Math.Abs(k + m) == Math.Abs(k2 + m2))) || (k == k2 || m == m2))
            {
                Console.WriteLine("4) e) Фигуру бьёт ферзь");
            }
            

            //Console.WriteLine("\nHello world;");

        }
    }
}