namespace BankAccount
{
    abstract class BankAccount
    {
        public static int accountNumber = 0;
        public string accountHolder;
        public double balance;

        public BankAccount(string accountHolder, double balance)
        {
            this.accountHolder = accountHolder;
            this.balance = balance;
            accountNumber++;
        }

        public abstract double Deposit(double amount);
        public abstract double Withdraw(double amount);
        public abstract void DisplayAccountInfo();
    }
}