namespace Implementation;

public class DayOfTheProgrammer
{
    public static void Main()
    {
        Console.WriteLine(Solution(1918));
    }

    public static string Solution(int year)
    {
        DateTime date = new DateTime(year, 1, 1);
        DateTime newDate;

        if (year == 1700 || year == 1800 || year == 1900)
            newDate = date.AddDays(254);
        else if (year == 1918)
            newDate = date.AddDays(268);
        else
            newDate = date.AddDays(255);

        return newDate.ToString("dd.MM.yyyy");
    }
}