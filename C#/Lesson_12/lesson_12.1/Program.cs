using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankSavingsAccount = new SavingsAccount("Me", 5000, 0.05);

            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankSavingsAccount.Withdraw(1000);
            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();
            bankSavingsAccount.Deposit(8000);
            bankSavingsAccount.DisplayAccountInfo();
            Console.WriteLine();

            BankAccount bankCheckingAccount = new CheckingAccount("You", 2000, 1000);
            bankCheckingAccount.DisplayAccountInfo();
        }
    }
}