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

            public enum typeTrain: byte
            {
                Скорый_поезд,
                Пассажирский_поезд,
                Товарный_поезд
            }

            public typeTrain tp;

            public Train(int a, string b, int c, typeTrain s)
            {
                this.trainNumber = a;
                this.message = b;
                this.vansQuantity = c;
                this.tp = (typeTrain)s;
            }
            
            public override string ToString() {
                return $"Отправление поездов:\n\tНомер: {trainNumber}\tСообщением: {message}\n\tКоличество вагонов: {vansQuantity}\tтип: {tp}";
            }
        }
        
        static void Main(string[] args)
        {
            Train obj1 = new Train(809,"Минеральные Воды - Ростов-на-Дону",5,0);
            Console.WriteLine(obj1.ToString());
            
        }
    }
}