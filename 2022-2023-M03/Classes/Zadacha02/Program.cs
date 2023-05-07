using System;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Id = int.Parse(Console.ReadLine());
            account.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine(account.ToString());
            account.Withdraw(50);
            Console.WriteLine(account.ToString());
        }
    }
}
