namespace PermutingTwoArrays;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(TwoArrays(1, [0, 1], [0, 2]));
        Console.WriteLine(TwoArrays(10, [2, 1, 3], [7, 8, 9]));
        Console.WriteLine(TwoArrays(5, [1, 2, 2, 1], [3, 3, 3, 4]));
    }

    static string TwoArrays(int k, int[] A, int[] B)
    {
        var orderedA = A.Order().ToArray();
        var orderedB = B.Order().ToArray();
        var length = A.Count();

        for (var i = 0; i < length; i++)
            if (orderedA[i] + orderedB[length - i - 1] < k)
                return "NO";

        return "YES";
    }
}