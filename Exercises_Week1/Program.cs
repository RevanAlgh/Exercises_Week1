
using System;

public class Program
{
    public static string ChangeCase(string str)
    {
        string Changedstr = "";
        foreach (char C in str)
        {
            if (char.IsUpper(C))
                Changedstr += char.ToLower(C);
            else if (char.IsLower(C))
                Changedstr += char.ToUpper(C);
            else
                Changedstr += C;
        }

        return Changedstr;
    }
    public static int[] SortArray(int[] numbers)
    {
        Array.Sort(numbers);
        foreach (int i in numbers)
        {
            Console.Write(i + ",");
        }
        return numbers;
    }

    public static string ConvertDate(string date)
    {
        string[] parts = date.Split('/');

        string day = parts[0];
        string month = parts[1];
        string year = parts[2];

        string result = $"{year}{month}{day}";

        return result;
    }

    public static bool Friday13th(int month, int year)
    {
        DateTime date = new DateTime(year, month, 13);

        bool result = date.DayOfWeek == DayOfWeek.Friday;

        return result;
    }

public static void Main(string[] args)
    {

        //First method
        string Sentence = "";
        Console.WriteLine("\n\nPlease Enter Your Sentence that you want to case reverse it: ");
        Sentence = Console.ReadLine();
        Console.WriteLine(ChangeCase(Sentence));


        //Second method
        Console.WriteLine("\n\nThis method is to sort an array of numbers: ");
        int[] myNumbers = { 3, 5, 1, 6, 7 };
        SortArray(myNumbers);


        //Third method
        Console.WriteLine("\n\nThis methode converts a date formatted as MM/DD/YYYY to YYYYDDMM.");
        Console.WriteLine("Please enter a date in MM/DD/YYYY format:");
        string inputDate = Console.ReadLine();
        string outputDate = ConvertDate(inputDate);
        Console.WriteLine($"The Converted Date is: {outputDate}");


        //Fourth method
        Console.WriteLine("\n\nThis methode takes the month and year and tell you whether that month contains a Friday 13th. :");
        Console.WriteLine("Please enter a month:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a year:");
        int year = int.Parse(Console.ReadLine());

        bool result = Friday13th(month, year);

        Console.WriteLine($"Does {month}/{year} have a Friday 13th? {result}");

    }

}
