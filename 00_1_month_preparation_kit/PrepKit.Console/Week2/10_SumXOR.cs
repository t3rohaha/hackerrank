namespace Week2;

public class SumXOR
{
    public static void Main()
    {
        Console.WriteLine(Solution(4));
        Console.WriteLine(Solution(5));
        Console.WriteLine(Solution(10));
    }

    // 4/12 tests fail.
    static long Solution(long n)
    {
        long counter = 0;
        for (long x = 0; x <= n; x++)
        {
            var sum = n+x;
            var xor = n^x;
            if (sum == xor)
            {
                counter++;
            }
        }

        return counter;
    }
}