namespace SumXOR;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(SumXOR(4));
        Console.WriteLine(SumXOR(5));
        Console.WriteLine(SumXOR(10));
    }

    // 4/12 tests fail.
    static long SumXOR(long n)
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