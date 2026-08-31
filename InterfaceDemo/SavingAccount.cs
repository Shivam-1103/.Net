namespace Bank;
public class SavingsAccount : IAccount
{
    private decimal _balance = 0;
    private decimal _interestRate = 0.05m;

    public void Deposit(decimal amount)
    {
        _balance += amount + (amount * _interestRate);
        Console.WriteLine($"SavingsAccount: Deposited {amount} + interest. Balance: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"SavingsAccount: Withdrew {amount}. Balance: {_balance}");
        }
        else
        {
            Console.WriteLine("SavingsAccount: Insufficient funds!");
        }
    }

    public decimal CheckBalance() => _balance;
}