namespace Implementation;

public class ExtraLongFactorial
{
    public static void Main()
    {
        Solution(30);       
    }

    public static void Solution(int n)
    {
        System.Numerics.BigInteger f = n;

        for (var i = n-1; i > 1; i--)
            f *= i;

        Console.WriteLine(f);
    }
}