namespace Warmup;

public class BirthdayCakeCandles
{
    public static void Main()
    {
        Console.WriteLine(Solution([3, 2, 1, 3]));
    }

    public static int Solution(List<int> candles)
    {
        return candles.GroupBy(x => x).OrderBy(x => x.Key).Last().Count();
    }
}