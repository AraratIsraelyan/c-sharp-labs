using System;

namespace Part_2__task_1
{
    class Program
    {
        class Train
        {
            public int trainNumber;
            public string message;
            public int vansQuantity;

            public Train(int trainNumber, string message, int vansQuantity)
            {
                this.trainNumber = trainNumber;
                this.message = message;
                this.vansQuantity = vansQuantity;
            }

            public int TrainNumber
            {
                get => trainNumber;
            }

            public string Message
            {
                get => message;
            }

            public int VansQuantity
            {
                get => vansQuantity;
            }

            public override string ToString() {
                return $"Отправление поездов:\n\tНомер: {trainNumber}\tСообщением: {message}\tКоличество вагонов: {vansQuantity}";
            }
        }

        class FirmTrain : Train
        {
            public string nameFirm;
            public double kPrice;
            
            public FirmTrain(int trainNumber, string message, int vansQuantity, string nameFirm, double kPrice) : base(trainNumber, message, vansQuantity)
            {
                this.trainNumber = trainNumber;
                this.message = message;
                this.vansQuantity = vansQuantity;
                this.nameFirm = nameFirm;
                this.kPrice = kPrice;
            }
            public override string ToString() {
                return $"Отправление поездов:\n\tНомер: {trainNumber}\tСообщением: {message}\tКоличество вагонов: {vansQuantity}" +
                       $"\tФирменное название: {nameFirm}\tКоэффицент удорожание: {kPrice}";
            }

        }
        
        static void Main(string[] args)
        {
            Train obj1 = new Train(809,"Минеральные Воды - Ростов-на-Дону",5);
            Console.WriteLine(obj1.ToString());
            
            FirmTrain obj2 = new FirmTrain(809,"Минеральные Воды - Ростов-на-Дону",5,"Ласточка", 1.3);
            Console.WriteLine(obj2.ToString());

        }
    }
}