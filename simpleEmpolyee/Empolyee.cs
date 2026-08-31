using System.Reflection;

namespace empSystem ;
public class Empolyee
{
  public int Employee_id;
  public string FirstName ; 
  public string LastName ;

  private decimal BasicPay;
  public decimal HRA;
  public string Email ;
  public decimal Daliywages ;
  public decimal Workingdays ; 

    public Empolyee
    (int employee_id, string firstname, string lastname, string email, decimal daliywages, decimal workingdays  )
  {
    Employee_id = employee_id;
    FirstName = firstname;
    LastName = lastname;
    Email = email;
    Daliywages = daliywages ;
    Workingdays = workingdays ;

  }
    public void ComputeBasicPay()
  {
    BasicPay = Daliywages*Workingdays;
    
  }
    public void ComputeHRA()
  {
    HRA = BasicPay*20/100;
    
  }
    public void ComputeGrosspay()
  {
    decimal grosspay = BasicPay + HRA;
    
  }
    public decimal ComputePay()
  {
    decimal pay =BasicPay+ HRA;
    return pay;
  }
    public string ComputeFullName()
  {
    string fullname = FirstName + LastName;
    return fullname;
  } 

   public decimal getBasicPay()
  {
    return BasicPay;
  }
   public void setBasicPay(decimal Amount)
  {
    BasicPay = Amount;
  }

    public void display()
    {
        Console.WriteLine("EmployeeID="+Employee_id);
        Console.WriteLine("FullName="+ComputeFullName());
        Console.WriteLine("Email="+Email);
        Console.WriteLine("BasicSalary="+BasicPay);
        Console.WriteLine("HRA="+HRA);
        Console.WriteLine("DailyWages="+Daliywages);
        Console.WriteLine("WorkingDays="+Workingdays);
    }

  } 




