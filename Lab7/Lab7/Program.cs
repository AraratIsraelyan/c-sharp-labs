using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Lab7
{
    class Program
    {
        class Person
        {
            private string fam;
            private string status;
            private int salary;
            private int age;
            private string health;

            public Person()
            {
                this.fam = "";
                this.status = "Кассир";
                this.health = "Здоровей видали";
            }

            public string Fam
            {
                set
                {
                    if (fam == "") fam = value;
                }
                get { return (fam); }

            }

            public string Status
            {
                get { return (status); }
            }

            public int Salary
            {
                set { salary = value; }
            }

            public int GetSalary()
            {
                return this.salary;
        }

            public int Age
            {
                set { age = value; }
                get { return (age); }
            }

            public string GetHelth()
            {
                return this.health;
            }
            
        }


        static void Main()
        {
            Person parametr = new Person();
            parametr.Fam = "Ivanov";
            parametr.Age = 21;
            parametr.Salary = 18000;
            
            Console.WriteLine($"Фамилия: {parametr.Fam}\nВозраст: {parametr.Age}\nСтатус: {parametr.Status}\n" +
                              $"Заработная плата: {parametr.GetSalary()}\nЗдоровье: {parametr.GetHelth()}");

        }

    }
}