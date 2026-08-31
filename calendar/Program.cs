using System.Security.Cryptography.X509Certificates;

namespace Calendar;
public class Program
{
    public static void Main(String[] args)
    {
        Console.Write("enter day:");
        int day =int.Parse(Console.ReadLine());

        Console.Write("enter month:");
        int month =int.Parse(Console.ReadLine());

        Console.Write("enter Year:");
        int year =int.Parse(Console.ReadLine());
        
        Date date = new Date(day,month,year);

        bool status = date.IsDay();
        {
            if(status == true )
            {
                Console.WriteLine($"valid day: {day}");
            }
            else
            {
                Console.WriteLine("invaild Day");
            }
        }
        bool view = date.IsMonth();
        {
            if (view == true)
            {
                Console.WriteLine($"Is valid month:{month}");
            }
            else
            {
                Console.WriteLine("Invalid month");
            }
        }
        Console.WriteLine()
        date.Display();
        date.Isleapyear();
    }
} 

