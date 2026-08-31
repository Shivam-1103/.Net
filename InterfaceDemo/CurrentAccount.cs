namespace Bank;
public class CurrentAccount : IAccount
{
    private decimal _balance = 0;
    private decimal _overdraftLimit = 1000;

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"CurrentAccount: Deposited {amount}. Balance: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (_balance + _overdraftLimit >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"CurrentAccount: Withdrew {amount}. Balance: {_balance}");
        }
        else
        {
            Console.WriteLine("CurrentAccount: Exceeds overdraft limit!");
        }
    }

    public decimal CheckBalance() => _balance;
}