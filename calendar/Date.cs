using Microsoft.VisualBasic;

namespace Calendar;
public class Date
{
    public int  day;
    public int month;
    public int year;

    public Date(int day,int month, int year)
    {
        this.day=day;
        this.month=month;
        this.year=year;
    }


    public bool Isleapyear()
    {
        return year % 400 == 0 ||
                    (year % 4 == 0 && year % 100 != 0);
    
    }
    public bool IsDay()
    {
        return day>=1 &&  day<=31  ;
    }
    public bool IsMonth()
    {
        return month>=1 && month<=12 ;
    }
    public int MoveNext()
    {
        return day++;
    }

    public void Display()
    {
        Console.WriteLine($"{day}/{month}/{year}");
        
        Console.WriteLine($"{Isleapyear()}");   
        Console.WriteLine($"{IsDay()}");
        Console.WriteLine($"{IsMonth()}");
        Console.WriteLine($"{MoveNext()}");

    }
    
    
    
        
    
   
    
}