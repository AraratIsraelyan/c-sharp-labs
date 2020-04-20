using System;

namespace Lab8
{
    class Program
    {
        struct Train
        {
            public int trainNumber;
            public string message;
            public int vansQuantity;

            public Train(int a, string b, int c)
            {
                this.trainNumber = a;
                this.message = b;
                this.vansQuantity = c;
            }
            
            public override string ToString() {
                return $"Отправление поездов:\n\tНомер: {trainNumber}\tСообщением: {message}\tКоличество вагонов: {vansQuantity}";
            }
        }
        
        static void Main(string[] args)
        {
            Train obj1 = new Train(809,"Минеральные Воды - Ростов-на-Дону",5);
            Console.WriteLine(obj1.ToString());
            
        }
    }
}