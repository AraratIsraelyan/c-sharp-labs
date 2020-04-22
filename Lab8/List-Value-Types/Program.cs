using System;

namespace List_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte sb = 127;
            Byte bt = 255;
            Int16 i16 = 16;
            Int32 i32 = 32;
            Int64 i64 = 64;
            String s = "";
            Exception ex = new Exception();
            Object[] types = {sb, bt, i16, i32, i64, s, ex};
            
            Type t = types.GetType();
            bool flag = false;
            foreach (var a1 in types)
            {
                Console.WriteLine($"{a1.GetType()}:\t{a1.GetType().IsValueType}");
            }
            /*
                ВЫВОД:
             Типы String и Exception не являются значимыми
             */
            Console.WriteLine("Hello World!");
        }
    }
}