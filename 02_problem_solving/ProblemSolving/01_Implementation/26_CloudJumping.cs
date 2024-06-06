namespace Implementation;

public class CloudJumping
{
    public static void Main()
    {
        Console.WriteLine(Solution([0, 0, 1, 0], 2));
        Console.WriteLine(Solution([0, 0, 1, 0, 0, 1, 1, 0], 2));
        Console.WriteLine(Solution([1, 1, 1, 0, 1, 1, 0, 0, 0, 0], 3));
    }

    public static int Solution(int[] c, int k)
    {
        var e = 100;
        var idx = 0;

        do
        {
            e--;
            idx = (idx+k) % c.Length;
            var cloud = c[idx];
            if (cloud == 1) e -= 2;
        }
        while(idx != 0);

        return e;
    }
}