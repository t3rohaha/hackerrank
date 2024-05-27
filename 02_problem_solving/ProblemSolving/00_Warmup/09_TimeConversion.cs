namespace Warmup;

public class TimeConversion
{
    public static void Main()
    {
        Console.WriteLine(Solution("12:00:00PM"));
    }

    public static string Solution(string s)
    {
        return DateTime.Parse(s).ToString("HH:mmm:ss");
    }
}