namespace CRM;
public class Date
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Date(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public void DisplayDate()
    {
        Console.WriteLine($"Date: {Day}/{Month}/{Year}");
    }
}