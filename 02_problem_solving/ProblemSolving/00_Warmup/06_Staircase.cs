namespace Warmup;

public class Staircase
{
    public static void Main()
    {
        Solution(80);
    }

    public static void Solution(int n)
    {
        for (var i = 1; i <= n; i++)
        {
            var row = new string(' ', n-i) + new string('#', i);
            Console.WriteLine(row);
        }
    }
}