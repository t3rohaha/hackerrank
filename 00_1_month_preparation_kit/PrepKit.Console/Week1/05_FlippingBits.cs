namespace FlippingBits;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(FlippingBits(1));
    }

    static long FlippingBits(long n)
    {
        return ~(uint)n;
    }
}