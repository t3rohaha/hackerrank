namespace Implementation;

public class CloudJumping2
{
    public static void Main()
    {
        Solution([0, 0, 1, 0, 0, 1, 0]);
    }

    public static int Solution(List<int> c)
    {
        var count = 0;

        var current = 0;
        while (current != c.Count-1)
        {
            count++;
            current++;

            if (current+1 < c.Count)
                if (c[current+1] == 0)
                    current++;
        }

        return count;
    }
}