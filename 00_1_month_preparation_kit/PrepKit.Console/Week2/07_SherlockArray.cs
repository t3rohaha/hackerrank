namespace SherlockArray;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(BalancedSums([1]));
        Console.WriteLine(BalancedSums([1, 2]));
        Console.WriteLine(BalancedSums([5, 6, 8, 11]));
        Console.WriteLine(BalancedSums([1, 2, 3]));
        Console.WriteLine(BalancedSums([1, 2, 3, 3]));
    }

    static string BalancedSums(int[] arr)
    {
        var size = arr.Count();

        if (size == 1 || arr.Contains(0))
        {
            return "YES";
        }

        if (size == 2 && !arr.Contains(0))
        {
            return "NO";
        }

        var leftSum = arr.Take(1).Sum();
        var rightSum = arr.Skip(2).Sum();

        if (leftSum == rightSum)
        {
            return "YES";
        }

        for (var i = 1; i < size - 1; i++)
        {
            leftSum += arr[i];
            rightSum -= arr[i+1];

            if (leftSum == rightSum)
            {
                return "YES";
            }
        }

        return "NO";
    }
}