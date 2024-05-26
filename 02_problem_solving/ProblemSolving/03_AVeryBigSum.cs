namespace ProblemSolving;

public class AVeryBigSum
{
    public static void Main()
    {

    }

    public static long Solution(List<long> ar)
    {
        long sum = 0;

        foreach (long n in ar)
            sum += n;

        return sum;
    }
}