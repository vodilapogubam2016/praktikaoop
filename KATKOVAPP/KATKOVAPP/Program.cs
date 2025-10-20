using System;

namespace zadanie1
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть от 0 до 120!");
                    _age = 0;
                }
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Person");

            Person person1 = new Person("Маша", 25);
            person1.SayHello();

            Person person2 = new Person("Маша", 150);
            person2.SayHello();

            Person person3 = new Person("Маша", -5);
            person3.SayHello();

            Console.ReadLine();
        }
    }
}