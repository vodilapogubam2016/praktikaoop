using System;

namespace ZADANIE2
{
    public class Phone
    {
        private string _brand;
        private int _batteryLevel;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int BatteryLevel
        {
            get { return _batteryLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _batteryLevel = value;
                }
                else
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                }
            }
        }

        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void UsePhone()
        {
            if (_batteryLevel >= 10)
            {
                _batteryLevel -= 10;
            }
            else
            {
                _batteryLevel = 0;
            }
            Console.WriteLine($"Телефон {Brand}, заряд: {BatteryLevel}%.");
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Задание 2: Phone ===");

            // Тестирование с корректными данными
            Phone phone = new Phone("Samsung", 80);
            phone.UsePhone();
            phone.UsePhone();

            // Тестирование с некорректными данными
            Phone phone2 = new Phone("Samsung", -10);
            phone2.UsePhone();

            Console.ReadLine();
        }
    }
}