namespace Week1;

public class SubarrayDivision
{
    public static void Main()
    {
        Console.WriteLine(Solution([2, 2, 1, 3, 2], 4, 2));
        Console.WriteLine(Solution([4], 4, 1));
    }

    static int Solution(List<int> s, int d, int m)
    {
        int n = s.Count(); 
        int counter = 0;

        for (int i = 0; i <= n-m; i++)
        {
            var segment = s.Slice(i, m);
            var sum = segment.Sum();
            if (sum == d) counter++;
        }

        return counter;
    }
}

/*
s = 2, 2, 1, 3, 2
d = 4
m = 2 

0 -> 2, 2
1 -> 2, 1
2 -> 1, 3
3 -> 3, 2
*/