namespace Warmup;

public class SimpleArraySum
{
    public static void Main()
    {
        Console.WriteLine(Solution([1, 2, 3, 4]));
    }

    public static int Solution(List<int> ar)
    {
        return ar.Sum();
    }
}