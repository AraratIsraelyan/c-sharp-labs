using System;

namespace Lab4_4
{
    class Student
    {
        private string name;
        private object sumb;
        private static Random rnd = new Random();

        public void SetValue(string a)
        {
            name = a;
            sumb = rnd.Next(1,100);
        }

        public void Print()
        {
            Console.WriteLine($"{name} {sumb}");
        }

        public static Student[] InitAr(Student[] stud)
        {
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student();
            }
            return stud;
        }
        
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            
            Student[] stud = new Student[3];

            for (int i = 0; i < stud.Length; i++ )
            {
                Student.InitAr(stud);
            }
            
            stud[0].SetValue("Анастасия");
            stud[1].SetValue("Екатерина");
            stud[2].SetValue("Виктория");
            
            /* При запуске ошибка
            Unhandled exception. System.NullReferenceException: 
            Object reference not set to an instance of an object.
            В экземпляре объекта не задана ссылка на объект. */

            stud[0].Print();
            stud[1].Print();
            stud[2].Print();

        }
        
        
    }
}