using System;

namespace ZADANIE3
{
    public class BankAccount
    {
        private string _owner;
        private double _balance;

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным!");
                }
            }
        }

        public BankAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма депозита должна быть больше 0!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"{Owner}, баланс: {Balance}.");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств!");
                }
            }
            else
            {
                Console.WriteLine("Сумма снятия должна быть больше 0!");
            }
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Задание 3: BankAccount ===");

            BankAccount account = new BankAccount("Иван", 1000);

            account.Deposit(500);

            account.Withdraw(500);

            account.Withdraw(2000);

            Console.ReadLine();
        }
    }
}