using System.Runtime;

namespace Bank ;

public class Account
{
    public int Accountnumber;


    public string Name;

    public Decimal Balance;

     public Account(int an, string name, decimal balance)
    {
        Accountnumber= an;
        Name = name;
        Balance = balance;
    }

    public void credit(decimal Amount)
    {
        Balance += Amount;
    }     

    public void debit(decimal Amount)
    {
        Balance = Balance - Amount;
    }

    public void display()
    {
        Console.WriteLine("Account Number"+ Accountnumber);
        Console.WriteLine("Name"+ Name);
        Console.WriteLine("Balance"+ Balance);
    }
}
