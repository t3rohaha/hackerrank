namespace Week1;

public class TimeConversion
{
    public static void Main()
    {
        Console.WriteLine(Solution("07:05:45PM"));
        Console.WriteLine(Solution("12:00:00AM"));
    }

    static string Solution(string s)
    {
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }
}