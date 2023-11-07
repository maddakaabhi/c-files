using System;

public class Class1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first date");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter second date");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        TimeSpan difference = date2 - date1;
        int daysdifference = difference.Days;
        int monthsdifference=((date2.Year-date1.Year)*12+ date2.Month - date1.Month);
        int yeardifference =date2.Year-date1.Year;

        Console.WriteLine(daysdifference);
        Console.WriteLine(monthsdifference);
        Console.WriteLine(yeardifference);    
    }
}

