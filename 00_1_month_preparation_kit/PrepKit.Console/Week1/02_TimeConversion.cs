namespace TimeConversion;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(TimeConversion("07:05:45PM"));
        Console.WriteLine(TimeConversion("12:00:00AM"));
    }

    static string TimeConversion(string s)
    {
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }
}