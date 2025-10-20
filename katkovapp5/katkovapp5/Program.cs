using System;

namespace OOPPracticalWork
{
    public class Pet
    {
        private string _name;
        private int _energy;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }
                else
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                    _energy = 50;
                }
            }
        }

        public Pet(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public void Play()
        {
            if (_energy >= 20)
            {
                _energy -= 20;
            }
            else
            {
                _energy = 0;
            }
            Console.WriteLine($"{Name} играет, энергия: {Energy}.");
        }

        public void Rest()
        {
            if (_energy <= 70)
            {
                _energy += 30;
            }
            else
            {
                _energy = 100;
            }
            Console.WriteLine($"{Name} отдыхает, энергия: {Energy}.");
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {

            Pet pet = new Pet("Рекс", 80);
            pet.Play();
            pet.Rest();

            Pet pet2 = new Pet("Рекс", 150);
            pet2.Play();

            Console.ReadLine();
        }
    }
}