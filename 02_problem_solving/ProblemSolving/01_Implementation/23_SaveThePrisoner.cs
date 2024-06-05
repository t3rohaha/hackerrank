namespace Implementation;

public class SaveThePrisoner
{
    public static void Main()
    {
        Console.WriteLine(Solution(4, 6, 2));
        Console.WriteLine(Solution(5, 2, 1));
        Console.WriteLine(Solution(5, 2, 2));
        Console.WriteLine(Solution(7, 19, 2));
        Console.WriteLine(Solution(3, 7, 3));
    }

    // (n) number of prisoners.
    // (m) number of sweets.
    // (s) number of seat to start distribution.
    public static int Solution(int n, int m, int s)
    {
        var result = m + s - 1;

        if (result > n)
            result %= n;

        if (result == 0)
            return n;

        return result;
    }
}