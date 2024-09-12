namespace Implementation;

public class FindDigits
{
    public static void Main()
    {
        Console.WriteLine(Solution(12));
        Console.WriteLine(Solution(1012));
    }

    public static int Solution(int n)
    {
        var s = n.ToString();
        var count = 0;

        foreach (var c in s)
        {
            var d = int.Parse(c.ToString());
            if (d == 0) continue;
            if (n % d == 0) count++;
        }

        return count;
    }
}