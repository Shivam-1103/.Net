namespace Bank;
class Program
{
    static void Main()
    {
        // The bank system can work with any account type through IAccount
        IAccount account = new SavingsAccount();
        account.Deposit(1000);
        account.Withdraw(200);

        account = new CurrentAccount();
        account.Deposit(500);
        account.Withdraw(1200); // Uses overdraft
    }
}
