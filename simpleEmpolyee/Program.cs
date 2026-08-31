using empSystem;

 public class Program
{
    public static void Main(String[]args)
    {
      Empolyee Emp = new Empolyee(101,"Shivam","harbale","shiv@gmail.com",500,30);
    //   Emp.display();
  
    Console.WriteLine(Emp.ComputeFullName());

    
    Emp.ComputeBasicPay();

    Emp.ComputeHRA ();
    
    Emp.ComputeGrosspay();

    Emp.ComputePay() ;

    Emp.display();

    }
}
    

