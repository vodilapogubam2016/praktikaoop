using System;

namespace zadanie4
{
    public class Circle
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    Console.WriteLine("Радиус должен быть больше 0!");
                    _radius = 1.0;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void GetArea()
        {
            double area = Math.PI * _radius * _radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {

            Circle circle1 = new Circle(5);
            circle1.GetArea();

            Circle circle2 = new Circle(-2);
            circle2.GetArea();

            Console.ReadLine();
        }
    }
}
