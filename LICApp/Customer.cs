namespace LIC;
public class Customer
{

    //visibility : public, private, protected, internal
    //members
    private int id;

    public void SetId(int i)
    {
        id=i;
    }

    public int GetId()
    {
        return id;
    }
    private string fullName;
    
    public string GetFullName()
    {
        return fullName;
    }

    public void SetFullName(string name)
    {
        fullName=name;
    }

 

//Property
private string email;
public string  Email
{
    get{return email;}
    set{email=value;}
}
   
   //Auto Property
   public string ContactNumber{get;set;}

    //functions
    //1.constructor  : used for initialization
    //2.getter and setters : used to access private variables
    //3.destructor   :used for deinitialization


    //default constructor
    public Customer()
    {
        id=67;
    }

    //parameterized constructor
    public Customer(int number)
    {
        id=number;
    }

    

}