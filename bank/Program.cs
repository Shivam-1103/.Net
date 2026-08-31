using Bank ;
public class Program
{
    public static void Main(string[]args)
    {
        Account Acc1 = new Account(101,"shivam", 500000);
        Acc1.display();
        Acc1.credit(1000);
        Acc1.display();
        Acc1.debit(5000);
        Acc1.display();
    }
}
