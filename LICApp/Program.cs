namespace LIC;
public class Program{

    public static int Main(){
        Customer cst=new Customer();

        int result=cst.GetId();
        string name=cst.GetFullName();
        int identifier=cst.GetHashCode();

        Console.WriteLine(identifier);
        Console.WriteLine(result);
        Console.WriteLine(name);
       
        //Using constructor object creation
       Policy policy=new Policy();
       Policy policy2 = new Policy(1,"POL001",101,10, null,"Life Insurance",500000, false);

      //Object creation using Property initializer

       Premium premium = new Premium {
            PremiumId = 1,
            PolicyNumber = 1000001,
            PolicyId = 101,
            CustomerId = 501,
            AmountPaid = 2500.00m,
            PaymentDate = DateTime.Now,
            PaymentMode = "UPI",
            TransactionId = "TXN123456",
            PaymentFrequency = "Monthly",
            PaymentStatus = "Paid"
        };
        
        return 0;
    }
}