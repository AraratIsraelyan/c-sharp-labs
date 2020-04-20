using System;

namespace Part_2___task_4
{
    class Program
    {
        static void Main()
        {
            Int16 i16 = 16, x;
            Int32 i32 = 32, y;
            double db = 1122.63, db1, db2;
            
            Console.WriteLine($"Любой целочисленный тип можно неявно преобразовать в любой числовой тип с плавающей запятой.\n 1 преобразование Int16->double: {db1 = i16}");
            Console.WriteLine($" 2 преобразование Int32->double: {db2 = i32}");
            Console.WriteLine($" 3 преобразование Int16->Int32: {y = i16}");
            Console.WriteLine($" 4 преобразование Int32->Int16: x = i32 -  не поддерживается, так как диапазон исходного числа больше");
            Console.WriteLine($" 5 преобразование double -> Int16: x = db - не поддерживается, так как из типов double и decimal не поддерживается неявное преобразование");
            Console.WriteLine($" 6 преобразование double -> Int32: y = db - не поддерживается");
            
            Console.WriteLine("\nПочему? Потому что нужно читать документацию:" +
                              "https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions");
        }
    }
}