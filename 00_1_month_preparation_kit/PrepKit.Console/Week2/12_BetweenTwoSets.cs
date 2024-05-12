namespace Week2;

public class BetweenTwoSets
{
    public static void Main()
    {
        Console.WriteLine(Solution([2, 6], [24, 36]));
        Console.WriteLine(Solution([2, 4], [16, 32, 96]));
    }

    public static int Solution(List<int> a, List<int> b)
    {
        var counter = 0;

        for (var n = 1; n <= 100; n++)
        {
            if (AreFactorsOfN(n, a))
                if (IsFactorOfList(n, b))
                    counter++;
        }

        return counter;
    }

    public static bool IsFactorOfList(int n, List<int> list)
    {
        return list.All(l => l % n == 0);
    }

    public static bool AreFactorsOfN(int n, List<int> list)
    {
        return list.All(l => n % l == 0);
    }

}