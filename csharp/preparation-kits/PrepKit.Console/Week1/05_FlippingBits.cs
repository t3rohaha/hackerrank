namespace Week1;

public class FlippingBits
{
    public static void Main()
    {
        Console.WriteLine(Solution(1));
    }

    static long Solution(long n)
    {
        return ~(uint)n;
    }
}